namespace Pine_sTool.DetailedFunctionalities.IntranetDataDownload
{
    partial class DownloadTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadTable));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.UpdateByDrawNumberSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ShowAllSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ServerChoeseComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ReloadSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lot_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.draw_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fileSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rmk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cust_nm_full = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISRT_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.supy_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rowSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.item_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIN_FLAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISRT_EMP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plan_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RelativePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerChoeseComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.UpdateByDrawNumberSimpleButton);
            this.layoutControl1.Controls.Add(this.ShowAllSimpleButton);
            this.layoutControl1.Controls.Add(this.ServerChoeseComboBoxEdit);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.ReloadSimpleButton);
            this.layoutControl1.Controls.Add(this.gc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1669, 923);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // UpdateByDrawNumberSimpleButton
            // 
            this.UpdateByDrawNumberSimpleButton.Location = new System.Drawing.Point(445, 12);
            this.UpdateByDrawNumberSimpleButton.Name = "UpdateByDrawNumberSimpleButton";
            this.UpdateByDrawNumberSimpleButton.Size = new System.Drawing.Size(93, 22);
            this.UpdateByDrawNumberSimpleButton.StyleController = this.layoutControl1;
            this.UpdateByDrawNumberSimpleButton.TabIndex = 9;
            this.UpdateByDrawNumberSimpleButton.Text = "按当前图号更新";
            this.UpdateByDrawNumberSimpleButton.Click += new System.EventHandler(this.UpdateByDrawNumberSimpleButton_Click);
            // 
            // ShowAllSimpleButton
            // 
            this.ShowAllSimpleButton.Location = new System.Drawing.Point(542, 12);
            this.ShowAllSimpleButton.Name = "ShowAllSimpleButton";
            this.ShowAllSimpleButton.Size = new System.Drawing.Size(81, 22);
            this.ShowAllSimpleButton.StyleController = this.layoutControl1;
            this.ShowAllSimpleButton.TabIndex = 8;
            this.ShowAllSimpleButton.Text = "显示所有数据";
            this.ShowAllSimpleButton.Click += new System.EventHandler(this.ShowAllSimpleButton_Click);
            // 
            // ServerChoeseComboBoxEdit
            // 
            this.ServerChoeseComboBoxEdit.EditValue = "\\\\192.168.10.202\\";
            this.ServerChoeseComboBoxEdit.Location = new System.Drawing.Point(175, 12);
            this.ServerChoeseComboBoxEdit.Name = "ServerChoeseComboBoxEdit";
            this.ServerChoeseComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ServerChoeseComboBoxEdit.Properties.ReadOnly = true;
            this.ServerChoeseComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ServerChoeseComboBoxEdit.Size = new System.Drawing.Size(186, 20);
            this.ServerChoeseComboBoxEdit.StyleController = this.layoutControl1;
            this.ServerChoeseComboBoxEdit.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(373, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "labelControl1";
            // 
            // ReloadSimpleButton
            // 
            this.ReloadSimpleButton.Location = new System.Drawing.Point(12, 12);
            this.ReloadSimpleButton.Name = "ReloadSimpleButton";
            this.ReloadSimpleButton.Size = new System.Drawing.Size(86, 22);
            this.ReloadSimpleButton.StyleController = this.layoutControl1;
            this.ReloadSimpleButton.TabIndex = 5;
            this.ReloadSimpleButton.Text = "刷新";
            this.ReloadSimpleButton.Click += new System.EventHandler(this.ReloadSimpleButton_Click);
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(12, 38);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(1645, 873);
            this.gc.TabIndex = 4;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.index,
            this.lot_no,
            this.draw_no,
            this.PartName,
            this.fileSum,
            this.PartPath,
            this.rmk,
            this.cust_nm_full,
            this.ISRT_DT,
            this.supy_nm,
            this.rowSelected,
            this.item_nm,
            this.FIN_FLAG,
            this.type,
            this.id,
            this.ISRT_EMP_NO,
            this.plan_no,
            this.RelativePath});
            this.gv.GridControl = this.gc;
            this.gv.IndicatorWidth = 60;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.ReadOnly = true;
            this.gv.OptionsFind.AlwaysVisible = true;
            this.gv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.DoubleClick += new System.EventHandler(this.gv_DoubleClick);
            // 
            // index
            // 
            this.index.Caption = "索引";
            this.index.FieldName = "index";
            this.index.Name = "index";
            this.index.OptionsColumn.AllowEdit = false;
            this.index.Visible = true;
            this.index.VisibleIndex = 0;
            this.index.Width = 60;
            // 
            // lot_no
            // 
            this.lot_no.Caption = "出厂序号";
            this.lot_no.FieldName = "lot_no";
            this.lot_no.Name = "lot_no";
            this.lot_no.OptionsColumn.AllowEdit = false;
            this.lot_no.Visible = true;
            this.lot_no.VisibleIndex = 1;
            this.lot_no.Width = 121;
            // 
            // draw_no
            // 
            this.draw_no.Caption = "图号";
            this.draw_no.FieldName = "draw_no";
            this.draw_no.Name = "draw_no";
            this.draw_no.OptionsColumn.AllowEdit = false;
            this.draw_no.Visible = true;
            this.draw_no.VisibleIndex = 3;
            this.draw_no.Width = 155;
            // 
            // PartName
            // 
            this.PartName.Caption = "部件名";
            this.PartName.FieldName = "PartName";
            this.PartName.Name = "PartName";
            this.PartName.OptionsColumn.AllowEdit = false;
            this.PartName.Visible = true;
            this.PartName.VisibleIndex = 4;
            this.PartName.Width = 283;
            // 
            // fileSum
            // 
            this.fileSum.Caption = "文件量";
            this.fileSum.FieldName = "fileSum";
            this.fileSum.Name = "fileSum";
            this.fileSum.OptionsColumn.AllowEdit = false;
            this.fileSum.Visible = true;
            this.fileSum.VisibleIndex = 5;
            this.fileSum.Width = 57;
            // 
            // PartPath
            // 
            this.PartPath.Caption = "服务器位置";
            this.PartPath.FieldName = "PartPath";
            this.PartPath.Name = "PartPath";
            this.PartPath.OptionsColumn.AllowEdit = false;
            this.PartPath.Width = 83;
            // 
            // rmk
            // 
            this.rmk.Caption = "rmk";
            this.rmk.FieldName = "rmk";
            this.rmk.Name = "rmk";
            this.rmk.OptionsColumn.AllowEdit = false;
            // 
            // cust_nm_full
            // 
            this.cust_nm_full.Caption = "目标单位";
            this.cust_nm_full.FieldName = "cust_nm_full";
            this.cust_nm_full.Name = "cust_nm_full";
            this.cust_nm_full.OptionsColumn.AllowEdit = false;
            this.cust_nm_full.Width = 90;
            // 
            // ISRT_DT
            // 
            this.ISRT_DT.Caption = "登记时间";
            this.ISRT_DT.FieldName = "ISRT_DT";
            this.ISRT_DT.Name = "ISRT_DT";
            this.ISRT_DT.OptionsColumn.AllowEdit = false;
            this.ISRT_DT.Visible = true;
            this.ISRT_DT.VisibleIndex = 6;
            this.ISRT_DT.Width = 220;
            // 
            // supy_nm
            // 
            this.supy_nm.Caption = "supy_nm";
            this.supy_nm.FieldName = "supy_nm";
            this.supy_nm.Name = "supy_nm";
            this.supy_nm.OptionsColumn.AllowEdit = false;
            // 
            // rowSelected
            // 
            this.rowSelected.Caption = "rowSelected";
            this.rowSelected.FieldName = "rowSelected";
            this.rowSelected.Name = "rowSelected";
            this.rowSelected.OptionsColumn.AllowEdit = false;
            // 
            // item_nm
            // 
            this.item_nm.Caption = "物件码";
            this.item_nm.FieldName = "item_nm";
            this.item_nm.Name = "item_nm";
            this.item_nm.OptionsColumn.AllowEdit = false;
            this.item_nm.Width = 90;
            // 
            // FIN_FLAG
            // 
            this.FIN_FLAG.Caption = "标识";
            this.FIN_FLAG.FieldName = "FIN_FLAG";
            this.FIN_FLAG.Name = "FIN_FLAG";
            this.FIN_FLAG.OptionsColumn.AllowEdit = false;
            this.FIN_FLAG.Width = 90;
            // 
            // type
            // 
            this.type.Caption = "类别";
            this.type.FieldName = "type";
            this.type.Name = "type";
            this.type.OptionsColumn.AllowEdit = false;
            this.type.Width = 90;
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.Width = 96;
            // 
            // ISRT_EMP_NO
            // 
            this.ISRT_EMP_NO.Caption = "登记人";
            this.ISRT_EMP_NO.FieldName = "ISRT_EMP_NO";
            this.ISRT_EMP_NO.Name = "ISRT_EMP_NO";
            this.ISRT_EMP_NO.OptionsColumn.AllowEdit = false;
            this.ISRT_EMP_NO.Visible = true;
            this.ISRT_EMP_NO.VisibleIndex = 8;
            this.ISRT_EMP_NO.Width = 106;
            // 
            // plan_no
            // 
            this.plan_no.Caption = "生产号";
            this.plan_no.FieldName = "plan_no";
            this.plan_no.Name = "plan_no";
            this.plan_no.OptionsColumn.AllowEdit = false;
            this.plan_no.Visible = true;
            this.plan_no.VisibleIndex = 2;
            this.plan_no.Width = 121;
            // 
            // RelativePath
            // 
            this.RelativePath.Caption = "相对路径";
            this.RelativePath.FieldName = "RelativePath";
            this.RelativePath.Name = "RelativePath";
            this.RelativePath.OptionsColumn.AllowEdit = false;
            this.RelativePath.Visible = true;
            this.RelativePath.VisibleIndex = 7;
            this.RelativePath.Width = 460;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1669, 923);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1649, 877);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ReloadSimpleButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(90, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(615, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1034, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem3.Control = this.labelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(363, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 6, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(70, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(90, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ServerChoeseComboBoxEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(100, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(253, 26);
            this.layoutControlItem4.Text = "选择服务器";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(353, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ShowAllSimpleButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(530, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(85, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.UpdateByDrawNumberSimpleButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(433, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // DownloadTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 923);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出厂资料下载表";
            this.Load += new System.EventHandler(this.DownloadTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServerChoeseComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton ReloadSimpleButton;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraGrid.Columns.GridColumn index;
        private DevExpress.XtraGrid.Columns.GridColumn lot_no;
        private DevExpress.XtraGrid.Columns.GridColumn draw_no;
        private DevExpress.XtraGrid.Columns.GridColumn PartName;
        private DevExpress.XtraGrid.Columns.GridColumn fileSum;
        private DevExpress.XtraGrid.Columns.GridColumn PartPath;
        private DevExpress.XtraGrid.Columns.GridColumn rmk;
        private DevExpress.XtraGrid.Columns.GridColumn cust_nm_full;
        private DevExpress.XtraGrid.Columns.GridColumn ISRT_DT;
        private DevExpress.XtraGrid.Columns.GridColumn supy_nm;
        private DevExpress.XtraGrid.Columns.GridColumn rowSelected;
        private DevExpress.XtraGrid.Columns.GridColumn item_nm;
        private DevExpress.XtraGrid.Columns.GridColumn FIN_FLAG;
        private DevExpress.XtraGrid.Columns.GridColumn type;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn ISRT_EMP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn plan_no;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.ComboBoxEdit ServerChoeseComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.Columns.GridColumn RelativePath;
        private DevExpress.XtraEditors.SimpleButton ShowAllSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton UpdateByDrawNumberSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}