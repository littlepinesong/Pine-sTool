/*──────────────────────────────────────
* 三维AI设计系统_数据库模板
* ──────────────────────────────────────
* Ver     变更日期    负责人   变更内容
* ──────────────────────────────────────
* V0.1   2018/10/27   陈鹏     模板创建
* V0.2   2019/5/27    陈鹏     增加DIMS模板相关函数
* V0.3   2020/6/26    陈鹏     增加Ext扩展，添加数据库类名获取
* ──────────────────────────────────────
* Copyright (c) 2019-2020 特变电工衡阳变压器有限公司. All rights reserved.
*┌─────────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．      　│
*│　版权所有：特变电工衡阳变压器有限公司  　　　　　　　　　　　　　　      │
*└─────────────────────────────────────┘
* 文    件： View_PT_MES_SCZJH_Merger.cs
* 功    能： 数据库操作_DAL
* 类    名： View_PT_MES_SCZJH_Merger
* 创建时间： 2024/9/5 16:55:49
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/

using Maticsoft.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Pine_sTool.DAL
{
    //View_PT_MES_SCZJH_Merger
    public partial class View_PT_MES_SCZJH_Merger
    {
        public static string TableName = "View_PT_MES_SCZJH_Merger";

        private DbHelperSQLP DbHelperSQL = new DbHelperSQLP(PineConn.SqlConnAuto);

        /// <summary>
        /// 得到数据库访问类名
        /// </summary>
        public DbHelperSQLP DbHelperSql()
        {
            return DbHelperSQL;
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxID()
        {
            return DbHelperSQL.GetMaxID("ID", "View_PT_MES_SCZJH_Merger");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_PT_MES_SCZJH_Merger");
            strSql.Append(" where ");

            SqlParameter[] parameters = {
             };

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Pine_sTool.Model.View_PT_MES_SCZJH_Merger model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into View_PT_MES_SCZJH_Merger(");
            strSql.Append("productNo主干,model主干,planCompletime主干,dateEnd主干,drawingNo主干,customerName主干,noTaxAmount主干,outPut主干,timeLimitName主干,count主干,stateName主干,createDt节点,editDt节点,drawingNo节点,name节点,type节点,nodeDate节点,finishDate节点,status节点,startDate节点,actualStartDate节点,hbFinishDate节点,startUserName节点,finishUserName节点");
            strSql.Append(") values (");
            strSql.Append("@productNo主干,@model主干,@planCompletime主干,@dateEnd主干,@drawingNo主干,@customerName主干,@noTaxAmount主干,@outPut主干,@timeLimitName主干,@count主干,@stateName主干,@createDt节点,@editDt节点,@drawingNo节点,@name节点,@type节点,@nodeDate节点,@finishDate节点,@status节点,@startDate节点,@actualStartDate节点,@hbFinishDate节点,@startUserName节点,@finishUserName节点");
            strSql.Append(") ");

            SqlParameter[] parameters = {
                         new SqlParameter("@productNo主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@model主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@planCompletime主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@dateEnd主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@drawingNo主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@customerName主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@noTaxAmount主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@outPut主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@timeLimitName主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@count主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@stateName主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@createDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@editDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawingNo节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@name节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@type节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@status节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@actualStartDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@hbFinishDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserName节点", SqlDbType.VarChar,-1)
             };

            parameters[0].Value = model.productNo主干;
            parameters[1].Value = model.model主干;
            parameters[2].Value = model.planCompletime主干;
            parameters[3].Value = model.dateEnd主干;
            parameters[4].Value = model.drawingNo主干;
            parameters[5].Value = model.customerName主干;
            parameters[6].Value = model.noTaxAmount主干;
            parameters[7].Value = model.outPut主干;
            parameters[8].Value = model.timeLimitName主干;
            parameters[9].Value = model.count主干;
            parameters[10].Value = model.stateName主干;
            parameters[11].Value = model.createDt节点;
            parameters[12].Value = model.editDt节点;
            parameters[13].Value = model.drawingNo节点;
            parameters[14].Value = model.name节点;
            parameters[15].Value = model.type节点;
            parameters[16].Value = model.nodeDate节点;
            parameters[17].Value = model.finishDate节点;
            parameters[18].Value = model.status节点;
            parameters[19].Value = model.startDate节点;
            parameters[20].Value = model.actualStartDate节点;
            parameters[21].Value = model.hbFinishDate节点;
            parameters[22].Value = model.startUserName节点;
            parameters[23].Value = model.finishUserName节点;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Pine_sTool.Model.View_PT_MES_SCZJH_Merger model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_PT_MES_SCZJH_Merger set ");

            strSql.Append(" productNo主干 = @productNo主干 , ");
            strSql.Append(" model主干 = @model主干 , ");
            strSql.Append(" planCompletime主干 = @planCompletime主干 , ");
            strSql.Append(" dateEnd主干 = @dateEnd主干 , ");
            strSql.Append(" drawingNo主干 = @drawingNo主干 , ");
            strSql.Append(" customerName主干 = @customerName主干 , ");
            strSql.Append(" noTaxAmount主干 = @noTaxAmount主干 , ");
            strSql.Append(" outPut主干 = @outPut主干 , ");
            strSql.Append(" timeLimitName主干 = @timeLimitName主干 , ");
            strSql.Append(" count主干 = @count主干 , ");
            strSql.Append(" stateName主干 = @stateName主干 , ");
            strSql.Append(" createDt节点 = @createDt节点 , ");
            strSql.Append(" editDt节点 = @editDt节点 , ");
            strSql.Append(" drawingNo节点 = @drawingNo节点 , ");
            strSql.Append(" name节点 = @name节点 , ");
            strSql.Append(" type节点 = @type节点 , ");
            strSql.Append(" nodeDate节点 = @nodeDate节点 , ");
            strSql.Append(" finishDate节点 = @finishDate节点 , ");
            strSql.Append(" status节点 = @status节点 , ");
            strSql.Append(" startDate节点 = @startDate节点 , ");
            strSql.Append(" actualStartDate节点 = @actualStartDate节点 , ");
            strSql.Append(" hbFinishDate节点 = @hbFinishDate节点 , ");
            strSql.Append(" startUserName节点 = @startUserName节点 , ");
            strSql.Append(" finishUserName节点 = @finishUserName节点  ");

            strSql.Append(" where  ");

            SqlParameter[] parameters = {
                         new SqlParameter("@productNo主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@model主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@planCompletime主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@dateEnd主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@drawingNo主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@customerName主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@noTaxAmount主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@outPut主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@timeLimitName主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@count主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@stateName主干", SqlDbType.NChar,10) ,
                         new SqlParameter("@createDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@editDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawingNo节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@name节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@type节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@status节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@actualStartDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@hbFinishDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserName节点", SqlDbType.VarChar,-1)
             };

            parameters[0].Value = model.productNo主干;
            parameters[1].Value = model.model主干;
            parameters[2].Value = model.planCompletime主干;
            parameters[3].Value = model.dateEnd主干;
            parameters[4].Value = model.drawingNo主干;
            parameters[5].Value = model.customerName主干;
            parameters[6].Value = model.noTaxAmount主干;
            parameters[7].Value = model.outPut主干;
            parameters[8].Value = model.timeLimitName主干;
            parameters[9].Value = model.count主干;
            parameters[10].Value = model.stateName主干;
            parameters[11].Value = model.createDt节点;
            parameters[12].Value = model.editDt节点;
            parameters[13].Value = model.drawingNo节点;
            parameters[14].Value = model.name节点;
            parameters[15].Value = model.type节点;
            parameters[16].Value = model.nodeDate节点;
            parameters[17].Value = model.finishDate节点;
            parameters[18].Value = model.status节点;
            parameters[19].Value = model.startDate节点;
            parameters[20].Value = model.actualStartDate节点;
            parameters[21].Value = model.hbFinishDate节点;
            parameters[22].Value = model.startUserName节点;
            parameters[23].Value = model.finishUserName节点;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_PT_MES_SCZJH_Merger ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
             };

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Pine_sTool.Model.View_PT_MES_SCZJH_Merger GetModel()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select productNo主干, model主干, planCompletime主干, dateEnd主干, drawingNo主干, customerName主干, noTaxAmount主干, outPut主干, timeLimitName主干, count主干, stateName主干, createDt节点, editDt节点, drawingNo节点, name节点, type节点, nodeDate节点, finishDate节点, status节点, startDate节点, actualStartDate节点, hbFinishDate节点, startUserName节点, finishUserName节点  ");
            strSql.Append("  from View_PT_MES_SCZJH_Merger ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
             };

            Pine_sTool.Model.View_PT_MES_SCZJH_Merger model = new Pine_sTool.Model.View_PT_MES_SCZJH_Merger();

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var row = ds.Tables[0].Rows[0];

                return DataRowToModel(row);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Pine_sTool.Model.View_PT_MES_SCZJH_Merger DataRowToModel(DataRow row)
        {
            Pine_sTool.Model.View_PT_MES_SCZJH_Merger model = new Pine_sTool.Model.View_PT_MES_SCZJH_Merger();
            if (row != null)
            {
                //|string|False|nchar
                if (row["productNo主干"] != DBNull.Value)
                {
                    model.productNo主干 = row["productNo主干"].ToString();
                }

                //|string|False|nchar
                if (row["model主干"] != DBNull.Value)
                {
                    model.model主干 = row["model主干"].ToString();
                }

                //|string|False|nchar
                if (row["planCompletime主干"] != DBNull.Value)
                {
                    model.planCompletime主干 = row["planCompletime主干"].ToString();
                }

                //|string|False|nchar
                if (row["dateEnd主干"] != DBNull.Value)
                {
                    model.dateEnd主干 = row["dateEnd主干"].ToString();
                }

                //|string|False|nchar
                if (row["drawingNo主干"] != DBNull.Value)
                {
                    model.drawingNo主干 = row["drawingNo主干"].ToString();
                }

                //|string|False|nchar
                if (row["customerName主干"] != DBNull.Value)
                {
                    model.customerName主干 = row["customerName主干"].ToString();
                }

                //|string|False|nchar
                if (row["noTaxAmount主干"] != DBNull.Value)
                {
                    model.noTaxAmount主干 = row["noTaxAmount主干"].ToString();
                }

                //|string|False|nchar
                if (row["outPut主干"] != DBNull.Value)
                {
                    model.outPut主干 = row["outPut主干"].ToString();
                }

                //|string|False|nchar
                if (row["timeLimitName主干"] != DBNull.Value)
                {
                    model.timeLimitName主干 = row["timeLimitName主干"].ToString();
                }

                //|string|False|nchar
                if (row["count主干"] != DBNull.Value)
                {
                    model.count主干 = row["count主干"].ToString();
                }

                //|string|False|nchar
                if (row["stateName主干"] != DBNull.Value)
                {
                    model.stateName主干 = row["stateName主干"].ToString();
                }

                //|string|False|varchar
                if (row["createDt节点"] != DBNull.Value)
                {
                    model.createDt节点 = row["createDt节点"].ToString();
                }

                //|string|False|varchar
                if (row["editDt节点"] != DBNull.Value)
                {
                    model.editDt节点 = row["editDt节点"].ToString();
                }

                //|string|False|varchar
                if (row["drawingNo节点"] != DBNull.Value)
                {
                    model.drawingNo节点 = row["drawingNo节点"].ToString();
                }

                //|string|False|varchar
                if (row["name节点"] != DBNull.Value)
                {
                    model.name节点 = row["name节点"].ToString();
                }

                //|string|False|varchar
                if (row["type节点"] != DBNull.Value)
                {
                    model.type节点 = row["type节点"].ToString();
                }

                //|string|False|varchar
                if (row["nodeDate节点"] != DBNull.Value)
                {
                    model.nodeDate节点 = row["nodeDate节点"].ToString();
                }

                //|string|False|varchar
                if (row["finishDate节点"] != DBNull.Value)
                {
                    model.finishDate节点 = row["finishDate节点"].ToString();
                }

                //|string|False|varchar
                if (row["status节点"] != DBNull.Value)
                {
                    model.status节点 = row["status节点"].ToString();
                }

                //|string|False|varchar
                if (row["startDate节点"] != DBNull.Value)
                {
                    model.startDate节点 = row["startDate节点"].ToString();
                }

                //|string|False|varchar
                if (row["actualStartDate节点"] != DBNull.Value)
                {
                    model.actualStartDate节点 = row["actualStartDate节点"].ToString();
                }

                //|string|False|varchar
                if (row["hbFinishDate节点"] != DBNull.Value)
                {
                    model.hbFinishDate节点 = row["hbFinishDate节点"].ToString();
                }

                //|string|False|varchar
                if (row["startUserName节点"] != DBNull.Value)
                {
                    model.startUserName节点 = row["startUserName节点"].ToString();
                }

                //|string|False|varchar
                if (row["finishUserName节点"] != DBNull.Value)
                {
                    model.finishUserName节点 = row["finishUserName节点"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM View_PT_MES_SCZJH_Merger ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM View_PT_MES_SCZJH_Merger ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM View_PT_MES_SCZJH_Merger ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by " + orderby);
            }
            else
            {
                strSql.Append("order by Id desc");
            }
            strSql.Append(")AS Row, T.*  from View_PT_MES_SCZJH_Merger T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public static class Cols
        {
            public static string productNo主干 = "productNo主干";
            public static string model主干 = "model主干";
            public static string planCompletime主干 = "planCompletime主干";
            public static string dateEnd主干 = "dateEnd主干";
            public static string drawingNo主干 = "drawingNo主干";
            public static string customerName主干 = "customerName主干";
            public static string noTaxAmount主干 = "noTaxAmount主干";
            public static string outPut主干 = "outPut主干";
            public static string timeLimitName主干 = "timeLimitName主干";
            public static string count主干 = "count主干";
            public static string stateName主干 = "stateName主干";
            public static string createDt节点 = "createDt节点";
            public static string editDt节点 = "editDt节点";
            public static string drawingNo节点 = "drawingNo节点";
            public static string name节点 = "name节点";
            public static string type节点 = "type节点";
            public static string nodeDate节点 = "nodeDate节点";
            public static string finishDate节点 = "finishDate节点";
            public static string status节点 = "status节点";
            public static string startDate节点 = "startDate节点";
            public static string actualStartDate节点 = "actualStartDate节点";
            public static string hbFinishDate节点 = "hbFinishDate节点";
            public static string startUserName节点 = "startUserName节点";
            public static string finishUserName节点 = "finishUserName节点";
        }
    }
}