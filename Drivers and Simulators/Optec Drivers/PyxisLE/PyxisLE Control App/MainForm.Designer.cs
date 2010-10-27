﻿namespace PyxisLE_Control
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SkyPA_TB = new System.Windows.Forms.TextBox();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.SetPA_BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AbsoluteMove_TB = new System.Windows.Forms.TextBox();
            this.AbsoluteMove_BTN = new System.Windows.Forms.Button();
            this.HomeDev_LBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RelativeForward_BTN = new System.Windows.Forms.Button();
            this.RelativeReverse_Btn = new System.Windows.Forms.Button();
            this.Relative_NUD = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHideSkyPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDeviceDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideHomeButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideAbsoluteMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideRelativeMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Degree_LBL = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AbsPanel = new System.Windows.Forms.Panel();
            this.RelativePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.SkyPAPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RotatorDiagram = new System.Windows.Forms.PictureBox();
            this.StatusLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.ExternalControlTimer = new System.Windows.Forms.Timer(this.components);
            this.VersionCheckerBGWorker = new System.ComponentModel.BackgroundWorker();
            this.Halt_BTN = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Relative_NUD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.AbsPanel.SuspendLayout();
            this.RelativePanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.SkyPAPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotatorDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(298, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(77, 17);
            this.StatusLabel.Text = "Device Status";
            this.StatusLabel.TextChanged += new System.EventHandler(this.StatusLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sky PA:";
            // 
            // SkyPA_TB
            // 
            this.SkyPA_TB.Cursor = System.Windows.Forms.Cursors.No;
            this.SkyPA_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyPA_TB.Location = new System.Drawing.Point(81, 5);
            this.SkyPA_TB.Name = "SkyPA_TB";
            this.SkyPA_TB.ReadOnly = true;
            this.SkyPA_TB.Size = new System.Drawing.Size(95, 26);
            this.SkyPA_TB.TabIndex = 2;
            this.SkyPA_TB.TabStop = false;
            // 
            // HomeBTN
            // 
            this.HomeBTN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HomeBTN.Location = new System.Drawing.Point(96, 7);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(73, 23);
            this.HomeBTN.TabIndex = 4;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = true;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // SetPA_BTN
            // 
            this.SetPA_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPA_BTN.Location = new System.Drawing.Point(189, 8);
            this.SetPA_BTN.Name = "SetPA_BTN";
            this.SetPA_BTN.Size = new System.Drawing.Size(85, 23);
            this.SetPA_BTN.TabIndex = 5;
            this.SetPA_BTN.Text = "Change...";
            this.SetPA_BTN.UseVisualStyleBackColor = true;
            this.SetPA_BTN.Click += new System.EventHandler(this.SetPA_BTN_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Move to Absolute Sky PA:";
            // 
            // AbsoluteMove_TB
            // 
            this.AbsoluteMove_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AbsoluteMove_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsoluteMove_TB.Location = new System.Drawing.Point(162, 9);
            this.AbsoluteMove_TB.Name = "AbsoluteMove_TB";
            this.AbsoluteMove_TB.Size = new System.Drawing.Size(73, 20);
            this.AbsoluteMove_TB.TabIndex = 7;
            this.AbsoluteMove_TB.Text = "0";
            this.AbsoluteMove_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AbsoluteMove_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AbsoluteMove_TB_KeyPress);
            this.AbsoluteMove_TB.Validating += new System.ComponentModel.CancelEventHandler(this.AbsoluteMove_TB_Validating);
            // 
            // AbsoluteMove_BTN
            // 
            this.AbsoluteMove_BTN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AbsoluteMove_BTN.Location = new System.Drawing.Point(243, 7);
            this.AbsoluteMove_BTN.Name = "AbsoluteMove_BTN";
            this.AbsoluteMove_BTN.Size = new System.Drawing.Size(37, 23);
            this.AbsoluteMove_BTN.TabIndex = 8;
            this.AbsoluteMove_BTN.Text = "Go";
            this.AbsoluteMove_BTN.UseVisualStyleBackColor = true;
            this.AbsoluteMove_BTN.Click += new System.EventHandler(this.AbsoluteMove_BTN_Click);
            // 
            // HomeDev_LBL
            // 
            this.HomeDev_LBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HomeDev_LBL.AutoSize = true;
            this.HomeDev_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeDev_LBL.Location = new System.Drawing.Point(3, 12);
            this.HomeDev_LBL.Name = "HomeDev_LBL";
            this.HomeDev_LBL.Size = new System.Drawing.Size(87, 13);
            this.HomeDev_LBL.TabIndex = 9;
            this.HomeDev_LBL.Text = "Home Device:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Increment(°)";
            // 
            // RelativeForward_BTN
            // 
            this.RelativeForward_BTN.Location = new System.Drawing.Point(210, 32);
            this.RelativeForward_BTN.Name = "RelativeForward_BTN";
            this.RelativeForward_BTN.Size = new System.Drawing.Size(70, 25);
            this.RelativeForward_BTN.TabIndex = 13;
            this.RelativeForward_BTN.Text = ">>";
            this.RelativeForward_BTN.UseVisualStyleBackColor = true;
            this.RelativeForward_BTN.Click += new System.EventHandler(this.RelativeForward_BTN_Click);
            this.RelativeForward_BTN.Validating += new System.ComponentModel.CancelEventHandler(this.RelativeIncrement_TB_Validating);
            // 
            // RelativeReverse_Btn
            // 
            this.RelativeReverse_Btn.Location = new System.Drawing.Point(8, 32);
            this.RelativeReverse_Btn.Name = "RelativeReverse_Btn";
            this.RelativeReverse_Btn.Size = new System.Drawing.Size(70, 25);
            this.RelativeReverse_Btn.TabIndex = 14;
            this.RelativeReverse_Btn.Text = "<<";
            this.RelativeReverse_Btn.UseVisualStyleBackColor = true;
            this.RelativeReverse_Btn.Click += new System.EventHandler(this.RelativeReverse_Btn_Click);
            this.RelativeReverse_Btn.Validating += new System.ComponentModel.CancelEventHandler(this.RelativeIncrement_TB_Validating);
            // 
            // Relative_NUD
            // 
            this.Relative_NUD.DecimalPlaces = 2;
            this.Relative_NUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Relative_NUD.Location = new System.Drawing.Point(99, 36);
            this.Relative_NUD.Maximum = new decimal(new int[] {
            35999,
            0,
            0,
            131072});
            this.Relative_NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Relative_NUD.Name = "Relative_NUD";
            this.Relative_NUD.Size = new System.Drawing.Size(90, 20);
            this.Relative_NUD.TabIndex = 15;
            this.Relative_NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Relative_NUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.ShowHideSkyPAToolStripMenuItem,
            this.showDeviceDiagramToolStripMenuItem,
            this.showHideHomeButtonToolStripMenuItem,
            this.showHideAbsoluteMoveToolStripMenuItem,
            this.showHideRelativeMoveToolStripMenuItem,
            this.toolStripSeparator1,
            this.alwaysOnTopToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // ShowHideSkyPAToolStripMenuItem
            // 
            this.ShowHideSkyPAToolStripMenuItem.Name = "ShowHideSkyPAToolStripMenuItem";
            this.ShowHideSkyPAToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ShowHideSkyPAToolStripMenuItem.Text = "Show/Hide Sky PA";
            this.ShowHideSkyPAToolStripMenuItem.Click += new System.EventHandler(this.ShowHideSkyPAToolStripMenuItem_Click);
            // 
            // showDeviceDiagramToolStripMenuItem
            // 
            this.showDeviceDiagramToolStripMenuItem.Name = "showDeviceDiagramToolStripMenuItem";
            this.showDeviceDiagramToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.showDeviceDiagramToolStripMenuItem.Text = "Show/Hide Rotator Diagram";
            this.showDeviceDiagramToolStripMenuItem.Click += new System.EventHandler(this.showDeviceDiagramToolStripMenuItem_Click);
            // 
            // showHideHomeButtonToolStripMenuItem
            // 
            this.showHideHomeButtonToolStripMenuItem.Name = "showHideHomeButtonToolStripMenuItem";
            this.showHideHomeButtonToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.showHideHomeButtonToolStripMenuItem.Text = "Show/Hide Home Button";
            this.showHideHomeButtonToolStripMenuItem.Click += new System.EventHandler(this.showHideHomeButtonToolStripMenuItem_Click);
            // 
            // showHideAbsoluteMoveToolStripMenuItem
            // 
            this.showHideAbsoluteMoveToolStripMenuItem.Name = "showHideAbsoluteMoveToolStripMenuItem";
            this.showHideAbsoluteMoveToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.showHideAbsoluteMoveToolStripMenuItem.Text = "Show/Hide Absolute Move";
            this.showHideAbsoluteMoveToolStripMenuItem.Click += new System.EventHandler(this.showHideAbsoluteMoveToolStripMenuItem_Click);
            // 
            // showHideRelativeMoveToolStripMenuItem
            // 
            this.showHideRelativeMoveToolStripMenuItem.Name = "showHideRelativeMoveToolStripMenuItem";
            this.showHideRelativeMoveToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.showHideRelativeMoveToolStripMenuItem.Text = "Show/Hide Relative Move";
            this.showHideRelativeMoveToolStripMenuItem.Click += new System.EventHandler(this.showHideRelativeMoveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedSetupToolStripMenuItem,
            this.haltToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // advancedSetupToolStripMenuItem
            // 
            this.advancedSetupToolStripMenuItem.Name = "advancedSetupToolStripMenuItem";
            this.advancedSetupToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.advancedSetupToolStripMenuItem.Text = "Advanced Setup";
            this.advancedSetupToolStripMenuItem.Click += new System.EventHandler(this.advancedSetupToolStripMenuItem_Click);
            // 
            // haltToolStripMenuItem
            // 
            this.haltToolStripMenuItem.Name = "haltToolStripMenuItem";
            this.haltToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.haltToolStripMenuItem.Text = "Halt";
            this.haltToolStripMenuItem.Click += new System.EventHandler(this.haltToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.deviceDocumentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // deviceDocumentationToolStripMenuItem
            // 
            this.deviceDocumentationToolStripMenuItem.Name = "deviceDocumentationToolStripMenuItem";
            this.deviceDocumentationToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deviceDocumentationToolStripMenuItem.Text = "Device Documentation";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Degree_LBL
            // 
            this.Degree_LBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Degree_LBL.AutoSize = true;
            this.Degree_LBL.BackColor = System.Drawing.Color.White;
            this.Degree_LBL.Location = new System.Drawing.Point(221, 12);
            this.Degree_LBL.Name = "Degree_LBL";
            this.Degree_LBL.Size = new System.Drawing.Size(11, 13);
            this.Degree_LBL.TabIndex = 17;
            this.Degree_LBL.Text = "°";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AbsPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.RelativePanel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.HomePanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SkyPAPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 471);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // AbsPanel
            // 
            this.AbsPanel.Controls.Add(this.Degree_LBL);
            this.AbsPanel.Controls.Add(this.label3);
            this.AbsPanel.Controls.Add(this.AbsoluteMove_TB);
            this.AbsPanel.Controls.Add(this.AbsoluteMove_BTN);
            this.AbsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbsPanel.Location = new System.Drawing.Point(6, 356);
            this.AbsPanel.Name = "AbsPanel";
            this.AbsPanel.Size = new System.Drawing.Size(286, 37);
            this.AbsPanel.TabIndex = 20;
            // 
            // RelativePanel
            // 
            this.RelativePanel.Controls.Add(this.label2);
            this.RelativePanel.Controls.Add(this.Relative_NUD);
            this.RelativePanel.Controls.Add(this.label5);
            this.RelativePanel.Controls.Add(this.RelativeReverse_Btn);
            this.RelativePanel.Controls.Add(this.RelativeForward_BTN);
            this.RelativePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelativePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelativePanel.Location = new System.Drawing.Point(6, 402);
            this.RelativePanel.Name = "RelativePanel";
            this.RelativePanel.Size = new System.Drawing.Size(286, 63);
            this.RelativePanel.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Relative Move:";
            // 
            // HomePanel
            // 
            this.HomePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomePanel.Controls.Add(this.HomeDev_LBL);
            this.HomePanel.Controls.Add(this.HomeBTN);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(6, 310);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(286, 37);
            this.HomePanel.TabIndex = 20;
            // 
            // SkyPAPanel
            // 
            this.SkyPAPanel.Controls.Add(this.label1);
            this.SkyPAPanel.Controls.Add(this.SkyPA_TB);
            this.SkyPAPanel.Controls.Add(this.SetPA_BTN);
            this.SkyPAPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkyPAPanel.Location = new System.Drawing.Point(6, 6);
            this.SkyPAPanel.Name = "SkyPAPanel";
            this.SkyPAPanel.Size = new System.Drawing.Size(286, 37);
            this.SkyPAPanel.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Halt_BTN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.RotatorDiagram);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 249);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PyxisLE_Control.Properties.Resources.Optec_Logo_medium_png;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RotatorDiagram
            // 
            this.RotatorDiagram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RotatorDiagram.Cursor = System.Windows.Forms.Cursors.Cross;
            this.RotatorDiagram.Location = new System.Drawing.Point(18, -1);
            this.RotatorDiagram.Name = "RotatorDiagram";
            this.RotatorDiagram.Size = new System.Drawing.Size(250, 250);
            this.RotatorDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RotatorDiagram.TabIndex = 10;
            this.RotatorDiagram.TabStop = false;
            this.RotatorDiagram.Click += new System.EventHandler(this.RotatorDiagram_Click);
            this.RotatorDiagram.Paint += new System.Windows.Forms.PaintEventHandler(this.RotatorDiagram_Paint);
            // 
            // StatusLabelTimer
            // 
            this.StatusLabelTimer.Interval = 5000;
            this.StatusLabelTimer.Tick += new System.EventHandler(this.StatusLabelTimer_Tick);
            // 
            // ExternalControlTimer
            // 
            this.ExternalControlTimer.Interval = 1000;
            this.ExternalControlTimer.Tick += new System.EventHandler(this.ExternalControlTimer_Tick);
            // 
            // VersionCheckerBGWorker
            // 
            this.VersionCheckerBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.VersionCheckerBGWorker_DoWork);
            // 
            // Halt_BTN
            // 
            this.Halt_BTN.Enabled = false;
            this.Halt_BTN.Location = new System.Drawing.Point(226, 174);
            this.Halt_BTN.Name = "Halt_BTN";
            this.Halt_BTN.Size = new System.Drawing.Size(42, 42);
            this.Halt_BTN.TabIndex = 12;
            this.Halt_BTN.Text = "Halt";
            this.Halt_BTN.UseVisualStyleBackColor = true;
            this.Halt_BTN.Click += new System.EventHandler(this.Halt_BTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(298, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(35, 38);
            this.Name = "MainForm";
            this.Text = "Pyxis LE Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Relative_NUD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.AbsPanel.ResumeLayout(false);
            this.AbsPanel.PerformLayout();
            this.RelativePanel.ResumeLayout(false);
            this.RelativePanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.SkyPAPanel.ResumeLayout(false);
            this.SkyPAPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotatorDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SkyPA_TB;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button SetPA_BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AbsoluteMove_TB;
        private System.Windows.Forms.Button AbsoluteMove_BTN;
        private System.Windows.Forms.Label HomeDev_LBL;
        private System.Windows.Forms.PictureBox RotatorDiagram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RelativeForward_BTN;
        private System.Windows.Forms.Button RelativeReverse_Btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceDocumentationToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDeviceDiagramToolStripMenuItem;
        private System.Windows.Forms.Label Degree_LBL;
        private System.Windows.Forms.NumericUpDown Relative_NUD;
        private System.Windows.Forms.ToolStripMenuItem ShowHideSkyPAToolStripMenuItem;
        private System.Windows.Forms.Panel SkyPAPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel AbsPanel;
        private System.Windows.Forms.ToolStripMenuItem showHideHomeButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideAbsoluteMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideRelativeMoveToolStripMenuItem;
        private System.Windows.Forms.Panel RelativePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.Timer StatusLabelTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer ExternalControlTimer;
        private System.ComponentModel.BackgroundWorker VersionCheckerBGWorker;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haltToolStripMenuItem;
        private System.Windows.Forms.Button Halt_BTN;
    }
}