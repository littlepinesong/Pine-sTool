using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pine_sTool.DetailedFunctionalities
{
    /// <summary>
    /// 进程控制工具
    /// </summary>
    public partial class ProcessControl : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ControlPanelMessage(string message);
        public event ControlPanelMessage ShowMessage;
        Process[] myProcess;
        DataTable dgvProcessTable = new DataTable();
        public ProcessControl()
        {
            InitializeComponent();
        }

        private void ProcessControl_Load(object sender, EventArgs e)
        {
            ShowMessage("启动：进程控制器");
            dgvProcessTable.Columns.AddRange(new DataColumn[] { new DataColumn("进程ID", typeof(string)), new DataColumn("进程名称", typeof(string)) });
        }

        private void GetAllProcessSimpleButton_Click(object sender, EventArgs e)
        {
            myProcess = Process.GetProcesses();
            OutProcess();
        }

        private void OutProcess()
        {
            dgvProcessTable.Clear();
            foreach (Process p in myProcess)
            {
                DataRow row = dgvProcessTable.Rows.Add();
                row["进程ID"] = p.Id.ToString();
                row["进程名称"] = p.ProcessName.ToString();
            }
            ProcessGridControl.DataSource = dgvProcessTable;
        }

        private void ProcessGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = ProcessGridView.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //获取光标所在列
                string mouseColumn = ProcessGridView.FocusedColumn.FieldName.ToString();
                //判断光标是否在行和指定列
                #region 双击路径
                if (hInfo.InRow && mouseColumn == "TempArchiveFolderPath")
                {
                    //取得选定行信息
                    string path = ProcessGridView.GetRowCellValue(ProcessGridView.FocusedRowHandle, "TempArchiveFolderPath").ToString();
                    //打开所在文件夹
                    try
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                #endregion
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessControl));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.GetAllProcessSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProcessGridControl = new DevExpress.XtraGrid.GridControl();
            this.ProcessGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.GetAllProcessSimpleButton);
            this.dataLayoutControl1.Controls.Add(this.ProcessGridControl);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1375, 518, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1102, 761);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // GetAllProcessSimpleButton
            // 
            this.GetAllProcessSimpleButton.Location = new System.Drawing.Point(12, 12);
            this.GetAllProcessSimpleButton.Name = "GetAllProcessSimpleButton";
            this.GetAllProcessSimpleButton.Size = new System.Drawing.Size(1078, 22);
            this.GetAllProcessSimpleButton.StyleController = this.dataLayoutControl1;
            this.GetAllProcessSimpleButton.TabIndex = 5;
            this.GetAllProcessSimpleButton.Text = "获取所有进程";
            this.GetAllProcessSimpleButton.Click += new System.EventHandler(this.GetAllProcessSimpleButton_Click);
            // 
            // ProcessGridControl
            // 
            this.ProcessGridControl.Location = new System.Drawing.Point(12, 38);
            this.ProcessGridControl.MainView = this.ProcessGridView;
            this.ProcessGridControl.Name = "ProcessGridControl";
            this.ProcessGridControl.Size = new System.Drawing.Size(1078, 711);
            this.ProcessGridControl.TabIndex = 4;
            this.ProcessGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProcessGridView});
            this.ProcessGridControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcessGridControl_MouseDown);
            // 
            // ProcessGridView
            // 
            this.ProcessGridView.GridControl = this.ProcessGridControl;
            this.ProcessGridView.Name = "ProcessGridView";
            this.ProcessGridView.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1102, 761);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ProcessGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1082, 715);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.GetAllProcessSimpleButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1082, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ProcessControl
            // 
            this.ClientSize = new System.Drawing.Size(1102, 761);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进程控制";
            this.Load += new System.EventHandler(this.ProcessControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl ProcessGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ProcessGridView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton GetAllProcessSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;        
    }
}
