using TeltonikaClient.Core;

namespace TeltonikaClient.UI {
  public partial class MainForm {
    TeltonikaSocket Client = new();
    private TeltonikaSocket CreateClient() {
      Client = new TeltonikaSocket();
      Client.OnConnect += OnConnect;
      Client.OnClose += OnClose;
      Client.OnAccept += OnAccept;
      Client.OnRefuse += OnRefuse;
      Client.OnError += OnError;
      Client.OnCommand += OnCommand;
      return Client;
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
      logger.Success($"Client Connected with IMEI {imei}");
    }
    private void OnClose(object? sender, string imei) {
      SetStatus(false, "Disconnected");
      logger.Warn("Client Disconnected");
    }
    private void OnAccept(object? sender, string imei) {
      SetStatus(true, "Accepted");
      logger.Success($"Connection Accepted for IMEI {imei}");
    }
    private void OnRefuse(object? sender, string imei) {
      SetStatus(false, "Refused");
      logger.Warn($"Connection Refused for IMEI {imei}");
    }
    private void OnError(object? sender, string error) {
      logger.Error($"Error: {error}");
    }
    private void OnCommand(object? sender, string command) {
      var response = _responseSource.Get(command);
      Client.SendResponse(response);
      logger.Log($"Received Command: {command}, Sent Response: {response}.");
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