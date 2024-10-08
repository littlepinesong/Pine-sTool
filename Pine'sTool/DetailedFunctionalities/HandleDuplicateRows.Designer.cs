namespace Pine_sTool.DetailedFunctionalities
{
    partial class HandleDuplicateRows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandleDuplicateRows));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.FilteredGridControl = new DevExpress.XtraGrid.GridControl();
            this.FilteredGgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OriginGridControl = new DevExpress.XtraGrid.GridControl();
            this.OriginGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SearchMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredGgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.FilteredGridControl);
            this.layoutControl1.Controls.Add(this.OriginGridControl);
            this.layoutControl1.Controls.Add(this.SearchMemoEdit);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FilteredGridControl
            // 
            resources.ApplyResources(this.FilteredGridControl, "FilteredGridControl");
            this.FilteredGridControl.MainView = this.FilteredGgridView;
            this.FilteredGridControl.Name = "FilteredGridControl";
            this.FilteredGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.FilteredGgridView});
            // 
            // FilteredGgridView
            // 
            this.FilteredGgridView.GridControl = this.FilteredGridControl;
            this.FilteredGgridView.Name = "FilteredGgridView";
            this.FilteredGgridView.OptionsView.ShowGroupPanel = false;
            // 
            // OriginGridControl
            // 
            resources.ApplyResources(this.OriginGridControl, "OriginGridControl");
            this.OriginGridControl.MainView = this.OriginGridView;
            this.OriginGridControl.Name = "OriginGridControl";
            this.OriginGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OriginGridView});
            // 
            // OriginGridView
            // 
            this.OriginGridView.GridControl = this.OriginGridControl;
            this.OriginGridView.Name = "OriginGridView";
            this.OriginGridView.OptionsView.ShowGroupPanel = false;
            // 
            // SearchMemoEdit
            // 
            resources.ApplyResources(this.SearchMemoEdit, "SearchMemoEdit");
            this.SearchMemoEdit.Name = "SearchMemoEdit";
            this.SearchMemoEdit.StyleController = this.layoutControl1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(977, 727);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.SearchMemoEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(957, 178);
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.OriginGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 204);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(464, 503);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.FilteredGridControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(464, 204);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(493, 503);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 178);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(957, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // HandleDuplicateRows
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "HandleDuplicateRows";
            this.Load += new System.EventHandler(this.HandleDuplicateRows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilteredGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredGgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl FilteredGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView FilteredGgridView;
        private DevExpress.XtraGrid.GridControl OriginGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView OriginGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.MemoEdit SearchMemoEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}