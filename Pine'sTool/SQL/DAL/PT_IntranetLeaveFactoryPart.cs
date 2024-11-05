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
* 文    件： PT_IntranetLeaveFactoryPart.cs
* 功    能： 数据库操作_DAL
* 类    名： PT_IntranetLeaveFactoryPart
* 创建时间： 2024/8/1 15:48:17
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/

using Maticsoft.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Pine_sTool.DAL
{
    //PT_IntranetLeaveFactoryPart
    public partial class PT_IntranetLeaveFactoryPart
    {
        public static string TableName = "PT_IntranetLeaveFactoryPart";

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
            return DbHelperSQL.GetMaxID("ID", "PT_IntranetLeaveFactoryPart");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PT_IntranetLeaveFactoryPart");
            strSql.Append(" where ");

            SqlParameter[] parameters = {
             };

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Pine_sTool.Model.PT_IntranetLeaveFactoryPart model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PT_IntranetLeaveFactoryPart(");
            strSql.Append("PartName,lot_no,fileSum,PartPath,RelativePath");
            strSql.Append(") values (");
            strSql.Append("@PartName,@lot_no,@fileSum,@PartPath,@RelativePath");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                         new SqlParameter("@PartName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@lot_no", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@fileSum", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@PartPath", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@RelativePath", SqlDbType.VarChar,-1)
             };

            parameters[0].Value = model.PartName;
            parameters[1].Value = model.lot_no;
            parameters[2].Value = model.fileSum;
            parameters[3].Value = model.PartPath;
            parameters[4].Value = model.RelativePath;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Pine_sTool.Model.PT_IntranetLeaveFactoryPart model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PT_IntranetLeaveFactoryPart set ");

            strSql.Append(" PartName = @PartName , ");
            strSql.Append(" lot_no = @lot_no , ");
            strSql.Append(" fileSum = @fileSum , ");
            strSql.Append(" PartPath = @PartPath , ");
            strSql.Append(" RelativePath = @RelativePath  ");

            strSql.Append(" where  ");

            SqlParameter[] parameters = {
                         new SqlParameter("@ID", SqlDbType.Int,4) ,
                         new SqlParameter("@PartName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@lot_no", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@fileSum", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@PartPath", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@RelativePath", SqlDbType.VarChar,-1)
             };

            parameters[0].Value = model.ID;
            parameters[1].Value = model.PartName;
            parameters[2].Value = model.lot_no;
            parameters[3].Value = model.fileSum;
            parameters[4].Value = model.PartPath;
            parameters[5].Value = model.RelativePath;
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
            strSql.Append("delete from PT_IntranetLeaveFactoryPart ");
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
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PT_IntranetLeaveFactoryPart ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Pine_sTool.Model.PT_IntranetLeaveFactoryPart GetModel()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, PartName, lot_no, fileSum, PartPath, RelativePath  ");
            strSql.Append("  from PT_IntranetLeaveFactoryPart ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
             };

            Pine_sTool.Model.PT_IntranetLeaveFactoryPart model = new Pine_sTool.Model.PT_IntranetLeaveFactoryPart();

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
        public Pine_sTool.Model.PT_IntranetLeaveFactoryPart DataRowToModel(DataRow row)
        {
            Pine_sTool.Model.PT_IntranetLeaveFactoryPart model = new Pine_sTool.Model.PT_IntranetLeaveFactoryPart();
            if (row != null)
            {
                //|int|True|int
                if (row["ID"] != DBNull.Value && !string.IsNullOrEmpty(row["ID"].ToString()))
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }

                //|string|False|varchar
                if (row["PartName"] != DBNull.Value)
                {
                    model.PartName = row["PartName"].ToString();
                }

                //|string|False|varchar
                if (row["lot_no"] != DBNull.Value)
                {
                    model.lot_no = row["lot_no"].ToString();
                }

                //|string|False|varchar
                if (row["fileSum"] != DBNull.Value)
                {
                    model.fileSum = row["fileSum"].ToString();
                }

                //|string|False|varchar
                if (row["PartPath"] != DBNull.Value)
                {
                    model.PartPath = row["PartPath"].ToString();
                }

                //|string|False|varchar
                if (row["RelativePath"] != DBNull.Value)
                {
                    model.RelativePath = row["RelativePath"].ToString();
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
            strSql.Append(" FROM PT_IntranetLeaveFactoryPart ");
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
            strSql.Append(" FROM PT_IntranetLeaveFactoryPart ");
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
            strSql.Append("select count(1) FROM PT_IntranetLeaveFactoryPart ");
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
            strSql.Append(")AS Row, T.*  from PT_IntranetLeaveFactoryPart T ");
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
            public static string ID = "ID";
            public static string PartName = "PartName";
            public static string lot_no = "lot_no";
            public static string fileSum = "fileSum";
            public static string PartPath = "PartPath";
            public static string RelativePath = "RelativePath";
        }
    }
}