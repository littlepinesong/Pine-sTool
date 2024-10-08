namespace MoveAndClickMouse
{
    partial class rotationPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rotationPrint));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.RandomPrintBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ClickBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.IPandHostNameBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.AuxiliaryToolsBarListItem = new DevExpress.XtraBars.BarListItem();
            this.TestBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ApplicationTestBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MessageListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControl1);
            this.barManager.DockControls.Add(this.barDockControl2);
            this.barManager.DockControls.Add(this.barDockControl3);
            this.barManager.DockControls.Add(this.barDockControl4);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RandomPrintBarButtonItem,
            this.ClickBarButtonItem,
            this.IPandHostNameBarButtonItem,
            this.AuxiliaryToolsBarListItem,
            this.barButtonItem2,
            this.TestBarButtonItem,
            this.ApplicationTestBarButtonItem});
            this.barManager.MainMenu = this.bar1;
            this.barManager.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(345, 139);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.RandomPrintBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ClickBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.IPandHostNameBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.AuxiliaryToolsBarListItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.TestBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.ApplicationTestBarButtonItem, "应用程序测试按钮", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawSizeGrip = true;
            this.bar1.OptionsBar.MinHeight = 32;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // RandomPrintBarButtonItem
            // 
            this.RandomPrintBarButtonItem.Caption = "打印";
            this.RandomPrintBarButtonItem.Id = 0;
            this.RandomPrintBarButtonItem.ImageOptions.Image = global::MoveAndClickMouse.Properties.Resources.printernetwork_32x32;
            this.RandomPrintBarButtonItem.ImageOptions.LargeImage = global::MoveAndClickMouse.Properties.Resources.printernetwork_32x32;
            this.RandomPrintBarButtonItem.Name = "RandomPrintBarButtonItem";
            this.RandomPrintBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ClickBarButtonItem
            // 
            this.ClickBarButtonItem.Caption = "自动点击";
            this.ClickBarButtonItem.Id = 1;
            this.ClickBarButtonItem.ImageOptions.Image = global::MoveAndClickMouse.Properties.Resources.pointer_32x32;
            this.ClickBarButtonItem.ImageOptions.LargeImage = global::MoveAndClickMouse.Properties.Resources.pointer_32x32;
            this.ClickBarButtonItem.Name = "ClickBarButtonItem";
            this.ClickBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // IPandHostNameBarButtonItem
            // 
            this.IPandHostNameBarButtonItem.Caption = "IP/主机名";
            this.IPandHostNameBarButtonItem.Id = 2;
            this.IPandHostNameBarButtonItem.ImageOptions.Image = global::MoveAndClickMouse.Properties.Resources.operatingsystem_32x32;
            this.IPandHostNameBarButtonItem.ImageOptions.LargeImage = global::MoveAndClickMouse.Properties.Resources.operatingsystem_32x32;
            this.IPandHostNameBarButtonItem.Name = "IPandHostNameBarButtonItem";
            this.IPandHostNameBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.IPandHostNameBarButtonItem_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageOptions.Image = global::MoveAndClickMouse.Properties.Resources.solution_32x32;
            this.barButtonItem2.ImageOptions.LargeImage = global::MoveAndClickMouse.Properties.Resources.solution_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // AuxiliaryToolsBarListItem
            // 
            this.AuxiliaryToolsBarListItem.Caption = "辅助工具";
            this.AuxiliaryToolsBarListItem.Id = 3;
            this.AuxiliaryToolsBarListItem.ImageOptions.Image = global::MoveAndClickMouse.Properties.Resources.listbullets_32x32;
            this.AuxiliaryToolsBarListItem.ImageOptions.LargeImage = global::MoveAndClickMouse.Properties.Resources.listbullets_32x32;
            this.AuxiliaryToolsBarListItem.Name = "AuxiliaryToolsBarListItem";
            this.AuxiliaryToolsBarListItem.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.AuxiliaryToolsBarListItem_ListItemClick);
            // 
            // TestBarButtonItem
            // 
            this.TestBarButtonItem.Caption = "测试按钮";
            this.TestBarButtonItem.Id = 5;
            this.TestBarButtonItem.ImageOptions.Image = global::MoveAndClickMouse.Properties.Resources.showtestreport_32x32;
            this.TestBarButtonItem.ImageOptions.LargeImage = global::MoveAndClickMouse.Properties.Resources.showtestreport_32x32;
            this.TestBarButtonItem.Name = "TestBarButtonItem";
            this.TestBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TestBarButtonItem_ItemClick);
            // 
            // ApplicationTestBarButtonItem
            // 
            this.ApplicationTestBarButtonItem.Caption = "应用程序测试按钮";
            this.ApplicationTestBarButtonItem.Id = 6;
            this.ApplicationTestBarButtonItem.ImageOptions.Image = global::MoveAndClickMouse.Properties.Resources.sortdialog_32x32;
            this.ApplicationTestBarButtonItem.ImageOptions.LargeImage = global::MoveAndClickMouse.Properties.Resources.sortdialog_32x32;
            this.ApplicationTestBarButtonItem.Name = "ApplicationTestBarButtonItem";
            this.ApplicationTestBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ApplicationTestBarButtonItem_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Size = new System.Drawing.Size(1598, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 893);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(1598, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 853);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1598, 40);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 853);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "工作面板";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // MessageListBoxControl
            // 
            this.MessageListBoxControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageListBoxControl.Location = new System.Drawing.Point(0, 403);
            this.MessageListBoxControl.Name = "MessageListBoxControl";
            this.MessageListBoxControl.Size = new System.Drawing.Size(1598, 490);
            this.MessageListBoxControl.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1598, 363);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "MainLayoutControl";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1598, 363);
            this.Root.TextVisible = false;
            // 
            // rotationPrint
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1598, 893);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.MessageListBoxControl);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.HtmlText = "工作面板";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "rotationPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.rotationPrint_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rotationPrint_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rotationPrint_KeyPress);
            this.Resize += new System.EventHandler(this.rotationPrint_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem RandomPrintBarButtonItem;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarButtonItem ClickBarButtonItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraBars.BarButtonItem IPandHostNameBarButtonItem;
        private DevExpress.XtraEditors.ListBoxControl MessageListBoxControl;
        private DevExpress.XtraBars.BarListItem AuxiliaryToolsBarListItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem TestBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ApplicationTestBarButtonItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
    }
}