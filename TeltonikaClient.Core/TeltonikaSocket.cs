using System.Net.Sockets;
using TeltonikaClient.Core.Codecs;
using TeltonikaClient.Core.Entities;
using TeltonikaClient.Core.Utils;

namespace TeltonikaClient.Core {
  public class TeltonikaSocket {
    private static readonly byte Accept = 0x01;
    private readonly TcpClient _socket = new();
    private readonly TeltonikaStream _stream = new();
    private string _imei = String.Empty;
    public event EventHandler<string>? OnCommand;
    public event EventHandler<string>? OnConnect;
    public event EventHandler<string>? OnClose;
    public event EventHandler<string>? OnAccept;
    public event EventHandler<string>? OnRefuse;
    public event EventHandler<string>? OnError;

    public async Task<bool> Connect(string imei, string host, int port) {
      try {
        _imei = imei;
        await _socket.ConnectAsync(host, port);
        OnConnect?.Invoke(this, _imei);
      } catch(Exception ex) {
        OnError?.Invoke(this, $"Failed to connect to {host}:{port}: {ex.Message}");
        return false;
      }
      return InitializeConnection();
    }
    public void Close() {
      try {
        _socket.Close();
        OnClose?.Invoke(this, _imei);
      } catch(Exception ex) {
        OnError?.Invoke(this, $"Error while closing connection: {ex.Message}");
      }
    }
    public void SendRecords(List<TeltonikaRecord> records) {
      try {
        var buffer = TeltonikaStream.Packetize(Codec8.Encode(records));
        Send(buffer);
      } catch(Exception ex) {
        OnError?.Invoke(this, $"Error sending records: {ex.Message}");
      }
    }
    public void SendResponse(string response) {
      try {
        var buffer = TeltonikaStream.Packetize(Codec12.Encode(response, CodecTextType.Response));
        Send(buffer);
      } catch(Exception ex) {
        OnError?.Invoke(this, $"Error sending response: {ex.Message}");
      }
    }
    private bool InitializeConnection() {
      SendImei();
      if(!ServerAccepted()) return false;
      Listen();
      return true;
    }
    private bool ServerAccepted() {
      try {
        var ack = _socket.GetStream().ReadByte();
        if(ack == Accept) {
          OnAccept?.Invoke(this, _imei);
          return true;
        } else {
          OnRefuse?.Invoke(this, _imei);
          _socket.Close();
          return false;
        }
      } catch(Exception ex) {
        OnError?.Invoke(this, $"Error while reading server acceptance: {ex.Message}");
        _socket.Close();
        return false;
      }
    }
    private void SendImei() {
      var writer = new BufferWriter(17);
      writer.Write((ushort)_imei.Length);
      writer.Write(_imei);
      Send(writer.ToArray());
    }
    private async void Listen() {
      byte[] buffer = new byte[4096];
      while(_socket.Connected) {
        try {
          var bytesRead = await _socket.GetStream().ReadAsync(buffer);
          if(bytesRead > 0) {
            ProcessData(buffer[0..bytesRead]);
          } else {
            OnError?.Invoke(this, "Server Disconnected");
            break;
          }
        } catch(Exception ex) {
          OnError?.Invoke(this, $"Error while listening: {ex.Message}");
          break;
        }
      }
      Close();
    }
    private void ProcessData(byte[] chunk) {
      try {
        _stream.Write(chunk);
        while(_stream.CanRead()) {
          var data = _stream.Read();
          if(data == null) continue;
          var (output, type) = Codec12.Decode(data);
          if(type == CodecTextType.Command) {
            OnCommand?.Invoke(this, output);
          }
        }
      } catch(Exception ex) {
        OnError?.Invoke(this, $"Error processing data: {ex.Message}");
      }
    }
    private void Send(byte[] data) {
      try {
        _socket.GetStream().Write(data);
      } catch(Exception ex) {
        OnError?.Invoke(this, $"Failed to send data to socket {ex.Message}");
        Close();
      }
    }
  }
}
