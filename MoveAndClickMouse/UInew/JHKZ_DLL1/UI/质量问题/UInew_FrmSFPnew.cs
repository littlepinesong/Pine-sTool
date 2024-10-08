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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Maticsoft.Common;

namespace UInew.JHKZ_DLL1.UI.质量问题
{
    public partial class UInew_FrmSFPnew : DevExpress.XtraEditors.XtraForm
    {
        //Security.BLL.userinfo userBll = new Security.BLL.userinfo();

        public static DbHelperSQLP DbHelperSQLP_cmd = new DbHelperSQLP("server=192.168.10.203;database=hbcshdb;user=cshadmin;pwd=57Ki)j9-");//连接数据库
        DataTable STable;
        DataTable FTable;
        DataTable PTable;
        DataTable RPITable;
        //使用事件传递结果值
        public event EventHandler<IntEventArgs> UpshopRPI;
        public event EventHandler<IntEventArgs> UpshopS;
        public event EventHandler<IntEventArgs> UpshopF;
        public event EventHandler<IntEventArgs> UpshopP;

        int _S, _F, _P, _RPI;

        public UInew_FrmSFPnew(int S, int F, int P)
        {
            InitializeComponent();
            _S = S;
            _F = F;
            _P = P;
        }

        private void UInew_FrmSFPnew_Load(object sender, EventArgs e)
        {
            LoadSFP();
            Initialize();
        }

        #region 初始化数据
        private void LoadSFP()
        {
            //先初始化选择的状态
            string ScommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Severity] set Choose='0'";
            DbHelperSQLP_cmd.ExecuteSql(ScommadSqlInit);
            //通过S设置选择的状态 
            string ScommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Severity] set Choose='1' where Severity =  '{_S}'";
            DbHelperSQLP_cmd.ExecuteSql(ScommadSql);

