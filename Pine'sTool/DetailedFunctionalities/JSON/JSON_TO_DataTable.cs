using System.Collections.Generic;
using System.Data;
using System.IO;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PT_MES_SCZJH_data_BLL = Pine_sTool.BLL.PT_MES_SCZJH_data;
using PT_MES_SCZJH_nodeList_BLL = Pine_sTool.BLL.PT_MES_SCZJH_nodeList;
using PT_MES_SCZJH_MergerTable = Pine_sTool.BLL.PT_MES_SCZJH_MergerTable;

namespace Pine_sTool.DetailedFunctionalities.JSON
{
    public class JSON_TO_DataTable
    {
        public static string _filePath = @"‪E:\打包文件\往期工作文件\2024年09月工作文件\2024年09月02日文件\output_2.txt";
        public static string _filePath_JDCX = @"D:\176630\Desktop\每日工作文件\2024年09月02日文件\工单各阶段状态.txt";//进度查询
        public static DataTable Convert_SCZJH(string typeStr = "生产主计划")
        {
            string json = "";
            // 文件路径
            string filePath = _filePath;//生产主计划
            try { json = File.ReadAllText(filePath); }
            catch (FileNotFoundException ex) { Console.WriteLine("文件未找到: " + ex.Message); }
            catch (UnauthorizedAccessException ex) { Console.WriteLine("没有权限访问文件: " + ex.Message); }
            catch (Exception ex) { Console.WriteLine("读取文件时发生错误: " + ex.Message); }
            JObject jsonObject = new JObject();
            DataTable dataTable_sczjh = new DataTable();
            if (typeStr == "生产主计划")
            {
                System.Text.Encoding type;
                try
                {
                    File.ReadLines(filePath, System.Text.Encoding.Default);
                    type = System.Text.Encoding.Default;
                }
                catch (Exception)
                {
                    File.ReadLines(filePath, System.Text.Encoding.UTF8);
                    type = System.Text.Encoding.UTF8;
                }
                foreach (var line in File.ReadLines(filePath, type))
                {
                    try
                    {
                        // 尝试解析为 JObject（如果是 JSON 对象）
                        jsonObject = JObject.Parse(line);
                        // 提取节点数据
                        var dataList_data = (jsonObject["data"] as JArray);
                        // 将节点数据转换为 DataTable
                        dataTable_sczjh=(GreatPineMerge(dataTable_sczjh, dataList_data)).Copy();
                        int sczjhCount2 = dataTable_sczjh.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"JSON Parsing Error: {ex.Message}");
                    }
                }
            }
            foreach (DataColumn column in dataTable_sczjh.Columns)
            {
                string name = column.Caption;
            }
            //int rowCount = dataTable_sczjh_nodeList.Rows.Count;
            int rowCount2 = dataTable_sczjh.Rows.Count;
            // 输出 DataTable 到 CSV 文件
            ExportDataTableToCsv(dataTable_sczjh, "生产主计划.csv");
            return dataTable_sczjh;
        }
        private static DataTable GetMergerTable(DataTable dataTable_MergerTable, DataTable dataTable_sczjh, DataTable dataTable_sczjh_nodeList)
        {
            foreach (DataRow row in dataTable_sczjh.Rows)
            {
                foreach (DataRow rowNode in dataTable_sczjh_nodeList.Rows)
                {
                    if (row["drawingNo"].ToString() == rowNode["drawingNo"].ToString())
                    {
                        DataRow mergerRow = dataTable_MergerTable.NewRow();
                        foreach (DataColumn column in dataTable_sczjh.Columns)
                        {
                            mergerRow[column.ColumnName + "主干"] = row[column.ColumnName].ToString();
                        }
                        foreach (DataColumn columnNode in dataTable_sczjh_nodeList.Columns)
                        {
                            mergerRow[columnNode.ColumnName + "节点"] = rowNode[columnNode.ColumnName].ToString();
                        }
                        dataTable_MergerTable.Rows.Add(mergerRow.ItemArray);
                    }
                }
            }
            return dataTable_MergerTable;
        }
        /// <summary>
        /// 使用internal,使之在同一程序集当中可以访问
        /// </summary>
        /// <param name="typeStr"></param>
        /// <returns></returns>
        internal static DataTable Conver_MergerTable(string typeStr = "合并节点表")
        {
            string json = "";
            // 文件路径
            string filePath = _filePath;//生产主计划
            try { json = File.ReadAllText(filePath); }
            catch (FileNotFoundException ex) { Console.WriteLine("文件未找到: " + ex.Message); }
            catch (UnauthorizedAccessException ex) { Console.WriteLine("没有权限访问文件: " + ex.Message); }
            catch (Exception ex) { Console.WriteLine("读取文件时发生错误: " + ex.Message); }
            JObject jsonObject = new JObject();
            DataTable dataTable_MergerTable = new DataTable();
            DataTable result_sczjh = new DataTable()
            {
                Columns =
                    {
                        new DataColumn("productNo",typeof(string)),
                        new DataColumn("model",typeof(string)),
                        new DataColumn("planCompletime",typeof(string)),
                        new DataColumn("dateEnd",typeof(string)),
                        new DataColumn("drawingNo",typeof(string)),
                        new DataColumn("customerName",typeof(string)),
                        new DataColumn("noTaxAmount",typeof(string)),
                        new DataColumn("outPut",typeof(string)),
                        new DataColumn("timeLimitName",typeof(string)),
                        new DataColumn("count",typeof(string)),
                        new DataColumn("stateName",typeof(string)),
                    }
            };
            
            DataTable result_sczjh_nodeList = new DataTable()
            {
                Columns =
                    {
                        new DataColumn("createDt",typeof(string)),
                        new DataColumn("editDt",typeof(string)),
                        new DataColumn("drawingNo",typeof(string)),
                        new DataColumn("name",typeof(string)),
                        new DataColumn("type",typeof(string)),
                        new DataColumn("nodeDate",typeof(string)),
                        new DataColumn("finishDate",typeof(string)),
                        new DataColumn("status",typeof(string)),
                        new DataColumn("startDate",typeof(string)),
                        new DataColumn("actualStartDate",typeof(string)),
                        new DataColumn("hbFinishDate",typeof(string)),
                        new DataColumn("startUserName",typeof(string)),
                        new DataColumn("finishUserName",typeof(string)),
                    }
            };
            if (typeStr == "合并节点表")
            {
                System.Text.Encoding type;
                try
                {
                    File.ReadLines(filePath, System.Text.Encoding.Default);
                    type = System.Text.Encoding.Default;
                }
                catch (Exception e)
                {
                    File.ReadLines(filePath, System.Text.Encoding.UTF8);
                    type = System.Text.Encoding.UTF8;
                }
                foreach (var line in File.ReadLines(filePath, type))
                {
                    DataTable dataTable_sczjh = new DataTable();
                    try
                    {
                        // 尝试解析为 JObject（如果是 JSON 对象）
                        jsonObject = JObject.Parse(line);
                        // 提取节点数据
                        var dataList_data = (jsonObject["data"] as JArray);
                        for (int i = 0; i < dataList_data.Count; i++)
                        {
                            DataTable dataTable_sczjh_nodeList = new DataTable();
                            var dataList_nodeList = (jsonObject["data"] as JArray)[i]["nodeList"] as JArray;
                            dataTable_sczjh_nodeList = (GreatPineMerge(dataTable_sczjh_nodeList, dataList_nodeList)).Copy();
                            dataTable_sczjh_nodeList = (GreatPineCopy(result_sczjh_nodeList, dataTable_sczjh_nodeList)).Copy();
                            dataTable_sczjh_nodeList.Dispose();
                        }
                        // 将节点数据转换为 DataTable
                        dataTable_sczjh = (GreatPineMerge(dataTable_sczjh, dataList_data)).Copy();
                        //因为造成了内存溢出,所以进行列筛选
                        result_sczjh = (GreatPineCopy(result_sczjh, dataTable_sczjh)).Copy();
                        dataTable_sczjh.Dispose();
                        int sczjhCount2 = dataTable_sczjh.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"JSON Parsing Error: {ex.Message}");
                    }
                }

                int sczjhCount = result_sczjh.Rows.Count;
                if (dataTable_MergerTable.Rows.Count > 0)
                {
                    dataTable_MergerTable = GetMergerTable(dataTable_MergerTable, result_sczjh, result_sczjh_nodeList).Copy();
                }
                else
                {
                    foreach (DataColumn column in result_sczjh.Columns)
                    {
                        dataTable_MergerTable.Columns.Add(column.ColumnName + "主干");
                    }
                    foreach (DataColumn column in result_sczjh_nodeList.Columns)
                    {
                        dataTable_MergerTable.Columns.Add(column.ColumnName + "节点");
                    }
                    dataTable_MergerTable = GetMergerTable(dataTable_MergerTable, result_sczjh, result_sczjh_nodeList).Copy();
                }
            }
            foreach (DataColumn column in dataTable_MergerTable.Columns)
            {
                string name = column.Caption;
            }
            //int rowCount = dataTable_sczjh_nodeList.Rows.Count;
            int rowCount2 = dataTable_MergerTable.Rows.Count;
            // 输出 DataTable 到 CSV 文件
            ExportDataTableToCsv(dataTable_MergerTable, "生产主计划_合并节点表.csv");
            return dataTable_MergerTable;
        }

        private static DataTable GreatPineCopy(DataTable tableTarget, DataTable tableSource)
        {
            foreach (DataRow row in tableSource.Rows)
            {
                DataRow newrow = tableTarget.NewRow();
                foreach (DataColumn column in tableTarget.Columns)
                {
                    newrow[column.ColumnName] = row[column.ColumnName].ToString();
                }
                tableTarget.Rows.Add(newrow.ItemArray);
            }
            return tableTarget;
        }

        private static DataTable GreatPineMerge(DataTable table, JArray data)
        {
            table = ConvertToStringTable(table);
            if (table.Rows.Count > 0)
            {
                DataTable tempTable = (DataTable)JsonConvert.DeserializeObject(data.ToString(), (typeof(DataTable)));
                foreach (DataRow row in tempTable.Rows)
                {
                    DataRow newRow = table.NewRow();
                    foreach (DataColumn column in table.Columns)
                    {
                        newRow[column.ColumnName] = row[column.ColumnName].ToString();
                    }
                    table.Rows.Add(newRow.ItemArray);
                }
            }
            else
            {
                table.Merge((DataTable)JsonConvert.DeserializeObject(data.ToString(), (typeof(DataTable))));
            }
            return table;
        }

        public static DataTable Convert_SCZJH_nodeList(string typeStr = "生产主计划_节点表")
        {
            string json = "";

            // 文件路径
            string filePath = _filePath;//生产主计划
            //string filePath = @"D:\176630\Desktop\每日工作文件\2024年09月02日文件\TZ230958A工单各阶段状态-planid_20231102122321765321011790791333.txt";//进度查询

            try
            {
                // 读取文件内容
                json = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException ex) { Console.WriteLine("文件未找到: " + ex.Message); }
            catch (UnauthorizedAccessException ex) { Console.WriteLine("没有权限访问文件: " + ex.Message); }
            catch (Exception ex) { Console.WriteLine("读取文件时发生错误: " + ex.Message); }
            JObject jsonObject = new JObject();
            DataTable dataTable_sczjh_nodeList = new DataTable();
            if (typeStr == "生产主计划_节点表")
            {
                System.Text.Encoding type;
                try
                {
                    File.ReadLines(filePath, System.Text.Encoding.Default);
                    type = System.Text.Encoding.Default;
                }
                catch (Exception)
                {
                    File.ReadLines(filePath, System.Text.Encoding.UTF8);
                    type = System.Text.Encoding.UTF8;
                }
                foreach (var line in File.ReadLines(filePath, type))
                {
                    try
                    {
                        // 尝试解析为 JObject（如果是 JSON 对象）
                        jsonObject = JObject.Parse(line);
                        // 提取节点数据
                        var dataList_data = (jsonObject["data"] as JArray);
                        for (int i = 0; i < dataList_data.Count; i++)
                        {
                            var dataList_nodeList = (jsonObject["data"] as JArray)[i]["nodeList"] as JArray;
                            dataTable_sczjh_nodeList=(GreatPineMerge(dataTable_sczjh_nodeList, dataList_nodeList)).Copy();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"JSON Parsing Error: {ex.Message}");
                    }
                }
            }
            foreach (DataColumn column in dataTable_sczjh_nodeList.Columns)
            {
                string name = column.Caption;
            }
            int rowCount = dataTable_sczjh_nodeList.Rows.Count;
            //int rowCount2 = dataTable2.Rows.Count;
            // 输出 DataTable 到 CSV 文件
            ExportDataTableToCsv(dataTable_sczjh_nodeList, "生产主计划_节点表.csv");
            return dataTable_sczjh_nodeList;
        }

        public static DataTable Convert_JDCX(string typeStr = "进度查询")
        {
            string json = "";

            // 文件路径
            //string filePath = @"E:\打包文件\往期工作文件\2024年08月工作文件\2024年08月29日文件\output_2.txt";//生产主计划
            string filePath = _filePath_JDCX;//进度查询

            try
            {
                // 读取文件内容
                json = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException ex) { Console.WriteLine("文件未找到: " + ex.Message); }
            catch (UnauthorizedAccessException ex) { Console.WriteLine("没有权限访问文件: " + ex.Message); }
            catch (Exception ex) { Console.WriteLine("读取文件时发生错误: " + ex.Message); }

            JObject jsonObject = new JObject();
            DataTable dataTable_jdcx = new DataTable();

            if (typeStr == "进度查询")
            {
                JObject jobject = JObject.Parse(json);
                JArray jArray = (JArray)jobject["data"];
                foreach (JObject row in jArray)
                {
                    if (dataTable_jdcx.Columns.Count == 0)
                    {
                        foreach (var property in row.Properties())
                        {
                            dataTable_jdcx.Columns.Add(property.Name);
                        }
                    }
                    DataRow dataRow = dataTable_jdcx.NewRow();
                    foreach (var property in row.Properties())
                    {
                        dataRow[property.Name] = property.Value.ToString();
                    }
                    dataTable_jdcx.Rows.Add(dataRow);
                }
            }
            foreach (DataColumn column in dataTable_jdcx.Columns)
            {
                string name = column.Caption;
            }
            // 输出 DataTable 到 CSV 文件
            ExportDataTableToCsv(dataTable_jdcx, "生产主计划_进度查询.csv");
            return dataTable_jdcx;
        }

        static void ExportDataTableToCsv(DataTable dataTable, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // 写入列名
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (i > 0) sw.Write(",");
                    sw.Write(dataTable.Columns[i].ColumnName);
                }
                sw.WriteLine();

                // 写入行数据
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        if (i > 0) sw.Write(",");
                        sw.Write(row[i].ToString());
                    }
                    sw.WriteLine();
                }
            }
        }
        /// <summary>
        /// 将数据表转化为所有列均为string类型的数据表
        /// </summary>
        /// <param name="originalTable"></param>
        /// <returns></returns>
        public static DataTable ConvertToStringTable(DataTable originalTable)
        {
            DataTable newTable = new DataTable();
            foreach (DataColumn col in originalTable.Columns)
            {
                newTable.Columns.Add(col.ColumnName, typeof(string));
            }
            foreach (DataRow row in originalTable.Rows)
            {
                DataRow newRow = newTable.NewRow();
                for (int i = 0; i < originalTable.Columns.Count; i++)
                {
                    if (string.IsNullOrEmpty(row[i].ToString()))
                    {
                        newRow[i] = "";
                    }
                    else
                    {
                        newRow[i] = row[i].ToString();
                    }
                }
                newTable.Rows.Add(newRow);
            }
            return newTable;
        }
    }
}
