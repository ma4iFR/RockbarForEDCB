
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
            this.otherTabPage = new System.Windows.Forms.TabPage();
            this.colorPreviewLabel = new System.Windows.Forms.Label();
            this.selectForeColorLabel = new System.Windows.Forms.Label();
            this.foreColorTextBox = new System.Windows.Forms.TextBox();
            this.selectForeColorButton = new System.Windows.Forms.Button();
            this.listBackColorLabel = new System.Windows.Forms.Label();
            this.listBackColorTextBox = new System.Windows.Forms.TextBox();
            this.selectListBackColorButton = new System.Windows.Forms.Button();
            this.formBackColorPanel = new System.Windows.Forms.Panel();
            this.listBackColorPanel = new System.Windows.Forms.Panel();
            this.foreColorLabel = new System.Windows.Forms.Label();
            this.formBackColorLabel = new System.Windows.Forms.Label();
            this.formBackColorTextBox = new System.Windows.Forms.TextBox();
            this.selectFormBackColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.isHorizontalSplitCheckBox = new System.Windows.Forms.CheckBox();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.selectFontButton = new System.Windows.Forms.Button();
            this.toggleVisibleTaskTrayIconClickCheckBox = new System.Windows.Forms.CheckBox();
            this.storeTaskTrayByClosingCheckBox = new System.Windows.Forms.CheckBox();
            this.showTaskTraiIconCheckBox = new System.Windows.Forms.CheckBox();
            this.tvtestOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tunerTabPage = new System.Windows.Forms.TabPage();
            this.tunerNameListView = new System.Windows.Forms.ListView();
            this.tunerNameTunerIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tunerNameBonDriverNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tunerNameTunerNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tunerNameTextBox = new System.Windows.Forms.TextBox();
            this.updateTunerNameButton = new System.Windows.Forms.Button();
            this.tunerNameNoteLabel = new System.Windows.Forms.Label();
            this.tunerNameLabel = new System.Windows.Forms.Label();
            this.tunerNameMarkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingTabControl.SuspendLayout();
            this.edcbLinkageTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberNumericUpDown)).BeginInit();
            this.allServiceTabPage.SuspendLayout();
            this.favoriteServiceTabPage.SuspendLayout();
            this.tvtestLinkageTabPage.SuspendLayout();
            this.autoStartTargetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCloseMarginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoOpenMarginNumericUpDown)).BeginInit();
            this.otherTabPage.SuspendLayout();
            this.formBackColorPanel.SuspendLayout();
            this.listBackColorPanel.SuspendLayout();
            this.tunerTabPage.SuspendLayout();
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
            this.webLinkUrlExampleLabel.Size = new System.Drawing.Size(410, 84);
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
            // otherTabPage
            // 
            this.otherTabPage.Controls.Add(this.colorPreviewLabel);
            this.otherTabPage.Controls.Add(this.selectForeColorLabel);
            this.otherTabPage.Controls.Add(this.foreColorTextBox);
            this.otherTabPage.Controls.Add(this.selectForeColorButton);
            this.otherTabPage.Controls.Add(this.listBackColorLabel);
            this.otherTabPage.Controls.Add(this.listBackColorTextBox);
            this.otherTabPage.Controls.Add(this.selectListBackColorButton);
            this.otherTabPage.Controls.Add(this.formBackColorPanel);
            this.otherTabPage.Controls.Add(this.formBackColorLabel);
            this.otherTabPage.Controls.Add(this.formBackColorTextBox);
            this.otherTabPage.Controls.Add(this.selectFormBackColorButton);
            this.otherTabPage.Controls.Add(this.label1);
            this.otherTabPage.Controls.Add(this.isHorizontalSplitCheckBox);
            this.otherTabPage.Controls.Add(this.fontTextBox);
            this.otherTabPage.Controls.Add(this.selectFontButton);
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
            // colorPreviewLabel
            // 
            this.colorPreviewLabel.AutoSize = true;
            this.colorPreviewLabel.Location = new System.Drawing.Point(406, 168);
            this.colorPreviewLabel.Name = "colorPreviewLabel";
            this.colorPreviewLabel.Size = new System.Drawing.Size(49, 12);
            this.colorPreviewLabel.TabIndex = 27;
            this.colorPreviewLabel.Text = "プレビュー";
            // 
            // selectForeColorLabel
            // 
            this.selectForeColorLabel.AutoSize = true;
            this.selectForeColorLabel.Location = new System.Drawing.Point(48, 232);
            this.selectForeColorLabel.Name = "selectForeColorLabel";
            this.selectForeColorLabel.Size = new System.Drawing.Size(41, 12);
            this.selectForeColorLabel.TabIndex = 26;
            this.selectForeColorLabel.Text = "文字色";
            // 
            // foreColorTextBox
            // 
            this.foreColorTextBox.Location = new System.Drawing.Point(100, 229);
            this.foreColorTextBox.Name = "foreColorTextBox";
            this.foreColorTextBox.ReadOnly = true;
            this.foreColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.foreColorTextBox.TabIndex = 25;
            // 
            // selectForeColorButton
            // 
            this.selectForeColorButton.Location = new System.Drawing.Point(242, 227);
            this.selectForeColorButton.Name = "selectForeColorButton";
            this.selectForeColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectForeColorButton.TabIndex = 24;
            this.selectForeColorButton.Text = "選択";
            this.selectForeColorButton.UseVisualStyleBackColor = true;
            this.selectForeColorButton.Click += new System.EventHandler(this.selectForeColorButton_Click);
            // 
            // listBackColorLabel
            // 
            this.listBackColorLabel.AutoSize = true;
            this.listBackColorLabel.Location = new System.Drawing.Point(24, 197);
            this.listBackColorLabel.Name = "listBackColorLabel";
            this.listBackColorLabel.Size = new System.Drawing.Size(65, 12);
            this.listBackColorLabel.TabIndex = 23;
            this.listBackColorLabel.Text = "リスト背景色";
            // 
            // listBackColorTextBox
            // 
            this.listBackColorTextBox.Location = new System.Drawing.Point(100, 194);
            this.listBackColorTextBox.Name = "listBackColorTextBox";
            this.listBackColorTextBox.ReadOnly = true;
            this.listBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.listBackColorTextBox.TabIndex = 22;
            // 
            // selectListBackColorButton
            // 
            this.selectListBackColorButton.Location = new System.Drawing.Point(242, 192);
            this.selectListBackColorButton.Name = "selectListBackColorButton";
            this.selectListBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectListBackColorButton.TabIndex = 21;
            this.selectListBackColorButton.Text = "選択";
            this.selectListBackColorButton.UseVisualStyleBackColor = true;
            this.selectListBackColorButton.Click += new System.EventHandler(this.selectListBackColorButton_Click);
            // 
            // formBackColorPanel
            // 
            this.formBackColorPanel.Controls.Add(this.listBackColorPanel);
            this.formBackColorPanel.Location = new System.Drawing.Point(408, 191);
            this.formBackColorPanel.Name = "formBackColorPanel";
            this.formBackColorPanel.Size = new System.Drawing.Size(129, 39);
            this.formBackColorPanel.TabIndex = 20;
            // 
            // listBackColorPanel
            // 
            this.listBackColorPanel.Controls.Add(this.foreColorLabel);
            this.listBackColorPanel.Location = new System.Drawing.Point(16, 15);
            this.listBackColorPanel.Name = "listBackColorPanel";
            this.listBackColorPanel.Size = new System.Drawing.Size(113, 24);
            this.listBackColorPanel.TabIndex = 21;
            // 
            // foreColorLabel
            // 
            this.foreColorLabel.AutoSize = true;
            this.foreColorLabel.Location = new System.Drawing.Point(4, 5);
            this.foreColorLabel.Name = "foreColorLabel";
            this.foreColorLabel.Size = new System.Drawing.Size(64, 12);
            this.foreColorLabel.TabIndex = 0;
            this.foreColorLabel.Text = "ＮＨＫ総合１";
            // 
            // formBackColorLabel
            // 
            this.formBackColorLabel.AutoSize = true;
            this.formBackColorLabel.Location = new System.Drawing.Point(12, 162);
            this.formBackColorLabel.Name = "formBackColorLabel";
            this.formBackColorLabel.Size = new System.Drawing.Size(77, 12);
            this.formBackColorLabel.TabIndex = 19;
            this.formBackColorLabel.Text = "フォーム背景色";
            // 
            // formBackColorTextBox
            // 
            this.formBackColorTextBox.Location = new System.Drawing.Point(100, 159);
            this.formBackColorTextBox.Name = "formBackColorTextBox";
            this.formBackColorTextBox.ReadOnly = true;
            this.formBackColorTextBox.Size = new System.Drawing.Size(136, 19);
            this.formBackColorTextBox.TabIndex = 18;
            // 
            // selectFormBackColorButton
            // 
            this.selectFormBackColorButton.Location = new System.Drawing.Point(242, 157);
            this.selectFormBackColorButton.Name = "selectFormBackColorButton";
            this.selectFormBackColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectFormBackColorButton.TabIndex = 17;
            this.selectFormBackColorButton.Text = "選択";
            this.selectFormBackColorButton.UseVisualStyleBackColor = true;
            this.selectFormBackColorButton.Click += new System.EventHandler(this.selectFormBackColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "フォント";
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
            // fontTextBox
            // 
            this.fontTextBox.Location = new System.Drawing.Point(100, 121);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.ReadOnly = true;
            this.fontTextBox.Size = new System.Drawing.Size(302, 19);
            this.fontTextBox.TabIndex = 14;
            // 
            // selectFontButton
            // 
            this.selectFontButton.Location = new System.Drawing.Point(408, 119);
            this.selectFontButton.Name = "selectFontButton";
            this.selectFontButton.Size = new System.Drawing.Size(75, 23);
            this.selectFontButton.TabIndex = 13;
            this.selectFontButton.Text = "選択";
            this.selectFontButton.UseVisualStyleBackColor = true;
            this.selectFontButton.Click += new System.EventHandler(this.selectFontButton_Click);
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
            // tunerNameTextBox
            // 
            this.tunerNameTextBox.Location = new System.Drawing.Point(525, 23);
            this.tunerNameTextBox.Name = "tunerNameTextBox";
            this.tunerNameTextBox.Size = new System.Drawing.Size(127, 19);
            this.tunerNameTextBox.TabIndex = 2;
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
            // tunerNameLabel
            // 
            this.tunerNameLabel.AutoSize = true;
            this.tunerNameLabel.Location = new System.Drawing.Point(478, 26);
            this.tunerNameLabel.Name = "tunerNameLabel";
            this.tunerNameLabel.Size = new System.Drawing.Size(41, 12);
            this.tunerNameLabel.TabIndex = 27;
            this.tunerNameLabel.Text = "表示名";
            // 
            // tunerNameMarkColumnHeader
            // 
            this.tunerNameMarkColumnHeader.Text = "";
            this.tunerNameMarkColumnHeader.Width = 20;
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
            this.otherTabPage.ResumeLayout(false);
            this.otherTabPage.PerformLayout();
            this.formBackColorPanel.ResumeLayout(false);
            this.listBackColorPanel.ResumeLayout(false);
            this.listBackColorPanel.PerformLayout();
            this.tunerTabPage.ResumeLayout(false);
            this.tunerTabPage.PerformLayout();
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
        private System.Windows.Forms.Button selectFontButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.CheckBox isHorizontalSplitCheckBox;
        private System.Windows.Forms.Label formBackColorLabel;
        private System.Windows.Forms.TextBox formBackColorTextBox;
        private System.Windows.Forms.Button selectFormBackColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel formBackColorPanel;
        private System.Windows.Forms.Panel listBackColorPanel;
        private System.Windows.Forms.Label foreColorLabel;
        private System.Windows.Forms.Label colorPreviewLabel;
        private System.Windows.Forms.Label selectForeColorLabel;
        private System.Windows.Forms.TextBox foreColorTextBox;
        private System.Windows.Forms.Button selectForeColorButton;
        private System.Windows.Forms.Label listBackColorLabel;
        private System.Windows.Forms.TextBox listBackColorTextBox;
        private System.Windows.Forms.Button selectListBackColorButton;
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
    }
}