            //先初始化选择的状态
            string FcommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Frequency] set Choose='0'";
            DbHelperSQLP_cmd.ExecuteSql(FcommadSqlInit);
            //通过S设置选择的状态 
            string FcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Frequency] set Choose='1' where Frequency =  '{_F}'";
            DbHelperSQLP_cmd.ExecuteSql(FcommadSql);

            //先初始化选择的状态
            string PcommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Probability] set Choose='0'";
            DbHelperSQLP_cmd.ExecuteSql(PcommadSqlInit);
            //通过S设置选择的状态 
            string PcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Probability] set Choose='1' where Probability =  '{_P}'";
            DbHelperSQLP_cmd.ExecuteSql(PcommadSql);

            //自适应高度
            SgridView.RowHeight = SgridView.RowHeight + repositoryItemMemoEdit1.Appearance.Font.Height;
            PgridView.RowHeight = PgridView.RowHeight + repositoryItemMemoEdit2.Appearance.Font.Height;
            RPIgridView.RowHeight = RPIgridView.RowHeight + repositoryItemMemoEdit3.Appearance.Font.Height;
        }

        private void Initialize()
        {
            string SQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Severity]";
            STable = DbHelperSQLP_cmd.Query(SQuery).Tables[0];
            SgridControl.DataSource = STable;

            string FQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Frequency]";
            FTable = DbHelperSQLP_cmd.Query(FQuery).Tables[0];
            FgridControl.DataSource = FTable;

            string PQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Probability]";
            PTable = DbHelperSQLP_cmd.Query(PQuery).Tables[0];
            PgridControl.DataSource = PTable;

            //string RPIQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI]";
            //RPITable = DbHelperSQLP_cmd.Query(RPIQuery).Tables[0];
            //RPIgridControl.DataSource = RPITable;
            reCualculateRPI();
        }
        #endregion

        #region 初始化颜色
        private void SFPgridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            string Scolor = Convert.ToString(SFPgridView.GetDataRow(e.RowHandle)["S"]).Trim();
            if (e.Column.FieldName == "S")
            {
                if (Scolor == "1")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else if (Scolor == "2")
                {
                    e.Appearance.BackColor = Color.Orange;
                }
                else if (Scolor == "3" || Scolor == "4")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }

            string Fcolor = Convert.ToString(SFPgridView.GetDataRow(e.RowHandle)["F"]).Trim();
            if (e.Column.FieldName == "F")
            {
                if (Fcolor == "1")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else if (Fcolor == "2")
                {
                    e.Appearance.BackColor = Color.Orange;
                }
                else if (Fcolor == "3")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }

            string Pcolor = Convert.ToString(SFPgridView.GetDataRow(e.RowHandle)["P"]).Trim();
            if (e.Column.FieldName == "P")
            {
                if (Pcolor == "1")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else if (Pcolor == "2")
                {
                    e.Appearance.BackColor = Color.Orange;
                }
                else if (Pcolor == "3")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }

            string RPIcolor = Convert.ToString(SFPgridView.GetDataRow(e.RowHandle)["RPI"]).Trim();
            int RPI;
            int.TryParse(RPIcolor, out RPI);
            if (e.Column.FieldName == "RPI")
            {
                if (RPI >= 1 && RPI < 4)
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else if (RPI >= 4 && RPI <= 8)
                {
                    e.Appearance.BackColor = Color.Orange;
                }
                if (RPI > 8 && RPI <= 36 || _S >= 3 || _F == 3 || _P == 3)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void SgridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            string Scolor = Convert.ToString(SgridView.GetDataRow(e.RowHandle)["Severity"]).Trim();
            if (e.Column.FieldName == "Severity")
            {
                if (Scolor == "1")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else if (Scolor == "2")
                {
                    e.Appearance.BackColor = Color.Orange;
                }
                else if (Scolor == "3" || Scolor == "4")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void FgridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            string Fcolor = Convert.ToString(FgridView.GetDataRow(e.RowHandle)["Frequency"]).Trim();
            if (e.Column.FieldName == "Frequency")
            {
                if (Fcolor == "1")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else if (Fcolor == "2")
                {
                    e.Appearance.BackColor = Color.Orange;
                }
                else if (Fcolor == "3")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void PgridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            string Pcolor = Convert.ToString(PgridView.GetDataRow(e.RowHandle)["Probability"]).Trim();
            if (e.Column.FieldName == "Probability")
            {
                if (Pcolor == "1")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else if (Pcolor == "2")
                {
                    e.Appearance.BackColor = Color.Orange;
                }
                else if (Pcolor == "3")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void RPIgridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            string RPIcolor = Convert.ToString(RPIgridView.GetDataRow(e.RowHandle)["RiskPriorityIndex"]).Trim();
            if (e.Column.FieldName == "RiskPriorityIndex")
            {
                if (RPIcolor == "L")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else if (RPIcolor == "M")
                {
                    e.Appearance.BackColor = Color.Orange;
                }
                else if (RPIcolor == "H")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        #endregion

        #region 选择状态处理
        /// <summary>
        /// 实现在选中当前行的同时取消对其它行的选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit editor = sender as DevExpress.XtraEditors.CheckEdit;
            if (editor != null && SgridView.IsDataRow(SgridView.FocusedRowHandle))
            {
                bool isChecked = editor.Checked;
                //获取当前行的值
                int currentRowHandle = SgridView.FocusedRowHandle;
                int currentValue = (int)SgridView.GetRowCellValue(currentRowHandle, "Severity");
                _S = currentValue;
                //重置其它行
                ReLoadSCheck(currentValue);
                //重新计算RPI
                reCualculateRPI();
            }
        }

        private void ReLoadSCheck(int currentValue)
        {
            //先初始化选择的状态
            string ScommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Severity] set Choose='0'";
            DbHelperSQLP_cmd.ExecuteSql(ScommadSqlInit);
            //通过S设置选择的状态 
            string ScommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Severity] set Choose='1' where Severity =  '{currentValue}'";
            DbHelperSQLP_cmd.ExecuteSql(ScommadSql);
            //数据源刷新
            string SQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Severity]";
            STable = DbHelperSQLP_cmd.Query(SQuery).Tables[0];
            SgridControl.DataSource = STable;

            //获取当前选中值的行号
            int rowIndex = SgridView.LocateByValue("Severity", currentValue);
            //将索引列的焦点移动到找到的列
            if (rowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                SgridView.FocusedRowHandle = rowIndex;
            }
            ////更改选中行的外观
            //SgridView.OptionsSelection.EnableAppearanceFocusedRow = true;
            //SgridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
        }

        private void repositoryItemCheckEdit2_CheckedChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit editor = sender as DevExpress.XtraEditors.CheckEdit;
            if (editor != null && FgridView.IsDataRow(FgridView.FocusedRowHandle))
            {
                bool isChecked = editor.Checked;
                //获取当前行的值
                int currentRowHandle = FgridView.FocusedRowHandle;
                int currentValue = (int)FgridView.GetRowCellValue(currentRowHandle, "Frequency");
                _F = currentValue;
                //重置其它行
                ReLoadFCheck(currentValue);
                //重新计算RPI
                reCualculateRPI();
            }
        }

        private void ReLoadFCheck(int currentValue)
        {
            //先初始化选择的状态
            string FcommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Frequency] set Choose='0'";
            DbHelperSQLP_cmd.ExecuteSql(FcommadSqlInit);
            //通过F设置选择的状态 
            string FcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Frequency] set Choose='1' where Frequency =  '{currentValue}'";
            DbHelperSQLP_cmd.ExecuteSql(FcommadSql);
            //数据源刷新
            string FQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Frequency]";
            FTable = DbHelperSQLP_cmd.Query(FQuery).Tables[0];
            FgridControl.DataSource = FTable;

            //获取当前选中值的行号
            int rowIndex = FgridView.LocateByValue("Frequency", currentValue);
            //将索引列的焦点移动到找到的列
            if (rowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                FgridView.FocusedRowHandle = rowIndex;
            }
            ////更改选中行的外观
            //FgridView.OptionsSelection.EnableAppearanceFocusedRow = true;
            //FgridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
        }

        private void repositoryItemCheckEdit3_CheckedChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit editor = sender as DevExpress.XtraEditors.CheckEdit;
            if (editor != null && PgridView.IsDataRow(PgridView.FocusedRowHandle))
            {
                bool isChecked = editor.Checked;
                //获取当前行的值
                int currentRowHandle = PgridView.FocusedRowHandle;
                int currentValue = (int)PgridView.GetRowCellValue(currentRowHandle, "Probability");
                _P = currentValue;
                //重置其它行
                ReLoadPCheck(currentValue);
                //重新计算RPI
                reCualculateRPI();
            }
        }

        private void ReLoadPCheck(int currentValue)
        {
            //先初始化选择的状态
            string PcommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Probability] set Choose='0'";
            DbHelperSQLP_cmd.ExecuteSql(PcommadSqlInit);
            //通过P设置选择的状态 
            string PcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Probability] set Choose='1' where Probability =  '{currentValue}'";
            DbHelperSQLP_cmd.ExecuteSql(PcommadSql);
            //数据源刷新
            string PQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Probability]";
            PTable = DbHelperSQLP_cmd.Query(PQuery).Tables[0];
            PgridControl.DataSource = PTable;

            //获取当前选中值的行号
            int rowIndex = PgridView.LocateByValue("Probability", currentValue);
            //将索引列的焦点移动到找到的列
            if (rowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                PgridView.FocusedRowHandle = rowIndex;
            }
            ////更改选中行的外观
            //PgridView.OptionsSelection.EnableAppearanceFocusedRow = true;
            //PgridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
        }

        private void reCualculateRPI()
        {
            int RPI = _S * _F * _P;
            int rowIndex = -1;
            if (RPI >= 1 && RPI < 4)
            {
                //先初始化选择的状态
                string PcommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI] set Choose='0'";
                DbHelperSQLP_cmd.ExecuteSql(PcommadSqlInit);
                //通过RPI设置选择的状态 
                string PcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI] set Choose='1' where RiskPriorityIndex =  'L'";
                DbHelperSQLP_cmd.ExecuteSql(PcommadSql);
                //数据源刷新
                string RPIQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI]";
                RPITable = DbHelperSQLP_cmd.Query(RPIQuery).Tables[0];
                RPIgridControl.DataSource = RPITable;

                //获取当前选中值的行号
                rowIndex = RPIgridView.LocateByValue("RiskPriorityIndex", "L");
            }
            if (RPI >= 4 && RPI <= 8)
            {
                //先初始化选择的状态
                string PcommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI] set Choose='0'";
                DbHelperSQLP_cmd.ExecuteSql(PcommadSqlInit);
                //通过RPI设置选择的状态 
                string PcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI] set Choose='1' where RiskPriorityIndex =  'M'";
                DbHelperSQLP_cmd.ExecuteSql(PcommadSql);
                //数据源刷新
                string RPIQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI]";
                RPITable = DbHelperSQLP_cmd.Query(RPIQuery).Tables[0];
                RPIgridControl.DataSource = RPITable;

                //获取当前选中值的行号
                rowIndex = RPIgridView.LocateByValue("RiskPriorityIndex", "M");
            }
            if (RPI > 8 && RPI <= 36 || _S >= 3 || _F == 3 || _P == 3)
            {
                //先初始化选择的状态
                string PcommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI] set Choose='0'";
                DbHelperSQLP_cmd.ExecuteSql(PcommadSqlInit);
                //通过RPI设置选择的状态 
                string PcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI] set Choose='1' where RiskPriorityIndex =  'H'";
                DbHelperSQLP_cmd.ExecuteSql(PcommadSql);
                //数据源刷新
                string RPIQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI]";
                RPITable = DbHelperSQLP_cmd.Query(RPIQuery).Tables[0];
                RPIgridControl.DataSource = RPITable;
                //获取当前选中值的行号
                rowIndex = RPIgridView.LocateByValue("RiskPriorityIndex", "H");
            }
            else if (RPI == 0 || RPI > 36)
            {
                //先初始化选择的状态
                string PcommadSqlInit = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI] set Choose='0'";
                DbHelperSQLP_cmd.ExecuteSql(PcommadSqlInit);
                //数据源刷新
                string RPIQuery = "select * from [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI]";
                RPITable = DbHelperSQLP_cmd.Query(RPIQuery).Tables[0];
                RPIgridControl.DataSource = RPITable;
            }
            //重新加载SFP界面
            reLoadSFP();
            _RPI = RPI;

            
            //将索引列的焦点移动到找到的列
            if (rowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                RPIgridView.FocusedRowHandle = rowIndex;
            }
            ////更改选中行的外观
            //RPIgridView.OptionsSelection.EnableAppearanceFocusedRow = true;
            //RPIgridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
        }

        private void reLoadSFP()
        {
            DataTable SFP = new DataTable();
            SFP.Columns.Add("ID", typeof(int));
            SFP.PrimaryKey = new DataColumn[] { SFP.Columns["ID"] };
            SFP.Columns.Add("S");
            SFP.Columns.Add("F");
            SFP.Columns.Add("P");
            SFP.Columns.Add("RPI");
            if (SFP.Rows.Count > 0)
            {
                DataRow row = SFP.Rows.Find(1);
                row["S"] = _S;
                row["F"] = _F;
                row["P"] = _P;
                row["RPI"] = _S * _F * _P;
            }
            else
            {
                DataRow newRow = SFP.NewRow();
                newRow["ID"] = 1;
                newRow["S"] = _S;
                newRow["F"] = _F;
                newRow["P"] = _P;
                newRow["RPI"] = _S * _F * _P;
                SFP.Rows.Add(newRow);
            }
            SFPgridControl.DataSource = SFP;
        }
        #endregion

        //由于现在要设置为应用程序，所以定义返回值属性，而之前使用的委托现在就无效了
        public int ReturnS { get; set; }
        public int ReturnF { get; set; }
        public int ReturnP { get; set; }
        public int ReturnRPI { get; set; }

        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            //UpshopS?.Invoke(this, new IntEventArgs(_S));
            //UpshopF?.Invoke(this, new IntEventArgs(_F));
            //UpshopP?.Invoke(this, new IntEventArgs(_P));
            //UpshopRPI?.Invoke(this, new IntEventArgs(_RPI));

            this.DialogResult = DialogResult.OK;
            this.ReturnS = _S;
            this.ReturnF = _F;
            this.ReturnP = _P;
            this.ReturnRPI = _RPI;

            this.Close();
        }
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.ReturnS = 0;
            this.ReturnF = 0;
            this.ReturnP = 0;
            this.ReturnRPI = 0;

            this.Close();
        }

        #region 举例内容修改和保存
        private void SgridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string ExternalImplication = Convert.ToString(SgridView.GetDataRow(e.RowHandle)["ExternalImplication"]).Trim();
            string InherentImplication = Convert.ToString(SgridView.GetDataRow(e.RowHandle)["InherentImplication"]).Trim();
            string Cost = Convert.ToString(SgridView.GetDataRow(e.RowHandle)["Cost"]).Trim();
            string SExample = Convert.ToString(SgridView.GetDataRow(e.RowHandle)["Example"]).Trim();
            string Performance = Convert.ToString(SgridView.GetDataRow(e.RowHandle)["Performance"]).Trim();

            string Severity = Convert.ToString(SgridView.GetDataRow(e.RowHandle)["Severity"]).Trim();
            if (e.Column.FieldName == "Example") { }
            {
                //通过S设置选择的状态 
                string ScommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Severity] set ExternalImplication='{ExternalImplication}',InherentImplication='{InherentImplication}',Cost='{Cost}',Example='{SExample}',Performance='{Performance}' where Severity =  '{Severity}'";
                DbHelperSQLP_cmd.ExecuteSql(ScommadSql);
            }
        }

        private void FgridControl_Click(object sender, EventArgs e)
        {

        }

        private void FgridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string Explanation = Convert.ToString(FgridView.GetDataRow(e.RowHandle)["Explanation"]).Trim();
            string Frequency = Convert.ToString(FgridView.GetDataRow(e.RowHandle)["Frequency"]).Trim();
            if (e.Column.FieldName == "Explanation") { }
            {
                //通过F设置选择的状态 
                string FcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Frequency] set Explanation='{Explanation}' where Frequency =  '{Frequency}'";
                DbHelperSQLP_cmd.ExecuteSql(FcommadSql);
            }
        }

        private void PgridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string Explanation = Convert.ToString(PgridView.GetDataRow(e.RowHandle)["Explanation"]).Trim();
            string PExample = Convert.ToString(PgridView.GetDataRow(e.RowHandle)["Example"]).Trim();
            string Probability = Convert.ToString(PgridView.GetDataRow(e.RowHandle)["Probability"]).Trim();
            if (e.Column.FieldName == "Example") { }
            {
                //通过S设置选择的状态
                string PcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_Probability] set Explanation='{Explanation}',Example='{PExample}' where Probability =  '{Probability}'";
                DbHelperSQLP_cmd.ExecuteSql(PcommadSql);
            }
        }

        private void RPIgridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string Explanation = Convert.ToString(RPIgridView.GetDataRow(e.RowHandle)["Explanation"]).Trim();
            string RPIExample = Convert.ToString(RPIgridView.GetDataRow(e.RowHandle)["Example"]).Trim();
            string RiskPriorityIndex = Convert.ToString(RPIgridView.GetDataRow(e.RowHandle)["RiskPriorityIndex"]).Trim();
            if (e.Column.FieldName == "Example") { }
            {
                //通过S设置选择的状态 
                string RPIcommadSql = $"update [hbcshdb].[dbo].[jhkz_zlwttb_SFP_RPI] set Explanation='{Explanation}',Example='{RPIExample}' where RiskPriorityIndex =  '{RiskPriorityIndex}'";
                DbHelperSQLP_cmd.ExecuteSql(RPIcommadSql);
            }
        }
        #endregion
    }
}
