namespace TeltonikaClient.UI {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      components = new System.ComponentModel.Container();
      DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      imeiBox = new TextBox();
      hostBox = new TextBox();
      portBox = new NumericUpDown();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      connectButton = new Button();
      socketGroup = new GroupBox();
      panel3 = new Panel();
      closeButton = new Button();
      tabs = new TabControl();
      recordsPage = new TabPage();
      recordsPanel = new Panel();
      panel2 = new Panel();
      recordRandom = new Button();
      recordDefault = new Button();
      label6 = new Label();
      recordOdometer = new NumericUpDown();
      recordSpeed = new NumericUpDown();
      recordNow = new CheckBox();
      speedLabel = new Label();
      recordTime = new DateTimePicker();
      recordLongitude = new NumericUpDown();
      recordSend = new Button();
      label4 = new Label();
      recordIdle = new CheckBox();
      recordLatitude = new NumericUpDown();
      recordMovement = new CheckBox();
      label5 = new Label();
      recordTow = new CheckBox();
      recordAltitude = new NumericUpDown();
      recordIgnition = new CheckBox();
      label7 = new Label();
      label12 = new Label();
      recordAngle = new NumericUpDown();
      recordBattery = new NumericUpDown();
      label8 = new Label();
      label11 = new Label();
      recordSatallites = new NumericUpDown();
      recordVoltage = new NumericUpDown();
      label9 = new Label();
      label10 = new Label();
      responsesPage = new TabPage();
      responseList = new DataGridView();
      commandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      responseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      responseBindingSource = new BindingSource(components);
      panel1 = new Panel();
      addResponse = new Button();
      label14 = new Label();
      responseBox = new TextBox();
      label13 = new Label();
      commandBox = new TextBox();
      commandsPage = new TabPage();
      commandsList = new ListView();
      timeColumn = new ColumnHeader();
      commandColumn = new ColumnHeader();
      responseColumn = new ColumnHeader();
      logsPage = new TabPage();
      logsBox = new RichTextBox();
      tabPage1 = new TabPage();
      panel5 = new Panel();
      label18 = new Label();
      panel4 = new Panel();
      label19 = new Label();
      label17 = new Label();
      label16 = new Label();
      label15 = new Label();
      pictureBox1 = new PictureBox();
      splitContainer1 = new SplitContainer();
      ((System.ComponentModel.ISupportInitialize)portBox).BeginInit();
      socketGroup.SuspendLayout();
      panel3.SuspendLayout();
      tabs.SuspendLayout();
      recordsPage.SuspendLayout();
      recordsPanel.SuspendLayout();
      panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)recordOdometer).BeginInit();
      ((System.ComponentModel.ISupportInitialize)recordSpeed).BeginInit();
      ((System.ComponentModel.ISupportInitialize)recordLongitude).BeginInit();
      ((System.ComponentModel.ISupportInitialize)recordLatitude).BeginInit();
      ((System.ComponentModel.ISupportInitialize)recordAltitude).BeginInit();
      ((System.ComponentModel.ISupportInitialize)recordAngle).BeginInit();
      ((System.ComponentModel.ISupportInitialize)recordBattery).BeginInit();
      ((System.ComponentModel.ISupportInitialize)recordSatallites).BeginInit();
      ((System.ComponentModel.ISupportInitialize)recordVoltage).BeginInit();
      responsesPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)responseList).BeginInit();
      ((System.ComponentModel.ISupportInitialize)responseBindingSource).BeginInit();
      panel1.SuspendLayout();
      commandsPage.SuspendLayout();
      logsPage.SuspendLayout();
      tabPage1.SuspendLayout();
      panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
      splitContainer1.SuspendLayout();
      SuspendLayout();
      // 
      // imeiBox
      // 
      imeiBox.Font = new Font("Segoe UI", 10.2F);
      imeiBox.ForeColor = SystemColors.ControlText;
      imeiBox.Location = new Point(67, 32);
      imeiBox.Margin = new Padding(3, 2, 3, 2);
      imeiBox.MaxLength = 15;
      imeiBox.Name = "imeiBox";
      imeiBox.PlaceholderText = "IMEI";
      imeiBox.Size = new Size(210, 26);
      imeiBox.TabIndex = 0;
      imeiBox.Text = "350317179894484";
      // 
      // hostBox
      // 
      hostBox.Font = new Font("Segoe UI", 10.2F);
      hostBox.ForeColor = SystemColors.ControlText;
      hostBox.Location = new Point(67, 65);
      hostBox.Margin = new Padding(3, 2, 3, 2);
      hostBox.Name = "hostBox";
      hostBox.PlaceholderText = "Host";
      hostBox.Size = new Size(210, 26);
      hostBox.TabIndex = 1;
      hostBox.Text = "127.0.0.1";
      // 
      // portBox
      // 
      portBox.Font = new Font("Segoe UI", 10.2F);
      portBox.ForeColor = SystemColors.ControlText;
      portBox.Location = new Point(67, 98);
      portBox.Margin = new Padding(3, 2, 3, 2);
      portBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
      portBox.Name = "portBox";
      portBox.Size = new Size(131, 26);
      portBox.TabIndex = 2;
      portBox.Value = new decimal(new int[] { 57000, 0, 0, 0 });
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 10.2F);
      label1.ForeColor = SystemColors.ControlText;
      label1.Location = new Point(22, 35);
      label1.Name = "label1";
      label1.Size = new Size(37, 19);
      label1.TabIndex = 3;
      label1.Text = "IMEI";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 10.2F);
      label2.ForeColor = SystemColors.ControlText;
      label2.Location = new Point(22, 69);
      label2.Name = "label2";
      label2.Size = new Size(38, 19);
      label2.TabIndex = 4;
      label2.Text = "Host";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 10.2F);
      label3.ForeColor = SystemColors.ControlText;
      label3.Location = new Point(22, 101);
      label3.Name = "label3";
      label3.Size = new Size(34, 19);
      label3.TabIndex = 5;
      label3.Text = "Port";
      // 
      // connectButton
      // 
      connectButton.ForeColor = Color.Green;
      connectButton.Location = new Point(3, 19);
      connectButton.Margin = new Padding(3, 2, 3, 2);
      connectButton.Name = "connectButton";
      connectButton.Size = new Size(100, 35);
      connectButton.TabIndex = 6;
      connectButton.Text = "Connect";
      connectButton.UseVisualStyleBackColor = true;
      connectButton.Click += connectButton_Click;
      // 
      // socketGroup
      // 
      socketGroup.Controls.Add(panel3);
      socketGroup.Controls.Add(label1);
      socketGroup.Controls.Add(imeiBox);
      socketGroup.Controls.Add(label3);
      socketGroup.Controls.Add(hostBox);
      socketGroup.Controls.Add(label2);
      socketGroup.Controls.Add(portBox);
      socketGroup.Dock = DockStyle.Fill;
      socketGroup.Font = new Font("Cascadia Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
      socketGroup.ForeColor = Color.Red;
      socketGroup.Location = new Point(0, 0);
      socketGroup.Margin = new Padding(3, 2, 3, 2);
      socketGroup.Name = "socketGroup";
      socketGroup.Padding = new Padding(3, 2, 3, 2);
      socketGroup.Size = new Size(534, 135);
      socketGroup.TabIndex = 8;
      socketGroup.TabStop = false;
      socketGroup.Text = "Client: Disconnected";
      // 
      // panel3
      // 
      panel3.Controls.Add(connectButton);
      panel3.Controls.Add(closeButton);
      panel3.Dock = DockStyle.Right;
      panel3.Location = new Point(420, 19);
      panel3.Name = "panel3";
      panel3.Size = new Size(111, 114);
      panel3.TabIndex = 8;
      // 
      // closeButton
      // 
      closeButton.Enabled = false;
      closeButton.ForeColor = Color.Red;
      closeButton.Location = new Point(3, 61);
      closeButton.Margin = new Padding(3, 2, 3, 2);
      closeButton.Name = "closeButton";
      closeButton.Size = new Size(100, 35);
      closeButton.TabIndex = 7;
      closeButton.Text = "Close";
      closeButton.UseVisualStyleBackColor = true;
      closeButton.Click += closeButton_Click;
      // 
      // tabs
      // 
      tabs.Controls.Add(recordsPage);
      tabs.Controls.Add(responsesPage);
      tabs.Controls.Add(commandsPage);
      tabs.Controls.Add(logsPage);
      tabs.Controls.Add(tabPage1);
      tabs.Dock = DockStyle.Fill;
      tabs.Location = new Point(0, 0);
      tabs.Margin = new Padding(3, 2, 3, 2);
      tabs.Name = "tabs";
      tabs.SelectedIndex = 0;
      tabs.Size = new Size(534, 423);
      tabs.TabIndex = 9;
      // 
      // recordsPage
      // 
      recordsPage.Controls.Add(recordsPanel);
      recordsPage.Location = new Point(4, 24);
      recordsPage.Margin = new Padding(3, 2, 3, 2);
      recordsPage.Name = "recordsPage";
      recordsPage.Padding = new Padding(3, 2, 3, 2);
      recordsPage.Size = new Size(526, 395);
      recordsPage.TabIndex = 0;
      recordsPage.Text = "Records";
      recordsPage.UseVisualStyleBackColor = true;
      // 
      // recordsPanel
      // 
      recordsPanel.Controls.Add(panel2);
      recordsPanel.Controls.Add(label6);
      recordsPanel.Controls.Add(recordOdometer);
      recordsPanel.Controls.Add(recordSpeed);
      recordsPanel.Controls.Add(recordNow);
      recordsPanel.Controls.Add(speedLabel);
      recordsPanel.Controls.Add(recordTime);
      recordsPanel.Controls.Add(recordLongitude);
      recordsPanel.Controls.Add(recordSend);
      recordsPanel.Controls.Add(label4);
      recordsPanel.Controls.Add(recordIdle);
      recordsPanel.Controls.Add(recordLatitude);
      recordsPanel.Controls.Add(recordMovement);
      recordsPanel.Controls.Add(label5);
      recordsPanel.Controls.Add(recordTow);
      recordsPanel.Controls.Add(recordAltitude);
      recordsPanel.Controls.Add(recordIgnition);
      recordsPanel.Controls.Add(label7);
      recordsPanel.Controls.Add(label12);
      recordsPanel.Controls.Add(recordAngle);
      recordsPanel.Controls.Add(recordBattery);
      recordsPanel.Controls.Add(label8);
      recordsPanel.Controls.Add(label11);
      recordsPanel.Controls.Add(recordSatallites);
      recordsPanel.Controls.Add(recordVoltage);
      recordsPanel.Controls.Add(label9);
      recordsPanel.Controls.Add(label10);
      recordsPanel.Dock = DockStyle.Fill;
      recordsPanel.Enabled = false;
      recordsPanel.Location = new Point(3, 2);
      recordsPanel.Name = "recordsPanel";
      recordsPanel.Size = new Size(520, 391);
      recordsPanel.TabIndex = 30;
      // 
      // panel2
      // 
      panel2.Controls.Add(recordRandom);
      panel2.Controls.Add(recordDefault);
      panel2.Dock = DockStyle.Right;
      panel2.Location = new Point(413, 0);
      panel2.Name = "panel2";
      panel2.Size = new Size(107, 336);
      panel2.TabIndex = 30;
      // 
      // recordRandom
      // 
      recordRandom.Font = new Font("Cascadia Mono", 10.2F);
      recordRandom.ForeColor = Color.RoyalBlue;
      recordRandom.Location = new Point(3, 23);
      recordRandom.Margin = new Padding(3, 2, 3, 2);
      recordRandom.Name = "recordRandom";
      recordRandom.Size = new Size(100, 35);
      recordRandom.TabIndex = 25;
      recordRandom.Text = "Random";
      recordRandom.UseVisualStyleBackColor = true;
      recordRandom.Click += recordRandom_Click;
      // 
      // recordDefault
      // 
      recordDefault.Font = new Font("Cascadia Mono", 10.2F);
      recordDefault.ForeColor = Color.RoyalBlue;
      recordDefault.Location = new Point(3, 66);
      recordDefault.Margin = new Padding(3, 2, 3, 2);
      recordDefault.Name = "recordDefault";
      recordDefault.Size = new Size(100, 35);
      recordDefault.TabIndex = 26;
      recordDefault.Text = "Default";
      recordDefault.UseVisualStyleBackColor = true;
      recordDefault.Click += recordDefault_Click;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(15, 20);
      label6.Name = "label6";
      label6.Size = new Size(66, 15);
      label6.TabIndex = 7;
      label6.Text = "Timestamp";
      // 
      // recordOdometer
      // 
      recordOdometer.Increment = new decimal(new int[] { 100, 0, 0, 0 });
      recordOdometer.Location = new Point(91, 218);
      recordOdometer.Margin = new Padding(3, 2, 3, 2);
      recordOdometer.Maximum = new decimal(new int[] { 2147483640, 0, 0, 0 });
      recordOdometer.Name = "recordOdometer";
      recordOdometer.Size = new Size(102, 23);
      recordOdometer.TabIndex = 29;
      recordOdometer.Value = new decimal(new int[] { 32527647, 0, 0, 0 });
      // 
      // recordSpeed
      // 
      recordSpeed.Increment = new decimal(new int[] { 5, 0, 0, 0 });
      recordSpeed.Location = new Point(91, 189);
      recordSpeed.Margin = new Padding(3, 2, 3, 2);
      recordSpeed.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
      recordSpeed.Name = "recordSpeed";
      recordSpeed.Size = new Size(102, 23);
      recordSpeed.TabIndex = 0;
      // 
      // recordNow
      // 
      recordNow.AutoSize = true;
      recordNow.Checked = true;
      recordNow.CheckState = CheckState.Checked;
      recordNow.Location = new Point(297, 20);
      recordNow.Margin = new Padding(3, 2, 3, 2);
      recordNow.Name = "recordNow";
      recordNow.Size = new Size(51, 19);
      recordNow.TabIndex = 27;
      recordNow.Text = "Now";
      recordNow.UseVisualStyleBackColor = true;
      recordNow.CheckedChanged += recordNow_CheckedChanged;
      // 
      // speedLabel
      // 
      speedLabel.AutoSize = true;
      speedLabel.Location = new Point(15, 194);
      speedLabel.Name = "speedLabel";
      speedLabel.Size = new Size(39, 15);
      speedLabel.TabIndex = 1;
      speedLabel.Text = "Speed";
      // 
      // recordTime
      // 
      recordTime.CustomFormat = "hh:mm:ss tt d/M/yyyy";
      recordTime.Enabled = false;
      recordTime.Format = DateTimePickerFormat.Custom;
      recordTime.Location = new Point(91, 18);
      recordTime.Margin = new Padding(3, 2, 3, 2);
      recordTime.Name = "recordTime";
      recordTime.Size = new Size(197, 23);
      recordTime.TabIndex = 2;
      // 
      // recordLongitude
      // 
      recordLongitude.DecimalPlaces = 7;
      recordLongitude.Increment = new decimal(new int[] { 1, 0, 0, 393216 });
      recordLongitude.Location = new Point(91, 46);
      recordLongitude.Margin = new Padding(3, 2, 3, 2);
      recordLongitude.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
      recordLongitude.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
      recordLongitude.Name = "recordLongitude";
      recordLongitude.Size = new Size(102, 23);
      recordLongitude.TabIndex = 3;
      recordLongitude.Value = new decimal(new int[] { 46622610, 0, 0, 393216 });
      // 
      // recordSend
      // 
      recordSend.Dock = DockStyle.Bottom;
      recordSend.Font = new Font("Cascadia Mono SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
      recordSend.ForeColor = Color.Green;
      recordSend.Location = new Point(0, 336);
      recordSend.Margin = new Padding(3, 2, 3, 2);
      recordSend.Name = "recordSend";
      recordSend.Size = new Size(520, 55);
      recordSend.TabIndex = 24;
      recordSend.Text = "Send";
      recordSend.UseVisualStyleBackColor = true;
      recordSend.Click += recordSend_Click;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(15, 49);
      label4.Name = "label4";
      label4.Size = new Size(61, 15);
      label4.TabIndex = 4;
      label4.Text = "Longitude";
      // 
      // recordIdle
      // 
      recordIdle.AutoSize = true;
      recordIdle.Location = new Point(207, 280);
      recordIdle.Margin = new Padding(3, 2, 3, 2);
      recordIdle.Name = "recordIdle";
      recordIdle.Size = new Size(45, 19);
      recordIdle.TabIndex = 23;
      recordIdle.Text = "Idle";
      recordIdle.UseVisualStyleBackColor = true;
      // 
      // recordLatitude
      // 
      recordLatitude.DecimalPlaces = 7;
      recordLatitude.Increment = new decimal(new int[] { 1, 0, 0, 393216 });
      recordLatitude.Location = new Point(91, 75);
      recordLatitude.Margin = new Padding(3, 2, 3, 2);
      recordLatitude.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
      recordLatitude.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
      recordLatitude.Name = "recordLatitude";
      recordLatitude.Size = new Size(102, 23);
      recordLatitude.TabIndex = 5;
      recordLatitude.Value = new decimal(new int[] { 24663066, 0, 0, 393216 });
      // 
      // recordMovement
      // 
      recordMovement.AutoSize = true;
      recordMovement.Location = new Point(207, 220);
      recordMovement.Margin = new Padding(3, 2, 3, 2);
      recordMovement.Name = "recordMovement";
      recordMovement.Size = new Size(84, 19);
      recordMovement.TabIndex = 22;
      recordMovement.Text = "Movement";
      recordMovement.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(15, 77);
      label5.Name = "label5";
      label5.Size = new Size(50, 15);
      label5.TabIndex = 6;
      label5.Text = "Latitude";
      // 
      // recordTow
      // 
      recordTow.AutoSize = true;
      recordTow.Location = new Point(207, 250);
      recordTow.Margin = new Padding(3, 2, 3, 2);
      recordTow.Name = "recordTow";
      recordTow.Size = new Size(47, 19);
      recordTow.TabIndex = 21;
      recordTow.Text = "Tow";
      recordTow.UseVisualStyleBackColor = true;
      // 
      // recordAltitude
      // 
      recordAltitude.Location = new Point(91, 104);
      recordAltitude.Margin = new Padding(3, 2, 3, 2);
      recordAltitude.Maximum = new decimal(new int[] { 9000, 0, 0, 0 });
      recordAltitude.Name = "recordAltitude";
      recordAltitude.Size = new Size(102, 23);
      recordAltitude.TabIndex = 8;
      recordAltitude.Value = new decimal(new int[] { 636, 0, 0, 0 });
      // 
      // recordIgnition
      // 
      recordIgnition.AutoSize = true;
      recordIgnition.Checked = true;
      recordIgnition.CheckState = CheckState.Checked;
      recordIgnition.Location = new Point(207, 190);
      recordIgnition.Margin = new Padding(3, 2, 3, 2);
      recordIgnition.Name = "recordIgnition";
      recordIgnition.Size = new Size(67, 19);
      recordIgnition.TabIndex = 20;
      recordIgnition.Text = "Ignition";
      recordIgnition.UseVisualStyleBackColor = true;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(15, 106);
      label7.Name = "label7";
      label7.Size = new Size(49, 15);
      label7.TabIndex = 9;
      label7.Text = "Altitude";
      // 
      // label12
      // 
      label12.AutoSize = true;
      label12.Location = new Point(15, 278);
      label12.Name = "label12";
      label12.Size = new Size(44, 15);
      label12.TabIndex = 19;
      label12.Text = "Battery";
      // 
      // recordAngle
      // 
      recordAngle.Location = new Point(91, 132);
      recordAngle.Margin = new Padding(3, 2, 3, 2);
      recordAngle.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
      recordAngle.Name = "recordAngle";
      recordAngle.Size = new Size(102, 23);
      recordAngle.TabIndex = 10;
      recordAngle.Value = new decimal(new int[] { 143, 0, 0, 0 });
      // 
      // recordBattery
      // 
      recordBattery.Increment = new decimal(new int[] { 5, 0, 0, 0 });
      recordBattery.Location = new Point(91, 274);
      recordBattery.Margin = new Padding(3, 2, 3, 2);
      recordBattery.Name = "recordBattery";
      recordBattery.Size = new Size(102, 23);
      recordBattery.TabIndex = 18;
      recordBattery.Value = new decimal(new int[] { 100, 0, 0, 0 });
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Location = new Point(15, 134);
      label8.Name = "label8";
      label8.Size = new Size(38, 15);
      label8.TabIndex = 11;
      label8.Text = "Angle";
      // 
      // label11
      // 
      label11.AutoSize = true;
      label11.Location = new Point(15, 248);
      label11.Name = "label11";
      label11.Size = new Size(46, 15);
      label11.TabIndex = 17;
      label11.Text = "Voltage";
      // 
      // recordSatallites
      // 
      recordSatallites.Location = new Point(91, 160);
      recordSatallites.Margin = new Padding(3, 2, 3, 2);
      recordSatallites.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
      recordSatallites.Name = "recordSatallites";
      recordSatallites.Size = new Size(102, 23);
      recordSatallites.TabIndex = 12;
      recordSatallites.Value = new decimal(new int[] { 12, 0, 0, 0 });
      // 
      // recordVoltage
      // 
      recordVoltage.DecimalPlaces = 3;
      recordVoltage.Location = new Point(91, 246);
      recordVoltage.Margin = new Padding(3, 2, 3, 2);
      recordVoltage.Maximum = new decimal(new int[] { 65, 0, 0, 0 });
      recordVoltage.Name = "recordVoltage";
      recordVoltage.Size = new Size(102, 23);
      recordVoltage.TabIndex = 16;
      recordVoltage.Value = new decimal(new int[] { 1307, 0, 0, 131072 });
      // 
      // label9
      // 
      label9.AutoSize = true;
      label9.Location = new Point(15, 164);
      label9.Name = "label9";
      label9.Size = new Size(53, 15);
      label9.TabIndex = 13;
      label9.Text = "Satallites";
      // 
      // label10
      // 
      label10.AutoSize = true;
      label10.Location = new Point(15, 220);
      label10.Name = "label10";
      label10.Size = new Size(61, 15);
      label10.TabIndex = 15;
      label10.Text = "Odometer";
      // 
      // responsesPage
      // 
      responsesPage.Controls.Add(responseList);
      responsesPage.Controls.Add(panel1);
      responsesPage.Location = new Point(4, 24);
      responsesPage.Margin = new Padding(3, 2, 3, 2);
      responsesPage.Name = "responsesPage";
      responsesPage.Padding = new Padding(3, 2, 3, 2);
      responsesPage.Size = new Size(526, 395);
      responsesPage.TabIndex = 1;
      responsesPage.Text = "Response List";
      responsesPage.UseVisualStyleBackColor = true;
      // 
      // responseList
      // 
      dataGridViewCellStyle5.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
      responseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
      responseList.AutoGenerateColumns = false;
      responseList.BackgroundColor = SystemColors.ControlLightLight;
      responseList.BorderStyle = BorderStyle.Fixed3D;
      responseList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = Color.RoyalBlue;
      dataGridViewCellStyle6.Font = new Font("Cascadia Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
      dataGridViewCellStyle6.ForeColor = Color.White;
      dataGridViewCellStyle6.SelectionBackColor = Color.RoyalBlue;
      dataGridViewCellStyle6.SelectionForeColor = Color.White;
      dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
      responseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
      responseList.ColumnHeadersHeight = 35;
      responseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      responseList.Columns.AddRange(new DataGridViewColumn[] { commandDataGridViewTextBoxColumn, responseDataGridViewTextBoxColumn });
      responseList.DataSource = responseBindingSource;
      dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = SystemColors.Window;
      dataGridViewCellStyle7.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
      dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
      dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
      dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
      dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
      responseList.DefaultCellStyle = dataGridViewCellStyle7;
      responseList.Dock = DockStyle.Fill;
      responseList.EnableHeadersVisualStyles = false;
      responseList.Location = new Point(3, 2);
      responseList.MultiSelect = false;
      responseList.Name = "responseList";
      responseList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle8.BackColor = SystemColors.Control;
      dataGridViewCellStyle8.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
      dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
      responseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
      responseList.RowHeadersVisible = false;
      responseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      responseList.Size = new Size(520, 316);
      responseList.TabIndex = 10;
      // 
      // commandDataGridViewTextBoxColumn
      // 
      commandDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      commandDataGridViewTextBoxColumn.DataPropertyName = "Command";
      commandDataGridViewTextBoxColumn.HeaderText = "Command";
      commandDataGridViewTextBoxColumn.MinimumWidth = 200;
      commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
      // 
      // responseDataGridViewTextBoxColumn
      // 
      responseDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      responseDataGridViewTextBoxColumn.DataPropertyName = "Response";
      responseDataGridViewTextBoxColumn.HeaderText = "Response";
      responseDataGridViewTextBoxColumn.MinimumWidth = 200;
      responseDataGridViewTextBoxColumn.Name = "responseDataGridViewTextBoxColumn";
      // 
      // responseBindingSource
      // 
      responseBindingSource.DataSource = typeof(CommandResponse);
      // 
      // panel1
      // 
      panel1.Controls.Add(addResponse);
      panel1.Controls.Add(label14);
      panel1.Controls.Add(responseBox);
      panel1.Controls.Add(label13);
      panel1.Controls.Add(commandBox);
      panel1.Dock = DockStyle.Bottom;
      panel1.Location = new Point(3, 318);
      panel1.Name = "panel1";
      panel1.Size = new Size(520, 75);
      panel1.TabIndex = 1;
      // 
      // addResponse
      // 
      addResponse.Enabled = false;
      addResponse.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
      addResponse.ForeColor = Color.Green;
      addResponse.Location = new Point(275, 19);
      addResponse.Name = "addResponse";
      addResponse.Size = new Size(100, 35);
      addResponse.TabIndex = 4;
      addResponse.Text = "Add";
      addResponse.UseVisualStyleBackColor = true;
      addResponse.Click += addResponse_Click;
      // 
      // label14
      // 
      label14.AutoSize = true;
      label14.Location = new Point(12, 44);
      label14.Name = "label14";
      label14.Size = new Size(57, 15);
      label14.TabIndex = 3;
      label14.Text = "Response";
      // 
      // responseBox
      // 
      responseBox.Location = new Point(87, 40);
      responseBox.Name = "responseBox";
      responseBox.PlaceholderText = "Response";
      responseBox.Size = new Size(162, 23);
      responseBox.TabIndex = 2;
      responseBox.TextChanged += responseBox_TextChanged;
      // 
      // label13
      // 
      label13.AutoSize = true;
      label13.Location = new Point(12, 15);
      label13.Name = "label13";
      label13.Size = new Size(64, 15);
      label13.TabIndex = 1;
      label13.Text = "Command";
      // 
      // commandBox
      // 
      commandBox.Location = new Point(87, 11);
      commandBox.Name = "commandBox";
      commandBox.PlaceholderText = "Command";
      commandBox.Size = new Size(162, 23);
      commandBox.TabIndex = 0;
      commandBox.TextChanged += commandBox_TextChanged;
      // 
      // commandsPage
      // 
      commandsPage.Controls.Add(commandsList);
      commandsPage.Location = new Point(4, 24);
      commandsPage.Name = "commandsPage";
      commandsPage.Padding = new Padding(3);
      commandsPage.Size = new Size(526, 395);
      commandsPage.TabIndex = 2;
      commandsPage.Text = "Commands";
      commandsPage.UseVisualStyleBackColor = true;
      // 
      // commandsList
      // 
      commandsList.Columns.AddRange(new ColumnHeader[] { timeColumn, commandColumn, responseColumn });
      commandsList.Dock = DockStyle.Fill;
      commandsList.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
      commandsList.FullRowSelect = true;
      commandsList.GridLines = true;
      commandsList.Location = new Point(3, 3);
      commandsList.MultiSelect = false;
      commandsList.Name = "commandsList";
      commandsList.Size = new Size(520, 389);
      commandsList.TabIndex = 0;
      commandsList.UseCompatibleStateImageBehavior = false;
      commandsList.View = View.Details;
      commandsList.SizeChanged += commandsList_SizeChanged;
      // 
      // timeColumn
      // 
      timeColumn.Text = "Time";
      timeColumn.Width = 150;
      // 
      // commandColumn
      // 
      commandColumn.Text = "Command";
      commandColumn.Width = 120;
      // 
      // responseColumn
      // 
      responseColumn.Text = "Response";
      responseColumn.Width = 120;
      // 
      // logsPage
      // 
      logsPage.Controls.Add(logsBox);
      logsPage.Location = new Point(4, 24);
      logsPage.Name = "logsPage";
      logsPage.Padding = new Padding(3);
      logsPage.Size = new Size(526, 395);
      logsPage.TabIndex = 3;
      logsPage.Text = "Logs";
      logsPage.UseVisualStyleBackColor = true;
      // 
      // logsBox
      // 
      logsBox.BackColor = Color.Black;
      logsBox.BorderStyle = BorderStyle.None;
      logsBox.Dock = DockStyle.Fill;
      logsBox.Font = new Font("Cascadia Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
      logsBox.ForeColor = Color.White;
      logsBox.Location = new Point(3, 3);
      logsBox.Name = "logsBox";
      logsBox.ReadOnly = true;
      logsBox.Size = new Size(520, 389);
      logsBox.TabIndex = 0;
      logsBox.Text = "";
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(panel5);
      tabPage1.Controls.Add(label18);
      tabPage1.Controls.Add(panel4);
      tabPage1.Controls.Add(pictureBox1);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(526, 395);
      tabPage1.TabIndex = 4;
      tabPage1.Text = "About";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // panel5
      // 
      panel5.Location = new Point(18, 154);
      panel5.Name = "panel5";
      panel5.Size = new Size(500, 189);
      panel5.TabIndex = 4;
      // 
      // label18
      // 
      label18.Dock = DockStyle.Bottom;
      label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label18.Location = new Point(3, 346);
      label18.Name = "label18";
      label18.Size = new Size(520, 46);
      label18.TabIndex = 3;
      label18.Text = "© 2024 Mahmoud Elnagar. All rights reserved.";
      label18.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // panel4
      // 
      panel4.Controls.Add(label19);
      panel4.Controls.Add(label17);
      panel4.Controls.Add(label16);
      panel4.Controls.Add(label15);
      panel4.Location = new Point(152, 20);
      panel4.Name = "panel4";
      panel4.Size = new Size(366, 128);
      panel4.TabIndex = 2;
      // 
      // label19
      // 
      label19.AutoSize = true;
      label19.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label19.Location = new Point(10, 82);
      label19.Name = "label19";
      label19.Size = new Size(296, 18);
      label19.TabIndex = 4;
      label19.Text = "Email: mahmoud.elnagar1698@gmail.com";
      // 
      // label17
      // 
      label17.AutoSize = true;
      label17.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label17.Location = new Point(10, 49);
      label17.Name = "label17";
      label17.Size = new Size(217, 21);
      label17.TabIndex = 3;
      label17.Text = "Author: Mahmoud Elnagar";
      // 
      // label16
      // 
      label16.AutoSize = true;
      label16.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label16.ForeColor = Color.Crimson;
      label16.Location = new Point(271, 7);
      label16.Name = "label16";
      label16.Size = new Size(65, 29);
      label16.TabIndex = 2;
      label16.Text = "v0.1";
      // 
      // label15
      // 
      label15.AutoSize = true;
      label15.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label15.Location = new Point(10, 5);
      label15.Name = "label15";
      label15.Size = new Size(238, 32);
      label15.TabIndex = 1;
      label15.Text = "Teltonika Client";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
      pictureBox1.Location = new Point(18, 20);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(128, 128);
      pictureBox1.TabIndex = 0;
      pictureBox1.TabStop = false;
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = DockStyle.Fill;
      splitContainer1.FixedPanel = FixedPanel.Panel1;
      splitContainer1.IsSplitterFixed = true;
      splitContainer1.Location = new Point(0, 0);
      splitContainer1.Margin = new Padding(3, 2, 3, 2);
      splitContainer1.Name = "splitContainer1";
      splitContainer1.Orientation = Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(socketGroup);
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add(tabs);
      splitContainer1.Size = new Size(534, 561);
      splitContainer1.SplitterDistance = 135;
      splitContainer1.SplitterWidth = 3;
      splitContainer1.TabIndex = 10;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(534, 561);
      Controls.Add(splitContainer1);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Margin = new Padding(3, 2, 3, 2);
      MinimumSize = new Size(550, 600);
      Name = "MainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Teltonika Client";
      Load += MainForm_Load;
      ((System.ComponentModel.ISupportInitialize)portBox).EndInit();
      socketGroup.ResumeLayout(false);
      socketGroup.PerformLayout();
      panel3.ResumeLayout(false);
      tabs.ResumeLayout(false);
      recordsPage.ResumeLayout(false);
      recordsPanel.ResumeLayout(false);
      recordsPanel.PerformLayout();
      panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)recordOdometer).EndInit();
      ((System.ComponentModel.ISupportInitialize)recordSpeed).EndInit();
      ((System.ComponentModel.ISupportInitialize)recordLongitude).EndInit();
      ((System.ComponentModel.ISupportInitialize)recordLatitude).EndInit();
      ((System.ComponentModel.ISupportInitialize)recordAltitude).EndInit();
      ((System.ComponentModel.ISupportInitialize)recordAngle).EndInit();
      ((System.ComponentModel.ISupportInitialize)recordBattery).EndInit();
      ((System.ComponentModel.ISupportInitialize)recordSatallites).EndInit();
      ((System.ComponentModel.ISupportInitialize)recordVoltage).EndInit();
      responsesPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)responseList).EndInit();
      ((System.ComponentModel.ISupportInitialize)responseBindingSource).EndInit();
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      commandsPage.ResumeLayout(false);
      logsPage.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      panel4.ResumeLayout(false);
      panel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      splitContainer1.Panel1.ResumeLayout(false);
      splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private TextBox imeiBox;
    private TextBox hostBox;
    private NumericUpDown portBox;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button connectButton;
    private GroupBox socketGroup;
    private Button closeButton;
    private TabControl tabs;
    private TabPage recordsPage;
    private TabPage responsesPage;
    private SplitContainer splitContainer1;
    private DateTimePicker recordTime;
    private Label speedLabel;
    private NumericUpDown recordSpeed;
    private Label label5;
    private NumericUpDown recordLatitude;
    private Label label4;
    private NumericUpDown recordLongitude;
    private Label label12;
    private NumericUpDown recordBattery;
    private Label label11;
    private NumericUpDown recordVoltage;
    private Label label10;
    private Label label9;
    private NumericUpDown recordSatallites;
    private Label label8;
    private NumericUpDown recordAngle;
    private Label label7;
    private NumericUpDown recordAltitude;
    private Label label6;
    private CheckBox recordIgnition;
    private CheckBox recordIdle;
    private CheckBox recordMovement;
    private CheckBox recordTow;
    private Button recordDefault;
    private Button recordRandom;
    private Button recordSend;
    private CheckBox recordNow;
    private NumericUpDown recordOdometer;
    private Panel recordsPanel;
    private DataGridView responseList;
    private BindingSource responseBindingSource;
    private Panel panel1;
    private Label label14;
    private TextBox responseBox;
    private Label label13;
    private TextBox commandBox;
    private Button addResponse;
    private TabPage commandsPage;
    private ListView commandsList;
    private ColumnHeader timeColumn;
    private ColumnHeader commandColumn;
    private ColumnHeader responseColumn;
    private TabPage logsPage;
    private RichTextBox logsBox;
    private Panel panel2;
    private Panel panel3;
    private DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn responseDataGridViewTextBoxColumn;
    private TabPage tabPage1;
    private PictureBox pictureBox1;
    private Panel panel4;
    private Label label17;
    private Label label16;
    private Label label15;
    private Label label18;
    private Panel panel5;
    private Label label19;
  }
}