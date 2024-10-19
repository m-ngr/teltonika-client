using TeltonikaClient.Core;

namespace TeltonikaClient.UI {
  public partial class MainForm {
    private TeltonikaSocket _client = new();
    private TeltonikaSocket CreateClient() {
      _client = new TeltonikaSocket();
      _client.OnConnect += OnConnect;
      _client.OnClose += OnClose;
      _client.OnAccept += OnAccept;
      _client.OnRefuse += OnRefuse;
      _client.OnError += OnError;
      _client.OnCommand += OnCommand;
      return _client;
    }

    private void SetStatus(bool connected, string status) {
      socketGroup.ForeColor = connected ? Color.Green : Color.Red;
      socketGroup.Text = $"Client: {status}";
      connectButton.Enabled = !connected;
      closeButton.Enabled = connected;
      recordsPanel.Enabled = connected;
      imeiBox.Enabled = !connected;
      hostBox.Enabled = !connected;
      portBox.Enabled = !connected;
    }

    private void OnConnect(object? sender, string imei) {
      SetStatus(true, "Connected");
      _logger.Success($"Client Connected with IMEI {imei}");
    }
    private void OnClose(object? sender, string imei) {
      SetStatus(false, "Disconnected");
      _logger.Warn("Client Disconnected");
    }
    private void OnAccept(object? sender, string imei) {
      SetStatus(true, "Accepted");
      _logger.Success($"Connection Accepted for IMEI {imei}");
    }
    private void OnRefuse(object? sender, string imei) {
      SetStatus(false, "Refused");
      _logger.Warn($"Connection Refused for IMEI {imei}");
    }
    private void OnError(object? sender, string error) {
      _logger.Error($"Error: {error}");
    }
    private void OnCommand(object? sender, string command) {
      var response = _responseSource.Get(command);
      _client.SendResponse(response);
      _logger.Log($"Received Command: {command}, Sent Response: {response}.");
      AddCommandEntry(command, response);
    }
    private void AddCommandEntry(string command, string response) {
      string currentTime = DateTime.Now.ToString("HH:mm:ss");
      ListViewItem item = new(currentTime);
      item.SubItems.Add(command);
      item.SubItems.Add(response);
      commandsList.Items.Add(item);
    }
  }
}