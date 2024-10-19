using TeltonikaClient.Core.Entities;

namespace TeltonikaClient.UI {
  public partial class MainForm : Form {
    private readonly RTBLogger _logger;
    private string Imei { get => imeiBox.Text; }
    private string Host { get => hostBox.Text; }
    private int Port { get => (int)portBox.Value; }
    private DateTime RecordTime { get => recordNow.Checked ? DateTime.Now : recordTime.Value; }
    private TeltonikaRecord Record {
      get => new() {
        Timestamp = RecordTime,
        Longitude = (double)recordLongitude.Value,
        Latitude = (double)recordLatitude.Value,
        Altitude = (ushort)recordAltitude.Value,
        Angle = (ushort)recordAngle.Value,
        Satellites = (byte)recordSatallites.Value,
        Speed = (ushort)recordSpeed.Value,
        Ignition = recordIgnition.Checked,
        Movement = recordMovement.Checked,
        Tow = recordTow.Checked,
        Idle = recordIdle.Checked,
        Odometer = (uint)recordOdometer.Value,
        ExternalVoltage = (double)recordVoltage.Value,
        Battary = (byte)recordBattery.Value,
      };
    }

    private ResponseSource _responseSource;

    public MainForm() {
      InitializeComponent();
      _logger = new RTBLogger(logsBox);
      _responseSource = new ResponseSource("responses.json");
      _responseSource.Load();
      responseList.DataSource = _responseSource.BindingSource;
    }

    private void connectButton_Click(object sender, EventArgs e) {
      _client = CreateClient();
      _ = _client.Connect(Imei, Host, Port);
    }

    private void closeButton_Click(object sender, EventArgs e) {
      _client.Close();
    }

    private void recordNow_CheckedChanged(object sender, EventArgs e) {
      recordTime.Enabled = !recordNow.Checked;
      if(recordNow.Checked) {
        recordTime.Value = DateTime.Now;
      }
    }

    private void recordDefault_Click(object sender, EventArgs e) {
      recordNow.Checked = true;
      recordLongitude.Value = 46.6226100M;
      recordLatitude.Value = 24.6630660M;
      recordAltitude.Value = 636M;
      recordAngle.Value = 143M;
      recordSatallites.Value = 12M;
      recordSpeed.Value = 0;
      recordOdometer.Value = 32527647;
      recordVoltage.Value = 13.070M;
      recordBattery.Value = 100;
      recordIgnition.Checked = true;
      recordMovement.Checked = false;
      recordTow.Checked = false;
      recordIdle.Checked = false;
    }

    private void recordRandom_Click(object sender, EventArgs e) {
      recordNow.Checked = true;
      FormUtils.SetRandomDecimal(recordLongitude);
      FormUtils.SetRandomDecimal(recordLatitude);
      FormUtils.SetRandomInt(recordAltitude);
      FormUtils.SetRandomInt(recordAngle);
      FormUtils.SetRandomInt(recordSatallites);
      FormUtils.SetRandomInt(recordSpeed);
      FormUtils.SetRandomInt(recordOdometer);
      FormUtils.SetRandomDecimal(recordVoltage);
      FormUtils.SetRandomInt(recordBattery);
      FormUtils.SetRandomBool(recordIgnition);
      FormUtils.SetRandomBool(recordMovement);
      FormUtils.SetRandomBool(recordTow);
      FormUtils.SetRandomBool(recordIdle);
    }

    private void recordSend_Click(object sender, EventArgs e) {
      var record = Record;
      _logger.Info("Sending Record");
      _logger.Info("===========================================", false);
      _logger.Log($" - Timestamp: {record.Timestamp}", false);
      _logger.Log($" - Satellites: {record.Satellites}", false);
      _logger.Log($" - Logitude: {record.Longitude}", false);
      _logger.Log($" - Latitude: {record.Latitude}", false);
      _logger.Log($" - Altitude: {record.Altitude}", false);
      _logger.Log($" - Angle: {record.Angle}", false);
      _logger.Log($" - Speed: {record.Speed}", false);
      _logger.Log($" - Odometer: {record.Odometer}", false);
      _logger.Log($" - Voltage: {record.ExternalVoltage}", false);
      _logger.Log($" - Battary: {record.Battary}", false);
      _logger.Log($" - Ignition: {record.Ignition}", false);
      _logger.Log($" - Movement: {record.Movement}", false);
      _logger.Log($" - Tow: {record.Tow}", false);
      _logger.Log($" - Idle: {record.Idle}", false);
      _logger.Info("===========================================", false);
      _client.SendRecords([record]);
    }

    private void commandBox_TextChanged(object sender, EventArgs e) {
      if(commandBox.Text.Length > 0 && responseBox.Text.Length > 0) {
        addResponse.Enabled = true;
      } else {
        addResponse.Enabled = false;
      }
    }

    private void responseBox_TextChanged(object sender, EventArgs e) {
      if(commandBox.Text.Length > 0 && responseBox.Text.Length > 0) {
        addResponse.Enabled = true;
      } else {
        addResponse.Enabled = false;
      }
    }

    private void addResponse_Click(object sender, EventArgs e) {
      _responseSource.Set(commandBox.Text, responseBox.Text);
      commandBox.Text = "";
      responseBox.Text = "";
    }

    private void MainForm_Load(object sender, EventArgs e) {
      FormUtils.SetEqualColumnWidths(commandsList);
    }

    private void commandsList_SizeChanged(object sender, EventArgs e) {
      FormUtils.SetEqualColumnWidths(commandsList);
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      FormUtils.OpenBrowser(linkLabel1.Text);
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      FormUtils.OpenBrowser(linkLabel2.Text);
    }

    private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      FormUtils.OpenBrowser(linkLabel4.Text);
    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      FormUtils.OpenBrowser($"mailto:{linkLabel3.Text}");
    }

    private void pictureBox2_Click(object sender, EventArgs e) {
      Clipboard.SetText(linkLabel3.Text);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      _responseSource.Save();
    }
  }
}
