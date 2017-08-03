﻿namespace VideoPlayControl_UseDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.grpVideoInfo = new System.Windows.Forms.GroupBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.videoPTZControl1 = new VideoPlayControl.VideoPTZControl();
            this.button1 = new System.Windows.Forms.Button();
            this.chkPresetEanble = new System.Windows.Forms.CheckBox();
            this.chkMonitorEnable = new System.Windows.Forms.CheckBox();
            this.chkVideoRecordEnable = new System.Windows.Forms.CheckBox();
            this.cmbDVSAddress = new System.Windows.Forms.ComboBox();
            this.cmbOperAtVideo = new System.Windows.Forms.ComboBox();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.cmbVideoType = new System.Windows.Forms.ComboBox();
            this.btnVideoPlayClose = new System.Windows.Forms.Button();
            this.btnVideoPlay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoID = new System.Windows.Forms.TextBox();
            this.txtContactPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.pnlBottom_Left = new System.Windows.Forms.Panel();
            this.videoWindowTest = new VideoPlayControl.VideoPlayWindow();
            this.grp_PTZControl = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkSDKStateCallback = new System.Windows.Forms.CheckBox();
            this.cmbPlayVideoWindowSet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlpPlayVIdeoWindows = new System.Windows.Forms.TableLayoutPanel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageVideoInfo = new System.Windows.Forms.TabPage();
            this.txtCurrentDVSType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurrentDVSPwd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCurrentDVSPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCurrentUserName = new System.Windows.Forms.TextBox();
            this.txtCurrentChannelNum = new System.Windows.Forms.TextBox();
            this.videoPTZControl2 = new VideoPlayControl.VideoPTZControl();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbVideoList = new System.Windows.Forms.ComboBox();
            this.videoChannelList = new VideoPlayControl.VideoChannelList();
            this.pageEventRecord = new System.Windows.Forms.TabPage();
            this.dgvReocrd = new System.Windows.Forms.DataGridView();
            this.dgvReocrd_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReocrd_Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReocrd_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssrTip = new System.Windows.Forms.StatusStrip();
            this.tsslblPrompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCurrentDVSAddress = new System.Windows.Forms.TextBox();
            this.pnlBottom.SuspendLayout();
            this.grpVideoInfo.SuspendLayout();
            this.pnlBottom_Left.SuspendLayout();
            this.grp_PTZControl.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageVideoInfo.SuspendLayout();
            this.pageEventRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReocrd)).BeginInit();
            this.ssrTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.grpVideoInfo);
            this.pnlBottom.Controls.Add(this.pnlBottom_Left);
            this.pnlBottom.Controls.Add(this.grp_PTZControl);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 311);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1041, 136);
            this.pnlBottom.TabIndex = 0;
            // 
            // grpVideoInfo
            // 
            this.grpVideoInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpVideoInfo.Controls.Add(this.btnAddList);
            this.grpVideoInfo.Controls.Add(this.label14);
            this.grpVideoInfo.Controls.Add(this.videoPTZControl1);
            this.grpVideoInfo.Controls.Add(this.button1);
            this.grpVideoInfo.Controls.Add(this.cmbDVSAddress);
            this.grpVideoInfo.Controls.Add(this.cmbVideoType);
            this.grpVideoInfo.Controls.Add(this.label5);
            this.grpVideoInfo.Controls.Add(this.label7);
            this.grpVideoInfo.Controls.Add(this.label6);
            this.grpVideoInfo.Controls.Add(this.label4);
            this.grpVideoInfo.Controls.Add(this.txtPassword);
            this.grpVideoInfo.Controls.Add(this.label2);
            this.grpVideoInfo.Controls.Add(this.txtVideoID);
            this.grpVideoInfo.Controls.Add(this.txtContactPort);
            this.grpVideoInfo.Controls.Add(this.label3);
            this.grpVideoInfo.Controls.Add(this.button2);
            this.grpVideoInfo.Controls.Add(this.videoPTZControl2);
            this.grpVideoInfo.Controls.Add(this.txtUserName);
            this.grpVideoInfo.Controls.Add(this.txtChannel);
            this.grpVideoInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVideoInfo.Location = new System.Drawing.Point(219, 0);
            this.grpVideoInfo.Name = "grpVideoInfo";
            this.grpVideoInfo.Size = new System.Drawing.Size(640, 136);
            this.grpVideoInfo.TabIndex = 5;
            this.grpVideoInfo.TabStop = false;
            this.grpVideoInfo.Text = "主机信息";
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(221, 36);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(63, 23);
            this.btnAddList.TabIndex = 11;
            this.btnAddList.Text = "添加";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "设备编号";
            // 
            // videoPTZControl1
            // 
            this.videoPTZControl1.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl1.Location = new System.Drawing.Point(290, 37);
            this.videoPTZControl1.Name = "videoPTZControl1";
            this.videoPTZControl1.Size = new System.Drawing.Size(90, 90);
            this.videoPTZControl1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "测试按钮";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkPresetEanble
            // 
            this.chkPresetEanble.AutoSize = true;
            this.chkPresetEanble.Location = new System.Drawing.Point(3, 240);
            this.chkPresetEanble.Name = "chkPresetEanble";
            this.chkPresetEanble.Size = new System.Drawing.Size(84, 16);
            this.chkPresetEanble.TabIndex = 7;
            this.chkPresetEanble.Text = "预置点设置";
            this.chkPresetEanble.UseVisualStyleBackColor = true;
            // 
            // chkMonitorEnable
            // 
            this.chkMonitorEnable.AutoSize = true;
            this.chkMonitorEnable.Location = new System.Drawing.Point(72, 260);
            this.chkMonitorEnable.Name = "chkMonitorEnable";
            this.chkMonitorEnable.Size = new System.Drawing.Size(72, 16);
            this.chkMonitorEnable.TabIndex = 6;
            this.chkMonitorEnable.Text = "音频使能";
            this.chkMonitorEnable.UseVisualStyleBackColor = true;
            // 
            // chkVideoRecordEnable
            // 
            this.chkVideoRecordEnable.AutoSize = true;
            this.chkVideoRecordEnable.Location = new System.Drawing.Point(3, 260);
            this.chkVideoRecordEnable.Name = "chkVideoRecordEnable";
            this.chkVideoRecordEnable.Size = new System.Drawing.Size(72, 16);
            this.chkVideoRecordEnable.TabIndex = 6;
            this.chkVideoRecordEnable.Text = "录像使能";
            this.chkVideoRecordEnable.UseVisualStyleBackColor = true;
            // 
            // cmbDVSAddress
            // 
            this.cmbDVSAddress.FormattingEnabled = true;
            this.cmbDVSAddress.Items.AddRange(new object[] {
            "X5014851",
            "X6937816",
            "X7438372",
            "X5796224",
            "X4659975",
            "X6227077",
            "X6944415",
            "X7325728",
            "X12041891",
            "X7635198"});
            this.cmbDVSAddress.Location = new System.Drawing.Point(71, 37);
            this.cmbDVSAddress.Name = "cmbDVSAddress";
            this.cmbDVSAddress.Size = new System.Drawing.Size(144, 20);
            this.cmbDVSAddress.TabIndex = 4;
            this.cmbDVSAddress.Text = "X5014851";
            // 
            // cmbOperAtVideo
            // 
            this.cmbOperAtVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperAtVideo.FormattingEnabled = true;
            this.cmbOperAtVideo.Location = new System.Drawing.Point(3, 190);
            this.cmbOperAtVideo.Name = "cmbOperAtVideo";
            this.cmbOperAtVideo.Size = new System.Drawing.Size(62, 20);
            this.cmbOperAtVideo.TabIndex = 3;
            // 
            // cmbPreset
            // 
            this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(93, 238);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(49, 20);
            this.cmbPreset.TabIndex = 2;
            // 
            // cmbVideoType
            // 
            this.cmbVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoType.FormattingEnabled = true;
            this.cmbVideoType.Location = new System.Drawing.Point(71, 14);
            this.cmbVideoType.Name = "cmbVideoType";
            this.cmbVideoType.Size = new System.Drawing.Size(144, 20);
            this.cmbVideoType.TabIndex = 2;
            // 
            // btnVideoPlayClose
            // 
            this.btnVideoPlayClose.Location = new System.Drawing.Point(80, 211);
            this.btnVideoPlayClose.Name = "btnVideoPlayClose";
            this.btnVideoPlayClose.Size = new System.Drawing.Size(63, 23);
            this.btnVideoPlayClose.TabIndex = 0;
            this.btnVideoPlayClose.Text = "关闭";
            this.btnVideoPlayClose.UseVisualStyleBackColor = true;
            this.btnVideoPlayClose.Click += new System.EventHandler(this.btnVideoPlayClose_Click);
            // 
            // btnVideoPlay
            // 
            this.btnVideoPlay.Location = new System.Drawing.Point(3, 211);
            this.btnVideoPlay.Name = "btnVideoPlay";
            this.btnVideoPlay.Size = new System.Drawing.Size(63, 23);
            this.btnVideoPlay.TabIndex = 0;
            this.btnVideoPlay.Text = "播放";
            this.btnVideoPlay.UseVisualStyleBackColor = true;
            this.btnVideoPlay.Click += new System.EventHandler(this.btnVideoPly_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "密    码:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "设备类型:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "连接端口:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用 户 名:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "12345";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "设备地址:";
            // 
            // txtVideoID
            // 
            this.txtVideoID.Location = new System.Drawing.Point(280, 14);
            this.txtVideoID.Name = "txtVideoID";
            this.txtVideoID.Size = new System.Drawing.Size(81, 21);
            this.txtVideoID.TabIndex = 1;
            this.txtVideoID.Text = "000101";
            // 
            // txtContactPort
            // 
            this.txtContactPort.Location = new System.Drawing.Point(71, 61);
            this.txtContactPort.Name = "txtContactPort";
            this.txtContactPort.Size = new System.Drawing.Size(54, 21);
            this.txtContactPort.TabIndex = 1;
            this.txtContactPort.Text = "9010";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "通道数:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(71, 84);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "admin";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(184, 61);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(31, 21);
            this.txtChannel.TabIndex = 1;
            this.txtChannel.Text = "12";
            // 
            // pnlBottom_Left
            // 
            this.pnlBottom_Left.Controls.Add(this.videoWindowTest);
            this.pnlBottom_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottom_Left.Location = new System.Drawing.Point(0, 0);
            this.pnlBottom_Left.Name = "pnlBottom_Left";
            this.pnlBottom_Left.Size = new System.Drawing.Size(219, 136);
            this.pnlBottom_Left.TabIndex = 7;
            // 
            // videoWindowTest
            // 
            this.videoWindowTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoWindowTest.Location = new System.Drawing.Point(0, 0);
            this.videoWindowTest.Name = "videoWindowTest";
            this.videoWindowTest.Size = new System.Drawing.Size(219, 136);
            this.videoWindowTest.TabIndex = 0;
            // 
            // grp_PTZControl
            // 
            this.grp_PTZControl.Controls.Add(this.checkBox3);
            this.grp_PTZControl.Controls.Add(this.checkBox2);
            this.grp_PTZControl.Controls.Add(this.chkSDKStateCallback);
            this.grp_PTZControl.Controls.Add(this.cmbPlayVideoWindowSet);
            this.grp_PTZControl.Controls.Add(this.label8);
            this.grp_PTZControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_PTZControl.Location = new System.Drawing.Point(859, 0);
            this.grp_PTZControl.Name = "grp_PTZControl";
            this.grp_PTZControl.Size = new System.Drawing.Size(182, 136);
            this.grp_PTZControl.TabIndex = 6;
            this.grp_PTZControl.TabStop = false;
            this.grp_PTZControl.Text = "云台控制";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(6, 82);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 16);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "视频播放事件回调显示";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 16);
            this.checkBox2.TabIndex = 30;
            this.checkBox2.Text = "SDK回调事件显示";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkSDKStateCallback
            // 
            this.chkSDKStateCallback.AutoSize = true;
            this.chkSDKStateCallback.Checked = true;
            this.chkSDKStateCallback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSDKStateCallback.Location = new System.Drawing.Point(6, 40);
            this.chkSDKStateCallback.Name = "chkSDKStateCallback";
            this.chkSDKStateCallback.Size = new System.Drawing.Size(114, 16);
            this.chkSDKStateCallback.TabIndex = 30;
            this.chkSDKStateCallback.Text = "SDK状态回调显示";
            this.chkSDKStateCallback.UseVisualStyleBackColor = true;
            // 
            // cmbPlayVideoWindowSet
            // 
            this.cmbPlayVideoWindowSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayVideoWindowSet.FormattingEnabled = true;
            this.cmbPlayVideoWindowSet.Location = new System.Drawing.Point(44, 15);
            this.cmbPlayVideoWindowSet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlayVideoWindowSet.Name = "cmbPlayVideoWindowSet";
            this.cmbPlayVideoWindowSet.Size = new System.Drawing.Size(75, 20);
            this.cmbPlayVideoWindowSet.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "画面:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 308);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1041, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tlpPlayVIdeoWindows);
            this.pnlMain.Controls.Add(this.splitter2);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1041, 308);
            this.pnlMain.TabIndex = 2;
            // 
            // tlpPlayVIdeoWindows
            // 
            this.tlpPlayVIdeoWindows.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tlpPlayVIdeoWindows.ColumnCount = 1;
            this.tlpPlayVIdeoWindows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayVIdeoWindows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlayVIdeoWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlayVIdeoWindows.Location = new System.Drawing.Point(0, 0);
            this.tlpPlayVIdeoWindows.Name = "tlpPlayVIdeoWindows";
            this.tlpPlayVIdeoWindows.RowCount = 1;
            this.tlpPlayVIdeoWindows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayVIdeoWindows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tlpPlayVIdeoWindows.Size = new System.Drawing.Size(712, 308);
            this.tlpPlayVIdeoWindows.TabIndex = 9;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(712, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 308);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.tabControl);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(715, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(326, 308);
            this.pnlRight.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageVideoInfo);
            this.tabControl.Controls.Add(this.pageEventRecord);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(326, 308);
            this.tabControl.TabIndex = 0;
            // 
            // pageVideoInfo
            // 
            this.pageVideoInfo.Controls.Add(this.txtCurrentDVSAddress);
            this.pageVideoInfo.Controls.Add(this.txtCurrentDVSType);
            this.pageVideoInfo.Controls.Add(this.label1);
            this.pageVideoInfo.Controls.Add(this.label9);
            this.pageVideoInfo.Controls.Add(this.chkPresetEanble);
            this.pageVideoInfo.Controls.Add(this.cmbOperAtVideo);
            this.pageVideoInfo.Controls.Add(this.btnVideoPlayClose);
            this.pageVideoInfo.Controls.Add(this.chkMonitorEnable);
            this.pageVideoInfo.Controls.Add(this.btnVideoPlay);
            this.pageVideoInfo.Controls.Add(this.label10);
            this.pageVideoInfo.Controls.Add(this.chkVideoRecordEnable);
            this.pageVideoInfo.Controls.Add(this.label11);
            this.pageVideoInfo.Controls.Add(this.txtCurrentDVSPwd);
            this.pageVideoInfo.Controls.Add(this.label12);
            this.pageVideoInfo.Controls.Add(this.cmbPreset);
            this.pageVideoInfo.Controls.Add(this.txtCurrentDVSPort);
            this.pageVideoInfo.Controls.Add(this.label13);
            this.pageVideoInfo.Controls.Add(this.txtCurrentUserName);
            this.pageVideoInfo.Controls.Add(this.txtCurrentChannelNum);
            this.pageVideoInfo.Controls.Add(this.cmbVideoList);
            this.pageVideoInfo.Controls.Add(this.videoChannelList);
            this.pageVideoInfo.Location = new System.Drawing.Point(4, 22);
            this.pageVideoInfo.Name = "pageVideoInfo";
            this.pageVideoInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pageVideoInfo.Size = new System.Drawing.Size(318, 282);
            this.pageVideoInfo.TabIndex = 0;
            this.pageVideoInfo.Text = "视频设备信息";
            this.pageVideoInfo.UseVisualStyleBackColor = true;
            // 
            // txtCurrentDVSType
            // 
            this.txtCurrentDVSType.Location = new System.Drawing.Point(69, 26);
            this.txtCurrentDVSType.Name = "txtCurrentDVSType";
            this.txtCurrentDVSType.Size = new System.Drawing.Size(87, 21);
            this.txtCurrentDVSType.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "密    码:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "设备类型:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "连接端口:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "用 户 名:";
            // 
            // txtCurrentDVSPwd
            // 
            this.txtCurrentDVSPwd.Location = new System.Drawing.Point(69, 143);
            this.txtCurrentDVSPwd.Name = "txtCurrentDVSPwd";
            this.txtCurrentDVSPwd.Size = new System.Drawing.Size(87, 21);
            this.txtCurrentDVSPwd.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "设备地址:";
            // 
            // txtCurrentDVSPort
            // 
            this.txtCurrentDVSPort.Location = new System.Drawing.Point(69, 72);
            this.txtCurrentDVSPort.Name = "txtCurrentDVSPort";
            this.txtCurrentDVSPort.Size = new System.Drawing.Size(54, 21);
            this.txtCurrentDVSPort.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "通道数量:";
            // 
            // txtCurrentUserName
            // 
            this.txtCurrentUserName.Location = new System.Drawing.Point(69, 119);
            this.txtCurrentUserName.Name = "txtCurrentUserName";
            this.txtCurrentUserName.Size = new System.Drawing.Size(87, 21);
            this.txtCurrentUserName.TabIndex = 28;
            // 
            // txtCurrentChannelNum
            // 
            this.txtCurrentChannelNum.Location = new System.Drawing.Point(70, 96);
            this.txtCurrentChannelNum.Name = "txtCurrentChannelNum";
            this.txtCurrentChannelNum.Size = new System.Drawing.Size(53, 21);
            this.txtCurrentChannelNum.TabIndex = 29;
            // 
            // videoPTZControl2
            // 
            this.videoPTZControl2.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl2.Location = new System.Drawing.Point(453, 61);
            this.videoPTZControl2.Name = "videoPTZControl2";
            this.videoPTZControl2.Size = new System.Drawing.Size(57, 60);
            this.videoPTZControl2.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "测试按钮";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbVideoList
            // 
            this.cmbVideoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoList.FormattingEnabled = true;
            this.cmbVideoList.Location = new System.Drawing.Point(8, 3);
            this.cmbVideoList.Name = "cmbVideoList";
            this.cmbVideoList.Size = new System.Drawing.Size(148, 20);
            this.cmbVideoList.TabIndex = 14;
            this.cmbVideoList.SelectedIndexChanged += new System.EventHandler(this.cmbVideoList_SelectedIndexChanged);
            // 
            // videoChannelList
            // 
            this.videoChannelList.Dock = System.Windows.Forms.DockStyle.Right;
            this.videoChannelList.Location = new System.Drawing.Point(166, 3);
            this.videoChannelList.Name = "videoChannelList";
            this.videoChannelList.Size = new System.Drawing.Size(149, 276);
            this.videoChannelList.TabIndex = 10;
            // 
            // pageEventRecord
            // 
            this.pageEventRecord.Controls.Add(this.dgvReocrd);
            this.pageEventRecord.Location = new System.Drawing.Point(4, 22);
            this.pageEventRecord.Name = "pageEventRecord";
            this.pageEventRecord.Padding = new System.Windows.Forms.Padding(3);
            this.pageEventRecord.Size = new System.Drawing.Size(318, 282);
            this.pageEventRecord.TabIndex = 1;
            this.pageEventRecord.Text = "事件记录";
            this.pageEventRecord.UseVisualStyleBackColor = true;
            // 
            // dgvReocrd
            // 
            this.dgvReocrd.AllowUserToAddRows = false;
            this.dgvReocrd.AllowUserToDeleteRows = false;
            this.dgvReocrd.AllowUserToResizeRows = false;
            this.dgvReocrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReocrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvReocrd_Time,
            this.dgvReocrd_Tag,
            this.dgvReocrd_Content});
            this.dgvReocrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReocrd.Location = new System.Drawing.Point(3, 3);
            this.dgvReocrd.Name = "dgvReocrd";
            this.dgvReocrd.ReadOnly = true;
            this.dgvReocrd.RowHeadersVisible = false;
            this.dgvReocrd.RowTemplate.Height = 23;
            this.dgvReocrd.Size = new System.Drawing.Size(312, 276);
            this.dgvReocrd.TabIndex = 1;
            // 
            // dgvReocrd_Time
            // 
            this.dgvReocrd_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Time.HeaderText = "记录事件";
            this.dgvReocrd_Time.Name = "dgvReocrd_Time";
            this.dgvReocrd_Time.ReadOnly = true;
            this.dgvReocrd_Time.Width = 78;
            // 
            // dgvReocrd_Tag
            // 
            this.dgvReocrd_Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Tag.HeaderText = "记录标签";
            this.dgvReocrd_Tag.Name = "dgvReocrd_Tag";
            this.dgvReocrd_Tag.ReadOnly = true;
            this.dgvReocrd_Tag.Width = 78;
            // 
            // dgvReocrd_Content
            // 
            this.dgvReocrd_Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Content.HeaderText = "记录内容";
            this.dgvReocrd_Content.Name = "dgvReocrd_Content";
            this.dgvReocrd_Content.ReadOnly = true;
            this.dgvReocrd_Content.Width = 78;
            // 
            // ssrTip
            // 
            this.ssrTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblPrompt});
            this.ssrTip.Location = new System.Drawing.Point(0, 447);
            this.ssrTip.Name = "ssrTip";
            this.ssrTip.Size = new System.Drawing.Size(1041, 22);
            this.ssrTip.TabIndex = 7;
            this.ssrTip.Text = "statusStrip1";
            // 
            // tsslblPrompt
            // 
            this.tsslblPrompt.Name = "tsslblPrompt";
            this.tsslblPrompt.Size = new System.Drawing.Size(32, 17);
            this.tsslblPrompt.Text = "提示";
            // 
            // txtCurrentDVSAddress
            // 
            this.txtCurrentDVSAddress.Location = new System.Drawing.Point(69, 49);
            this.txtCurrentDVSAddress.Name = "txtCurrentDVSAddress";
            this.txtCurrentDVSAddress.Size = new System.Drawing.Size(87, 21);
            this.txtCurrentDVSAddress.TabIndex = 33;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 469);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.ssrTip);
            this.Name = "FrmMain";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Move += new System.EventHandler(this.FrmMain_Move);
            this.pnlBottom.ResumeLayout(false);
            this.grpVideoInfo.ResumeLayout(false);
            this.grpVideoInfo.PerformLayout();
            this.pnlBottom_Left.ResumeLayout(false);
            this.grp_PTZControl.ResumeLayout(false);
            this.grp_PTZControl.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.pageVideoInfo.ResumeLayout(false);
            this.pageVideoInfo.PerformLayout();
            this.pageEventRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReocrd)).EndInit();
            this.ssrTip.ResumeLayout(false);
            this.ssrTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnVideoPlay;
        private System.Windows.Forms.GroupBox grp_PTZControl;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.GroupBox grpVideoInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactPort;
        private System.Windows.Forms.ComboBox cmbVideoType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip ssrTip;
        private System.Windows.Forms.ToolStripStatusLabel tsslblPrompt;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvReocrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Content;
        private System.Windows.Forms.Panel pnlBottom_Left;
        private System.Windows.Forms.TableLayoutPanel tlpPlayVIdeoWindows;
        private VideoPlayControl.VideoPlayWindow videoWindowTest;
        private System.Windows.Forms.ComboBox cmbPlayVideoWindowSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOperAtVideo;
        private System.Windows.Forms.ComboBox cmbDVSAddress;
        private System.Windows.Forms.Button btnVideoPlayClose;
        private System.Windows.Forms.CheckBox chkVideoRecordEnable;
        private System.Windows.Forms.CheckBox chkMonitorEnable;
        private System.Windows.Forms.CheckBox chkPresetEanble;
        private System.Windows.Forms.Button button1;
        private VideoPlayControl.VideoPTZControl videoPTZControl1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkSDKStateCallback;
        private VideoPlayControl.VideoChannelList videoChannelList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageVideoInfo;
        private System.Windows.Forms.TabPage pageEventRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCurrentDVSPwd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCurrentDVSPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCurrentUserName;
        private System.Windows.Forms.TextBox txtCurrentChannelNum;
        private VideoPlayControl.VideoPTZControl videoPTZControl2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbVideoList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCurrentDVSType;
        private System.Windows.Forms.TextBox txtVideoID;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.TextBox txtCurrentDVSAddress;
    }
}

