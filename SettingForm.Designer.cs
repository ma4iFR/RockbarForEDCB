
namespace RockbarForEDCB
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "チャンネル　00:00-00:00　　　通常番組",
            "test",
            "test",
            "test"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("チャンネル　00:00-00:00　◎　正常予約番組");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("チャンネル　00:00-00:00　欠　部分予約番組");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("チャンネル　00:00-00:00　×　予約不可番組");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "01/01 00:00～00:00  　  通常番組",
            "test",
            "test",
            "test"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("01/01 00:00～00:00  ◎  正常予約番組");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("01/01 00:00～00:00  欠  部分予約番組");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("01/01 00:00～00:00  ×  予約不可番組");
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.allServiceListView = new System.Windows.Forms.ListView();
            this.allServiceMarkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allServiceTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allServiceNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allServiceTsidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allServiceSidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addSelectedServiceButton = new System.Windows.Forms.Button();
            this.removeSelectedServiceButton = new System.Windows.Forms.Button();
            this.moveDownSelectedServiceButton = new System.Windows.Forms.Button();
            this.moveUpSelectedServiceButton = new System.Windows.Forms.Button();
            this.selectedServiceListView = new System.Windows.Forms.ListView();
            this.selectedServiceMarkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedServiceTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedServiceNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedServiceTsidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedServiceSidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingTabControl = new System.Windows.Forms.TabControl();
            this.edcbLinkageTabPage = new System.Windows.Forms.TabPage();
            this.portNumberNoteLabel = new System.Windows.Forms.Label();
            this.portNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.portNumberLabel = new System.Windows.Forms.Label();
            this.webLinkUrlExampleLabel = new System.Windows.Forms.Label();
            this.useTcpIpCheckbox = new System.Windows.Forms.CheckBox();
            this.useWebLinkCheckBox = new System.Windows.Forms.CheckBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.webLinkUrlLabel = new System.Windows.Forms.Label();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.webLinkUrlTextBox = new System.Windows.Forms.TextBox();
            this.tunerTabPage = new System.Windows.Forms.TabPage();
            this.tunerNameLabel = new System.Windows.Forms.Label();
            this.tunerNameNoteLabel = new System.Windows.Forms.Label();
            this.updateTunerNameButton = new System.Windows.Forms.Button();
            this.tunerNameTextBox = new System.Windows.Forms.TextBox();
            this.tunerNameListView = new System.Windows.Forms.ListView();
            this.tunerNameMarkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tunerNameTunerIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tunerNameBonDriverNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tunerNameTunerNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allServiceTabPage = new System.Windows.Forms.TabPage();
            this.selectedServiceListLabel = new System.Windows.Forms.Label();
            this.allServiceListLabel = new System.Windows.Forms.Label();
            this.favoriteServiceTabPage = new System.Windows.Forms.TabPage();
            this.favoriteServiceListLabel = new System.Windows.Forms.Label();
            this.selectedServiceList2Label = new System.Windows.Forms.Label();
            this.selectedServiceListView2 = new System.Windows.Forms.ListView();
            this.selectedService2MarkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedService2TypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedService2NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedService2TsidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedService2SidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moveUpFavoriteServiceButton = new System.Windows.Forms.Button();
            this.moveDownFavoriteServiceButton = new System.Windows.Forms.Button();
            this.removeFavoriteServiceButton = new System.Windows.Forms.Button();
            this.favoriteServiceListView = new System.Windows.Forms.ListView();
            this.favoriteServiceMarkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.favoriteServiceTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.favoriteServiceNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.favoriteServiceTsidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.favoriteServiceSidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addFavoriteServiceButton = new System.Windows.Forms.Button();
            this.tvtestLinkageTabPage = new System.Windows.Forms.TabPage();
            this.tvtestDttvOptionExampleLabel = new System.Windows.Forms.Label();
            this.tvtestBscsOptionExampleLabel = new System.Windows.Forms.Label();
            this.autoStartTargetGroupBox = new System.Windows.Forms.GroupBox();
            this.isAutoOpenFavoriteServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.isAutoOpenDttvCheckBox = new System.Windows.Forms.CheckBox();
            this.isAutoOpenCsCheckBox = new System.Windows.Forms.CheckBox();
            this.isAutoOpenBsCheckBox = new System.Windows.Forms.CheckBox();
            this.autoCloseMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.autoCloseMarginLabel = new System.Windows.Forms.Label();
            this.autoOpenMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.autoOpenMarginLabel = new System.Windows.Forms.Label();
            this.isAutoOpenTvtestCheckBox = new System.Windows.Forms.CheckBox();
            this.tvTestNoteLabel = new System.Windows.Forms.Label();
            this.useDoubleClickTvtestCheckBox = new System.Windows.Forms.CheckBox();
            this.tvtestDttvOptionLabel = new System.Windows.Forms.Label();
            this.tvtestDttvOptionTextBox = new System.Windows.Forms.TextBox();
            this.tvtestBscsOptionLabel = new System.Windows.Forms.Label();
            this.tvtestBscsOptionTextBox = new System.Windows.Forms.TextBox();
            this.tvtestPathLabel = new System.Windows.Forms.Label();
            this.tvtestOpenButton = new System.Windows.Forms.Button();
            this.tvtestPathTextBox = new System.Windows.Forms.TextBox();
            this.listViewContColorTabPage = new System.Windows.Forms.TabPage();
            this.previewLabel = new System.Windows.Forms.Label();
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.selectFontButton = new System.Windows.Forms.Button();
            this.otherTabPage = new System.Windows.Forms.TabPage();
            this.isHorizontalSplitCheckBox = new System.Windows.Forms.CheckBox();
            this.toggleVisibleTaskTrayIconClickCheckBox = new System.Windows.Forms.CheckBox();
            this.storeTaskTrayByClosingCheckBox = new System.Windows.Forms.CheckBox();
            this.showTaskTraiIconCheckBox = new System.Windows.Forms.CheckBox();
            this.tvtestOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.selectFormBackColorButton = new System.Windows.Forms.Button();
            this.formBackColorTextBox = new System.Windows.Forms.TextBox();
            this.formBackColorLabel = new System.Windows.Forms.Label();
            this.previewFormPanel = new System.Windows.Forms.Panel();
            this.previewListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectListBackColorButton = new System.Windows.Forms.Button();
            this.listBackColorTextBox = new System.Windows.Forms.TextBox();
            this.listBackColorLabel = new System.Windows.Forms.Label();
            this.selectForeColorButton = new System.Windows.Forms.Button();
            this.foreColorTextBox = new System.Windows.Forms.TextBox();
            this.foreColorLabel = new System.Windows.Forms.Label();
            this.selectOkReserveListBackColorButton = new System.Windows.Forms.Button();
            this.okReserveListBackColorTextBox = new System.Windows.Forms.TextBox();
            this.okReserveListBackColorLabel = new System.Windows.Forms.Label();
            this.selectPartialReserveListBackColorButton = new System.Windows.Forms.Button();
            this.partialReserveListBackColorTextBox = new System.Windows.Forms.TextBox();
            this.partialReserveListBackColorLabel = new System.Windows.Forms.Label();
            this.selectNgReserveListBackColorButton = new System.Windows.Forms.Button();
            this.ngReserveListBackColorTextBox = new System.Windows.Forms.TextBox();
            this.ngReserveListBackColorLabel = new System.Windows.Forms.Label();
            this.contextMenuFontColorTabPage = new System.Windows.Forms.TabPage();
            this.ngReserveMenuBackColorTextBox = new System.Windows.Forms.TextBox();
            this.selectNgReserveMenuBackColorButton = new System.Windows.Forms.Button();
            this.partialReserveMenuBackColorLabel = new System.Windows.Forms.Label();
            this.partialReserveMenuBackColorTextBox = new System.Windows.Forms.TextBox();
            this.selectPartialReserveMenuBackColorButton = new System.Windows.Forms.Button();
            this.okReserveMenuBackColorLabel = new System.Windows.Forms.Label();
            this.okReserveMenuBackColorTextBox = new System.Windows.Forms.TextBox();
            this.selectOkReserveMenuBackColorButton = new System.Windows.Forms.Button();
            this.previewMenuListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.menuBackColorLabel = new System.Windows.Forms.Label();
            this.menuBackColorTextBox = new System.Windows.Forms.TextBox();
            this.selectMenuBackColorButton = new System.Windows.Forms.Button();
            this.menuFontLabel = new System.Windows.Forms.Label();
            this.menuFontTextBox = new System.Windows.Forms.TextBox();
            this.selectMenuFontButton = new System.Windows.Forms.Button();
            this.ngReserveMenuBackColorLabel = new System.Windows.Forms.Label();
            this.settingTabControl.SuspendLayout();
            this.edcbLinkageTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberNumericUpDown)).BeginInit();
            this.tunerTabPage.SuspendLayout();
            this.allServiceTabPage.SuspendLayout();
            this.favoriteServiceTabPage.SuspendLayout();
            this.tvtestLinkageTabPage.SuspendLayout();
            this.autoStartTargetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCloseMarginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoOpenMarginNumericUpDown)).BeginInit();
            this.listViewContColorTabPage.SuspendLayout();
            this.otherTabPage.SuspendLayout();
            this.contextMenuFontColorTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(721, 419);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(630, 419);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "設定保存";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // allServiceListView
            // 
            this.allServiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.allServiceMarkColumnHeader,
            this.allServiceTypeColumnHeader,
            this.allServiceNameColumnHeader,
            this.allServiceTsidColumnHeader,
            this.allServiceSidColumnHeader});
            this.allServiceListView.FullRowSelect = true;
            this.allServiceListView.HideSelection = false;
            this.allServiceListView.Location = new System.Drawing.Point(8, 26);
            this.allServiceListView.Name = "allServiceListView";
            this.allServiceListView.Size = new System.Drawing.Size(333, 353);
            this.allServiceListView.TabIndex = 0;
            this.allServiceListView.UseCompatibleStateImageBehavior = false;
            this.allServiceListView.View = System.Windows.Forms.View.Details;
            this.allServiceListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.allServiceListView_ColumnClick);
            // 
            // allServiceMarkColumnHeader
            // 
            this.allServiceMarkColumnHeader.Text = "";
            this.allServiceMarkColumnHeader.Width = 20;
            // 
            // allServiceTypeColumnHeader
            // 
            this.allServiceTypeColumnHeader.Text = "種類";
            this.allServiceTypeColumnHeader.Width = 40;
            // 
            // allServiceNameColumnHeader
            // 
            this.allServiceNameColumnHeader.Text = "名前";
            this.allServiceNameColumnHeader.Width = 130;
            // 
            // allServiceTsidColumnHeader
            // 
            this.allServiceTsidColumnHeader.Text = "TSID";
            // 
            // allServiceSidColumnHeader
            // 
            this.allServiceSidColumnHeader.Text = "SID";
            // 
            // addSelectedServiceButton
            // 
            this.addSelectedServiceButton.Location = new System.Drawing.Point(347, 139);
            this.addSelectedServiceButton.Name = "addSelectedServiceButton";
            this.addSelectedServiceButton.Size = new System.Drawing.Size(51, 23);
            this.addSelectedServiceButton.TabIndex = 2;
            this.addSelectedServiceButton.Text = ">>";
            this.addSelectedServiceButton.UseVisualStyleBackColor = true;
            this.addSelectedServiceButton.Click += new System.EventHandler(this.addSelectedServiceButton_Click);
            // 
            // removeSelectedServiceButton
            // 
            this.removeSelectedServiceButton.Location = new System.Drawing.Point(347, 243);
            this.removeSelectedServiceButton.Name = "removeSelectedServiceButton";
            this.removeSelectedServiceButton.Size = new System.Drawing.Size(51, 23);
            this.removeSelectedServiceButton.TabIndex = 3;
            this.removeSelectedServiceButton.Text = "<<";
            this.removeSelectedServiceButton.UseVisualStyleBackColor = true;
            this.removeSelectedServiceButton.Click += new System.EventHandler(this.removeServiceButton_Click);
            // 
            // moveDownSelectedServiceButton
            // 
            this.moveDownSelectedServiceButton.Location = new System.Drawing.Point(744, 208);
            this.moveDownSelectedServiceButton.Name = "moveDownSelectedServiceButton";
            this.moveDownSelectedServiceButton.Size = new System.Drawing.Size(40, 23);
            this.moveDownSelectedServiceButton.TabIndex = 5;
            this.moveDownSelectedServiceButton.Text = "↓";
            this.moveDownSelectedServiceButton.UseVisualStyleBackColor = true;
            this.moveDownSelectedServiceButton.Click += new System.EventHandler(this.moveDownSelectedServiceButton_Click);
            // 
            // moveUpSelectedServiceButton
            // 
            this.moveUpSelectedServiceButton.Location = new System.Drawing.Point(744, 169);
            this.moveUpSelectedServiceButton.Name = "moveUpSelectedServiceButton";
            this.moveUpSelectedServiceButton.Size = new System.Drawing.Size(40, 23);
            this.moveUpSelectedServiceButton.TabIndex = 4;
            this.moveUpSelectedServiceButton.Text = "↑";
            this.moveUpSelectedServiceButton.UseVisualStyleBackColor = true;
            this.moveUpSelectedServiceButton.Click += new System.EventHandler(this.moveUpSelectedServiceButton_Click);
            // 
            // selectedServiceListView
            // 
            this.selectedServiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.selectedServiceMarkColumnHeader,
            this.selectedServiceTypeColumnHeader,
            this.selectedServiceNameColumnHeader,
            this.selectedServiceTsidColumnHeader,
            this.selectedServiceSidColumnHeader});
            this.selectedServiceListView.FullRowSelect = true;
            this.selectedServiceListView.HideSelection = false;
            this.selectedServiceListView.Location = new System.Drawing.Point(405, 26);
            this.selectedServiceListView.Name = "selectedServiceListView";
            this.selectedServiceListView.Size = new System.Drawing.Size(333, 353);
            this.selectedServiceListView.TabIndex = 1;
            this.selectedServiceListView.UseCompatibleStateImageBehavior = false;
            this.selectedServiceListView.View = System.Windows.Forms.View.Details;
            this.selectedServiceListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.selectedServiceListView_ColumnClick);
            // 
            // selectedServiceMarkColumnHeader
            // 
            this.selectedServiceMarkColumnHeader.Text = "";
            this.selectedServiceMarkColumnHeader.Width = 20;
            // 
            // selectedServiceTypeColumnHeader
            // 
            this.selectedServiceTypeColumnHeader.Text = "種類";
            this.selectedServiceTypeColumnHeader.Width = 40;
            // 
            // selectedServiceNameColumnHeader
            // 
            this.selectedServiceNameColumnHeader.Text = "名前";
            this.selectedServiceNameColumnHeader.Width = 130;
            // 
            // selectedServiceTsidColumnHeader
            // 
            this.selectedServiceTsidColumnHeader.Text = "TSID";
            // 
            // selectedServiceSidColumnHeader
            // 
            this.selectedServiceSidColumnHeader.Text = "SID";
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.edcbLinkageTabPage);
            this.settingTabControl.Controls.Add(this.tunerTabPage);
            this.settingTabControl.Controls.Add(this.allServiceTabPage);
            this.settingTabControl.Controls.Add(this.favoriteServiceTabPage);
            this.settingTabControl.Controls.Add(this.tvtestLinkageTabPage);
            this.settingTabControl.Controls.Add(this.listViewContColorTabPage);
            this.settingTabControl.Controls.Add(this.contextMenuFontColorTabPage);
            this.settingTabControl.Controls.Add(this.otherTabPage);
            this.settingTabControl.Location = new System.Drawing.Point(1, 3);
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            this.settingTabControl.Size = new System.Drawing.Size(799, 410);
            this.settingTabControl.TabIndex = 0;
            this.settingTabControl.SelectedIndexChanged += new System.EventHandler(this.settingTabControl_SelectedIndexChanged);
            // 
            // edcbLinkageTabPage
            // 
            this.edcbLinkageTabPage.Controls.Add(this.portNumberNoteLabel);
            this.edcbLinkageTabPage.Controls.Add(this.portNumberNumericUpDown);
            this.edcbLinkageTabPage.Controls.Add(this.label3);
            this.edcbLinkageTabPage.Controls.Add(this.portNumberLabel);
            this.edcbLinkageTabPage.Controls.Add(this.webLinkUrlExampleLabel);
            this.edcbLinkageTabPage.Controls.Add(this.useTcpIpCheckbox);
            this.edcbLinkageTabPage.Controls.Add(this.useWebLinkCheckBox);
            this.edcbLinkageTabPage.Controls.Add(this.ipAddressLabel);
            this.edcbLinkageTabPage.Controls.Add(this.webLinkUrlLabel);
            this.edcbLinkageTabPage.Controls.Add(this.ipAddressTextBox);
            this.edcbLinkageTabPage.Controls.Add(this.webLinkUrlTextBox);
            this.edcbLinkageTabPage.Location = new System.Drawing.Point(4, 22);
            this.edcbLinkageTabPage.Name = "edcbLinkageTabPage";
            this.edcbLinkageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.edcbLinkageTabPage.Size = new System.Drawing.Size(791, 384);
            this.edcbLinkageTabPage.TabIndex = 0;
            this.edcbLinkageTabPage.Text = "EDCB連携";
            this.edcbLinkageTabPage.UseVisualStyleBackColor = true;
            // 
            // portNumberNoteLabel
            // 
            this.portNumberNoteLabel.AutoSize = true;
            this.portNumberNoteLabel.Location = new System.Drawing.Point(303, 77);
            this.portNumberNoteLabel.Name = "portNumberNoteLabel";
            this.portNumberNoteLabel.Size = new System.Drawing.Size(209, 12);
            this.portNumberNoteLabel.TabIndex = 16;
            this.portNumberNoteLabel.Text = "※localhost, ホスト名はNG。127.0.0.1はOK";
            // 
            // portNumberNumericUpDown
            // 
            this.portNumberNumericUpDown.Location = new System.Drawing.Point(178, 111);
            this.portNumberNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNumberNumericUpDown.Name = "portNumberNumericUpDown";
            this.portNumberNumericUpDown.Size = new System.Drawing.Size(70, 19);
            this.portNumberNumericUpDown.TabIndex = 2;
            this.portNumberNumericUpDown.Value = new decimal(new int[] {
            5510,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "※非チェック時はローカルパイプ通信。次回起動時反映";
            // 
            // portNumberLabel
            // 
            this.portNumberLabel.AutoSize = true;
            this.portNumberLabel.Location = new System.Drawing.Point(59, 113);
            this.portNumberLabel.Name = "portNumberLabel";
            this.portNumberLabel.Size = new System.Drawing.Size(113, 12);
            this.portNumberLabel.TabIndex = 13;
            this.portNumberLabel.Text = "ポート番号(1～65535)";
            // 
            // webLinkUrlExampleLabel
            // 
            this.webLinkUrlExampleLabel.AutoSize = true;
            this.webLinkUrlExampleLabel.Location = new System.Drawing.Point(120, 239);
            this.webLinkUrlExampleLabel.Name = "webLinkUrlExampleLabel";
            this.webLinkUrlExampleLabel.Size = new System.Drawing.Size(452, 84);
            this.webLinkUrlExampleLabel.TabIndex = 11;
            this.webLinkUrlExampleLabel.Text = resources.GetString("webLinkUrlExampleLabel.Text");
            // 
            // useTcpIpCheckbox
            // 
            this.useTcpIpCheckbox.AutoSize = true;
            this.useTcpIpCheckbox.Location = new System.Drawing.Point(22, 20);
            this.useTcpIpCheckbox.Name = "useTcpIpCheckbox";
            this.useTcpIpCheckbox.Size = new System.Drawing.Size(196, 16);
            this.useTcpIpCheckbox.TabIndex = 0;
            this.useTcpIpCheckbox.Text = "EDCBとの通信にTCP/IPを使用する";
            this.useTcpIpCheckbox.UseVisualStyleBackColor = true;
            // 
            // useWebLinkCheckBox
            // 
            this.useWebLinkCheckBox.AutoSize = true;
            this.useWebLinkCheckBox.Location = new System.Drawing.Point(22, 173);
            this.useWebLinkCheckBox.Name = "useWebLinkCheckBox";
            this.useWebLinkCheckBox.Size = new System.Drawing.Size(170, 16);
            this.useWebLinkCheckBox.TabIndex = 3;
            this.useWebLinkCheckBox.Text = "Web番組詳細へのリンクを表示";
            this.useWebLinkCheckBox.UseVisualStyleBackColor = true;
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(65, 77);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(51, 12);
            this.ipAddressLabel.TabIndex = 8;
            this.ipAddressLabel.Text = "IPアドレス";
            // 
            // webLinkUrlLabel
            // 
            this.webLinkUrlLabel.AutoSize = true;
            this.webLinkUrlLabel.Location = new System.Drawing.Point(20, 204);
            this.webLinkUrlLabel.Name = "webLinkUrlLabel";
            this.webLinkUrlLabel.Size = new System.Drawing.Size(96, 12);
            this.webLinkUrlLabel.TabIndex = 8;
            this.webLinkUrlLabel.Text = "Web番組詳細URL";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(122, 74);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(166, 19);
            this.ipAddressTextBox.TabIndex = 1;
            // 
            // webLinkUrlTextBox
            // 
            this.webLinkUrlTextBox.Location = new System.Drawing.Point(122, 201);
            this.webLinkUrlTextBox.Name = "webLinkUrlTextBox";
            this.webLinkUrlTextBox.Size = new System.Drawing.Size(478, 19);
            this.webLinkUrlTextBox.TabIndex = 4;
            // 
            // tunerTabPage
            // 
            this.tunerTabPage.Controls.Add(this.tunerNameLabel);
            this.tunerTabPage.Controls.Add(this.tunerNameNoteLabel);
            this.tunerTabPage.Controls.Add(this.updateTunerNameButton);
            this.tunerTabPage.Controls.Add(this.tunerNameTextBox);
            this.tunerTabPage.Controls.Add(this.tunerNameListView);
            this.tunerTabPage.Location = new System.Drawing.Point(4, 22);
            this.tunerTabPage.Name = "tunerTabPage";
            this.tunerTabPage.Size = new System.Drawing.Size(791, 384);
            this.tunerTabPage.TabIndex = 5;
            this.tunerTabPage.Text = "チューナー名";
            this.tunerTabPage.UseVisualStyleBackColor = true;
            // 
            // tunerNameLabel
            // 
            this.tunerNameLabel.AutoSize = true;
            this.tunerNameLabel.Location = new System.Drawing.Point(478, 26);
            this.tunerNameLabel.Name = "tunerNameLabel";
            this.tunerNameLabel.Size = new System.Drawing.Size(41, 12);
            this.tunerNameLabel.TabIndex = 27;
            this.tunerNameLabel.Text = "表示名";
            // 
            // tunerNameNoteLabel
            // 
            this.tunerNameNoteLabel.AutoSize = true;
            this.tunerNameNoteLabel.Location = new System.Drawing.Point(475, 60);
            this.tunerNameNoteLabel.Name = "tunerNameNoteLabel";
            this.tunerNameNoteLabel.Size = new System.Drawing.Size(317, 48);
            this.tunerNameNoteLabel.TabIndex = 26;
            this.tunerNameNoteLabel.Text = "※チューナー一覧に表示名+連番(チューナーID下位2byte)で表示\r\n\r\nデフォルトでBonDriver名から推測した表示名を当て込んでいます。\r\nあっていない" +
    "場合もあるので適宜更新してください。";
            // 
            // updateTunerNameButton
            // 
            this.updateTunerNameButton.Location = new System.Drawing.Point(658, 21);
            this.updateTunerNameButton.Name = "updateTunerNameButton";
            this.updateTunerNameButton.Size = new System.Drawing.Size(75, 23);
            this.updateTunerNameButton.TabIndex = 3;
            this.updateTunerNameButton.Text = "更新";
            this.updateTunerNameButton.UseVisualStyleBackColor = true;
            this.updateTunerNameButton.Click += new System.EventHandler(this.updateTunerNameButton_Click);
            // 
            // tunerNameTextBox
            // 
            this.tunerNameTextBox.Location = new System.Drawing.Point(525, 23);
            this.tunerNameTextBox.Name = "tunerNameTextBox";
            this.tunerNameTextBox.Size = new System.Drawing.Size(127, 19);
            this.tunerNameTextBox.TabIndex = 2;
            // 
            // tunerNameListView
            // 
            this.tunerNameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tunerNameMarkColumnHeader,
            this.tunerNameTunerIdColumnHeader,
            this.tunerNameBonDriverNameColumnHeader,
            this.tunerNameTunerNameColumnHeader});
            this.tunerNameListView.FullRowSelect = true;
            this.tunerNameListView.HideSelection = false;
            this.tunerNameListView.Location = new System.Drawing.Point(7, 12);
            this.tunerNameListView.MultiSelect = false;
            this.tunerNameListView.Name = "tunerNameListView";
            this.tunerNameListView.Size = new System.Drawing.Size(463, 353);
            this.tunerNameListView.TabIndex = 1;
            this.tunerNameListView.UseCompatibleStateImageBehavior = false;
            this.tunerNameListView.View = System.Windows.Forms.View.Details;
            this.tunerNameListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.tunerNameListView_ColumnClick);
            this.tunerNameListView.SelectedIndexChanged += new System.EventHandler(this.tunerNameListView_SelectedIndexChanged);
            // 
            // tunerNameMarkColumnHeader
            // 
            this.tunerNameMarkColumnHeader.Text = "";
            this.tunerNameMarkColumnHeader.Width = 20;
            // 
            // tunerNameTunerIdColumnHeader
            // 
            this.tunerNameTunerIdColumnHeader.Text = "チューナーID(上位2byte)";
            this.tunerNameTunerIdColumnHeader.Width = 130;
            // 
            // tunerNameBonDriverNameColumnHeader
            // 
            this.tunerNameBonDriverNameColumnHeader.Text = "BonDriver名";
            this.tunerNameBonDriverNameColumnHeader.Width = 160;
            // 
            // tunerNameTunerNameColumnHeader
            // 
            this.tunerNameTunerNameColumnHeader.Text = "表示名";
            this.tunerNameTunerNameColumnHeader.Width = 140;
            // 
            // allServiceTabPage
            // 
            this.allServiceTabPage.Controls.Add(this.selectedServiceListLabel);
            this.allServiceTabPage.Controls.Add(this.allServiceListLabel);
            this.allServiceTabPage.Controls.Add(this.allServiceListView);
            this.allServiceTabPage.Controls.Add(this.moveUpSelectedServiceButton);
            this.allServiceTabPage.Controls.Add(this.moveDownSelectedServiceButton);
            this.allServiceTabPage.Controls.Add(this.removeSelectedServiceButton);
            this.allServiceTabPage.Controls.Add(this.selectedServiceListView);
            this.allServiceTabPage.Controls.Add(this.addSelectedServiceButton);
            this.allServiceTabPage.Location = new System.Drawing.Point(4, 22);
            this.allServiceTabPage.Name = "allServiceTabPage";
            this.allServiceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allServiceTabPage.Size = new System.Drawing.Size(791, 384);
            this.allServiceTabPage.TabIndex = 2;
            this.allServiceTabPage.Text = "選択チャンネル";
            this.allServiceTabPage.UseVisualStyleBackColor = true;
            // 
            // selectedServiceListLabel
            // 
            this.selectedServiceListLabel.AutoSize = true;
            this.selectedServiceListLabel.Location = new System.Drawing.Point(403, 10);
            this.selectedServiceListLabel.Name = "selectedServiceListLabel";
            this.selectedServiceListLabel.Size = new System.Drawing.Size(75, 12);
            this.selectedServiceListLabel.TabIndex = 9;
            this.selectedServiceListLabel.Text = "選択チャンネル";
            // 
            // allServiceListLabel
            // 
            this.allServiceListLabel.AutoSize = true;
            this.allServiceListLabel.Location = new System.Drawing.Point(6, 10);
            this.allServiceListLabel.Name = "allServiceListLabel";
            this.allServiceListLabel.Size = new System.Drawing.Size(63, 12);
            this.allServiceListLabel.TabIndex = 8;
            this.allServiceListLabel.Text = "全チャンネル";
            // 
            // favoriteServiceTabPage
            // 
            this.favoriteServiceTabPage.Controls.Add(this.favoriteServiceListLabel);
            this.favoriteServiceTabPage.Controls.Add(this.selectedServiceList2Label);
            this.favoriteServiceTabPage.Controls.Add(this.selectedServiceListView2);
            this.favoriteServiceTabPage.Controls.Add(this.moveUpFavoriteServiceButton);
            this.favoriteServiceTabPage.Controls.Add(this.moveDownFavoriteServiceButton);
            this.favoriteServiceTabPage.Controls.Add(this.removeFavoriteServiceButton);
            this.favoriteServiceTabPage.Controls.Add(this.favoriteServiceListView);
            this.favoriteServiceTabPage.Controls.Add(this.addFavoriteServiceButton);
            this.favoriteServiceTabPage.Location = new System.Drawing.Point(4, 22);
            this.favoriteServiceTabPage.Name = "favoriteServiceTabPage";
            this.favoriteServiceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.favoriteServiceTabPage.Size = new System.Drawing.Size(791, 384);
            this.favoriteServiceTabPage.TabIndex = 1;
            this.favoriteServiceTabPage.Text = "お気に入りチャンネル";
            this.favoriteServiceTabPage.UseVisualStyleBackColor = true;
            // 
            // favoriteServiceListLabel
            // 
            this.favoriteServiceListLabel.AutoSize = true;
            this.favoriteServiceListLabel.Location = new System.Drawing.Point(403, 11);
            this.favoriteServiceListLabel.Name = "favoriteServiceListLabel";
            this.favoriteServiceListLabel.Size = new System.Drawing.Size(102, 12);
            this.favoriteServiceListLabel.TabIndex = 15;
            this.favoriteServiceListLabel.Text = "お気に入りチャンネル";
            // 
            // selectedServiceList2Label
            // 
            this.selectedServiceList2Label.AutoSize = true;
            this.selectedServiceList2Label.Location = new System.Drawing.Point(7, 11);
            this.selectedServiceList2Label.Name = "selectedServiceList2Label";
            this.selectedServiceList2Label.Size = new System.Drawing.Size(75, 12);
            this.selectedServiceList2Label.TabIndex = 14;
            this.selectedServiceList2Label.Text = "選択チャンネル";
            // 
            // selectedServiceListView2
            // 
            this.selectedServiceListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.selectedService2MarkColumnHeader,
            this.selectedService2TypeColumnHeader,
            this.selectedService2NameColumnHeader,
            this.selectedService2TsidColumnHeader,
            this.selectedService2SidColumnHeader});
            this.selectedServiceListView2.FullRowSelect = true;
            this.selectedServiceListView2.HideSelection = false;
            this.selectedServiceListView2.Location = new System.Drawing.Point(8, 26);
            this.selectedServiceListView2.Name = "selectedServiceListView2";
            this.selectedServiceListView2.Size = new System.Drawing.Size(333, 353);
            this.selectedServiceListView2.TabIndex = 0;
            this.selectedServiceListView2.UseCompatibleStateImageBehavior = false;
            this.selectedServiceListView2.View = System.Windows.Forms.View.Details;
            this.selectedServiceListView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.selectedServiceListView2_ColumnClick);
            // 
            // selectedService2MarkColumnHeader
            // 
            this.selectedService2MarkColumnHeader.Text = "";
            this.selectedService2MarkColumnHeader.Width = 20;
            // 
            // selectedService2TypeColumnHeader
            // 
            this.selectedService2TypeColumnHeader.Text = "種類";
            this.selectedService2TypeColumnHeader.Width = 40;
            // 
            // selectedService2NameColumnHeader
            // 
            this.selectedService2NameColumnHeader.Text = "名前";
            this.selectedService2NameColumnHeader.Width = 130;
            // 
            // selectedService2TsidColumnHeader
            // 
            this.selectedService2TsidColumnHeader.Text = "TSID";
            // 
            // selectedService2SidColumnHeader
            // 
            this.selectedService2SidColumnHeader.Text = "SID";
            // 
            // moveUpFavoriteServiceButton
            // 
            this.moveUpFavoriteServiceButton.Location = new System.Drawing.Point(744, 169);
            this.moveUpFavoriteServiceButton.Name = "moveUpFavoriteServiceButton";
            this.moveUpFavoriteServiceButton.Size = new System.Drawing.Size(40, 23);
            this.moveUpFavoriteServiceButton.TabIndex = 4;
            this.moveUpFavoriteServiceButton.Text = "↑";
            this.moveUpFavoriteServiceButton.UseVisualStyleBackColor = true;
            this.moveUpFavoriteServiceButton.Click += new System.EventHandler(this.moveUpFavoriteServiceButton_Click);
            // 
            // moveDownFavoriteServiceButton
            // 
            this.moveDownFavoriteServiceButton.Location = new System.Drawing.Point(744, 208);
            this.moveDownFavoriteServiceButton.Name = "moveDownFavoriteServiceButton";
            this.moveDownFavoriteServiceButton.Size = new System.Drawing.Size(40, 23);
            this.moveDownFavoriteServiceButton.TabIndex = 5;
            this.moveDownFavoriteServiceButton.Text = "↓";
            this.moveDownFavoriteServiceButton.UseVisualStyleBackColor = true;
            this.moveDownFavoriteServiceButton.Click += new System.EventHandler(this.moveDownFavoriteServiceButton_Click);
            // 
            // removeFavoriteServiceButton
            // 
            this.removeFavoriteServiceButton.Location = new System.Drawing.Point(347, 243);
            this.removeFavoriteServiceButton.Name = "removeFavoriteServiceButton";
            this.removeFavoriteServiceButton.Size = new System.Drawing.Size(51, 23);
            this.removeFavoriteServiceButton.TabIndex = 3;
            this.removeFavoriteServiceButton.Text = "<<";
            this.removeFavoriteServiceButton.UseVisualStyleBackColor = true;
            this.removeFavoriteServiceButton.Click += new System.EventHandler(this.removeFavoriteServiceButton_Click);
            // 
            // favoriteServiceListView
            // 
            this.favoriteServiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.favoriteServiceMarkColumnHeader,
            this.favoriteServiceTypeColumnHeader,
            this.favoriteServiceNameColumnHeader,
            this.favoriteServiceTsidColumnHeader,
            this.favoriteServiceSidColumnHeader});
            this.favoriteServiceListView.FullRowSelect = true;
            this.favoriteServiceListView.HideSelection = false;
            this.favoriteServiceListView.Location = new System.Drawing.Point(405, 26);
            this.favoriteServiceListView.Name = "favoriteServiceListView";
            this.favoriteServiceListView.Size = new System.Drawing.Size(333, 353);
            this.favoriteServiceListView.TabIndex = 1;
            this.favoriteServiceListView.UseCompatibleStateImageBehavior = false;
            this.favoriteServiceListView.View = System.Windows.Forms.View.Details;
            this.favoriteServiceListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.favoriteServiceListView_ColumnClick);
            // 
            // favoriteServiceMarkColumnHeader
            // 
            this.favoriteServiceMarkColumnHeader.Text = "";
            this.favoriteServiceMarkColumnHeader.Width = 20;
            // 
            // favoriteServiceTypeColumnHeader
            // 
            this.favoriteServiceTypeColumnHeader.Text = "種類";
            this.favoriteServiceTypeColumnHeader.Width = 40;
            // 
            // favoriteServiceNameColumnHeader
            // 
            this.favoriteServiceNameColumnHeader.Text = "名前";
            this.favoriteServiceNameColumnHeader.Width = 130;
            // 
            // favoriteServiceTsidColumnHeader
            // 
            this.favoriteServiceTsidColumnHeader.Text = "TSID";
            // 
            // favoriteServiceSidColumnHeader
            // 
            this.favoriteServiceSidColumnHeader.Text = "SID";
            // 
            // addFavoriteServiceButton
            // 
            this.addFavoriteServiceButton.Location = new System.Drawing.Point(347, 139);
            this.addFavoriteServiceButton.Name = "addFavoriteServiceButton";
            this.addFavoriteServiceButton.Size = new System.Drawing.Size(51, 23);
            this.addFavoriteServiceButton.TabIndex = 2;
            this.addFavoriteServiceButton.Text = ">>";
            this.addFavoriteServiceButton.UseVisualStyleBackColor = true;
            this.addFavoriteServiceButton.Click += new System.EventHandler(this.addFavoriteServiceButton_Click);
            // 
            // tvtestLinkageTabPage
            // 
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestDttvOptionExampleLabel);
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestBscsOptionExampleLabel);
            this.tvtestLinkageTabPage.Controls.Add(this.autoStartTargetGroupBox);
            this.tvtestLinkageTabPage.Controls.Add(this.autoCloseMarginNumericUpDown);
            this.tvtestLinkageTabPage.Controls.Add(this.autoCloseMarginLabel);
            this.tvtestLinkageTabPage.Controls.Add(this.autoOpenMarginNumericUpDown);
            this.tvtestLinkageTabPage.Controls.Add(this.autoOpenMarginLabel);
            this.tvtestLinkageTabPage.Controls.Add(this.isAutoOpenTvtestCheckBox);
            this.tvtestLinkageTabPage.Controls.Add(this.tvTestNoteLabel);
            this.tvtestLinkageTabPage.Controls.Add(this.useDoubleClickTvtestCheckBox);
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestDttvOptionLabel);
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestDttvOptionTextBox);
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestBscsOptionLabel);
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestBscsOptionTextBox);
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestPathLabel);
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestOpenButton);
            this.tvtestLinkageTabPage.Controls.Add(this.tvtestPathTextBox);
            this.tvtestLinkageTabPage.Location = new System.Drawing.Point(4, 22);
            this.tvtestLinkageTabPage.Name = "tvtestLinkageTabPage";
            this.tvtestLinkageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tvtestLinkageTabPage.Size = new System.Drawing.Size(791, 384);
            this.tvtestLinkageTabPage.TabIndex = 3;
            this.tvtestLinkageTabPage.Text = "TVTest連携";
            this.tvtestLinkageTabPage.UseVisualStyleBackColor = true;
            // 
            // tvtestDttvOptionExampleLabel
            // 
            this.tvtestDttvOptionExampleLabel.AutoSize = true;
            this.tvtestDttvOptionExampleLabel.Location = new System.Drawing.Point(424, 89);
            this.tvtestDttvOptionExampleLabel.Name = "tvtestDttvOptionExampleLabel";
            this.tvtestDttvOptionExampleLabel.Size = new System.Drawing.Size(121, 24);
            this.tvtestDttvOptionExampleLabel.TabIndex = 25;
            this.tvtestDttvOptionExampleLabel.Text = "(例: 地デジ)\r\n/d BonDriver_PT3_T.dll";
            // 
            // tvtestBscsOptionExampleLabel
            // 
            this.tvtestBscsOptionExampleLabel.AutoSize = true;
            this.tvtestBscsOptionExampleLabel.Location = new System.Drawing.Point(424, 52);
            this.tvtestBscsOptionExampleLabel.Name = "tvtestBscsOptionExampleLabel";
            this.tvtestBscsOptionExampleLabel.Size = new System.Drawing.Size(121, 24);
            this.tvtestBscsOptionExampleLabel.TabIndex = 24;
            this.tvtestBscsOptionExampleLabel.Text = "(例: BS/CS)\r\n/d BonDriver_PT3_S.dll";
            // 
            // autoStartTargetGroupBox
            // 
            this.autoStartTargetGroupBox.Controls.Add(this.isAutoOpenFavoriteServiceCheckBox);
            this.autoStartTargetGroupBox.Controls.Add(this.isAutoOpenDttvCheckBox);
            this.autoStartTargetGroupBox.Controls.Add(this.isAutoOpenCsCheckBox);
            this.autoStartTargetGroupBox.Controls.Add(this.isAutoOpenBsCheckBox);
            this.autoStartTargetGroupBox.Location = new System.Drawing.Point(36, 261);
            this.autoStartTargetGroupBox.Name = "autoStartTargetGroupBox";
            this.autoStartTargetGroupBox.Size = new System.Drawing.Size(229, 88);
            this.autoStartTargetGroupBox.TabIndex = 6;
            this.autoStartTargetGroupBox.TabStop = false;
            this.autoStartTargetGroupBox.Text = "対象チャンネル";
            // 
            // isAutoOpenFavoriteServiceCheckBox
            // 
            this.isAutoOpenFavoriteServiceCheckBox.AutoSize = true;
            this.isAutoOpenFavoriteServiceCheckBox.Location = new System.Drawing.Point(7, 49);
            this.isAutoOpenFavoriteServiceCheckBox.Name = "isAutoOpenFavoriteServiceCheckBox";
            this.isAutoOpenFavoriteServiceCheckBox.Size = new System.Drawing.Size(196, 28);
            this.isAutoOpenFavoriteServiceCheckBox.TabIndex = 9;
            this.isAutoOpenFavoriteServiceCheckBox.Text = "お気に入りサービスのみ\r\n(地デジ／BS／CS設定との積集合)";
            this.isAutoOpenFavoriteServiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // isAutoOpenDttvCheckBox
            // 
            this.isAutoOpenDttvCheckBox.AutoSize = true;
            this.isAutoOpenDttvCheckBox.Location = new System.Drawing.Point(7, 18);
            this.isAutoOpenDttvCheckBox.Name = "isAutoOpenDttvCheckBox";
            this.isAutoOpenDttvCheckBox.Size = new System.Drawing.Size(56, 16);
            this.isAutoOpenDttvCheckBox.TabIndex = 6;
            this.isAutoOpenDttvCheckBox.Text = "地デジ";
            this.isAutoOpenDttvCheckBox.UseVisualStyleBackColor = true;
            // 
            // isAutoOpenCsCheckBox
            // 
            this.isAutoOpenCsCheckBox.AutoSize = true;
            this.isAutoOpenCsCheckBox.Location = new System.Drawing.Point(141, 18);
            this.isAutoOpenCsCheckBox.Name = "isAutoOpenCsCheckBox";
            this.isAutoOpenCsCheckBox.Size = new System.Drawing.Size(39, 16);
            this.isAutoOpenCsCheckBox.TabIndex = 8;
            this.isAutoOpenCsCheckBox.Text = "CS";
            this.isAutoOpenCsCheckBox.UseVisualStyleBackColor = true;
            // 
            // isAutoOpenBsCheckBox
            // 
            this.isAutoOpenBsCheckBox.AutoSize = true;
            this.isAutoOpenBsCheckBox.Location = new System.Drawing.Point(79, 18);
            this.isAutoOpenBsCheckBox.Name = "isAutoOpenBsCheckBox";
            this.isAutoOpenBsCheckBox.Size = new System.Drawing.Size(39, 16);
            this.isAutoOpenBsCheckBox.TabIndex = 7;
            this.isAutoOpenBsCheckBox.Text = "BS";
            this.isAutoOpenBsCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoCloseMarginNumericUpDown
            // 
            this.autoCloseMarginNumericUpDown.Location = new System.Drawing.Point(445, 290);
            this.autoCloseMarginNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.autoCloseMarginNumericUpDown.Name = "autoCloseMarginNumericUpDown";
            this.autoCloseMarginNumericUpDown.Size = new System.Drawing.Size(70, 19);
            this.autoCloseMarginNumericUpDown.TabIndex = 11;
            this.autoCloseMarginNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // autoCloseMarginLabel
            // 
            this.autoCloseMarginLabel.AutoSize = true;
            this.autoCloseMarginLabel.Location = new System.Drawing.Point(285, 293);
            this.autoCloseMarginLabel.Name = "autoCloseMarginLabel";
            this.autoCloseMarginLabel.Size = new System.Drawing.Size(153, 12);
            this.autoCloseMarginLabel.TabIndex = 23;
            this.autoCloseMarginLabel.Text = "終了マージン(0～59秒後終了)";
            // 
            // autoOpenMarginNumericUpDown
            // 
            this.autoOpenMarginNumericUpDown.Location = new System.Drawing.Point(444, 261);
            this.autoOpenMarginNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.autoOpenMarginNumericUpDown.Name = "autoOpenMarginNumericUpDown";
            this.autoOpenMarginNumericUpDown.Size = new System.Drawing.Size(70, 19);
            this.autoOpenMarginNumericUpDown.TabIndex = 10;
            this.autoOpenMarginNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // autoOpenMarginLabel
            // 
            this.autoOpenMarginLabel.AutoSize = true;
            this.autoOpenMarginLabel.Location = new System.Drawing.Point(285, 264);
            this.autoOpenMarginLabel.Name = "autoOpenMarginLabel";
            this.autoOpenMarginLabel.Size = new System.Drawing.Size(153, 12);
            this.autoOpenMarginLabel.TabIndex = 21;
            this.autoOpenMarginLabel.Text = "開始マージン(0～59秒前起動)";
            // 
            // isAutoOpenTvtestCheckBox
            // 
            this.isAutoOpenTvtestCheckBox.AutoSize = true;
            this.isAutoOpenTvtestCheckBox.Location = new System.Drawing.Point(16, 231);
            this.isAutoOpenTvtestCheckBox.Name = "isAutoOpenTvtestCheckBox";
            this.isAutoOpenTvtestCheckBox.Size = new System.Drawing.Size(272, 16);
            this.isAutoOpenTvtestCheckBox.TabIndex = 5;
            this.isAutoOpenTvtestCheckBox.Text = "予約時間に合わせてTVTestを自動起動／終了する";
            this.isAutoOpenTvtestCheckBox.UseVisualStyleBackColor = true;
            // 
            // tvTestNoteLabel
            // 
            this.tvTestNoteLabel.AutoSize = true;
            this.tvTestNoteLabel.ForeColor = System.Drawing.Color.Red;
            this.tvTestNoteLabel.Location = new System.Drawing.Point(100, 123);
            this.tvTestNoteLabel.Name = "tvTestNoteLabel";
            this.tvTestNoteLabel.Size = new System.Drawing.Size(545, 48);
            this.tvTestNoteLabel.TabIndex = 19;
            this.tvTestNoteLabel.Text = "！！注意！！ \r\nチューナー共有前提です。\r\nチューナー共有していない場合、チューナーを占有してしまうことにより録画が失敗することがあるため注意してください。\r\n" +
    "/TSID /SIDオプションは自動付与します。";
            // 
            // useDoubleClickTvtestCheckBox
            // 
            this.useDoubleClickTvtestCheckBox.AutoSize = true;
            this.useDoubleClickTvtestCheckBox.Location = new System.Drawing.Point(16, 201);
            this.useDoubleClickTvtestCheckBox.Name = "useDoubleClickTvtestCheckBox";
            this.useDoubleClickTvtestCheckBox.Size = new System.Drawing.Size(209, 16);
            this.useDoubleClickTvtestCheckBox.TabIndex = 4;
            this.useDoubleClickTvtestCheckBox.Text = "チャンネルダブルクリックでTVTestを起動";
            this.useDoubleClickTvtestCheckBox.UseVisualStyleBackColor = true;
            // 
            // tvtestDttvOptionLabel
            // 
            this.tvtestDttvOptionLabel.AutoSize = true;
            this.tvtestDttvOptionLabel.Location = new System.Drawing.Point(14, 92);
            this.tvtestDttvOptionLabel.Name = "tvtestDttvOptionLabel";
            this.tvtestDttvOptionLabel.Size = new System.Drawing.Size(80, 12);
            this.tvtestDttvOptionLabel.TabIndex = 17;
            this.tvtestDttvOptionLabel.Text = "地デジオプション";
            // 
            // tvtestDttvOptionTextBox
            // 
            this.tvtestDttvOptionTextBox.Location = new System.Drawing.Point(102, 89);
            this.tvtestDttvOptionTextBox.Name = "tvtestDttvOptionTextBox";
            this.tvtestDttvOptionTextBox.Size = new System.Drawing.Size(312, 19);
            this.tvtestDttvOptionTextBox.TabIndex = 3;
            // 
            // tvtestBscsOptionLabel
            // 
            this.tvtestBscsOptionLabel.AutoSize = true;
            this.tvtestBscsOptionLabel.Location = new System.Drawing.Point(14, 57);
            this.tvtestBscsOptionLabel.Name = "tvtestBscsOptionLabel";
            this.tvtestBscsOptionLabel.Size = new System.Drawing.Size(84, 12);
            this.tvtestBscsOptionLabel.TabIndex = 15;
            this.tvtestBscsOptionLabel.Text = "BS/CSオプション";
            // 
            // tvtestBscsOptionTextBox
            // 
            this.tvtestBscsOptionTextBox.Location = new System.Drawing.Point(102, 54);
            this.tvtestBscsOptionTextBox.Name = "tvtestBscsOptionTextBox";
            this.tvtestBscsOptionTextBox.Size = new System.Drawing.Size(312, 19);
            this.tvtestBscsOptionTextBox.TabIndex = 2;
            // 
            // tvtestPathLabel
            // 
            this.tvtestPathLabel.AutoSize = true;
            this.tvtestPathLabel.Location = new System.Drawing.Point(14, 22);
            this.tvtestPathLabel.Name = "tvtestPathLabel";
            this.tvtestPathLabel.Size = new System.Drawing.Size(82, 12);
            this.tvtestPathLabel.TabIndex = 13;
            this.tvtestPathLabel.Text = "TVTest.exeパス";
            // 
            // tvtestOpenButton
            // 
            this.tvtestOpenButton.Location = new System.Drawing.Point(420, 17);
            this.tvtestOpenButton.Name = "tvtestOpenButton";
            this.tvtestOpenButton.Size = new System.Drawing.Size(75, 23);
            this.tvtestOpenButton.TabIndex = 1;
            this.tvtestOpenButton.Text = "開く";
            this.tvtestOpenButton.UseVisualStyleBackColor = true;
            this.tvtestOpenButton.Click += new System.EventHandler(this.tvtestOpenButton_Click);
            // 
            // tvtestPathTextBox
            // 
            this.tvtestPathTextBox.Location = new System.Drawing.Point(102, 19);
            this.tvtestPathTextBox.Name = "tvtestPathTextBox";
            this.tvtestPathTextBox.ReadOnly = true;
            this.tvtestPathTextBox.Size = new System.Drawing.Size(312, 19);
            this.tvtestPathTextBox.TabIndex = 0;
            // 
            // listViewContColorTabPage
            // 
            this.listViewContColorTabPage.Controls.Add(this.ngReserveListBackColorLabel);
            this.listViewContColorTabPage.Controls.Add(this.ngReserveListBackColorTextBox);
            this.listViewContColorTabPage.Controls.Add(this.selectNgReserveListBackColorButton);
            this.listViewContColorTabPage.Controls.Add(this.partialReserveListBackColorLabel);
            this.listViewContColorTabPage.Controls.Add(this.partialReserveListBackColorTextBox);
            this.listViewContColorTabPage.Controls.Add(this.selectPartialReserveListBackColorButton);
            this.listViewContColorTabPage.Controls.Add(this.okReserveListBackColorLabel);
            this.listViewContColorTabPage.Controls.Add(this.okReserveListBackColorTextBox);
            this.listViewContColorTabPage.Controls.Add(this.selectOkReserveListBackColorButton);
            this.listViewContColorTabPage.Controls.Add(this.previewListView);
            this.listViewContColorTabPage.Controls.Add(this.previewLabel);
            this.listViewContColorTabPage.Controls.Add(this.foreColorLabel);
            this.listViewContColorTabPage.Controls.Add(this.foreColorTextBox);
            this.listViewContColorTabPage.Controls.Add(this.selectForeColorButton);
            this.listViewContColorTabPage.Controls.Add(this.listBackColorLabel);
            this.listViewContColorTabPage.Controls.Add(this.listBackColorTextBox);
            this.listViewContColorTabPage.Controls.Add(this.selectListBackColorButton);
            this.listViewContColorTabPage.Controls.Add(this.previewFormPanel);
            this.listViewContColorTabPage.Controls.Add(this.formBackColorLabel);
            this.listViewContColorTabPage.Controls.Add(this.formBackColorTextBox);
            this.listViewContColorTabPage.Controls.Add(this.selectFormBackColorButton);
            this.listViewContColorTabPage.Controls.Add(this.fontLabel);
            this.listViewContColorTabPage.Controls.Add(this.fontTextBox);
            this.listViewContColorTabPage.Controls.Add(this.selectFontButton);
            this.listViewContColorTabPage.Location = new System.Drawing.Point(4, 22);
            this.listViewContColorTabPage.Name = "listViewContColorTabPage";
            this.listViewContColorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.listViewContColorTabPage.Size = new System.Drawing.Size(791, 384);
            this.listViewContColorTabPage.TabIndex = 6;
            this.listViewContColorTabPage.Text = "フォント・色";
            this.listViewContColorTabPage.UseVisualStyleBackColor = true;
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Location = new System.Drawing.Point(407, 60);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(49, 12);
            this.previewLabel.TabIndex = 51;
            this.previewLabel.Text = "プレビュー";
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(102, 15);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(38, 12);
            this.fontLabel.TabIndex = 40;
            this.fontLabel.Text = "フォント";
            // 
            // fontTextBox
            // 
            this.fontTextBox.Location = new System.Drawing.Point(148, 12);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.ReadOnly = true;
            this.fontTextBox.Size = new System.Drawing.Size(302, 19);
            this.fontTextBox.TabIndex = 39;
            // 
            // selectFontButton
            // 
            this.selectFontButton.Location = new System.Drawing.Point(456, 10);
            this.selectFontButton.Name = "selectFontButton";
            this.selectFontButton.Size = new System.Drawing.Size(75, 23);
            this.selectFontButton.TabIndex = 38;
            this.selectFontButton.Text = "選択";
            this.selectFontButton.UseVisualStyleBackColor = true;
            this.selectFontButton.Click += new System.EventHandler(this.selectFontButton_Click);
            // 
            // otherTabPage
            // 
            this.otherTabPage.Controls.Add(this.isHorizontalSplitCheckBox);
            this.otherTabPage.Controls.Add(this.toggleVisibleTaskTrayIconClickCheckBox);
            this.otherTabPage.Controls.Add(this.storeTaskTrayByClosingCheckBox);
            this.otherTabPage.Controls.Add(this.showTaskTraiIconCheckBox);
            this.otherTabPage.Location = new System.Drawing.Point(4, 22);
            this.otherTabPage.Name = "otherTabPage";
            this.otherTabPage.Size = new System.Drawing.Size(791, 384);
            this.otherTabPage.TabIndex = 4;
            this.otherTabPage.Text = "その他";
            this.otherTabPage.UseVisualStyleBackColor = true;
            // 
            // isHorizontalSplitCheckBox
            // 
            this.isHorizontalSplitCheckBox.AutoSize = true;
            this.isHorizontalSplitCheckBox.Location = new System.Drawing.Point(17, 88);
            this.isHorizontalSplitCheckBox.Name = "isHorizontalSplitCheckBox";
            this.isHorizontalSplitCheckBox.Size = new System.Drawing.Size(133, 16);
            this.isHorizontalSplitCheckBox.TabIndex = 15;
            this.isHorizontalSplitCheckBox.Text = "一覧を縦に並べて表示";
            this.isHorizontalSplitCheckBox.UseVisualStyleBackColor = true;
            // 
            // toggleVisibleTaskTrayIconClickCheckBox
            // 
            this.toggleVisibleTaskTrayIconClickCheckBox.AutoSize = true;
            this.toggleVisibleTaskTrayIconClickCheckBox.Location = new System.Drawing.Point(17, 66);
            this.toggleVisibleTaskTrayIconClickCheckBox.Name = "toggleVisibleTaskTrayIconClickCheckBox";
            this.toggleVisibleTaskTrayIconClickCheckBox.Size = new System.Drawing.Size(275, 16);
            this.toggleVisibleTaskTrayIconClickCheckBox.TabIndex = 12;
            this.toggleVisibleTaskTrayIconClickCheckBox.Text = "タスクトレイアイコンクリックで表示・非表示を切り替える";
            this.toggleVisibleTaskTrayIconClickCheckBox.UseVisualStyleBackColor = true;
            // 
            // storeTaskTrayByClosingCheckBox
            // 
            this.storeTaskTrayByClosingCheckBox.AutoSize = true;
            this.storeTaskTrayByClosingCheckBox.Location = new System.Drawing.Point(17, 44);
            this.storeTaskTrayByClosingCheckBox.Name = "storeTaskTrayByClosingCheckBox";
            this.storeTaskTrayByClosingCheckBox.Size = new System.Drawing.Size(176, 16);
            this.storeTaskTrayByClosingCheckBox.TabIndex = 11;
            this.storeTaskTrayByClosingCheckBox.Text = "×ボタンでタスクトレイに格納する";
            this.storeTaskTrayByClosingCheckBox.UseVisualStyleBackColor = true;
            // 
            // showTaskTraiIconCheckBox
            // 
            this.showTaskTraiIconCheckBox.AutoSize = true;
            this.showTaskTraiIconCheckBox.Location = new System.Drawing.Point(17, 22);
            this.showTaskTraiIconCheckBox.Name = "showTaskTraiIconCheckBox";
            this.showTaskTraiIconCheckBox.Size = new System.Drawing.Size(195, 16);
            this.showTaskTraiIconCheckBox.TabIndex = 10;
            this.showTaskTraiIconCheckBox.Text = "タスクトレイに常時アイコンを表示する";
            this.showTaskTraiIconCheckBox.UseVisualStyleBackColor = true;
            // 
            // tvtestOpenFileDialog
            // 
            this.tvtestOpenFileDialog.FileName = "openFileDialog1";
            this.tvtestOpenFileDialog.Filter = "exe Files (*.exe)|*.exe";
            this.tvtestOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.tvtestOpenFileDialog_FileOk);
            // 
            // fontDialog
            // 
            this.fontDialog.AllowVerticalFonts = false;
            this.fontDialog.MaxSize = 28;
            this.fontDialog.MinSize = 6;
            this.fontDialog.ShowEffects = false;
            // 
            // selectFormBackColorButton
            // 
            this.selectFormBackColorButton.Location = new System.Drawing.Point(290, 48);
            this.selectFormBackColorButton.Name = "selectFormBackColorButton";
            this.selectFormBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectFormBackColorButton.TabIndex = 41;
            this.selectFormBackColorButton.Text = "選択";
            this.selectFormBackColorButton.UseVisualStyleBackColor = true;
            this.selectFormBackColorButton.Click += new System.EventHandler(this.selectFormBackColorButton_Click);
            // 
            // formBackColorTextBox
            // 
            this.formBackColorTextBox.Location = new System.Drawing.Point(148, 50);
            this.formBackColorTextBox.Name = "formBackColorTextBox";
            this.formBackColorTextBox.ReadOnly = true;
            this.formBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.formBackColorTextBox.TabIndex = 42;
            // 
            // formBackColorLabel
            // 
            this.formBackColorLabel.AutoSize = true;
            this.formBackColorLabel.Location = new System.Drawing.Point(63, 53);
            this.formBackColorLabel.Name = "formBackColorLabel";
            this.formBackColorLabel.Size = new System.Drawing.Size(77, 12);
            this.formBackColorLabel.TabIndex = 43;
            this.formBackColorLabel.Text = "フォーム背景色";
            // 
            // previewFormPanel
            // 
            this.previewFormPanel.AutoSize = true;
            this.previewFormPanel.Location = new System.Drawing.Point(409, 77);
            this.previewFormPanel.Name = "previewFormPanel";
            this.previewFormPanel.Size = new System.Drawing.Size(337, 171);
            this.previewFormPanel.TabIndex = 44;
            // 
            // previewListView
            // 
            this.previewListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.previewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.previewListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.previewListView.FullRowSelect = true;
            this.previewListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.previewListView.HideSelection = false;
            this.previewListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.previewListView.Location = new System.Drawing.Point(423, 90);
            this.previewListView.MultiSelect = false;
            this.previewListView.Name = "previewListView";
            this.previewListView.ShowItemToolTips = true;
            this.previewListView.Size = new System.Drawing.Size(323, 158);
            this.previewListView.TabIndex = 52;
            this.previewListView.UseCompatibleStateImageBehavior = false;
            this.previewListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 319;
            // 
            // selectListBackColorButton
            // 
            this.selectListBackColorButton.Location = new System.Drawing.Point(290, 124);
            this.selectListBackColorButton.Name = "selectListBackColorButton";
            this.selectListBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectListBackColorButton.TabIndex = 45;
            this.selectListBackColorButton.Text = "選択";
            this.selectListBackColorButton.UseVisualStyleBackColor = true;
            this.selectListBackColorButton.Click += new System.EventHandler(this.selectListBackColorButton_Click);
            // 
            // listBackColorTextBox
            // 
            this.listBackColorTextBox.Location = new System.Drawing.Point(148, 126);
            this.listBackColorTextBox.Name = "listBackColorTextBox";
            this.listBackColorTextBox.ReadOnly = true;
            this.listBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.listBackColorTextBox.TabIndex = 46;
            // 
            // listBackColorLabel
            // 
            this.listBackColorLabel.AutoSize = true;
            this.listBackColorLabel.Location = new System.Drawing.Point(75, 129);
            this.listBackColorLabel.Name = "listBackColorLabel";
            this.listBackColorLabel.Size = new System.Drawing.Size(65, 12);
            this.listBackColorLabel.TabIndex = 47;
            this.listBackColorLabel.Text = "リスト背景色";
            // 
            // selectForeColorButton
            // 
            this.selectForeColorButton.Location = new System.Drawing.Point(290, 86);
            this.selectForeColorButton.Name = "selectForeColorButton";
            this.selectForeColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectForeColorButton.TabIndex = 48;
            this.selectForeColorButton.Text = "選択";
            this.selectForeColorButton.UseVisualStyleBackColor = true;
            this.selectForeColorButton.Click += new System.EventHandler(this.selectForeColorButton_Click);
            // 
            // foreColorTextBox
            // 
            this.foreColorTextBox.Location = new System.Drawing.Point(148, 88);
            this.foreColorTextBox.Name = "foreColorTextBox";
            this.foreColorTextBox.ReadOnly = true;
            this.foreColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.foreColorTextBox.TabIndex = 49;
            // 
            // foreColorLabel
            // 
            this.foreColorLabel.AutoSize = true;
            this.foreColorLabel.Location = new System.Drawing.Point(99, 91);
            this.foreColorLabel.Name = "foreColorLabel";
            this.foreColorLabel.Size = new System.Drawing.Size(41, 12);
            this.foreColorLabel.TabIndex = 50;
            this.foreColorLabel.Text = "文字色";
            // 
            // selectOkReserveListBackColorButton
            // 
            this.selectOkReserveListBackColorButton.Location = new System.Drawing.Point(290, 162);
            this.selectOkReserveListBackColorButton.Name = "selectOkReserveListBackColorButton";
            this.selectOkReserveListBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectOkReserveListBackColorButton.TabIndex = 53;
            this.selectOkReserveListBackColorButton.Text = "選択";
            this.selectOkReserveListBackColorButton.UseVisualStyleBackColor = true;
            this.selectOkReserveListBackColorButton.Click += new System.EventHandler(this.selectOkReserveListBackColorButton_Click);
            // 
            // okReserveListBackColorTextBox
            // 
            this.okReserveListBackColorTextBox.Location = new System.Drawing.Point(148, 164);
            this.okReserveListBackColorTextBox.Name = "okReserveListBackColorTextBox";
            this.okReserveListBackColorTextBox.ReadOnly = true;
            this.okReserveListBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.okReserveListBackColorTextBox.TabIndex = 54;
            // 
            // okReserveListBackColorLabel
            // 
            this.okReserveListBackColorLabel.AutoSize = true;
            this.okReserveListBackColorLabel.Location = new System.Drawing.Point(19, 167);
            this.okReserveListBackColorLabel.Name = "okReserveListBackColorLabel";
            this.okReserveListBackColorLabel.Size = new System.Drawing.Size(121, 12);
            this.okReserveListBackColorLabel.TabIndex = 55;
            this.okReserveListBackColorLabel.Text = "リスト背景色(正常予約)";
            // 
            // selectPartialReserveListBackColorButton
            // 
            this.selectPartialReserveListBackColorButton.Location = new System.Drawing.Point(290, 200);
            this.selectPartialReserveListBackColorButton.Name = "selectPartialReserveListBackColorButton";
            this.selectPartialReserveListBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectPartialReserveListBackColorButton.TabIndex = 56;
            this.selectPartialReserveListBackColorButton.Text = "選択";
            this.selectPartialReserveListBackColorButton.UseVisualStyleBackColor = true;
            this.selectPartialReserveListBackColorButton.Click += new System.EventHandler(this.selectPartialReserveListBackColorButton_Click);
            // 
            // partialReserveListBackColorTextBox
            // 
            this.partialReserveListBackColorTextBox.Location = new System.Drawing.Point(148, 202);
            this.partialReserveListBackColorTextBox.Name = "partialReserveListBackColorTextBox";
            this.partialReserveListBackColorTextBox.ReadOnly = true;
            this.partialReserveListBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.partialReserveListBackColorTextBox.TabIndex = 57;
            // 
            // partialReserveListBackColorLabel
            // 
            this.partialReserveListBackColorLabel.AutoSize = true;
            this.partialReserveListBackColorLabel.Location = new System.Drawing.Point(19, 205);
            this.partialReserveListBackColorLabel.Name = "partialReserveListBackColorLabel";
            this.partialReserveListBackColorLabel.Size = new System.Drawing.Size(121, 12);
            this.partialReserveListBackColorLabel.TabIndex = 58;
            this.partialReserveListBackColorLabel.Text = "リスト背景色(部分予約)";
            // 
            // selectNgReserveListBackColorButton
            // 
            this.selectNgReserveListBackColorButton.Location = new System.Drawing.Point(290, 238);
            this.selectNgReserveListBackColorButton.Name = "selectNgReserveListBackColorButton";
            this.selectNgReserveListBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectNgReserveListBackColorButton.TabIndex = 59;
            this.selectNgReserveListBackColorButton.Text = "選択";
            this.selectNgReserveListBackColorButton.UseVisualStyleBackColor = true;
            this.selectNgReserveListBackColorButton.Click += new System.EventHandler(this.selectNgReserveListBackColorButton_Click);
            // 
            // ngReserveListBackColorTextBox
            // 
            this.ngReserveListBackColorTextBox.Location = new System.Drawing.Point(148, 240);
            this.ngReserveListBackColorTextBox.Name = "ngReserveListBackColorTextBox";
            this.ngReserveListBackColorTextBox.ReadOnly = true;
            this.ngReserveListBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.ngReserveListBackColorTextBox.TabIndex = 60;
            // 
            // ngReserveListBackColorLabel
            // 
            this.ngReserveListBackColorLabel.AutoSize = true;
            this.ngReserveListBackColorLabel.Location = new System.Drawing.Point(19, 243);
            this.ngReserveListBackColorLabel.Name = "ngReserveListBackColorLabel";
            this.ngReserveListBackColorLabel.Size = new System.Drawing.Size(121, 12);
            this.ngReserveListBackColorLabel.TabIndex = 61;
            this.ngReserveListBackColorLabel.Text = "リスト背景色(予約不可)";
            // 
            // contextMenuFontColorTabPage
            // 
            this.contextMenuFontColorTabPage.Controls.Add(this.ngReserveMenuBackColorLabel);
            this.contextMenuFontColorTabPage.Controls.Add(this.ngReserveMenuBackColorTextBox);
            this.contextMenuFontColorTabPage.Controls.Add(this.selectNgReserveMenuBackColorButton);
            this.contextMenuFontColorTabPage.Controls.Add(this.partialReserveMenuBackColorLabel);
            this.contextMenuFontColorTabPage.Controls.Add(this.partialReserveMenuBackColorTextBox);
            this.contextMenuFontColorTabPage.Controls.Add(this.selectPartialReserveMenuBackColorButton);
            this.contextMenuFontColorTabPage.Controls.Add(this.okReserveMenuBackColorLabel);
            this.contextMenuFontColorTabPage.Controls.Add(this.okReserveMenuBackColorTextBox);
            this.contextMenuFontColorTabPage.Controls.Add(this.selectOkReserveMenuBackColorButton);
            this.contextMenuFontColorTabPage.Controls.Add(this.previewMenuListView);
            this.contextMenuFontColorTabPage.Controls.Add(this.label5);
            this.contextMenuFontColorTabPage.Controls.Add(this.menuBackColorLabel);
            this.contextMenuFontColorTabPage.Controls.Add(this.menuBackColorTextBox);
            this.contextMenuFontColorTabPage.Controls.Add(this.selectMenuBackColorButton);
            this.contextMenuFontColorTabPage.Controls.Add(this.menuFontLabel);
            this.contextMenuFontColorTabPage.Controls.Add(this.menuFontTextBox);
            this.contextMenuFontColorTabPage.Controls.Add(this.selectMenuFontButton);
            this.contextMenuFontColorTabPage.Location = new System.Drawing.Point(4, 22);
            this.contextMenuFontColorTabPage.Name = "contextMenuFontColorTabPage";
            this.contextMenuFontColorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contextMenuFontColorTabPage.Size = new System.Drawing.Size(791, 384);
            this.contextMenuFontColorTabPage.TabIndex = 7;
            this.contextMenuFontColorTabPage.Text = "フォント・色(右クリックメニュー)";
            this.contextMenuFontColorTabPage.UseVisualStyleBackColor = true;
            // 
            // ngReserveMenuBackColorTextBox
            // 
            this.ngReserveMenuBackColorTextBox.Location = new System.Drawing.Point(148, 164);
            this.ngReserveMenuBackColorTextBox.Name = "ngReserveMenuBackColorTextBox";
            this.ngReserveMenuBackColorTextBox.ReadOnly = true;
            this.ngReserveMenuBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.ngReserveMenuBackColorTextBox.TabIndex = 84;
            // 
            // selectNgReserveMenuBackColorButton
            // 
            this.selectNgReserveMenuBackColorButton.Location = new System.Drawing.Point(290, 162);
            this.selectNgReserveMenuBackColorButton.Name = "selectNgReserveMenuBackColorButton";
            this.selectNgReserveMenuBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectNgReserveMenuBackColorButton.TabIndex = 83;
            this.selectNgReserveMenuBackColorButton.Text = "選択";
            this.selectNgReserveMenuBackColorButton.UseVisualStyleBackColor = true;
            this.selectNgReserveMenuBackColorButton.Click += new System.EventHandler(this.selectNgReserveMenuBackColorButton_Click);
            // 
            // partialReserveMenuBackColorLabel
            // 
            this.partialReserveMenuBackColorLabel.AutoSize = true;
            this.partialReserveMenuBackColorLabel.Location = new System.Drawing.Point(7, 129);
            this.partialReserveMenuBackColorLabel.Name = "partialReserveMenuBackColorLabel";
            this.partialReserveMenuBackColorLabel.Size = new System.Drawing.Size(132, 12);
            this.partialReserveMenuBackColorLabel.TabIndex = 82;
            this.partialReserveMenuBackColorLabel.Text = "メニュー背景色(部分予約)";
            // 
            // partialReserveMenuBackColorTextBox
            // 
            this.partialReserveMenuBackColorTextBox.Location = new System.Drawing.Point(148, 126);
            this.partialReserveMenuBackColorTextBox.Name = "partialReserveMenuBackColorTextBox";
            this.partialReserveMenuBackColorTextBox.ReadOnly = true;
            this.partialReserveMenuBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.partialReserveMenuBackColorTextBox.TabIndex = 81;
            // 
            // selectPartialReserveMenuBackColorButton
            // 
            this.selectPartialReserveMenuBackColorButton.Location = new System.Drawing.Point(290, 124);
            this.selectPartialReserveMenuBackColorButton.Name = "selectPartialReserveMenuBackColorButton";
            this.selectPartialReserveMenuBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectPartialReserveMenuBackColorButton.TabIndex = 80;
            this.selectPartialReserveMenuBackColorButton.Text = "選択";
            this.selectPartialReserveMenuBackColorButton.UseVisualStyleBackColor = true;
            this.selectPartialReserveMenuBackColorButton.Click += new System.EventHandler(this.selectPartialReserveMenuBackColorButton_Click);
            // 
            // okReserveMenuBackColorLabel
            // 
            this.okReserveMenuBackColorLabel.AutoSize = true;
            this.okReserveMenuBackColorLabel.Location = new System.Drawing.Point(7, 91);
            this.okReserveMenuBackColorLabel.Name = "okReserveMenuBackColorLabel";
            this.okReserveMenuBackColorLabel.Size = new System.Drawing.Size(132, 12);
            this.okReserveMenuBackColorLabel.TabIndex = 79;
            this.okReserveMenuBackColorLabel.Text = "メニュー背景色(正常予約)";
            // 
            // okReserveMenuBackColorTextBox
            // 
            this.okReserveMenuBackColorTextBox.Location = new System.Drawing.Point(148, 88);
            this.okReserveMenuBackColorTextBox.Name = "okReserveMenuBackColorTextBox";
            this.okReserveMenuBackColorTextBox.ReadOnly = true;
            this.okReserveMenuBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.okReserveMenuBackColorTextBox.TabIndex = 78;
            // 
            // selectOkReserveMenuBackColorButton
            // 
            this.selectOkReserveMenuBackColorButton.Location = new System.Drawing.Point(290, 86);
            this.selectOkReserveMenuBackColorButton.Name = "selectOkReserveMenuBackColorButton";
            this.selectOkReserveMenuBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectOkReserveMenuBackColorButton.TabIndex = 77;
            this.selectOkReserveMenuBackColorButton.Text = "選択";
            this.selectOkReserveMenuBackColorButton.UseVisualStyleBackColor = true;
            this.selectOkReserveMenuBackColorButton.Click += new System.EventHandler(this.selectOkReserveMenuBackColorButton_Click);
            // 
            // previewMenuListView
            // 
            this.previewMenuListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.previewMenuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.previewMenuListView.ForeColor = System.Drawing.Color.Black;
            this.previewMenuListView.FullRowSelect = true;
            this.previewMenuListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.previewMenuListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.previewMenuListView.Location = new System.Drawing.Point(409, 75);
            this.previewMenuListView.MultiSelect = false;
            this.previewMenuListView.Name = "previewMenuListView";
            this.previewMenuListView.ShowItemToolTips = true;
            this.previewMenuListView.Size = new System.Drawing.Size(323, 158);
            this.previewMenuListView.TabIndex = 76;
            this.previewMenuListView.UseCompatibleStateImageBehavior = false;
            this.previewMenuListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 319;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 75;
            this.label5.Text = "プレビュー";
            // 
            // menuBackColorLabel
            // 
            this.menuBackColorLabel.AutoSize = true;
            this.menuBackColorLabel.Location = new System.Drawing.Point(63, 53);
            this.menuBackColorLabel.Name = "menuBackColorLabel";
            this.menuBackColorLabel.Size = new System.Drawing.Size(76, 12);
            this.menuBackColorLabel.TabIndex = 74;
            this.menuBackColorLabel.Text = "メニュー背景色";
            // 
            // menuBackColorTextBox
            // 
            this.menuBackColorTextBox.Location = new System.Drawing.Point(148, 50);
            this.menuBackColorTextBox.Name = "menuBackColorTextBox";
            this.menuBackColorTextBox.ReadOnly = true;
            this.menuBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.menuBackColorTextBox.TabIndex = 73;
            // 
            // selectMenuBackColorButton
            // 
            this.selectMenuBackColorButton.Location = new System.Drawing.Point(290, 48);
            this.selectMenuBackColorButton.Name = "selectMenuBackColorButton";
            this.selectMenuBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectMenuBackColorButton.TabIndex = 72;
            this.selectMenuBackColorButton.Text = "選択";
            this.selectMenuBackColorButton.UseVisualStyleBackColor = true;
            this.selectMenuBackColorButton.Click += new System.EventHandler(this.selectMenuBackColorButton_Click);
            // 
            // menuFontLabel
            // 
            this.menuFontLabel.AutoSize = true;
            this.menuFontLabel.Location = new System.Drawing.Point(102, 15);
            this.menuFontLabel.Name = "menuFontLabel";
            this.menuFontLabel.Size = new System.Drawing.Size(38, 12);
            this.menuFontLabel.TabIndex = 64;
            this.menuFontLabel.Text = "フォント";
            // 
            // menuFontTextBox
            // 
            this.menuFontTextBox.Location = new System.Drawing.Point(148, 12);
            this.menuFontTextBox.Name = "menuFontTextBox";
            this.menuFontTextBox.ReadOnly = true;
            this.menuFontTextBox.Size = new System.Drawing.Size(302, 19);
            this.menuFontTextBox.TabIndex = 63;
            // 
            // selectMenuFontButton
            // 
            this.selectMenuFontButton.Location = new System.Drawing.Point(456, 10);
            this.selectMenuFontButton.Name = "selectMenuFontButton";
            this.selectMenuFontButton.Size = new System.Drawing.Size(75, 23);
            this.selectMenuFontButton.TabIndex = 62;
            this.selectMenuFontButton.Text = "選択";
            this.selectMenuFontButton.UseVisualStyleBackColor = true;
            this.selectMenuFontButton.Click += new System.EventHandler(this.selectMenuFontButton_Click);
            // 
            // ngReserveMenuBackColorLabel
            // 
            this.ngReserveMenuBackColorLabel.AutoSize = true;
            this.ngReserveMenuBackColorLabel.Location = new System.Drawing.Point(7, 167);
            this.ngReserveMenuBackColorLabel.Name = "ngReserveMenuBackColorLabel";
            this.ngReserveMenuBackColorLabel.Size = new System.Drawing.Size(132, 12);
            this.ngReserveMenuBackColorLabel.TabIndex = 85;
            this.ngReserveMenuBackColorLabel.Text = "メニュー背景色(予約不可)";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingTabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Name = "SettingForm";
            this.Text = "設定";
            this.settingTabControl.ResumeLayout(false);
            this.edcbLinkageTabPage.ResumeLayout(false);
            this.edcbLinkageTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberNumericUpDown)).EndInit();
            this.tunerTabPage.ResumeLayout(false);
            this.tunerTabPage.PerformLayout();
            this.allServiceTabPage.ResumeLayout(false);
            this.allServiceTabPage.PerformLayout();
            this.favoriteServiceTabPage.ResumeLayout(false);
            this.favoriteServiceTabPage.PerformLayout();
            this.tvtestLinkageTabPage.ResumeLayout(false);
            this.tvtestLinkageTabPage.PerformLayout();
            this.autoStartTargetGroupBox.ResumeLayout(false);
            this.autoStartTargetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCloseMarginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoOpenMarginNumericUpDown)).EndInit();
            this.listViewContColorTabPage.ResumeLayout(false);
            this.listViewContColorTabPage.PerformLayout();
            this.otherTabPage.ResumeLayout(false);
            this.otherTabPage.PerformLayout();
            this.contextMenuFontColorTabPage.ResumeLayout(false);
            this.contextMenuFontColorTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ListView allServiceListView;
        private System.Windows.Forms.Button addSelectedServiceButton;
        private System.Windows.Forms.Button removeSelectedServiceButton;
        private System.Windows.Forms.Button moveDownSelectedServiceButton;
        private System.Windows.Forms.Button moveUpSelectedServiceButton;
        private System.Windows.Forms.ColumnHeader allServiceTypeColumnHeader;
        private System.Windows.Forms.ColumnHeader allServiceNameColumnHeader;
        private System.Windows.Forms.ColumnHeader allServiceTsidColumnHeader;
        private System.Windows.Forms.ColumnHeader allServiceSidColumnHeader;
        private System.Windows.Forms.ColumnHeader allServiceMarkColumnHeader;
        private System.Windows.Forms.ListView selectedServiceListView;
        private System.Windows.Forms.ColumnHeader selectedServiceMarkColumnHeader;
        private System.Windows.Forms.ColumnHeader selectedServiceTypeColumnHeader;
        private System.Windows.Forms.ColumnHeader selectedServiceNameColumnHeader;
        private System.Windows.Forms.ColumnHeader selectedServiceTsidColumnHeader;
        private System.Windows.Forms.ColumnHeader selectedServiceSidColumnHeader;
        private System.Windows.Forms.TabControl settingTabControl;
        private System.Windows.Forms.TabPage allServiceTabPage;
        private System.Windows.Forms.TabPage edcbLinkageTabPage;
        private System.Windows.Forms.OpenFileDialog tvtestOpenFileDialog;
        private System.Windows.Forms.Label webLinkUrlExampleLabel;
        private System.Windows.Forms.CheckBox useWebLinkCheckBox;
        private System.Windows.Forms.Label webLinkUrlLabel;
        private System.Windows.Forms.TextBox webLinkUrlTextBox;
        private System.Windows.Forms.TabPage favoriteServiceTabPage;
        private System.Windows.Forms.ListView selectedServiceListView2;
        private System.Windows.Forms.ColumnHeader selectedService2MarkColumnHeader;
        private System.Windows.Forms.ColumnHeader selectedService2TypeColumnHeader;
        private System.Windows.Forms.ColumnHeader selectedService2NameColumnHeader;
        private System.Windows.Forms.ColumnHeader selectedService2TsidColumnHeader;
        private System.Windows.Forms.ColumnHeader selectedService2SidColumnHeader;
        private System.Windows.Forms.Button moveUpFavoriteServiceButton;
        private System.Windows.Forms.Button moveDownFavoriteServiceButton;
        private System.Windows.Forms.Button removeFavoriteServiceButton;
        private System.Windows.Forms.ListView favoriteServiceListView;
        private System.Windows.Forms.ColumnHeader favoriteServiceMarkColumnHeader;
        private System.Windows.Forms.ColumnHeader favoriteServiceTypeColumnHeader;
        private System.Windows.Forms.ColumnHeader favoriteServiceNameColumnHeader;
        private System.Windows.Forms.ColumnHeader favoriteServiceTsidColumnHeader;
        private System.Windows.Forms.ColumnHeader favoriteServiceSidColumnHeader;
        private System.Windows.Forms.Button addFavoriteServiceButton;
        private System.Windows.Forms.TabPage tvtestLinkageTabPage;
        private System.Windows.Forms.Label portNumberLabel;
        private System.Windows.Forms.CheckBox useTcpIpCheckbox;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Label tvTestNoteLabel;
        private System.Windows.Forms.CheckBox useDoubleClickTvtestCheckBox;
        private System.Windows.Forms.Label tvtestDttvOptionLabel;
        private System.Windows.Forms.TextBox tvtestDttvOptionTextBox;
        private System.Windows.Forms.Label tvtestBscsOptionLabel;
        private System.Windows.Forms.TextBox tvtestBscsOptionTextBox;
        private System.Windows.Forms.Label tvtestPathLabel;
        private System.Windows.Forms.Button tvtestOpenButton;
        private System.Windows.Forms.TextBox tvtestPathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown portNumberNumericUpDown;
        private System.Windows.Forms.Label selectedServiceListLabel;
        private System.Windows.Forms.Label allServiceListLabel;
        private System.Windows.Forms.Label favoriteServiceListLabel;
        private System.Windows.Forms.Label selectedServiceList2Label;
        private System.Windows.Forms.NumericUpDown autoCloseMarginNumericUpDown;
        private System.Windows.Forms.Label autoCloseMarginLabel;
        private System.Windows.Forms.NumericUpDown autoOpenMarginNumericUpDown;
        private System.Windows.Forms.Label autoOpenMarginLabel;
        private System.Windows.Forms.CheckBox isAutoOpenTvtestCheckBox;
        private System.Windows.Forms.GroupBox autoStartTargetGroupBox;
        private System.Windows.Forms.CheckBox isAutoOpenDttvCheckBox;
        private System.Windows.Forms.CheckBox isAutoOpenCsCheckBox;
        private System.Windows.Forms.CheckBox isAutoOpenBsCheckBox;
        private System.Windows.Forms.Label portNumberNoteLabel;
        private System.Windows.Forms.TabPage otherTabPage;
        private System.Windows.Forms.CheckBox showTaskTraiIconCheckBox;
        private System.Windows.Forms.CheckBox isAutoOpenFavoriteServiceCheckBox;
        private System.Windows.Forms.Label tvtestDttvOptionExampleLabel;
        private System.Windows.Forms.Label tvtestBscsOptionExampleLabel;
        private System.Windows.Forms.CheckBox toggleVisibleTaskTrayIconClickCheckBox;
        private System.Windows.Forms.CheckBox storeTaskTrayByClosingCheckBox;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.CheckBox isHorizontalSplitCheckBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TabPage tunerTabPage;
        private System.Windows.Forms.ListView tunerNameListView;
        private System.Windows.Forms.ColumnHeader tunerNameTunerIdColumnHeader;
        private System.Windows.Forms.ColumnHeader tunerNameBonDriverNameColumnHeader;
        private System.Windows.Forms.ColumnHeader tunerNameTunerNameColumnHeader;
        private System.Windows.Forms.Button updateTunerNameButton;
        private System.Windows.Forms.TextBox tunerNameTextBox;
        private System.Windows.Forms.Label tunerNameNoteLabel;
        private System.Windows.Forms.Label tunerNameLabel;
        private System.Windows.Forms.ColumnHeader tunerNameMarkColumnHeader;
        private System.Windows.Forms.TabPage listViewContColorTabPage;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.Button selectFontButton;
        private System.Windows.Forms.Label ngReserveListBackColorLabel;
        private System.Windows.Forms.TextBox ngReserveListBackColorTextBox;
        private System.Windows.Forms.Button selectNgReserveListBackColorButton;
        private System.Windows.Forms.Label partialReserveListBackColorLabel;
        private System.Windows.Forms.TextBox partialReserveListBackColorTextBox;
        private System.Windows.Forms.Button selectPartialReserveListBackColorButton;
        private System.Windows.Forms.Label okReserveListBackColorLabel;
        private System.Windows.Forms.TextBox okReserveListBackColorTextBox;
        private System.Windows.Forms.Button selectOkReserveListBackColorButton;
        private System.Windows.Forms.ListView previewListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label foreColorLabel;
        private System.Windows.Forms.TextBox foreColorTextBox;
        private System.Windows.Forms.Button selectForeColorButton;
        private System.Windows.Forms.Label listBackColorLabel;
        private System.Windows.Forms.TextBox listBackColorTextBox;
        private System.Windows.Forms.Button selectListBackColorButton;
        private System.Windows.Forms.Panel previewFormPanel;
        private System.Windows.Forms.Label formBackColorLabel;
        private System.Windows.Forms.TextBox formBackColorTextBox;
        private System.Windows.Forms.Button selectFormBackColorButton;
        private System.Windows.Forms.TabPage contextMenuFontColorTabPage;
        private System.Windows.Forms.Label ngReserveMenuBackColorLabel;
        private System.Windows.Forms.TextBox ngReserveMenuBackColorTextBox;
        private System.Windows.Forms.Button selectNgReserveMenuBackColorButton;
        private System.Windows.Forms.Label partialReserveMenuBackColorLabel;
        private System.Windows.Forms.TextBox partialReserveMenuBackColorTextBox;
        private System.Windows.Forms.Button selectPartialReserveMenuBackColorButton;
        private System.Windows.Forms.Label okReserveMenuBackColorLabel;
        private System.Windows.Forms.TextBox okReserveMenuBackColorTextBox;
        private System.Windows.Forms.Button selectOkReserveMenuBackColorButton;
        private System.Windows.Forms.ListView previewMenuListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label menuBackColorLabel;
        private System.Windows.Forms.TextBox menuBackColorTextBox;
        private System.Windows.Forms.Button selectMenuBackColorButton;
        private System.Windows.Forms.Label menuFontLabel;
        private System.Windows.Forms.TextBox menuFontTextBox;
        private System.Windows.Forms.Button selectMenuFontButton;
    }
}