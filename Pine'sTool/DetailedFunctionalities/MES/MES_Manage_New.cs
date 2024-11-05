using DevExpress.Utils;
using DevExpress.XtraEditors;
using Pine_sTool.DetailedFunctionalities.JSON;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PT_MES_SCZJH_data_BLL = Pine_sTool.BLL.PT_MES_SCZJH_data;
using PT_MES_SCZJH_data_Model = Pine_sTool.Model.PT_MES_SCZJH_data;
using PT_MES_SCZJH_nodeList_BLL = Pine_sTool.BLL.PT_MES_SCZJH_nodeList;
using PT_MES_SCZJH_nodeList_Model = Pine_sTool.Model.PT_MES_SCZJH_nodeList;

//using PT_MES_SCZJH_MergerTable = Pine_sTool.BLL.PT_MES_SCZJH_MergerTable;
using View_PT_MES_SCZJH_Merger_BLL = Pine_sTool.BLL.View_PT_MES_SCZJH_Merger;

namespace Pine_sTool.DetailedFunctionalities.MES
{
    public partial class MES_Manage_New : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt_MergerTable = new DataTable();
        private DataTable _gxbTable = new DataTable();
        private PT_MES_SCZJH_data_BLL pt_MES_SCZJH_data = new PT_MES_SCZJH_data_BLL();
        private PT_MES_SCZJH_data_Model data_model = new PT_MES_SCZJH_data_Model();
        private PT_MES_SCZJH_nodeList_BLL pt_MES_SCZJH_nodeList = new PT_MES_SCZJH_nodeList_BLL();
        private PT_MES_SCZJH_nodeList_Model nodeList_model = new PT_MES_SCZJH_nodeList_Model();

        //PT_MES_SCZJH_MergerTable pt_MES_SCZJH_MergerTable = new PT_MES_SCZJH_MergerTable();
        private View_PT_MES_SCZJH_Merger_BLL MergerTable = new View_PT_MES_SCZJH_Merger_BLL();

        private string _type = "";
        private string _th = "";

        public MES_Manage_New(string th = "1TBC.710.H30136")
        {
            _th = th;
            InitializeComponent();
        }

