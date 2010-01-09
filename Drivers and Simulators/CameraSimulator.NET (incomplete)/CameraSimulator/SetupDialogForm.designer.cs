namespace ASCOM.Simulator
{
	partial class SetupDialogForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picASCOM = new System.Windows.Forms.PictureBox();
            this.groupBoxCCD = new System.Windows.Forms.GroupBox();
            this.textBoxMaxBinY = new System.Windows.Forms.TextBox();
            this.textBoxMaxBinX = new System.Windows.Forms.TextBox();
            this.textBoxSensorName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxBayerOffsetY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxBayerOffsetX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxSensorType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxHasShutter = new System.Windows.Forms.CheckBox();
            this.checkBoxCanAsymmetricBin = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxGainSettings = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxCooling = new System.Windows.Forms.GroupBox();
            this.checkBoxHasCooler = new System.Windows.Forms.CheckBox();
            this.checkBoxCanGetCoolerPower = new System.Windows.Forms.CheckBox();
            this.checkBoxCanSetCCDTemperature = new System.Windows.Forms.CheckBox();
            this.groupBoxExposure = new System.Windows.Forms.GroupBox();
            this.textBoxMaxExposure = new System.Windows.Forms.TextBox();
            this.textBoxMinExposure = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCanStopExposure = new System.Windows.Forms.CheckBox();
            this.checkBoxCanAbortExposure = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMaxADU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSizeY = new System.Windows.Forms.Label();
            this.labelSizeX = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxElectronsPerADU = new System.Windows.Forms.TextBox();
            this.textBoxPixelSizeX = new System.Windows.Forms.TextBox();
            this.textBoxPixelSizeY = new System.Windows.Forms.TextBox();
            this.textBoxCameraXSize = new System.Windows.Forms.TextBox();
            this.textBoxCameraYSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).BeginInit();
            this.groupBoxCCD.SuspendLayout();
            this.groupBoxGainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBoxCooling.SuspendLayout();
            this.groupBoxExposure.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(502, 320);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(59, 24);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(502, 350);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(59, 25);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(354, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Construct your driver\'s setup dialog here.";
            // 
            // picASCOM
            // 
            this.picASCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picASCOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picASCOM.Image = global::ASCOM.Simulator.Properties.Resources.ASCOM;
            this.picASCOM.Location = new System.Drawing.Point(513, 9);
            this.picASCOM.Name = "picASCOM";
            this.picASCOM.Size = new System.Drawing.Size(48, 56);
            this.picASCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picASCOM.TabIndex = 3;
            this.picASCOM.TabStop = false;
            this.picASCOM.DoubleClick += new System.EventHandler(this.BrowseToAscom);
            this.picASCOM.Click += new System.EventHandler(this.BrowseToAscom);
            // 
            // groupBoxCCD
            // 
            this.groupBoxCCD.Controls.Add(this.textBoxCameraYSize);
            this.groupBoxCCD.Controls.Add(this.textBoxCameraXSize);
            this.groupBoxCCD.Controls.Add(this.textBoxMaxBinY);
            this.groupBoxCCD.Controls.Add(this.textBoxMaxBinX);
            this.groupBoxCCD.Controls.Add(this.textBoxSensorName);
            this.groupBoxCCD.Controls.Add(this.label13);
            this.groupBoxCCD.Controls.Add(this.textBoxBayerOffsetY);
            this.groupBoxCCD.Controls.Add(this.label15);
            this.groupBoxCCD.Controls.Add(this.textBoxBayerOffsetX);
            this.groupBoxCCD.Controls.Add(this.label14);
            this.groupBoxCCD.Controls.Add(this.comboBoxSensorType);
            this.groupBoxCCD.Controls.Add(this.label12);
            this.groupBoxCCD.Controls.Add(this.checkBoxHasShutter);
            this.groupBoxCCD.Controls.Add(this.checkBoxCanAsymmetricBin);
            this.groupBoxCCD.Controls.Add(this.label6);
            this.groupBoxCCD.Controls.Add(this.label4);
            this.groupBoxCCD.Controls.Add(this.label3);
            this.groupBoxCCD.Controls.Add(this.label2);
            this.groupBoxCCD.Location = new System.Drawing.Point(4, 126);
            this.groupBoxCCD.Name = "groupBoxCCD";
            this.groupBoxCCD.Size = new System.Drawing.Size(146, 217);
            this.groupBoxCCD.TabIndex = 4;
            this.groupBoxCCD.TabStop = false;
            this.groupBoxCCD.Text = "CCD";
            // 
            // textBoxMaxBinY
            // 
            this.textBoxMaxBinY.Location = new System.Drawing.Point(109, 63);
            this.textBoxMaxBinY.Name = "textBoxMaxBinY";
            this.textBoxMaxBinY.Size = new System.Drawing.Size(16, 20);
            this.textBoxMaxBinY.TabIndex = 26;
            // 
            // textBoxMaxBinX
            // 
            this.textBoxMaxBinX.Location = new System.Drawing.Point(71, 63);
            this.textBoxMaxBinX.Name = "textBoxMaxBinX";
            this.textBoxMaxBinX.Size = new System.Drawing.Size(16, 20);
            this.textBoxMaxBinX.TabIndex = 25;
            // 
            // textBoxSensorName
            // 
            this.textBoxSensorName.Location = new System.Drawing.Point(47, 135);
            this.textBoxSensorName.Name = "textBoxSensorName";
            this.textBoxSensorName.Size = new System.Drawing.Size(90, 20);
            this.textBoxSensorName.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Name";
            // 
            // textBoxBayerOffsetY
            // 
            this.textBoxBayerOffsetY.Location = new System.Drawing.Point(126, 191);
            this.textBoxBayerOffsetY.Name = "textBoxBayerOffsetY";
            this.textBoxBayerOffsetY.Size = new System.Drawing.Size(18, 20);
            this.textBoxBayerOffsetY.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Y:";
            // 
            // textBoxBayerOffsetX
            // 
            this.textBoxBayerOffsetX.Location = new System.Drawing.Point(88, 191);
            this.textBoxBayerOffsetX.Name = "textBoxBayerOffsetX";
            this.textBoxBayerOffsetX.Size = new System.Drawing.Size(18, 20);
            this.textBoxBayerOffsetX.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Bayer Offset   X:";
            // 
            // comboBoxSensorType
            // 
            this.comboBoxSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensorType.FormattingEnabled = true;
            this.comboBoxSensorType.Items.AddRange(new object[] {
            "Monochrome",
            "Color",
            "RGGB",
            "CMYG",
            "CMYG2",
            "LRGB"});
            this.comboBoxSensorType.Location = new System.Drawing.Point(47, 161);
            this.comboBoxSensorType.Name = "comboBoxSensorType";
            this.comboBoxSensorType.Size = new System.Drawing.Size(90, 21);
            this.comboBoxSensorType.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Type";
            // 
            // checkBoxHasShutter
            // 
            this.checkBoxHasShutter.AutoSize = true;
            this.checkBoxHasShutter.Location = new System.Drawing.Point(5, 112);
            this.checkBoxHasShutter.Name = "checkBoxHasShutter";
            this.checkBoxHasShutter.Size = new System.Drawing.Size(82, 17);
            this.checkBoxHasShutter.TabIndex = 14;
            this.checkBoxHasShutter.Text = "Has Shutter";
            this.checkBoxHasShutter.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanAsymmetricBin
            // 
            this.checkBoxCanAsymmetricBin.AutoSize = true;
            this.checkBoxCanAsymmetricBin.Checked = true;
            this.checkBoxCanAsymmetricBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCanAsymmetricBin.Location = new System.Drawing.Point(6, 89);
            this.checkBoxCanAsymmetricBin.Name = "checkBoxCanAsymmetricBin";
            this.checkBoxCanAsymmetricBin.Size = new System.Drawing.Size(119, 17);
            this.checkBoxCanAsymmetricBin.TabIndex = 13;
            this.checkBoxCanAsymmetricBin.Text = "Can Asymmetric Bin";
            this.checkBoxCanAsymmetricBin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Bin  X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height (Pixels)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width (Pixels)";
            // 
            // groupBoxGainSettings
            // 
            this.groupBoxGainSettings.Controls.Add(this.numericUpDown4);
            this.groupBoxGainSettings.Controls.Add(this.label11);
            this.groupBoxGainSettings.Controls.Add(this.numericUpDown3);
            this.groupBoxGainSettings.Controls.Add(this.label10);
            this.groupBoxGainSettings.Controls.Add(this.label9);
            this.groupBoxGainSettings.Controls.Add(this.comboBox1);
            this.groupBoxGainSettings.Controls.Add(this.radioButton2);
            this.groupBoxGainSettings.Controls.Add(this.radioButton1);
            this.groupBoxGainSettings.Location = new System.Drawing.Point(156, 91);
            this.groupBoxGainSettings.Name = "groupBoxGainSettings";
            this.groupBoxGainSettings.Size = new System.Drawing.Size(161, 143);
            this.groupBoxGainSettings.TabIndex = 5;
            this.groupBoxGainSettings.TabStop = false;
            this.groupBoxGainSettings.Text = "Gain Settings";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(69, 117);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown4.TabIndex = 7;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Max";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(70, 91);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Gains";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Use Min and Max";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Use Gains";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxCooling
            // 
            this.groupBoxCooling.Controls.Add(this.checkBoxHasCooler);
            this.groupBoxCooling.Controls.Add(this.checkBoxCanGetCoolerPower);
            this.groupBoxCooling.Controls.Add(this.checkBoxCanSetCCDTemperature);
            this.groupBoxCooling.Location = new System.Drawing.Point(156, 4);
            this.groupBoxCooling.Name = "groupBoxCooling";
            this.groupBoxCooling.Size = new System.Drawing.Size(161, 81);
            this.groupBoxCooling.TabIndex = 6;
            this.groupBoxCooling.TabStop = false;
            this.groupBoxCooling.Text = "Cooling";
            // 
            // checkBoxHasCooler
            // 
            this.checkBoxHasCooler.AutoSize = true;
            this.checkBoxHasCooler.Location = new System.Drawing.Point(6, 16);
            this.checkBoxHasCooler.Name = "checkBoxHasCooler";
            this.checkBoxHasCooler.Size = new System.Drawing.Size(78, 17);
            this.checkBoxHasCooler.TabIndex = 2;
            this.checkBoxHasCooler.Text = "Has Cooler";
            this.checkBoxHasCooler.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanGetCoolerPower
            // 
            this.checkBoxCanGetCoolerPower.AutoSize = true;
            this.checkBoxCanGetCoolerPower.Location = new System.Drawing.Point(6, 56);
            this.checkBoxCanGetCoolerPower.Name = "checkBoxCanGetCoolerPower";
            this.checkBoxCanGetCoolerPower.Size = new System.Drawing.Size(131, 17);
            this.checkBoxCanGetCoolerPower.TabIndex = 1;
            this.checkBoxCanGetCoolerPower.Text = "Can Get Cooler Power";
            this.checkBoxCanGetCoolerPower.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanSetCCDTemperature
            // 
            this.checkBoxCanSetCCDTemperature.AutoSize = true;
            this.checkBoxCanSetCCDTemperature.Location = new System.Drawing.Point(6, 36);
            this.checkBoxCanSetCCDTemperature.Name = "checkBoxCanSetCCDTemperature";
            this.checkBoxCanSetCCDTemperature.Size = new System.Drawing.Size(152, 17);
            this.checkBoxCanSetCCDTemperature.TabIndex = 0;
            this.checkBoxCanSetCCDTemperature.Text = "Can Set CCD Temperature";
            this.checkBoxCanSetCCDTemperature.UseVisualStyleBackColor = true;
            // 
            // groupBoxExposure
            // 
            this.groupBoxExposure.Controls.Add(this.textBoxMaxExposure);
            this.groupBoxExposure.Controls.Add(this.textBoxMinExposure);
            this.groupBoxExposure.Controls.Add(this.label16);
            this.groupBoxExposure.Controls.Add(this.label5);
            this.groupBoxExposure.Controls.Add(this.checkBoxCanStopExposure);
            this.groupBoxExposure.Controls.Add(this.checkBoxCanAbortExposure);
            this.groupBoxExposure.Location = new System.Drawing.Point(156, 253);
            this.groupBoxExposure.Name = "groupBoxExposure";
            this.groupBoxExposure.Size = new System.Drawing.Size(161, 118);
            this.groupBoxExposure.TabIndex = 7;
            this.groupBoxExposure.TabStop = false;
            this.groupBoxExposure.Text = "Exposure";
            // 
            // textBoxMaxExposure
            // 
            this.textBoxMaxExposure.Location = new System.Drawing.Point(93, 83);
            this.textBoxMaxExposure.Name = "textBoxMaxExposure";
            this.textBoxMaxExposure.Size = new System.Drawing.Size(61, 20);
            this.textBoxMaxExposure.TabIndex = 5;
            // 
            // textBoxMinExposure
            // 
            this.textBoxMinExposure.Location = new System.Drawing.Point(93, 57);
            this.textBoxMinExposure.Name = "textBoxMinExposure";
            this.textBoxMinExposure.Size = new System.Drawing.Size(61, 20);
            this.textBoxMinExposure.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Max Exposure (s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Min exposure (s)";
            // 
            // checkBoxCanStopExposure
            // 
            this.checkBoxCanStopExposure.AutoSize = true;
            this.checkBoxCanStopExposure.Location = new System.Drawing.Point(7, 40);
            this.checkBoxCanStopExposure.Name = "checkBoxCanStopExposure";
            this.checkBoxCanStopExposure.Size = new System.Drawing.Size(116, 17);
            this.checkBoxCanStopExposure.TabIndex = 1;
            this.checkBoxCanStopExposure.Text = "Can Stop exposure";
            this.checkBoxCanStopExposure.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanAbortExposure
            // 
            this.checkBoxCanAbortExposure.AutoSize = true;
            this.checkBoxCanAbortExposure.Location = new System.Drawing.Point(6, 17);
            this.checkBoxCanAbortExposure.Name = "checkBoxCanAbortExposure";
            this.checkBoxCanAbortExposure.Size = new System.Drawing.Size(120, 17);
            this.checkBoxCanAbortExposure.TabIndex = 0;
            this.checkBoxCanAbortExposure.Text = "Can Abort Exposure";
            this.checkBoxCanAbortExposure.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPixelSizeY);
            this.groupBox1.Controls.Add(this.textBoxPixelSizeX);
            this.groupBox1.Controls.Add(this.textBoxElectronsPerADU);
            this.groupBox1.Controls.Add(this.textBoxMaxADU);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelSizeY);
            this.groupBox1.Controls.Add(this.labelSizeX);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pixel";
            // 
            // textBoxMaxADU
            // 
            this.textBoxMaxADU.Location = new System.Drawing.Point(83, 61);
            this.textBoxMaxADU.Name = "textBoxMaxADU";
            this.textBoxMaxADU.Size = new System.Drawing.Size(47, 20);
            this.textBoxMaxADU.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Maximum ADU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = " e- per ADU";
            // 
            // labelSizeY
            // 
            this.labelSizeY.AutoSize = true;
            this.labelSizeY.Location = new System.Drawing.Point(6, 38);
            this.labelSizeY.Name = "labelSizeY";
            this.labelSizeY.Size = new System.Drawing.Size(83, 13);
            this.labelSizeY.TabIndex = 9;
            this.labelSizeY.Text = "Height (microns)";
            // 
            // labelSizeX
            // 
            this.labelSizeX.AutoSize = true;
            this.labelSizeX.Location = new System.Drawing.Point(6, 16);
            this.labelSizeX.Name = "labelSizeX";
            this.labelSizeX.Size = new System.Drawing.Size(80, 13);
            this.labelSizeX.TabIndex = 8;
            this.labelSizeX.Text = "Width (microns)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Location = new System.Drawing.Point(331, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 42);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 17);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "Add stars";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Apply Noise";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cameraBindingSource
            // 
            this.cameraBindingSource.DataSource = typeof(ASCOM.Simulator.Camera);
            // 
            // textBoxElectronsPerADU
            // 
            this.textBoxElectronsPerADU.Location = new System.Drawing.Point(83, 84);
            this.textBoxElectronsPerADU.Name = "textBoxElectronsPerADU";
            this.textBoxElectronsPerADU.Size = new System.Drawing.Size(47, 20);
            this.textBoxElectronsPerADU.TabIndex = 15;
            // 
            // textBoxPixelSizeX
            // 
            this.textBoxPixelSizeX.Location = new System.Drawing.Point(88, 13);
            this.textBoxPixelSizeX.Name = "textBoxPixelSizeX";
            this.textBoxPixelSizeX.Size = new System.Drawing.Size(42, 20);
            this.textBoxPixelSizeX.TabIndex = 16;
            // 
            // textBoxPixelSizeY
            // 
            this.textBoxPixelSizeY.Location = new System.Drawing.Point(88, 35);
            this.textBoxPixelSizeY.Name = "textBoxPixelSizeY";
            this.textBoxPixelSizeY.Size = new System.Drawing.Size(42, 20);
            this.textBoxPixelSizeY.TabIndex = 17;
            // 
            // textBoxCameraXSize
            // 
            this.textBoxCameraXSize.Location = new System.Drawing.Point(90, 13);
            this.textBoxCameraXSize.Name = "textBoxCameraXSize";
            this.textBoxCameraXSize.Size = new System.Drawing.Size(47, 20);
            this.textBoxCameraXSize.TabIndex = 27;
            // 
            // textBoxCameraYSize
            // 
            this.textBoxCameraYSize.Location = new System.Drawing.Point(90, 38);
            this.textBoxCameraYSize.Name = "textBoxCameraYSize";
            this.textBoxCameraYSize.Size = new System.Drawing.Size(47, 20);
            this.textBoxCameraYSize.TabIndex = 28;
            // 
            // SetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxExposure);
            this.Controls.Add(this.groupBoxCooling);
            this.Controls.Add(this.groupBoxGainSettings);
            this.Controls.Add(this.groupBoxCCD);
            this.Controls.Add(this.picASCOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator Setup";
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).EndInit();
            this.groupBoxCCD.ResumeLayout(false);
            this.groupBoxCCD.PerformLayout();
            this.groupBoxGainSettings.ResumeLayout(false);
            this.groupBoxGainSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBoxCooling.ResumeLayout(false);
            this.groupBoxCooling.PerformLayout();
            this.groupBoxExposure.ResumeLayout(false);
            this.groupBoxExposure.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picASCOM;
        private System.Windows.Forms.GroupBox groupBoxCCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCanAsymmetricBin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxHasShutter;
        private System.Windows.Forms.GroupBox groupBoxGainSettings;
        private System.Windows.Forms.GroupBox groupBoxCooling;
        private System.Windows.Forms.CheckBox checkBoxCanGetCoolerPower;
        private System.Windows.Forms.CheckBox checkBoxCanSetCCDTemperature;
        private System.Windows.Forms.GroupBox groupBoxExposure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSizeY;
        private System.Windows.Forms.Label labelSizeX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMaxADU;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxSensorType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMaxBinY;
        private System.Windows.Forms.TextBox textBoxMaxBinX;
        private System.Windows.Forms.TextBox textBoxSensorName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxBayerOffsetY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxBayerOffsetX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBoxMaxExposure;
        private System.Windows.Forms.TextBox textBoxMinExposure;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCanStopExposure;
        private System.Windows.Forms.CheckBox checkBoxCanAbortExposure;
        private System.Windows.Forms.CheckBox checkBoxHasCooler;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private System.Windows.Forms.TextBox textBoxElectronsPerADU;
        private System.Windows.Forms.TextBox textBoxPixelSizeY;
        private System.Windows.Forms.TextBox textBoxPixelSizeX;
        private System.Windows.Forms.TextBox textBoxCameraYSize;
        private System.Windows.Forms.TextBox textBoxCameraXSize;
	}
}