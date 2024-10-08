using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maticsoft.DBUtility;
using System.Diagnostics;
using System.Threading;

namespace Pine_sTool.DetailedFunctionalities
{
    public partial class HandleDuplicateRows : DevExpress.XtraEditors.XtraForm
    {
        DataTable originTable = new DataTable();
        DataTable filteredTable = new DataTable();
        public static DbHelperSQLP DbHelperSQL_data = new DbHelperSQLP("server=192.168.10.203;database=hbcshdb;user=cshadmin;pwd=57Ki)j9-");//连接数据库
        public delegate void ControlPanelMessage(string message);
        public event ControlPanelMessage ShowMessage;

        public HandleDuplicateRows()
        {
            InitializeComponent();
        }

        private void HandleDuplicateRows_Load(object sender, EventArgs e)
        {
            //SELECT * FROM [hb_Drawing_Mng].[dbo].[View_sjkz_drawing_drawing_Partflow_IncludeHis] where [flowNodeID] = 5 and th ='1TBC.710.H20055A'  order by SjTime
            SearchMemoEdit.Text = "SELECT  partName FROM [hb_Drawing_Mng].[dbo].[View_sjkz_drawing_drawing_Partflow_IncludeHis] where th ='1TBC.710.H20055A'";

            ShowMessage("启动：约除查询表中重复行");
            ShowMessage($"进程号：{Process.GetCurrentProcess().Id.ToString()}");
            ShowMessage($"线程号：{Thread.CurrentThread.ManagedThreadId.ToString()}");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OriginGridControl.DataSource = null;
            FilteredGridControl.DataSource = null;
            OriginGridView.Columns.Clear();
            FilteredGgridView.Columns.Clear();

            HandleOriginTable();
            HandleFilteredTable();
        }

        private void HandleFilteredTable()
        {
            //对产生的表进行去重操作            
            //使用LINQ查询并保留唯一的行
            var distinctRows = originTable.AsEnumerable().Distinct(DataRowComparer.Default);
            //filteredTable存储筛选结果
            filteredTable = distinctRows.CopyToDataTable();
            FilteredGridControl.DataSource = filteredTable;
        }

        private void HandleOriginTable()
        {
            string sql = SearchMemoEdit.Text;
            //originTable = DevUtil.Query(sql);
            try
            {
                originTable = DbHelperSQL_data.Query(sql).Tables[0];
                OriginGridControl.DataSource = originTable;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