        public MES_Manage_New(DataTable gxbTable, string type = "工序表")
        {
            _gxbTable = gxbTable.Copy();
            _type = type;
            InitializeComponent();
            this.Width = 750;
            this.Height = 1120;
            //this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MES_Manage_Load(object sender, EventArgs e)
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
                XtraMessageBox.Show("MES_Manage,CustomizeAll" + ex.Message);
            }
            LoadDataTable();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //DataTable dt_JDCX = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_JDCX();
            //DataTable dt_MergerTable = JSON.JSON_TO_DataTable.Conver_MergerTable();
            //获取到数据表的值
            dt_MergerTable = JSON.JSON_TO_DataTable.Conver_MergerTable();
            int a, b, c, d;
            //a = dt_SCZJH.Rows.Count;
            //b = dt_SCZJH_nodeList.Rows.Count;
            //c = dt_JDCX.Rows.Count;
            d = dt_MergerTable.Rows.Count;
            foreach (DataColumn column in dt_MergerTable.Columns)
            {
                string name = column.ColumnName;
            }
            //gridControl_SCZJH.DataSource = dt_SCZJH;
            //gridControl_JDB.DataSource = dt_SCZJH_nodeList;
            //gridControl_JDCX.DataSource = dt_JDCX;
            //gridControl_SCZJH_MergerTable.DataSource = dt_MergerTable;
            LoadDataTable();
        }

        private void SetVisible()
        {
            xtraTabPage4.Text = "生产主计划";
            this.Width = 1800;
            this.Height = 1000;
            //this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (Environment.UserName != "176630")
            {
                SCZJH_TO_SQL_Button.Enabled = false;
                SCZJH_NodeListToSQL_Button.Enabled = false;
                simpleButton1.Enabled = false;
            }
            //UpdateCurrentRowButton.Enabled = false;
            this.Text = "衡变MES管理端-生产主计划";
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView_SCZJH_MergerTable.Columns)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = false;
            }
            //id主干.Visible = true;
            productNo主干.Visible = true;
            model主干.Visible = true;
            //contractNo主干.Visible = true;
            drawingNo主干.Visible = true;
            customerName主干.Visible = true;
            noTaxAmount主干.Visible = true;
            dateEnd主干.Visible = true;
            //edition主干.Visible = true;
            //madeMode主干.Visible = true;
            //schedulingStatus主干.Visible = true;
            //project_name主干.Visible = true;
            count主干.Visible = true;
            stateName主干.Visible = true;
            //materialName主干.Visible = true;
            //importmentLevel主干.Visible = true;
            outPut主干.Visible = true;
            //timeLimitId主干.Visible = true;
            timeLimitName主干.Visible = true;
            //workShop主干.Visible = true;
            //orderIssuedTime主干.Visible = true;
            //planStartDate主干.Visible = true;
            //projectManager主干.Visible = true;
            //isExportProduct主干.Visible = true;
            planCompletime主干.Visible = true;
            //productionSite主干.Visible = true;
            //processStatus主干.Visible = true;
            //actualStartTime主干.Visible = true;
            //isRepair主干.Visible = true;
            //urgentLevel主干.Visible = true;
            //id节点.Visible = true;
            //ztbm节点.Visible = true;
            //createDt节点.Visible = true;
            //editDt节点.Visible = true;
            //isDeleted节点.Visible = true;
            //productPlanId节点.Visible = true;
            //drawingNo节点.Visible = true;
            //name节点.Visible = true;
            //type节点.Visible = true;
            //nodeDate节点.Visible = true;
            //finishDate节点.Visible = true;
            //status节点.Visible = true;
            //progressStatus节点.Visible = true;
            //confirmStatus节点.Visible = true;
            //startDate节点.Visible = true;
            //actualStartDate节点.Visible = true;
            //nodeId节点.Visible = true;
            //usedEquipment节点.Visible = true;
            //pauseReason节点.Visible = true;
            //bomInfo节点.Visible = true;
            //isOutsourcing节点.Visible = true;
            //hbFinishDate节点.Visible = true;
            //outsourcingSituation节点.Visible = true;
            //outsourcingSetTime节点.Visible = true;
            //finishUserId节点.Visible = true;
            //startUserId节点.Visible = true;
            //startUserName节点.Visible = true;
            //pauseDuration节点.Visible = true;
            //finishUserName节点.Visible = true;
            //difDay节点.Visible = true;

            productNo主干.Caption = "生产号";
            productNo主干.VisibleIndex = 0;
            productNo主干.Width = 110;
            model主干.Caption = "设计型号";
            model主干.VisibleIndex = 1;
            model主干.Width = 160;
            planCompletime主干.Caption = "计划生产完工时间";
            planCompletime主干.VisibleIndex = 2;
            planCompletime主干.Width = 110;
            dateEnd主干.Caption = "厂内完工时间";
            dateEnd主干.VisibleIndex = 3;
            dateEnd主干.Width = 100;
            drawingNo主干.Caption = "图号";
            drawingNo主干.VisibleIndex = 4;
            drawingNo主干.Width = 140;
            customerName主干.Caption = "用户单位";
            customerName主干.VisibleIndex = 5;
            customerName主干.Width = 500;
            noTaxAmount主干.Caption = "产值（万元）";
            noTaxAmount主干.VisibleIndex = 6;
            noTaxAmount主干.Width = 90;
            outPut主干.Caption = "产量（万kVA）";
            outPut主干.VisibleIndex = 7;
            outPut主干.Width = 100;
            timeLimitName主干.Caption = "产品期量";
            timeLimitName主干.VisibleIndex = 8;
            timeLimitName主干.Width = 250;
            count主干.Caption = "台量";
            count主干.VisibleIndex = 9;
            count主干.Width = 45;
            stateName主干.Caption = "状态";
            stateName主干.VisibleIndex = 10;
            stateName主干.Width = 90;
            //importmentLevel主干.Caption = "重点性";
            //importmentLevel主干.VisibleIndex = 11;
            //urgentLevel主干.Caption = "紧急性";
            //urgentLevel主干.VisibleIndex = 12;
        }

        private void SetSearchControlPlaceholder(SearchControl searchControl, string placeholderText)
        {
            searchControl.Text = placeholderText;

            searchControl.Enter += (s, e) =>
            {
                if (searchControl.Text == placeholderText)
                {
                    searchControl.Text = "";
                    searchControl1.Properties.Appearance.ForeColor = Color.Black;
                }
            };

            searchControl.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(searchControl.Text))
                {
                    searchControl.Text = placeholderText;
                    searchControl1.ForeColor = Color.Gray;
                }
            };
        }

        public DataTable LoadDataTable(string queryStr = "")
        {
            SetSearchControlPlaceholder(searchControl1, "可按图号、型号、生产号、时间...等任意文本查询");
            // 自动编号行号
            gridView_SCZJH_MergerTable.CustomDrawRowIndicator += (sender, e) =>
            {
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            };
            //if (_type == "")
            //{
            //    //如果从文件中构建数据表
            //    SetVisible();
            //    DataTable AfterMergeTable = new DataTable();
            //    foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView_SCZJH_MergerTable.VisibleColumns)
            //    {
            //        AfterMergeTable.Columns.Add(column.FieldName);
            //    }
            //    //设置主键防止重复
            //    AfterMergeTable.PrimaryKey = new DataColumn[] { AfterMergeTable.Columns["drawingNo主干"] };
            //    //获取到数据表的值
            //    dt_MergerTable = JSON.JSON_TO_DataTable.Conver_MergerTable();
            //    foreach (DataRow row in dt_MergerTable.Rows)
            //    {
            //        DataRow newRow = AfterMergeTable.NewRow();
            //        foreach (DataColumn column in AfterMergeTable.Columns)
            //        {
            //            newRow[column.ColumnName] = row[column.ColumnName].ToString();
            //        }
            //        if (AfterMergeTable.Rows.Find(row["drawingNo主干"]) == null)
            //        {
            //            AfterMergeTable.Rows.Add(newRow);
            //        }
            //    }
            //    gridControl_SCZJH_MergerTable.DataSource = AfterMergeTable;
            //}
            New_SetVisible();
            if (_type == "")
            {
                //SetVisible();
                DataTable AfterMergeTable = new DataTable();
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView_SCZJH_MergerTable.VisibleColumns)
                {
                    AfterMergeTable.Columns.Add(column.FieldName);
                }
                //设置主键防止重复
                AfterMergeTable.PrimaryKey = new DataColumn[] { AfterMergeTable.Columns["drawingNo主干"] };
                //获取到数据表的值
                if (_th == "")
                {
                    if (queryStr == "")
                    {
                        dt_MergerTable = MergerTable.GetAllList().Tables[0];
                    }
                    else
                    {
                        dt_MergerTable = MergerTable.GetList($@"drawingNo主干 like '%{queryStr}%' or productNo主干 like '%{queryStr}%'
or model主干 like '%{queryStr}%' or customerName主干 like '%{queryStr}%' or noTaxAmount主干 like '%{queryStr}%' or dateEnd主干 like '%{queryStr}%'
or count主干 like '%{queryStr}%' or stateName主干 like '%{queryStr}%' or outPut主干 like '%{queryStr}%' or timeLimitName主干 like '%{queryStr}%'
or planCompletime主干 like '%{queryStr}%' ").Tables[0];
                    }
                }
                else
                {
                    if (queryStr == "")
                    {
                        dt_MergerTable = MergerTable.GetList($"drawingNo主干 = '{_th}'").Tables[0];
                    }
                    else
                    {
                        dt_MergerTable = MergerTable.GetList($@"drawingNo主干 like '%{queryStr}%' or productNo主干 like '%{queryStr}%'
or model主干 like '%{queryStr}%' or customerName主干 like '%{queryStr}%' or noTaxAmount主干 like '%{queryStr}%' or dateEnd主干 like '%{queryStr}%'
or count主干 like '%{queryStr}%' or stateName主干 like '%{queryStr}%' or outPut主干 like '%{queryStr}%' or timeLimitName主干 like '%{queryStr}%'
or planCompletime主干 like '%{queryStr}%' ").Tables[0];
                    }
                }
                foreach (DataRow row in dt_MergerTable.Rows)
                {
                    DataRow newRow = AfterMergeTable.NewRow();
                    foreach (DataColumn column in AfterMergeTable.Columns)
                    {
                        newRow[column.ColumnName] = row[column.ColumnName].ToString();
                    }
                    if (AfterMergeTable.Rows.Find(row["drawingNo主干"]) == null)
                    {
                        AfterMergeTable.Rows.Add(newRow);
                    }
                }
                gridControl_SCZJH_MergerTable.DataSource = AfterMergeTable;
            }
            if (_type == "工序表")
            {
                //SetGxbVisible();
                gridControl_SCZJH_MergerTable.DataSource = _gxbTable;
            }
            return (DataTable)gridControl_SCZJH_MergerTable.DataSource;
        }

        private void New_SetVisible()
        {
            xtraTabPage4.Text = "生产主计划";
            this.Width = 2500 - 150;
            this.Height = 1115;
            //this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (Environment.UserName != "176630")
            {
                SCZJH_TO_SQL_Button.Enabled = false;
                SCZJH_TO_SQL_Button.Visible = false;
                SCZJH_NodeListToSQL_Button.Enabled = false;
                SCZJH_NodeListToSQL_Button.Visible = false;
                simpleButton1.Enabled = false;
                simpleButton1.Visible = false;
                ShowAllSCZJH_Button.Enabled = false;
                ShowAllSCZJH_Button.Visible = false;
            }
            //UpdateCurrentRowButton.Enabled = false;
            this.Text = "衡变MES生产主计划";
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView_SCZJH_MergerTable.Columns)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = false;
            }
            //id主干.Visible = true;
            productNo主干.Visible = true;
            model主干.Visible = true;
            //contractNo主干.Visible = true;
            drawingNo主干.Visible = true;
            customerName主干.Visible = true;
            noTaxAmount主干.Visible = true;
            dateEnd主干.Visible = true;
            //edition主干.Visible = true;
            //madeMode主干.Visible = true;
            //schedulingStatus主干.Visible = true;
            //project_name主干.Visible = true;
            count主干.Visible = true;
            stateName主干.Visible = true;
            //materialName主干.Visible = true;
            //importmentLevel主干.Visible = true;
            outPut主干.Visible = true;
            //timeLimitId主干.Visible = true;
            timeLimitName主干.Visible = true;
            //workShop主干.Visible = true;
            //orderIssuedTime主干.Visible = true;
            //planStartDate主干.Visible = true;
            //projectManager主干.Visible = true;
            //isExportProduct主干.Visible = true;
            planCompletime主干.Visible = true;
            //productionSite主干.Visible = true;
            //processStatus主干.Visible = true;
            //actualStartTime主干.Visible = true;
            //isRepair主干.Visible = true;
            //urgentLevel主干.Visible = true;
            //id节点.Visible = true;
            //ztbm节点.Visible = true;
            //createDt节点.Visible = true;
            //editDt节点.Visible = true;
            //isDeleted节点.Visible = true;
            //productPlanId节点.Visible = true;
            //drawingNo节点.Visible = true;
            //name节点.Visible = true;
            //type节点.Visible = true;
            //nodeDate节点.Visible = true;
            //finishDate节点.Visible = true;
            //status节点.Visible = true;
            //progressStatus节点.Visible = true;
            //confirmStatus节点.Visible = true;
            //startDate节点.Visible = true;
            //actualStartDate节点.Visible = true;
            //nodeId节点.Visible = true;
            //usedEquipment节点.Visible = true;
            //pauseReason节点.Visible = true;
            //bomInfo节点.Visible = true;
            //isOutsourcing节点.Visible = true;
            //hbFinishDate节点.Visible = true;
            //outsourcingSituation节点.Visible = true;
            //outsourcingSetTime节点.Visible = true;
            //finishUserId节点.Visible = true;
            //startUserId节点.Visible = true;
            //startUserName节点.Visible = true;
            //pauseDuration节点.Visible = true;
            //finishUserName节点.Visible = true;
            //difDay节点.Visible = true;

            productNo主干.Caption = "生产号";
            productNo主干.VisibleIndex = 0;
            productNo主干.Width = 110;
            model主干.Caption = "设计型号";
            model主干.VisibleIndex = 1;
            model主干.Width = 160;
            planCompletime主干.Caption = "计划生产完工时间";
            planCompletime主干.VisibleIndex = 2;
            planCompletime主干.Width = 110;
            dateEnd主干.Caption = "厂内完工时间";
            dateEnd主干.VisibleIndex = 3;
            dateEnd主干.Width = 100;
            drawingNo主干.Caption = "图号";
            drawingNo主干.VisibleIndex = 4;
            drawingNo主干.Width = 140;
            customerName主干.Caption = "用户单位";
            customerName主干.VisibleIndex = 5;
            customerName主干.Width = 500;
            noTaxAmount主干.Caption = "产值（万元）";
            noTaxAmount主干.VisibleIndex = 6;
            noTaxAmount主干.Width = 90;
            outPut主干.Caption = "产量（万kVA）";
            outPut主干.VisibleIndex = 7;
            outPut主干.Width = 100;
            timeLimitName主干.Caption = "产品期量";
            timeLimitName主干.VisibleIndex = 8;
            timeLimitName主干.Width = 250;
            count主干.Caption = "台量";
            count主干.VisibleIndex = 9;
            count主干.Width = 45;
            stateName主干.Caption = "状态";
            stateName主干.VisibleIndex = 10;
            stateName主干.Width = 90;
            //importmentLevel主干.Caption = "重点性";
            //importmentLevel主干.VisibleIndex = 11;
            //urgentLevel主干.Caption = "紧急性";
            //urgentLevel主干.VisibleIndex = 12;

            SCZJH_TO_SQL_Button.Enabled = false;
            SCZJH_NodeListToSQL_Button.Enabled = false;
            simpleButton1.Enabled = false;
            layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            if (_th == "")
            {
                UpdateCurrentRowButton.Enabled = false;
                layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                UpdateCurrentRowButton.Text = $@"更新图号{_th}数据(不覆盖)";
                UpdateCurrentRowButton.Enabled = true;
                layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            //this.Text = $"{_gxbTable.Rows[0]["drawingNo主干"].ToString()}工序表";
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView_part.Columns)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = false;
            }

            //id节点.Visible = true;
            //ztbm节点.Visible = true;
            //createDt节点.Visible = true;
            //editDt节点.Visible = true;
            //isDeleted节点.Visible = true;
            //productPlanId节点.Visible = true;
            //drawingNo节点2.Visible = true;
            name节点2.Visible = true;
            //type节点.Visible = true;
            nodeDate节点2.Visible = true;
            finishDate节点2.Visible = true;
            //status节点.Visible = true;
            //progressStatus节点.Visible = true;
            //confirmStatus节点.Visible = true;
            //startDate节点.Visible = true;
            //actualStartDate节点.Visible = true;
            //nodeId节点.Visible = true;
            //usedEquipment节点.Visible = true;
            //pauseReason节点.Visible = true;
            //bomInfo节点.Visible = true;
            //isOutsourcing节点.Visible = true;
            //hbFinishDate节点.Visible = true;
            //outsourcingSituation节点.Visible = true;
            //outsourcingSetTime节点.Visible = true;
            //finishUserId节点.Visible = true;
            //startUserId节点.Visible = true;
            startUserName节点2.Visible = true;
            //pauseDuration节点.Visible = true;
            finishUserName节点2.Visible = true;
            //difDay节点.Visible = true;
            workshop.Visible = true;

            workshop.Caption = "车间";
            workshop.VisibleIndex = 0;
            workshop.Width = 80;
            name节点2.Caption = "部件";
            name节点2.VisibleIndex = 1;
            name节点2.Width = 90;
            nodeDate节点2.Caption = "计划完工";
            nodeDate节点2.VisibleIndex = 2;
            nodeDate节点2.Width = 130;
            finishDate节点2.Caption = "完成日期";
            finishDate节点2.VisibleIndex = 3;
            finishDate节点2.Width = 130;
            //drawingNo节点2.Caption = "图号";
            //drawingNo节点2.VisibleIndex = 3;
            //drawingNo节点2.Width = 150;
            startUserName节点2.Caption = "开始人";
            startUserName节点2.VisibleIndex = 4;
            startUserName节点2.Width = 80;
            finishUserName节点2.Caption = "完成人";
            finishUserName节点2.VisibleIndex = 5;
            finishUserName节点2.Width = 80;

            //hbFinishDate节点.Caption = "衡变完成时间";
            //hbFinishDate节点.VisibleIndex = 1;
            //hbFinishDate节点.Width = 115;
            //actualStartDate节点.Caption = "实际开始时间";
            //actualStartDate节点.VisibleIndex = 2;
            //actualStartDate节点.Width = 130;
            //startDate节点.Caption = "开始日期";
            //startDate节点.VisibleIndex = 4;
            //startDate节点.Width = 100;
            //status节点.Caption = "状态";
            //status节点.VisibleIndex = 5;
            //status节点.Width = 80;
            //type节点.Caption = "类型";
            //type节点.VisibleIndex = 8;
            //type节点.Width = 70;
            //editDt节点.Caption = "编辑日期";
            //editDt节点.VisibleIndex = 11;
            //editDt节点.Width = 135;
            //createDt节点.Caption = "创建日期";
            //createDt节点.VisibleIndex = 12;
            //createDt节点.Width = 135;

            gridView_SCZJH_MergerTable.CellMerge += (s, e) =>
            {
                // 假设"KeyColumn"是决定合并的关键列
                if (e.Column.FieldName == "name节点")
                {
                    // 获取关键列的值
                    var keyValue1 = gridView1.GetRowCellValue(e.RowHandle1, "name节点");
                    var keyValue2 = gridView1.GetRowCellValue(e.RowHandle2, "name节点");

                    // 根据关键列的值来决定是否合并
                    e.Merge = keyValue1.Equals(keyValue2) && e.CellValue1.Equals(e.CellValue2);
                    e.Handled = true;
                }
            };
        }

        private void SetGxbVisible()
        {
            xtraTabPage4.Text = "工序表";
            SCZJH_TO_SQL_Button.Enabled = false;
            SCZJH_NodeListToSQL_Button.Enabled = false;
            simpleButton1.Enabled = false;
            UpdateCurrentRowButton.Enabled = false;
            layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            this.Text = $"{_gxbTable.Rows[0]["drawingNo主干"].ToString()}工序表";
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView_SCZJH_MergerTable.Columns)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = false;
            }
            //id节点.Visible = true;
            //ztbm节点.Visible = true;
            //createDt节点.Visible = true;
            //editDt节点.Visible = true;
            //isDeleted节点.Visible = true;
            //productPlanId节点.Visible = true;
            drawingNo节点.Visible = true;
            name节点.Visible = true;
            //type节点.Visible = true;
            nodeDate节点.Visible = true;
            finishDate节点.Visible = true;
            //status节点.Visible = true;
            //progressStatus节点.Visible = true;
            //confirmStatus节点.Visible = true;
            //startDate节点.Visible = true;
            //actualStartDate节点.Visible = true;
            //nodeId节点.Visible = true;
            //usedEquipment节点.Visible = true;
            //pauseReason节点.Visible = true;
            //bomInfo节点.Visible = true;
            //isOutsourcing节点.Visible = true;
            //hbFinishDate节点.Visible = true;
            //outsourcingSituation节点.Visible = true;
            //outsourcingSetTime节点.Visible = true;
            //finishUserId节点.Visible = true;
            //startUserId节点.Visible = true;
            startUserName节点.Visible = true;
            //pauseDuration节点.Visible = true;
            finishUserName节点.Visible = true;
            //difDay节点.Visible = true;
            workshop.Visible = true;

            workshop.Caption = "车间";
            workshop.VisibleIndex = 0;
            workshop.Width = 80;
            name节点.Caption = "部件";
            name节点.VisibleIndex = 0;
            name节点.Width = 90;
            nodeDate节点.Caption = "计划完工";
            nodeDate节点.VisibleIndex = 1;
            nodeDate节点.Width = 130;
            finishDate节点.Caption = "完成日期";
            finishDate节点.VisibleIndex = 2;
            finishDate节点.Width = 130;
            drawingNo节点.Caption = "图号";
            drawingNo节点.VisibleIndex = 3;
            drawingNo节点.Width = 150;
            startUserName节点.Caption = "开始人";
            startUserName节点.VisibleIndex = 4;
            startUserName节点.Width = 80;
            finishUserName节点.Caption = "完成人";
            finishUserName节点.VisibleIndex = 5;
            finishUserName节点.Width = 80;

            //hbFinishDate节点.Caption = "衡变完成时间";
            //hbFinishDate节点.VisibleIndex = 1;
            //hbFinishDate节点.Width = 115;
            //actualStartDate节点.Caption = "实际开始时间";
            //actualStartDate节点.VisibleIndex = 2;
            //actualStartDate节点.Width = 130;
            //startDate节点.Caption = "开始日期";
            //startDate节点.VisibleIndex = 4;
            //startDate节点.Width = 100;
            //status节点.Caption = "状态";
            //status节点.VisibleIndex = 5;
            //status节点.Width = 80;
            //type节点.Caption = "类型";
            //type节点.VisibleIndex = 8;
            //type节点.Width = 70;
            //editDt节点.Caption = "编辑日期";
            //editDt节点.VisibleIndex = 11;
            //editDt节点.Width = 135;
            //createDt节点.Caption = "创建日期";
            //createDt节点.VisibleIndex = 12;
            //createDt节点.Width = 135;
        }

        private void gridView_SCZJH_MergerTable_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (_type == "")
                {
                    //获取光标所在列
                    string mouseColumn = gridView_SCZJH_MergerTable.FocusedColumn.FieldName.ToString();
                    //判断光标是否在行和指定列

                    #region 双击路径

                    //if (mouseColumn == "PartPath"||mouseColumn== "RelativePath")
                    {
                        //取得选定行信息
                        string th = gridView_SCZJH_MergerTable.GetRowCellValue(gridView_SCZJH_MergerTable.FocusedRowHandle, "drawingNo主干").ToString();
                        //弹出节点信息表
                        DataTable targetTable = dt_MergerTable.Clone();
                        foreach (DataRow row in dt_MergerTable.Rows)
                        {
                            if (row["drawingNo主干"].ToString() == th)
                            {
                                targetTable.Rows.Add(row.ItemArray);
                            }
                        }
                        //MES_Manage form = new MES_Manage(targetTable, "工序表");
                        //form.Show();
                        DataTable tempTable = targetTable.Copy();
                        foreach (DataColumn column in tempTable.Columns)
                        {
                            if (column.ColumnName == "name节点" ||
                                column.ColumnName == "nodeDate节点" ||
                                column.ColumnName == "finishDate节点" ||
                                column.ColumnName == "startUserName节点" ||
                                column.ColumnName == "finishUserName节点") { }
                            else
                            {
                                targetTable.Columns.Remove(column.ColumnName);
                            }
                        }
                        targetTable = targetTable.AsEnumerable().
                        OrderBy(row => row.Field<string>("name节点")).
                        ThenBy(row => row.Field<string>("nodeDate节点")).
                        ThenBy(row => row.Field<string>("finishDate节点")).CopyToDataTable();
                        //对产生的表进行去重操作
                        //使用LINQ查询并保留唯一的行
                        var distinctRows = targetTable.AsEnumerable().Distinct(DataRowComparer.Default);
                        //filteredTable存储筛选结果
                        targetTable = distinctRows.CopyToDataTable();

                        gridControl_part.DataSource = targetTable;
                    }

                    #endregion 双击路径
                }
            }
            catch (Exception) { }
        }

        private void SCZJH_TO_SQL_Button_Click(object sender, EventArgs e)
        {
            DataTable dt_SCZJH = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_SCZJH();
            foreach (DataRow row in dt_SCZJH.Rows)
            {
                data_model = pt_MES_SCZJH_data.GetModel(1);
                data_model.productNo = row["productNo"].ToString();
                data_model.model = row["model"].ToString();
                data_model.planCompletime = row["planCompletime"].ToString();
                data_model.dateEnd = row["dateEnd"].ToString();
                data_model.drawingNo = row["drawingNo"].ToString();
                data_model.customerName = row["customerName"].ToString();
                data_model.noTaxAmount = row["noTaxAmount"].ToString();
                data_model.outPut = row["outPut"].ToString();
                data_model.timeLimitName = row["timeLimitName"].ToString();
                data_model.count = row["count"].ToString();
                data_model.stateName = row["stateName"].ToString();
                pt_MES_SCZJH_data.Add(data_model);
            }
            MessageBox.Show("生产主计划，添加完成");
        }

        private void SCZJH_NodeListToSQL_Button_Click(object sender, EventArgs e)
        {
            DataTable dt_SCZJH_nodeList = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_SCZJH_nodeList();
            foreach (DataRow row in dt_SCZJH_nodeList.Rows)
            {
                nodeList_model = pt_MES_SCZJH_nodeList.GetModel(1);
                nodeList_model.createDt = row["createDt"].ToString();
                nodeList_model.editDt = row["editDt"].ToString();
                nodeList_model.drawingNo = row["drawingNo"].ToString();
                nodeList_model.name = row["name"].ToString();
                nodeList_model.type = row["type"].ToString();
                nodeList_model.nodeDate = row["nodeDate"].ToString();
                nodeList_model.finishDate = row["finishDate"].ToString();
                nodeList_model.status = row["status"].ToString();
                nodeList_model.startDate = row["startDate"].ToString();
                nodeList_model.actualStartDate = row["actualStartDate"].ToString();
                nodeList_model.hbFinishDate = row["hbFinishDate"].ToString();
                nodeList_model.startUserName = row["startUserName"].ToString();
                nodeList_model.finishUserName = row["finishUserName"].ToString();
                pt_MES_SCZJH_nodeList.Add(nodeList_model);
            }
            MessageBox.Show("生产主计划节点，添加完成");
        }

        private void UpdateCurrentRowButton_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Sch = _sch;
            Properties.Settings.Default.DrawingNumber = _th;
            PythonConfig pythonConfig = new PythonConfig("SingleDrawUpdate");
            pythonConfig.ShowDialog();
            SingleDrawUpdate singleDrawUpdate = new SingleDrawUpdate();
            bool result = singleDrawUpdate.UpdateToSql();
            if (result) { MessageBox.Show("数据更新完成"); }
            else { MessageBox.Show("处理完成，未更改"); }
            LoadDataTable();
        }

        private void ShowAllSCZJH_Button_Click(object sender, EventArgs e)
        {
            _type = "";
            _th = "";
            LoadDataTable();
        }

        private void gridView_SCZJH_MergerTable_Click(object sender, EventArgs e)
        {
            gridView_SCZJH_MergerTable_DoubleClick(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchControl1.EditValue != null)
            {
                string queryStr = searchControl1.EditValue.ToString();
                LoadDataTable(queryStr);
            }
            else
            {
                LoadDataTable();
            }
        }
    }
}