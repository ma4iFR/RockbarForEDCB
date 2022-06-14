namespace RockbarForEDCB
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "test",
            "test",
            "test"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serviceListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serviceTabControl = new System.Windows.Forms.TabControl();
            this.allTabPage = new System.Windows.Forms.TabPage();
            this.dttvTabPage = new System.Windows.Forms.TabPage();
            this.bsTabPage = new System.Windows.Forms.TabPage();
            this.csTabPage = new System.Windows.Forms.TabPage();
            this.favoriteTabPage = new System.Windows.Forms.TabPage();
            this.tunerListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.filteringLabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.taskTrayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listContextMenuStrip.SuspendLayout();
            this.serviceTabControl.SuspendLayout();
            this.taskTrayContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceListView
            // 
            this.serviceListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.serviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.serviceListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.serviceListView.FullRowSelect = true;
            this.serviceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.serviceListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.serviceListView.Location = new System.Drawing.Point(0, 0);
            this.serviceListView.MultiSelect = false;
            this.serviceListView.Name = "serviceListView";
            this.serviceListView.ShowItemToolTips = true;
            this.serviceListView.Size = new System.Drawing.Size(467, 194);
            this.serviceListView.TabIndex = 0;
            this.serviceListView.UseCompatibleStateImageBehavior = false;
            this.serviceListView.View = System.Windows.Forms.View.Details;
            this.serviceListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.serviceListView_MouseClick);
            this.serviceListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.serviceListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 27;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 24;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 300;
            // 
            // listContextMenuStrip
            // 
            this.listContextMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaToolStripMenuItem});
            this.listContextMenuStrip.Name = "contextMenuStrip1";
            this.listContextMenuStrip.Size = new System.Drawing.Size(93, 26);
            // 
            // aaaToolStripMenuItem
            // 
            this.aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
            this.aaaToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.aaaToolStripMenuItem.Text = "aaa";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // serviceTabControl
            // 
            this.serviceTabControl.Controls.Add(this.allTabPage);
            this.serviceTabControl.Controls.Add(this.dttvTabPage);
            this.serviceTabControl.Controls.Add(this.bsTabPage);
            this.serviceTabControl.Controls.Add(this.csTabPage);
            this.serviceTabControl.Controls.Add(this.favoriteTabPage);
            this.serviceTabControl.Location = new System.Drawing.Point(8, 10);
            this.serviceTabControl.Name = "serviceTabControl";
            this.serviceTabControl.SelectedIndex = 0;
            this.serviceTabControl.Size = new System.Drawing.Size(245, 20);
            this.serviceTabControl.TabIndex = 1;
            this.serviceTabControl.SelectedIndexChanged += new System.EventHandler(this.serviceTabControl_SelectedIndexChanged);
            // 
            // allTabPage
            // 
            this.allTabPage.Location = new System.Drawing.Point(4, 22);
            this.allTabPage.Name = "allTabPage";
            this.allTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allTabPage.Size = new System.Drawing.Size(237, 0);
            this.allTabPage.TabIndex = 0;
            this.allTabPage.Text = "全て";
            this.allTabPage.UseVisualStyleBackColor = true;
            // 
            // dttvTabPage
            // 
            this.dttvTabPage.Location = new System.Drawing.Point(4, 22);
            this.dttvTabPage.Name = "dttvTabPage";
            this.dttvTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dttvTabPage.Size = new System.Drawing.Size(237, 0);
            this.dttvTabPage.TabIndex = 1;
            this.dttvTabPage.Text = "地デジ";
            this.dttvTabPage.UseVisualStyleBackColor = true;
            // 
            // bsTabPage
            // 
            this.bsTabPage.Location = new System.Drawing.Point(4, 22);
            this.bsTabPage.Name = "bsTabPage";
            this.bsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bsTabPage.Size = new System.Drawing.Size(237, 0);
            this.bsTabPage.TabIndex = 2;
            this.bsTabPage.Text = "BS";
            this.bsTabPage.UseVisualStyleBackColor = true;
            // 
            // csTabPage
            // 
            this.csTabPage.Location = new System.Drawing.Point(4, 22);
            this.csTabPage.Name = "csTabPage";
            this.csTabPage.Size = new System.Drawing.Size(237, 0);
            this.csTabPage.TabIndex = 3;
            this.csTabPage.Text = "CS";
            this.csTabPage.UseVisualStyleBackColor = true;
            // 
            // favoriteTabPage
            // 
            this.favoriteTabPage.Location = new System.Drawing.Point(4, 22);
            this.favoriteTabPage.Name = "favoriteTabPage";
            this.favoriteTabPage.Size = new System.Drawing.Size(237, 0);
            this.favoriteTabPage.TabIndex = 4;
            this.favoriteTabPage.Text = "お気に入り";
            this.favoriteTabPage.UseVisualStyleBackColor = true;
            // 
            // tunerListView
            // 
            this.tunerListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tunerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.tunerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tunerListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.tunerListView.FullRowSelect = true;
            this.tunerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.tunerListView.Location = new System.Drawing.Point(0, 0);
            this.tunerListView.MultiSelect = false;
            this.tunerListView.Name = "tunerListView";
            this.tunerListView.ShowItemToolTips = true;
            this.tunerListView.Size = new System.Drawing.Size(260, 194);
            this.tunerListView.TabIndex = 2;
            this.tunerListView.UseCompatibleStateImageBehavior = false;
            this.tunerListView.View = System.Windows.Forms.View.Details;
            this.tunerListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tunerListView_MouseClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 130;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(298, 8);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(128, 19);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTextBox_KeyDown);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(480, 6);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(47, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(715, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // filteringLabel
            // 
            this.filteringLabel.AutoSize = true;
            this.filteringLabel.ForeColor = System.Drawing.Color.Red;
            this.filteringLabel.Location = new System.Drawing.Point(247, 11);
            this.filteringLabel.Name = "filteringLabel";
            this.filteringLabel.Size = new System.Drawing.Size(50, 12);
            this.filteringLabel.TabIndex = 7;
            this.filteringLabel.Text = "フィルタ中";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(432, 6);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(47, 23);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingButton.Location = new System.Drawing.Point(689, 7);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(24, 23);
            this.settingButton.TabIndex = 6;
            this.settingButton.Text = "設";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.taskTrayContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Rockbar for EDCB";
            this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDown);
            // 
            // taskTrayContextMenuStrip
            // 
            this.taskTrayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.taskTrayContextMenuStrip.Name = "taskTrayContextMenuStrip";
            this.taskTrayContextMenuStrip.Size = new System.Drawing.Size(99, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.closeToolStripMenuItem.Text = "終了";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(8, 32);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.serviceListView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tunerListView);
            this.splitContainer.Size = new System.Drawing.Size(731, 194);
            this.splitContainer.SplitterDistance = 467;
            this.splitContainer.TabIndex = 11;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(216)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(746, 233);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filteringLabel);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.serviceTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 100);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "RockbarForEDCB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.listContextMenuStrip.ResumeLayout(false);
            this.serviceTabControl.ResumeLayout(false);
            this.taskTrayContextMenuStrip.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView serviceListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip listContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aaaToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl serviceTabControl;
        private System.Windows.Forms.TabPage dttvTabPage;
        private System.Windows.Forms.TabPage bsTabPage;
        private System.Windows.Forms.TabPage csTabPage;
        private System.Windows.Forms.TabPage favoriteTabPage;
        private System.Windows.Forms.ListView tunerListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage allTabPage;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label filteringLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip taskTrayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}

