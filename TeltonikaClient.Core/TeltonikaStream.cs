using System.Text;
using TeltonikaClient.Core.Utils;

namespace TeltonikaClient.Core {
  public class TeltonikaStream {
    private static readonly byte[] DATA_PREAMBLE = [0x00, 0x00, 0x00, 0x00];
    public static byte[] Packetize(byte[] data) {
      var writer = new BufferWriter(data.Length + 12);
      writer.Write(DATA_PREAMBLE);
      writer.Write((uint)data.Length);
      writer.Write(data);
      writer.Write((uint)CRC16.Calculate(data));
      return writer.ToArray();
    }

    private byte[] _stream = [];

    public TeltonikaStream Write(byte[] chunk) {
      _stream = [.. _stream, .. chunk];
      return this;
    }
    public byte[]? Read() {
      if(GoToNextPreamble()) {
        return ReadMessage();
      }
      return null;
    }

    public bool CanRead() {
      return _stream.Length >= 12 && _stream.Length >= MessageLength();
    }

    public void Clear(int keep = 0) {
      if(_stream.Length > keep) {
        _stream = _stream[^keep..];
      }
    }

    public override string ToString() {
      return Encoding.Default.GetString(_stream);
    }

    private bool GoToNextPreamble() {
      int index = Array.IndexOf(_stream, DATA_PREAMBLE);

      if(index == -1) {
        if(_stream.Length > 4) Clear(4);
        return false;
      }

      _stream = _stream[index..];
      return true;
    }

    private int DataLength() {
      return BitConverter.ToInt32(_stream[4..8].Reverse().ToArray(), 0);
    }

    private int MessageLength() {
      return 12 + DataLength();
    }

    private byte[]? ReadMessage() {
      if(!CanRead()) return null;

      if(!ValidateChecksum()) {
        RemoveMessage();
        Console.Error.WriteLine("Teltonika Stream: Checksum does not match");
        return null;
      }

      byte[] data = ReadData();
      RemoveMessage();
      return data;
    }

    private void RemoveMessage() {
      _stream = _stream[MessageLength()..];
    }

    private byte[] ReadData() {
      return _stream[8..(8 + DataLength())];
    }

    private bool ValidateChecksum() {
      uint checksum = BitConverter.ToUInt32(_stream[^4..].Reverse().ToArray(), 0);
      return checksum == CRC16.Calculate(ReadData());
    }

  }
}
