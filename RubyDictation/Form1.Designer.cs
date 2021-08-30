
namespace RubyDictation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recognizeButton = new System.Windows.Forms.Button();
            this.rubyConsole = new System.Windows.Forms.TextBox();
            this.rubyUrl = new System.Windows.Forms.Label();
            this.rubyFormat = new System.Windows.Forms.Label();
            this.rubyPartial1 = new System.Windows.Forms.Label();
            this.rubyPartial2 = new System.Windows.Forms.Label();
            this.NteConsole = new System.Windows.Forms.TextBox();
            this.settingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rubyGroupBox = new System.Windows.Forms.GroupBox();
            this.rubySettingGroupBox = new System.Windows.Forms.GroupBox();
            this.rubyKana = new System.Windows.Forms.CheckBox();
            this.rubyArabic = new System.Windows.Forms.CheckBox();
            this.rubyRemoveFiller = new System.Windows.Forms.CheckBox();
            this.rubyPunctuation = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rubyPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rubyIp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nteGroupBox = new System.Windows.Forms.GroupBox();
            this.nteUrl = new System.Windows.Forms.Label();
            this.nteSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.operatingModeGroupBox = new System.Windows.Forms.GroupBox();
            this.nteWarp = new System.Windows.Forms.RadioButton();
            this.nteFast = new System.Windows.Forms.RadioButton();
            this.nteAccurate = new System.Windows.Forms.RadioButton();
            this.nteDiarize = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ntePort = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nteIp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.audioInputGroupBox = new System.Windows.Forms.GroupBox();
            this.deviceAudioInput = new System.Windows.Forms.RadioButton();
            this.fileAudioInput = new System.Windows.Forms.RadioButton();
            this.audioPath = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sampleRateGroupBox = new System.Windows.Forms.GroupBox();
            this.kHz16 = new System.Windows.Forms.RadioButton();
            this.kHz8 = new System.Windows.Forms.RadioButton();
            this.channelGroupBox = new System.Windows.Forms.GroupBox();
            this.ch2 = new System.Windows.Forms.RadioButton();
            this.ch1 = new System.Windows.Forms.RadioButton();
            this.bitGroupBox = new System.Windows.Forms.GroupBox();
            this.bit16 = new System.Windows.Forms.RadioButton();
            this.bit8 = new System.Windows.Forms.RadioButton();
            this.formatGroupBox = new System.Windows.Forms.GroupBox();
            this.mp3Format = new System.Windows.Forms.RadioButton();
            this.muLawFormat = new System.Windows.Forms.RadioButton();
            this.rawFormat = new System.Windows.Forms.RadioButton();
            this.inputAudioSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rubyResultGroupBox = new System.Windows.Forms.GroupBox();
            this.nteResultGroupBox = new System.Windows.Forms.GroupBox();
            this.RecognizeStopButton = new System.Windows.Forms.Button();
            this.settingTableLayoutPanel.SuspendLayout();
            this.rubyGroupBox.SuspendLayout();
            this.rubySettingGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubyPort)).BeginInit();
            this.nteGroupBox.SuspendLayout();
            this.nteSettingGroupBox.SuspendLayout();
            this.operatingModeGroupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntePort)).BeginInit();
            this.audioInputGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.sampleRateGroupBox.SuspendLayout();
            this.channelGroupBox.SuspendLayout();
            this.bitGroupBox.SuspendLayout();
            this.formatGroupBox.SuspendLayout();
            this.inputAudioSettingGroupBox.SuspendLayout();
            this.resultTableLayoutPanel.SuspendLayout();
            this.rubyResultGroupBox.SuspendLayout();
            this.nteResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // recognizeButton
            // 
            this.recognizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recognizeButton.Location = new System.Drawing.Point(843, 432);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(75, 23);
            this.recognizeButton.TabIndex = 1;
            this.recognizeButton.Text = "認識開始";
            this.recognizeButton.UseVisualStyleBackColor = true;
            this.recognizeButton.Click += new System.EventHandler(this.RecognizeButton_Click);
            // 
            // rubyConsole
            // 
            this.rubyConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubyConsole.Location = new System.Drawing.Point(6, 22);
            this.rubyConsole.Multiline = true;
            this.rubyConsole.Name = "rubyConsole";
            this.rubyConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rubyConsole.Size = new System.Drawing.Size(435, 62);
            this.rubyConsole.TabIndex = 2;
            // 
            // rubyUrl
            // 
            this.rubyUrl.AutoSize = true;
            this.rubyUrl.Location = new System.Drawing.Point(6, 126);
            this.rubyUrl.Margin = new System.Windows.Forms.Padding(3);
            this.rubyUrl.Name = "rubyUrl";
            this.rubyUrl.Size = new System.Drawing.Size(90, 15);
            this.rubyUrl.TabIndex = 3;
            this.rubyUrl.Text = "WebSocket URL";
            // 
            // rubyFormat
            // 
            this.rubyFormat.AutoSize = true;
            this.rubyFormat.Location = new System.Drawing.Point(6, 147);
            this.rubyFormat.Margin = new System.Windows.Forms.Padding(3);
            this.rubyFormat.Name = "rubyFormat";
            this.rubyFormat.Size = new System.Drawing.Size(75, 15);
            this.rubyFormat.TabIndex = 4;
            this.rubyFormat.Text = "FormatString";
            // 
            // rubyPartial1
            // 
            this.rubyPartial1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rubyPartial1.AutoSize = true;
            this.rubyPartial1.Location = new System.Drawing.Point(12, 423);
            this.rubyPartial1.Margin = new System.Windows.Forms.Padding(3);
            this.rubyPartial1.Name = "rubyPartial1";
            this.rubyPartial1.Size = new System.Drawing.Size(49, 15);
            this.rubyPartial1.TabIndex = 6;
            this.rubyPartial1.Text = "話者１: ";
            // 
            // rubyPartial2
            // 
            this.rubyPartial2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rubyPartial2.AutoSize = true;
            this.rubyPartial2.Location = new System.Drawing.Point(12, 444);
            this.rubyPartial2.Margin = new System.Windows.Forms.Padding(3);
            this.rubyPartial2.Name = "rubyPartial2";
            this.rubyPartial2.Size = new System.Drawing.Size(49, 15);
            this.rubyPartial2.TabIndex = 7;
            this.rubyPartial2.Text = "話者２: ";
            // 
            // NteConsole
            // 
            this.NteConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NteConsole.Location = new System.Drawing.Point(6, 22);
            this.NteConsole.Multiline = true;
            this.NteConsole.Name = "NteConsole";
            this.NteConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NteConsole.Size = new System.Drawing.Size(432, 62);
            this.NteConsole.TabIndex = 8;
            // 
            // settingTableLayoutPanel
            // 
            this.settingTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingTableLayoutPanel.ColumnCount = 2;
            this.settingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingTableLayoutPanel.Controls.Add(this.rubyGroupBox, 0, 0);
            this.settingTableLayoutPanel.Controls.Add(this.nteGroupBox, 1, 0);
            this.settingTableLayoutPanel.Location = new System.Drawing.Point(12, 140);
            this.settingTableLayoutPanel.Name = "settingTableLayoutPanel";
            this.settingTableLayoutPanel.RowCount = 1;
            this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingTableLayoutPanel.Size = new System.Drawing.Size(905, 175);
            this.settingTableLayoutPanel.TabIndex = 12;
            // 
            // rubyGroupBox
            // 
            this.rubyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubyGroupBox.Controls.Add(this.rubySettingGroupBox);
            this.rubyGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.rubyGroupBox.Controls.Add(this.rubyFormat);
            this.rubyGroupBox.Controls.Add(this.rubyUrl);
            this.rubyGroupBox.Location = new System.Drawing.Point(3, 3);
            this.rubyGroupBox.Name = "rubyGroupBox";
            this.rubyGroupBox.Size = new System.Drawing.Size(446, 169);
            this.rubyGroupBox.TabIndex = 10;
            this.rubyGroupBox.TabStop = false;
            this.rubyGroupBox.Text = "Ruby Dictation設定";
            // 
            // rubySettingGroupBox
            // 
            this.rubySettingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubySettingGroupBox.Controls.Add(this.rubyKana);
            this.rubySettingGroupBox.Controls.Add(this.rubyArabic);
            this.rubySettingGroupBox.Controls.Add(this.rubyRemoveFiller);
            this.rubySettingGroupBox.Controls.Add(this.rubyPunctuation);
            this.rubySettingGroupBox.Location = new System.Drawing.Point(6, 56);
            this.rubySettingGroupBox.Name = "rubySettingGroupBox";
            this.rubySettingGroupBox.Size = new System.Drawing.Size(432, 64);
            this.rubySettingGroupBox.TabIndex = 13;
            this.rubySettingGroupBox.TabStop = false;
            this.rubySettingGroupBox.Text = "設定";
            // 
            // rubyKana
            // 
            this.rubyKana.AutoSize = true;
            this.rubyKana.Location = new System.Drawing.Point(343, 22);
            this.rubyKana.Name = "rubyKana";
            this.rubyKana.Size = new System.Drawing.Size(86, 19);
            this.rubyKana.TabIndex = 0;
            this.rubyKana.Text = "Kana Name";
            this.rubyKana.UseVisualStyleBackColor = true;
            // 
            // rubyArabic
            // 
            this.rubyArabic.AutoSize = true;
            this.rubyArabic.Location = new System.Drawing.Point(231, 22);
            this.rubyArabic.Name = "rubyArabic";
            this.rubyArabic.Size = new System.Drawing.Size(106, 19);
            this.rubyArabic.TabIndex = 0;
            this.rubyArabic.Text = "Arabic Number";
            this.rubyArabic.UseVisualStyleBackColor = true;
            // 
            // rubyRemoveFiller
            // 
            this.rubyRemoveFiller.AutoSize = true;
            this.rubyRemoveFiller.Location = new System.Drawing.Point(129, 22);
            this.rubyRemoveFiller.Name = "rubyRemoveFiller";
            this.rubyRemoveFiller.Size = new System.Drawing.Size(96, 19);
            this.rubyRemoveFiller.TabIndex = 0;
            this.rubyRemoveFiller.Text = "Remove Filler";
            this.rubyRemoveFiller.UseVisualStyleBackColor = true;
            // 
            // rubyPunctuation
            // 
            this.rubyPunctuation.AutoSize = true;
            this.rubyPunctuation.Location = new System.Drawing.Point(7, 23);
            this.rubyPunctuation.Name = "rubyPunctuation";
            this.rubyPunctuation.Size = new System.Drawing.Size(116, 19);
            this.rubyPunctuation.TabIndex = 0;
            this.rubyPunctuation.Text = "Add Punctuation";
            this.rubyPunctuation.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.Controls.Add(this.rubyPort, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rubyIp, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(432, 31);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // rubyPort
            // 
            this.rubyPort.Location = new System.Drawing.Point(355, 3);
            this.rubyPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.rubyPort.Name = "rubyPort";
            this.rubyPort.Size = new System.Drawing.Size(74, 23);
            this.rubyPort.TabIndex = 14;
            this.rubyPort.Value = new decimal(new int[] {
            8302,
            0,
            0,
            0});
            this.rubyPort.ValueChanged += new System.EventHandler(this.RubyPort_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "IP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rubyIp
            // 
            this.rubyIp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubyIp.Location = new System.Drawing.Point(43, 3);
            this.rubyIp.Name = "rubyIp";
            this.rubyIp.Size = new System.Drawing.Size(266, 23);
            this.rubyIp.TabIndex = 0;
            this.rubyIp.Text = "192.168.13.20";
            this.rubyIp.TextChanged += new System.EventHandler(this.RubyIp_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Port";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nteGroupBox
            // 
            this.nteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nteGroupBox.Controls.Add(this.nteUrl);
            this.nteGroupBox.Controls.Add(this.nteSettingGroupBox);
            this.nteGroupBox.Controls.Add(this.tableLayoutPanel5);
            this.nteGroupBox.Location = new System.Drawing.Point(455, 3);
            this.nteGroupBox.Name = "nteGroupBox";
            this.nteGroupBox.Size = new System.Drawing.Size(447, 169);
            this.nteGroupBox.TabIndex = 10;
            this.nteGroupBox.TabStop = false;
            this.nteGroupBox.Text = "NTE設定";
            // 
            // nteUrl
            // 
            this.nteUrl.AutoSize = true;
            this.nteUrl.Location = new System.Drawing.Point(10, 126);
            this.nteUrl.Name = "nteUrl";
            this.nteUrl.Size = new System.Drawing.Size(52, 15);
            this.nteUrl.TabIndex = 14;
            this.nteUrl.Text = "NTE URL";
            // 
            // nteSettingGroupBox
            // 
            this.nteSettingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nteSettingGroupBox.Controls.Add(this.operatingModeGroupBox);
            this.nteSettingGroupBox.Controls.Add(this.nteDiarize);
            this.nteSettingGroupBox.Location = new System.Drawing.Point(10, 56);
            this.nteSettingGroupBox.Name = "nteSettingGroupBox";
            this.nteSettingGroupBox.Size = new System.Drawing.Size(432, 64);
            this.nteSettingGroupBox.TabIndex = 13;
            this.nteSettingGroupBox.TabStop = false;
            this.nteSettingGroupBox.Text = "設定";
            // 
            // operatingModeGroupBox
            // 
            this.operatingModeGroupBox.Controls.Add(this.nteWarp);
            this.operatingModeGroupBox.Controls.Add(this.nteFast);
            this.operatingModeGroupBox.Controls.Add(this.nteAccurate);
            this.operatingModeGroupBox.Location = new System.Drawing.Point(6, 16);
            this.operatingModeGroupBox.Name = "operatingModeGroupBox";
            this.operatingModeGroupBox.Size = new System.Drawing.Size(197, 42);
            this.operatingModeGroupBox.TabIndex = 13;
            this.operatingModeGroupBox.TabStop = false;
            this.operatingModeGroupBox.Text = "OperatingMode";
            // 
            // nteWarp
            // 
            this.nteWarp.AutoSize = true;
            this.nteWarp.Location = new System.Drawing.Point(136, 19);
            this.nteWarp.Name = "nteWarp";
            this.nteWarp.Size = new System.Drawing.Size(53, 19);
            this.nteWarp.TabIndex = 0;
            this.nteWarp.Text = "Warp";
            this.nteWarp.UseVisualStyleBackColor = true;
            // 
            // nteFast
            // 
            this.nteFast.AutoSize = true;
            this.nteFast.Checked = true;
            this.nteFast.Location = new System.Drawing.Point(85, 19);
            this.nteFast.Name = "nteFast";
            this.nteFast.Size = new System.Drawing.Size(45, 19);
            this.nteFast.TabIndex = 0;
            this.nteFast.TabStop = true;
            this.nteFast.Text = "Fast";
            this.nteFast.UseVisualStyleBackColor = true;
            // 
            // nteAccurate
            // 
            this.nteAccurate.AutoSize = true;
            this.nteAccurate.Location = new System.Drawing.Point(7, 19);
            this.nteAccurate.Name = "nteAccurate";
            this.nteAccurate.Size = new System.Drawing.Size(72, 19);
            this.nteAccurate.TabIndex = 0;
            this.nteAccurate.Text = "Accurate";
            this.nteAccurate.UseVisualStyleBackColor = true;
            // 
            // nteDiarize
            // 
            this.nteDiarize.AutoSize = true;
            this.nteDiarize.Location = new System.Drawing.Point(209, 37);
            this.nteDiarize.Name = "nteDiarize";
            this.nteDiarize.Size = new System.Drawing.Size(82, 19);
            this.nteDiarize.TabIndex = 0;
            this.nteDiarize.Text = "Diarization";
            this.nteDiarize.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.Controls.Add(this.ntePort, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.nteIp, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(9, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(432, 31);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // ntePort
            // 
            this.ntePort.Location = new System.Drawing.Point(355, 3);
            this.ntePort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ntePort.Name = "ntePort";
            this.ntePort.Size = new System.Drawing.Size(74, 23);
            this.ntePort.TabIndex = 14;
            this.ntePort.Value = new decimal(new int[] {
            19901,
            0,
            0,
            0});
            this.ntePort.ValueChanged += new System.EventHandler(this.ntePort_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "IP";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nteIp
            // 
            this.nteIp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nteIp.Location = new System.Drawing.Point(43, 3);
            this.nteIp.Name = "nteIp";
            this.nteIp.Size = new System.Drawing.Size(266, 23);
            this.nteIp.TabIndex = 0;
            this.nteIp.Text = "192.168.13.17";
            this.nteIp.TextChanged += new System.EventHandler(this.nteIp_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Port";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // audioInputGroupBox
            // 
            this.audioInputGroupBox.Controls.Add(this.deviceAudioInput);
            this.audioInputGroupBox.Controls.Add(this.fileAudioInput);
            this.audioInputGroupBox.Location = new System.Drawing.Point(6, 15);
            this.audioInputGroupBox.Name = "audioInputGroupBox";
            this.audioInputGroupBox.Size = new System.Drawing.Size(171, 42);
            this.audioInputGroupBox.TabIndex = 13;
            this.audioInputGroupBox.TabStop = false;
            this.audioInputGroupBox.Text = "入力";
            // 
            // deviceAudioInput
            // 
            this.deviceAudioInput.AutoSize = true;
            this.deviceAudioInput.Location = new System.Drawing.Point(72, 19);
            this.deviceAudioInput.Name = "deviceAudioInput";
            this.deviceAudioInput.Size = new System.Drawing.Size(86, 19);
            this.deviceAudioInput.TabIndex = 0;
            this.deviceAudioInput.Text = "デバイス出力";
            this.deviceAudioInput.UseVisualStyleBackColor = true;
            this.deviceAudioInput.CheckedChanged += new System.EventHandler(this.DeviceAudioInput_CheckedChanged);
            // 
            // fileAudioInput
            // 
            this.fileAudioInput.AutoSize = true;
            this.fileAudioInput.Checked = true;
            this.fileAudioInput.Location = new System.Drawing.Point(7, 19);
            this.fileAudioInput.Name = "fileAudioInput";
            this.fileAudioInput.Size = new System.Drawing.Size(59, 19);
            this.fileAudioInput.TabIndex = 0;
            this.fileAudioInput.TabStop = true;
            this.fileAudioInput.Text = "ファイル";
            this.fileAudioInput.UseVisualStyleBackColor = true;
            // 
            // audioPath
            // 
            this.audioPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioPath.Location = new System.Drawing.Point(9, 22);
            this.audioPath.Name = "audioPath";
            this.audioPath.Size = new System.Drawing.Size(802, 23);
            this.audioPath.TabIndex = 14;
            this.audioPath.Text = "D:\\共有フォルダ\\サウンド\\１秒音声ステレオ.wav";
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Location = new System.Drawing.Point(817, 21);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 15;
            this.selectButton.Text = "select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sampleRateGroupBox);
            this.groupBox5.Controls.Add(this.channelGroupBox);
            this.groupBox5.Controls.Add(this.bitGroupBox);
            this.groupBox5.Controls.Add(this.audioInputGroupBox);
            this.groupBox5.Controls.Add(this.formatGroupBox);
            this.groupBox5.Location = new System.Drawing.Point(9, 51);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(739, 63);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "音声";
            // 
            // sampleRateGroupBox
            // 
            this.sampleRateGroupBox.Controls.Add(this.kHz16);
            this.sampleRateGroupBox.Controls.Add(this.kHz8);
            this.sampleRateGroupBox.Location = new System.Drawing.Point(609, 15);
            this.sampleRateGroupBox.Name = "sampleRateGroupBox";
            this.sampleRateGroupBox.Size = new System.Drawing.Size(124, 42);
            this.sampleRateGroupBox.TabIndex = 13;
            this.sampleRateGroupBox.TabStop = false;
            this.sampleRateGroupBox.Text = "サンプリング周波数";
            // 
            // kHz16
            // 
            this.kHz16.AutoSize = true;
            this.kHz16.Checked = true;
            this.kHz16.Location = new System.Drawing.Point(59, 19);
            this.kHz16.Name = "kHz16";
            this.kHz16.Size = new System.Drawing.Size(57, 19);
            this.kHz16.TabIndex = 0;
            this.kHz16.TabStop = true;
            this.kHz16.Text = "16kHz";
            this.kHz16.UseVisualStyleBackColor = true;
            this.kHz16.CheckedChanged += new System.EventHandler(this.KHz16_CheckedChanged);
            // 
            // kHz8
            // 
            this.kHz8.AutoSize = true;
            this.kHz8.Location = new System.Drawing.Point(6, 19);
            this.kHz8.Name = "kHz8";
            this.kHz8.Size = new System.Drawing.Size(51, 19);
            this.kHz8.TabIndex = 0;
            this.kHz8.Text = "8kHz";
            this.kHz8.UseVisualStyleBackColor = true;
            this.kHz8.CheckedChanged += new System.EventHandler(this.KHz8_CheckedChanged);
            // 
            // channelGroupBox
            // 
            this.channelGroupBox.Controls.Add(this.ch2);
            this.channelGroupBox.Controls.Add(this.ch1);
            this.channelGroupBox.Location = new System.Drawing.Point(363, 15);
            this.channelGroupBox.Name = "channelGroupBox";
            this.channelGroupBox.Size = new System.Drawing.Size(117, 42);
            this.channelGroupBox.TabIndex = 13;
            this.channelGroupBox.TabStop = false;
            this.channelGroupBox.Text = "チャンネル数";
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Checked = true;
            this.ch2.Location = new System.Drawing.Point(60, 19);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(45, 19);
            this.ch2.TabIndex = 0;
            this.ch2.TabStop = true;
            this.ch2.Text = "2Ch";
            this.ch2.UseVisualStyleBackColor = true;
            this.ch2.CheckedChanged += new System.EventHandler(this.Ch2_CheckedChanged);
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Location = new System.Drawing.Point(7, 19);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(45, 19);
            this.ch1.TabIndex = 0;
            this.ch1.Text = "1Ch";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.CheckedChanged += new System.EventHandler(this.Ch1_CheckedChanged);
            // 
            // bitGroupBox
            // 
            this.bitGroupBox.Controls.Add(this.bit16);
            this.bitGroupBox.Controls.Add(this.bit8);
            this.bitGroupBox.Location = new System.Drawing.Point(486, 15);
            this.bitGroupBox.Name = "bitGroupBox";
            this.bitGroupBox.Size = new System.Drawing.Size(117, 42);
            this.bitGroupBox.TabIndex = 13;
            this.bitGroupBox.TabStop = false;
            this.bitGroupBox.Text = "量子化ビット";
            // 
            // bit16
            // 
            this.bit16.AutoSize = true;
            this.bit16.Checked = true;
            this.bit16.Location = new System.Drawing.Point(60, 19);
            this.bit16.Name = "bit16";
            this.bit16.Size = new System.Drawing.Size(51, 19);
            this.bit16.TabIndex = 0;
            this.bit16.TabStop = true;
            this.bit16.Text = "16bit";
            this.bit16.UseVisualStyleBackColor = true;
            this.bit16.CheckedChanged += new System.EventHandler(this.Bit16_CheckedChanged);
            // 
            // bit8
            // 
            this.bit8.AutoSize = true;
            this.bit8.Location = new System.Drawing.Point(7, 19);
            this.bit8.Name = "bit8";
            this.bit8.Size = new System.Drawing.Size(45, 19);
            this.bit8.TabIndex = 0;
            this.bit8.Text = "8bit";
            this.bit8.UseVisualStyleBackColor = true;
            this.bit8.CheckedChanged += new System.EventHandler(this.Bit8_CheckedChanged);
            // 
            // formatGroupBox
            // 
            this.formatGroupBox.Controls.Add(this.mp3Format);
            this.formatGroupBox.Controls.Add(this.muLawFormat);
            this.formatGroupBox.Controls.Add(this.rawFormat);
            this.formatGroupBox.Location = new System.Drawing.Point(183, 15);
            this.formatGroupBox.Name = "formatGroupBox";
            this.formatGroupBox.Size = new System.Drawing.Size(174, 42);
            this.formatGroupBox.TabIndex = 13;
            this.formatGroupBox.TabStop = false;
            this.formatGroupBox.Text = "フォーマット";
            // 
            // mp3Format
            // 
            this.mp3Format.AutoSize = true;
            this.mp3Format.Location = new System.Drawing.Point(121, 19);
            this.mp3Format.Name = "mp3Format";
            this.mp3Format.Size = new System.Drawing.Size(48, 19);
            this.mp3Format.TabIndex = 0;
            this.mp3Format.Text = "mp3";
            this.mp3Format.UseVisualStyleBackColor = true;
            this.mp3Format.CheckedChanged += new System.EventHandler(this.Mp3Format_CheckedChanged);
            // 
            // muLawFormat
            // 
            this.muLawFormat.AutoSize = true;
            this.muLawFormat.Checked = true;
            this.muLawFormat.Location = new System.Drawing.Point(60, 19);
            this.muLawFormat.Name = "muLawFormat";
            this.muLawFormat.Size = new System.Drawing.Size(55, 19);
            this.muLawFormat.TabIndex = 0;
            this.muLawFormat.TabStop = true;
            this.muLawFormat.Text = "μ-law";
            this.muLawFormat.UseVisualStyleBackColor = true;
            this.muLawFormat.CheckedChanged += new System.EventHandler(this.MuLawFormat_CheckedChanged);
            // 
            // rawFormat
            // 
            this.rawFormat.AutoSize = true;
            this.rawFormat.Location = new System.Drawing.Point(7, 19);
            this.rawFormat.Name = "rawFormat";
            this.rawFormat.Size = new System.Drawing.Size(47, 19);
            this.rawFormat.TabIndex = 0;
            this.rawFormat.Text = "Raw";
            this.rawFormat.UseVisualStyleBackColor = true;
            this.rawFormat.CheckedChanged += new System.EventHandler(this.RawFormat_CheckedChanged);
            // 
            // inputAudioSettingGroupBox
            // 
            this.inputAudioSettingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputAudioSettingGroupBox.Controls.Add(this.audioPath);
            this.inputAudioSettingGroupBox.Controls.Add(this.selectButton);
            this.inputAudioSettingGroupBox.Controls.Add(this.groupBox5);
            this.inputAudioSettingGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputAudioSettingGroupBox.Name = "inputAudioSettingGroupBox";
            this.inputAudioSettingGroupBox.Size = new System.Drawing.Size(904, 122);
            this.inputAudioSettingGroupBox.TabIndex = 17;
            this.inputAudioSettingGroupBox.TabStop = false;
            this.inputAudioSettingGroupBox.Text = "入力音声設定";
            // 
            // resultTableLayoutPanel
            // 
            this.resultTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTableLayoutPanel.ColumnCount = 2;
            this.resultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultTableLayoutPanel.Controls.Add(this.rubyResultGroupBox, 0, 0);
            this.resultTableLayoutPanel.Controls.Add(this.nteResultGroupBox, 1, 0);
            this.resultTableLayoutPanel.Enabled = false;
            this.resultTableLayoutPanel.Location = new System.Drawing.Point(12, 321);
            this.resultTableLayoutPanel.Name = "resultTableLayoutPanel";
            this.resultTableLayoutPanel.RowCount = 1;
            this.resultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultTableLayoutPanel.Size = new System.Drawing.Size(906, 96);
            this.resultTableLayoutPanel.TabIndex = 18;
            // 
            // rubyResultGroupBox
            // 
            this.rubyResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubyResultGroupBox.Controls.Add(this.rubyConsole);
            this.rubyResultGroupBox.Location = new System.Drawing.Point(3, 3);
            this.rubyResultGroupBox.Name = "rubyResultGroupBox";
            this.rubyResultGroupBox.Size = new System.Drawing.Size(447, 90);
            this.rubyResultGroupBox.TabIndex = 0;
            this.rubyResultGroupBox.TabStop = false;
            this.rubyResultGroupBox.Text = "Ruby Dictation結果";
            // 
            // nteResultGroupBox
            // 
            this.nteResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nteResultGroupBox.Controls.Add(this.NteConsole);
            this.nteResultGroupBox.Location = new System.Drawing.Point(456, 3);
            this.nteResultGroupBox.Name = "nteResultGroupBox";
            this.nteResultGroupBox.Size = new System.Drawing.Size(447, 90);
            this.nteResultGroupBox.TabIndex = 0;
            this.nteResultGroupBox.TabStop = false;
            this.nteResultGroupBox.Text = "NTE結果";
            // 
            // RecognizeStopButton
            // 
            this.RecognizeStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RecognizeStopButton.Enabled = false;
            this.RecognizeStopButton.Location = new System.Drawing.Point(762, 432);
            this.RecognizeStopButton.Name = "RecognizeStopButton";
            this.RecognizeStopButton.Size = new System.Drawing.Size(75, 23);
            this.RecognizeStopButton.TabIndex = 1;
            this.RecognizeStopButton.Text = "認識停止";
            this.RecognizeStopButton.UseVisualStyleBackColor = true;
            this.RecognizeStopButton.Click += new System.EventHandler(this.RecognizeStopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 467);
            this.Controls.Add(this.rubyPartial2);
            this.Controls.Add(this.resultTableLayoutPanel);
            this.Controls.Add(this.inputAudioSettingGroupBox);
            this.Controls.Add(this.rubyPartial1);
            this.Controls.Add(this.settingTableLayoutPanel);
            this.Controls.Add(this.RecognizeStopButton);
            this.Controls.Add(this.recognizeButton);
            this.Name = "Form1";
            this.Text = "RubyDectation Client C#";
            this.settingTableLayoutPanel.ResumeLayout(false);
            this.rubyGroupBox.ResumeLayout(false);
            this.rubyGroupBox.PerformLayout();
            this.rubySettingGroupBox.ResumeLayout(false);
            this.rubySettingGroupBox.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubyPort)).EndInit();
            this.nteGroupBox.ResumeLayout(false);
            this.nteGroupBox.PerformLayout();
            this.nteSettingGroupBox.ResumeLayout(false);
            this.nteSettingGroupBox.PerformLayout();
            this.operatingModeGroupBox.ResumeLayout(false);
            this.operatingModeGroupBox.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntePort)).EndInit();
            this.audioInputGroupBox.ResumeLayout(false);
            this.audioInputGroupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.sampleRateGroupBox.ResumeLayout(false);
            this.sampleRateGroupBox.PerformLayout();
            this.channelGroupBox.ResumeLayout(false);
            this.channelGroupBox.PerformLayout();
            this.bitGroupBox.ResumeLayout(false);
            this.bitGroupBox.PerformLayout();
            this.formatGroupBox.ResumeLayout(false);
            this.formatGroupBox.PerformLayout();
            this.inputAudioSettingGroupBox.ResumeLayout(false);
            this.inputAudioSettingGroupBox.PerformLayout();
            this.resultTableLayoutPanel.ResumeLayout(false);
            this.rubyResultGroupBox.ResumeLayout(false);
            this.rubyResultGroupBox.PerformLayout();
            this.nteResultGroupBox.ResumeLayout(false);
            this.nteResultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rubyUrl;
        private System.Windows.Forms.Label rubyFormat;
        public System.Windows.Forms.TextBox rubyConsole;
        public System.Windows.Forms.Label rubyPartial1;
        public System.Windows.Forms.Label rubyPartial2;
        public System.Windows.Forms.TextBox NteConsole;
        private System.Windows.Forms.GroupBox audioInputGroupBox;
        private System.Windows.Forms.RadioButton deviceAudioInput;
        private System.Windows.Forms.RadioButton fileAudioInput;
        private System.Windows.Forms.TextBox audioPath;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox formatGroupBox;
        private System.Windows.Forms.RadioButton muLawFormat;
        private System.Windows.Forms.RadioButton rawFormat;
        private System.Windows.Forms.GroupBox bitGroupBox;
        private System.Windows.Forms.RadioButton bit16;
        private System.Windows.Forms.RadioButton bit8;
        private System.Windows.Forms.RadioButton mp3Format;
        private System.Windows.Forms.GroupBox sampleRateGroupBox;
        private System.Windows.Forms.RadioButton kHz16;
        private System.Windows.Forms.RadioButton kHz8;
        private System.Windows.Forms.GroupBox rubyGroupBox;
        private System.Windows.Forms.GroupBox nteGroupBox;
        private System.Windows.Forms.GroupBox rubySettingGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rubyIp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nteIp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox rubyKana;
        private System.Windows.Forms.CheckBox rubyArabic;
        private System.Windows.Forms.CheckBox rubyRemoveFiller;
        private System.Windows.Forms.CheckBox rubyPunctuation;
        private System.Windows.Forms.GroupBox nteSettingGroupBox;
        private System.Windows.Forms.GroupBox operatingModeGroupBox;
        private System.Windows.Forms.RadioButton nteWarp;
        private System.Windows.Forms.RadioButton nteFast;
        private System.Windows.Forms.RadioButton nteAccurate;
        private System.Windows.Forms.CheckBox nteDiarize;
        private System.Windows.Forms.NumericUpDown rubyPort;
        private System.Windows.Forms.NumericUpDown ntePort;
        private System.Windows.Forms.GroupBox channelGroupBox;
        private System.Windows.Forms.RadioButton ch2;
        private System.Windows.Forms.GroupBox rubyResultGroupBox;
        private System.Windows.Forms.GroupBox nteResultGroupBox;
        public System.Windows.Forms.TableLayoutPanel resultTableLayoutPanel;
        public System.Windows.Forms.TableLayoutPanel settingTableLayoutPanel;
        public System.Windows.Forms.GroupBox inputAudioSettingGroupBox;
        public System.Windows.Forms.RadioButton ch1;
        public System.Windows.Forms.Button recognizeButton;
        public System.Windows.Forms.Button RecognizeStopButton;
        private System.Windows.Forms.Label nteUrl;
    }
}

