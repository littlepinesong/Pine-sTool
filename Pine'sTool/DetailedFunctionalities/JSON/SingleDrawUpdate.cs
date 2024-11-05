using System.Data;
using System.IO;
using PT_MES_SCZJH_data_BLL = Pine_sTool.BLL.PT_MES_SCZJH_data;
using PT_MES_SCZJH_data_Model = Pine_sTool.Model.PT_MES_SCZJH_data;
using PT_MES_SCZJH_nodeList_BLL = Pine_sTool.BLL.PT_MES_SCZJH_nodeList;
using PT_MES_SCZJH_nodeList_Model = Pine_sTool.Model.PT_MES_SCZJH_nodeList;
using View_PT_MES_SCZJH_Merger_BLL = Pine_sTool.BLL.View_PT_MES_SCZJH_Merger;

namespace Pine_sTool.DetailedFunctionalities.JSON
{
    /// <summary>
    /// 用于MES当中的单个图号更新操作
    /// </summary>
    internal class SingleDrawUpdate
    {
        private PT_MES_SCZJH_data_BLL pt_MES_SCZJH_data = new PT_MES_SCZJH_data_BLL();
        private PT_MES_SCZJH_data_Model data_model = new PT_MES_SCZJH_data_Model();
        private PT_MES_SCZJH_nodeList_BLL pt_MES_SCZJH_nodeList = new PT_MES_SCZJH_nodeList_BLL();
        private PT_MES_SCZJH_nodeList_Model nodeList_model = new PT_MES_SCZJH_nodeList_Model();
        private View_PT_MES_SCZJH_Merger_BLL MergerTable = new View_PT_MES_SCZJH_Merger_BLL();

        /// <summary>
        /// 脚本导出文件路径
        /// </summary>
        public static string _filePath = @"C:\松的工具系统日志\数据\MES_SingleDrawNumDataOutput.txt";

        /// <summary>
        /// 单项更新的图号
        /// </summary>
        private static string _DrawingNumber = Pine_sTool.Properties.Settings.Default.DrawingNumber;

        /// <summary>
        /// 获取当前展示给用户的全表数据
        /// </summary>
        /// <returns>返回显示全表</returns>
        private DataTable GetCurrentShowTable()
        {
            MES.MES_Manage_New newForm = new MES.MES_Manage_New();
            DataTable currentShowTable = newForm.LoadDataTable("");
            return currentShowTable;
        }

        /// <summary>
        /// 返回读取获取输出文件当中含有所需图号的表单
        /// </summary>
        /// <returns></returns>
        private DataTable GetSingleDrawNumOutPutTable()
        {
            //获取输出文件的融合表
            JSON_TO_DataTable._filePath = Path.Combine(_filePath);
            DataTable outPutTable = JSON_TO_DataTable.Conver_MergerTable();
            DataTable returnTable = outPutTable.Clone();
            foreach (DataRow row in outPutTable.Rows)
            {
                if (row["drawingNo主干"].ToString() == _DrawingNumber)
                {
                    returnTable.Rows.Add(row.ItemArray);
                }
            }
            return returnTable;
        }

