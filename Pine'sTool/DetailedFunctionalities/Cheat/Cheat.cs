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
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using 出勤记录Model = Pine_sTool.Model.出勤记录;
using 出勤记录BLL = Pine_sTool.BLL.出勤记录;

namespace Pine_sTool.DetailedFunctionalities.Cheat
{
    public partial class Cheat : XtraForm
    {

        private 出勤记录Model model = new 出勤记录Model();
        private 出勤记录BLL bll = new 出勤记录BLL();
        DataTable table = new DataTable();
        public Cheat()
        {
            InitializeComponent();
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption == "Refresh") Init();
            if (e.Button.Properties.Caption == "Cheat")
            {
                //int id = SafeConvert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID"));
                DataRow row = gridView.GetFocusedDataRow();
                int id = SafeConvert.ToInt32(row["ID"]);
                出勤记录BLL bll = new 出勤记录BLL();
                出勤记录Model model = bll.GetModel(id);
                model.登录名 = SafeConvert.ToString(row["登录名"]);
                model.登记日期 = SafeConvert.ToDateTime(row["登记日期"]);
                model.开始时间 = SafeConvert.ToDateTime(row["开始时间"]);
                model.星期 = SafeConvert.ToString(row["星期"]);
                model.结束时间 = SafeConvert.ToDateTime(row["结束时间"]);
                model.累计时间 = SafeConvert.ToDecimal(row["累计时间"]);
                model.jiaban_ZS = SafeConvert.ToDecimal(row["jiaban_ZS"]);
                model.jiaban_T = SafeConvert.ToDecimal(row["jiaban_T"]);
                model.空闲时间 = SafeConvert.ToDecimal(row["空闲时间"]);
                model.是否出差 = SafeConvert.ToBoolean(row["是否出差"]);
                model.是否请假 = SafeConvert.ToBoolean(row["是否请假"]);
                model.是否补签 = SafeConvert.ToBoolean(row["是否补签"]);
                model.是否有效 = SafeConvert.ToBoolean(row["是否有效"]);
                model.备注 = null;
                model.jsID = null;
                model.trip_id = null;
                model.qjType = null;
                bll.Update(model);
                Init();
            }
        }

        private void Cheat_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            //gridControl.DataSource = GetDataSource();
            table = bll.GetList(" 登录名 = 538 order by 开始时间 desc").Tables[0];
            DataTable tempTable = new DataTable();
            foreach (DataColumn column in table.Columns)
            { tempTable.Columns.Add(column.ColumnName, typeof(string)); }
            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = tempTable.NewRow();
                foreach (DataColumn column in table.Columns)
                {
                    newRow[column.ColumnName] = row[column.ColumnName].ToString();
                }
                tempTable.Rows.Add(newRow.ItemArray);
            }
            gridControl.DataSource = tempTable;
        }
    }
}
