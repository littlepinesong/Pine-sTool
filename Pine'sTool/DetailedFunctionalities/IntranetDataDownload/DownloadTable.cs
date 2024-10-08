using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Maticsoft.DBUtility;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.Diagnostics;

namespace Pine_sTool.DetailedFunctionalities.IntranetDataDownload
{
    public partial class DownloadTable : DevExpress.XtraEditors.XtraForm
    {
        public static DbHelperSQLP DbHelperSQL_data = new DbHelperSQLP("server=192.168.10.203;database=hbcshdb;user=cshadmin;pwd=57Ki)j9-");//连接数据库
        string _th = "";
        string _sch = "";
        public DownloadTable(string th = "", string sch = "")
        {
            InitializeComponent();
            UpdateByDrawNumberSimpleButton.Enabled = false;
            if (th == "")
            {
                th = DateTime.Now.Year.ToString();
            }
            else
            {
                UpdateByDrawNumberSimpleButton.Enabled = true;
            }
            _th = th;
            _sch = sch;
        }

        private void DownloadTable_Load(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            try
            {
                System.Diagnostics.Debug.WriteLine(",CustomizeHelper ApplyCustomization ReadCustomization start--------用时-" + (DateTime.Now - start).ToString());//DateTime start = DateTime.Now;

                TBEAHB.Controls.CustomizeHelper.CustomizeAll(this, new TBEAHB.Controls.CustomizeHelper.UserCustomizeSetting()
                {
                    GridColumnCellHAligment = HorzAlignment.Near,
                    GridViewIndicatorWidth = 50,
                    //SavingFunction = () => { this.btnSave.PerformClick(); }
                });
                System.Diagnostics.Debug.WriteLine(",1CustomizeHelper ApplyCustomization ReadCustomization" + ",用时" + (DateTime.Now - start).ToString());//DateTime start = DateTime.Now;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("DownloadTable,CustomizeAll" + ex.Message);
            }

            loadDataTable();
        }

        private void loadDataTable()
        {
            // 假设 gridControl 是你的 GridControl 控件实例，view 是对应的 GridView
            //GridView view = gc.MainView as GridView;

            //// 添加一个行号列
            //GridColumn rowNumberColumn = gv.Columns.AddVisible("RowNumber", "No.");
            //rowNumberColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            //rowNumberColumn.VisibleIndex = 0;

            //// 自动编号行号
            gv.CustomDrawRowIndicator += (sender, e) =>
            {
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            };


            ServerChoeseComboBoxEdit.Properties.Items.Add(@"\\192.168.10.201\");
            ServerChoeseComboBoxEdit.Properties.Items.Add(@"\\192.168.10.202\");
            ServerChoeseComboBoxEdit.Properties.Items.Add(@"\\192.168.10.203\");
            ServerChoeseComboBoxEdit.Properties.Items.Add(@"\\192.168.10.204\");
            ServerChoeseComboBoxEdit.Properties.Items.Add(@"\\192.168.10.205\");
            ServerChoeseComboBoxEdit.Properties.Items.Add(@"\\192.168.10.206\");
            ServerChoeseComboBoxEdit.Properties.Items.Add(@"\\192.168.10.207\");
            ServerChoeseComboBoxEdit.Properties.Items.Add(@"\\192.168.10.208\");

            StringBuilder varname1 = new StringBuilder();
            varname1.Append("SELECT [index] \n");
            varname1.Append("      ,[lot_no] \n");
            varname1.Append("      ,[draw_no] \n");
            varname1.Append("      ,[PartName] \n");
            varname1.Append("      ,[fileSum] \n");
            varname1.Append("      ,[PartPath] \n");
            varname1.Append("      ,[rmk] \n");
            varname1.Append("      ,[cust_nm_full] \n");
            varname1.Append("      ,[ISRT_DT] \n");
            varname1.Append("      ,[supy_nm] \n");
            varname1.Append("      ,[rowSelected] \n");
            varname1.Append("      ,[item_nm] \n");
            varname1.Append("      ,[FIN_FLAG] \n");
            varname1.Append("      ,[type] \n");
            varname1.Append("      ,[id] \n");
            varname1.Append("      ,[ISRT_EMP_NO] \n");
            varname1.Append("      ,[plan_no] \n");
            varname1.Append("      ,[RelativePath] \n");
            varname1.Append("  FROM [hb_Auto_Mng].[dbo].[View_PT_IntranetLeaveFactory]");
            if (_th != "" && _th != DateTime.Now.Year.ToString())
            {
                varname1.Append($"  where draw_no like '%{_th}%'");
            }
            if (_th == DateTime.Now.Year.ToString())
            {
                varname1.Append($"  where ISRT_DT like '%{_th}%'");
            }
            varname1.Append($"   order by [ISRT_DT] desc, [index]");
            try
            {
                gc.DataSource = DbHelperSQL_data.Query(varname1.ToString()).Tables[0];
            }
            catch (Exception)
            {

            }
            DataTable table = (DataTable)gc.DataSource;
            int count = 0;
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    count += int.Parse(row["fileSum"].ToString());
                }
            }
            catch (Exception)
            { }
            if (_th != "" && _th != DateTime.Now.Year.ToString())
            {
                labelControl1.Text = $"图号{_th}包含{count}份出厂资料文件";
            }
            else if (_th == DateTime.Now.Year.ToString())
            {
                labelControl1.Text = $"{_th}年内包含{count}份出厂资料文件";
            }
            else
            {
                labelControl1.Text = $"包含{count}份出厂资料文件";
            }
        }

        private void ReloadSimpleButton_Click(object sender, EventArgs e)
        {
            loadDataTable();
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            //获取光标所在列
            string mouseColumn = gv.FocusedColumn.FieldName.ToString();
            //判断光标是否在行和指定列
            #region 双击路径
            //if (mouseColumn == "PartPath"||mouseColumn== "RelativePath")
            {
                //取得选定行信息
                string path = gv.GetRowCellValue(gv.FocusedRowHandle, "PartPath").ToString();
                //打开所在文件夹
                try
                {
                    System.Diagnostics.Process.Start(path);
                }
                catch (Exception ex)
                {
                    try
                    {
                        //取得选定行信息
                        path = Path.Combine(ServerChoeseComboBoxEdit.EditValue.ToString(), gv.GetRowCellValue(gv.FocusedRowHandle, "RelativePath").ToString());
                        System.Diagnostics.Process.Start(path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("目标路径已移动或删除\r\n" + ex.ToString());
                    }
                }
            }
            #endregion
        }

        private void ShowAllSimpleButton_Click(object sender, EventArgs e)
        {
            _th = "";
            loadDataTable();
        }

        Dictionary<string, string> DataConfig = new Dictionary<string, string>();
        private void UpdateByDrawNumberSimpleButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Sch = _sch;
            Properties.Settings.Default.DrawingNumber = _th;
            PythonConfig pythonConfig = new PythonConfig("SingleDrawUpdate");
            pythonConfig.Show();
            loadDataTable();
        }
    }
}