        public bool UpdateToSql()
        {
            bool flag = false;
            DataTable showTable = GetCurrentShowTable();
            DataTable updateTable = GetSingleDrawNumOutPutTable();
            if (updateTable.Rows.Count > 0)
            {
                if (showTable.Rows.Count > 0)
                {
                    foreach (DataRow row in showTable.Rows)
                    {
                        if (row["drawingNo主干"].ToString() == updateTable.Rows[0]["drawingNo主干"].ToString())
                        {
                            foreach (DataColumn column in showTable.Columns)
                            {
                                if (row[column.ColumnName].ToString() != updateTable.Rows[0][column.ColumnName].ToString())
                                {
                                    //更新生产主计划
                                    JSON_TO_DataTable._filePath = _filePath;
                                    DataTable dt_SCZJH = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_SCZJH();
                                    foreach (DataRow row1 in updateTable.Rows)
                                    {
                                        data_model = pt_MES_SCZJH_data.GetModel(1);
                                        data_model.productNo = row1["productNo主干"].ToString();
                                        data_model.model = row1["model主干"].ToString();
                                        data_model.planCompletime = row1["planCompletime主干"].ToString();
                                        data_model.dateEnd = row1["dateEnd主干"].ToString();
                                        data_model.drawingNo = row1["drawingNo主干"].ToString();
                                        data_model.customerName = row1["customerName主干"].ToString();
                                        data_model.noTaxAmount = row1["noTaxAmount主干"].ToString();
                                        data_model.outPut = row1["outPut主干"].ToString();
                                        data_model.timeLimitName = row1["timeLimitName主干"].ToString();
                                        data_model.count = row1["count主干"].ToString();
                                        data_model.stateName = row1["stateName主干"].ToString();
                                        pt_MES_SCZJH_data.Add(data_model);
                                    }

                                    //更新生产主计划节点表
                                    DataTable dt_SCZJH_nodeList = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_SCZJH_nodeList();
                                    foreach (DataRow row2 in updateTable.Rows)
                                    {
                                        nodeList_model = pt_MES_SCZJH_nodeList.GetModel(1);
                                        nodeList_model.createDt = row2["createDt节点"].ToString();
                                        nodeList_model.editDt = row2["editDt节点"].ToString();
                                        nodeList_model.drawingNo = row2["drawingNo节点"].ToString();
                                        nodeList_model.name = row2["name节点"].ToString();
                                        nodeList_model.type = row2["type节点"].ToString();
                                        nodeList_model.nodeDate = row2["nodeDate节点"].ToString();
                                        nodeList_model.finishDate = row2["finishDate节点"].ToString();
                                        nodeList_model.status = row2["status节点"].ToString();
                                        nodeList_model.startDate = row2["startDate节点"].ToString();
                                        nodeList_model.actualStartDate = row2["actualStartDate节点"].ToString();
                                        nodeList_model.hbFinishDate = row2["hbFinishDate节点"].ToString();
                                        nodeList_model.startUserName = row2["startUserName节点"].ToString();
                                        nodeList_model.finishUserName = row2["finishUserName节点"].ToString();
                                        pt_MES_SCZJH_nodeList.Add(nodeList_model);
                                    }

                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    //更新生产主计划
                    JSON_TO_DataTable._filePath = _filePath;
                    DataTable dt_SCZJH = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_SCZJH();
                    foreach (DataRow row1 in updateTable.Rows)
                    {
                        data_model = pt_MES_SCZJH_data.GetModel(1);
                        data_model.productNo = row1["productNo主干"].ToString();
                        data_model.model = row1["model主干"].ToString();
                        data_model.planCompletime = row1["planCompletime主干"].ToString();
                        data_model.dateEnd = row1["dateEnd主干"].ToString();
                        data_model.drawingNo = row1["drawingNo主干"].ToString();
                        data_model.customerName = row1["customerName主干"].ToString();
                        data_model.noTaxAmount = row1["noTaxAmount主干"].ToString();
                        data_model.outPut = row1["outPut主干"].ToString();
                        data_model.timeLimitName = row1["timeLimitName主干"].ToString();
                        data_model.count = row1["count主干"].ToString();
                        data_model.stateName = row1["stateName主干"].ToString();
                        pt_MES_SCZJH_data.Add(data_model);
                    }

                    //更新生产主计划节点表
                    DataTable dt_SCZJH_nodeList = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_SCZJH_nodeList();
                    foreach (DataRow row2 in updateTable.Rows)
                    {
                        nodeList_model = pt_MES_SCZJH_nodeList.GetModel(1);
                        nodeList_model.createDt = row2["createDt节点"].ToString();
                        nodeList_model.editDt = row2["editDt节点"].ToString();
                        nodeList_model.drawingNo = row2["drawingNo节点"].ToString();
                        nodeList_model.name = row2["name节点"].ToString();
                        nodeList_model.type = row2["type节点"].ToString();
                        nodeList_model.nodeDate = row2["nodeDate节点"].ToString();
                        nodeList_model.finishDate = row2["finishDate节点"].ToString();
                        nodeList_model.status = row2["status节点"].ToString();
                        nodeList_model.startDate = row2["startDate节点"].ToString();
                        nodeList_model.actualStartDate = row2["actualStartDate节点"].ToString();
                        nodeList_model.hbFinishDate = row2["hbFinishDate节点"].ToString();
                        nodeList_model.startUserName = row2["startUserName节点"].ToString();
                        nodeList_model.finishUserName = row2["finishUserName节点"].ToString();
                        pt_MES_SCZJH_nodeList.Add(nodeList_model);
                    }
                    flag = true;
                }
            }
            return flag;
        }
    }
}