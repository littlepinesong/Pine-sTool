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
* 文    件： PT_MES_SCZJH_nodeList.cs
* 功    能： 数据库操作_DAL
* 类    名： PT_MES_SCZJH_nodeList
* 创建时间： 2024/9/2 14:57:14
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/

using Maticsoft.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Pine_sTool.DAL
{
    //PT_MES_SCZJH_nodeList
    public partial class PT_MES_SCZJH_nodeList
    {
        public static string TableName = "PT_MES_SCZJH_nodeList";

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
            return DbHelperSQL.GetMaxID("ID", "PT_MES_SCZJH_nodeList");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PT_MES_SCZJH_nodeList");
            strSql.Append(" where ");

            SqlParameter[] parameters = {
             };

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Pine_sTool.Model.PT_MES_SCZJH_nodeList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PT_MES_SCZJH_nodeList(");
            strSql.Append("id,ztbm,createDt,editDt,isDeleted,deleteDt,productPlanId,drawingNo,name,type,nodeDate,finishDate,ruleConfig,status,progressStatus,confirmStatus,sentKey2Wms,wmsMid,startDate,actualStartDate,nodeId,nodeName,isMaterialPreparation,materialVersion,usedEquipment,pauseReason,describe,bomInfo,recordId,isOutsourcing,hbFinishDate,outsourcingSituation,outsourcingSetTime,finishUserId,finishUserName,startUserId,startUserName,pauseDuration,drawPhase,drawPlanFinishTime,drawActualFinishTime,chargePersonName,difDay,hashCode");
            strSql.Append(") values (");
            strSql.Append("@id,@ztbm,@createDt,@editDt,@isDeleted,@deleteDt,@productPlanId,@drawingNo,@name,@type,@nodeDate,@finishDate,@ruleConfig,@status,@progressStatus,@confirmStatus,@sentKey2Wms,@wmsMid,@startDate,@actualStartDate,@nodeId,@nodeName,@isMaterialPreparation,@materialVersion,@usedEquipment,@pauseReason,@describe,@bomInfo,@recordId,@isOutsourcing,@hbFinishDate,@outsourcingSituation,@outsourcingSetTime,@finishUserId,@finishUserName,@startUserId,@startUserName,@pauseDuration,@drawPhase,@drawPlanFinishTime,@drawActualFinishTime,@chargePersonName,@difDay,@hashCode");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                         new SqlParameter("@id", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ztbm", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@createDt", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@editDt", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isDeleted", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@deleteDt", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productPlanId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawingNo", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@name", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@type", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ruleConfig", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@status", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@progressStatus", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@confirmStatus", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@sentKey2Wms", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@wmsMid", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@actualStartDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isMaterialPreparation", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@materialVersion", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@usedEquipment", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseReason", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@describe", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@bomInfo", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@recordId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isOutsourcing", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@hbFinishDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outsourcingSituation", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outsourcingSetTime", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseDuration", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawPhase", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawPlanFinishTime", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawActualFinishTime", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@chargePersonName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@difDay", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@hashCode", SqlDbType.VarChar,-1)
             };

            parameters[0].Value = model.id;
            parameters[1].Value = model.ztbm;
            parameters[2].Value = model.createDt;
            parameters[3].Value = model.editDt;
            parameters[4].Value = model.isDeleted;
            parameters[5].Value = model.deleteDt;
            parameters[6].Value = model.productPlanId;
            parameters[7].Value = model.drawingNo;
            parameters[8].Value = model.name;
            parameters[9].Value = model.type;
            parameters[10].Value = model.nodeDate;
            parameters[11].Value = model.finishDate;
            parameters[12].Value = model.ruleConfig;
            parameters[13].Value = model.status;
            parameters[14].Value = model.progressStatus;
            parameters[15].Value = model.confirmStatus;
            parameters[16].Value = model.sentKey2Wms;
            parameters[17].Value = model.wmsMid;
            parameters[18].Value = model.startDate;
            parameters[19].Value = model.actualStartDate;
            parameters[20].Value = model.nodeId;
            parameters[21].Value = model.nodeName;
            parameters[22].Value = model.isMaterialPreparation;
            parameters[23].Value = model.materialVersion;
            parameters[24].Value = model.usedEquipment;
            parameters[25].Value = model.pauseReason;
            parameters[26].Value = model.describe;
            parameters[27].Value = model.bomInfo;
            parameters[28].Value = model.recordId;
            parameters[29].Value = model.isOutsourcing;
            parameters[30].Value = model.hbFinishDate;
            parameters[31].Value = model.outsourcingSituation;
            parameters[32].Value = model.outsourcingSetTime;
            parameters[33].Value = model.finishUserId;
            parameters[34].Value = model.finishUserName;
            parameters[35].Value = model.startUserId;
            parameters[36].Value = model.startUserName;
            parameters[37].Value = model.pauseDuration;
            parameters[38].Value = model.drawPhase;
            parameters[39].Value = model.drawPlanFinishTime;
            parameters[40].Value = model.drawActualFinishTime;
            parameters[41].Value = model.chargePersonName;
            parameters[42].Value = model.difDay;
            parameters[43].Value = model.hashCode;

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
        public bool Update(Pine_sTool.Model.PT_MES_SCZJH_nodeList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PT_MES_SCZJH_nodeList set ");

            strSql.Append(" id = @id , ");
            strSql.Append(" ztbm = @ztbm , ");
            strSql.Append(" createDt = @createDt , ");
            strSql.Append(" editDt = @editDt , ");
            strSql.Append(" isDeleted = @isDeleted , ");
            strSql.Append(" deleteDt = @deleteDt , ");
            strSql.Append(" productPlanId = @productPlanId , ");
            strSql.Append(" drawingNo = @drawingNo , ");
            strSql.Append(" name = @name , ");
            strSql.Append(" type = @type , ");
            strSql.Append(" nodeDate = @nodeDate , ");
            strSql.Append(" finishDate = @finishDate , ");
            strSql.Append(" ruleConfig = @ruleConfig , ");
            strSql.Append(" status = @status , ");
            strSql.Append(" progressStatus = @progressStatus , ");
            strSql.Append(" confirmStatus = @confirmStatus , ");
            strSql.Append(" sentKey2Wms = @sentKey2Wms , ");
            strSql.Append(" wmsMid = @wmsMid , ");
            strSql.Append(" startDate = @startDate , ");
            strSql.Append(" actualStartDate = @actualStartDate , ");
            strSql.Append(" nodeId = @nodeId , ");
            strSql.Append(" nodeName = @nodeName , ");
            strSql.Append(" isMaterialPreparation = @isMaterialPreparation , ");
            strSql.Append(" materialVersion = @materialVersion , ");
            strSql.Append(" usedEquipment = @usedEquipment , ");
            strSql.Append(" pauseReason = @pauseReason , ");
            strSql.Append(" describe = @describe , ");
            strSql.Append(" bomInfo = @bomInfo , ");
            strSql.Append(" recordId = @recordId , ");
            strSql.Append(" isOutsourcing = @isOutsourcing , ");
            strSql.Append(" hbFinishDate = @hbFinishDate , ");
            strSql.Append(" outsourcingSituation = @outsourcingSituation , ");
            strSql.Append(" outsourcingSetTime = @outsourcingSetTime , ");
            strSql.Append(" finishUserId = @finishUserId , ");
            strSql.Append(" finishUserName = @finishUserName , ");
            strSql.Append(" startUserId = @startUserId , ");
            strSql.Append(" startUserName = @startUserName , ");
            strSql.Append(" pauseDuration = @pauseDuration , ");
            strSql.Append(" drawPhase = @drawPhase , ");
            strSql.Append(" drawPlanFinishTime = @drawPlanFinishTime , ");
            strSql.Append(" drawActualFinishTime = @drawActualFinishTime , ");
            strSql.Append(" chargePersonName = @chargePersonName , ");
            strSql.Append(" difDay = @difDay , ");
            strSql.Append(" hashCode = @hashCode  ");

            strSql.Append(" where  ");

            SqlParameter[] parameters = {
                         new SqlParameter("@PT_ID", SqlDbType.Int,4) ,
                         new SqlParameter("@id", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ztbm", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@createDt", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@editDt", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isDeleted", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@deleteDt", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productPlanId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawingNo", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@name", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@type", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ruleConfig", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@status", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@progressStatus", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@confirmStatus", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@sentKey2Wms", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@wmsMid", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@actualStartDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isMaterialPreparation", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@materialVersion", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@usedEquipment", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseReason", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@describe", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@bomInfo", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@recordId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isOutsourcing", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@hbFinishDate", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outsourcingSituation", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outsourcingSetTime", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserId", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseDuration", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawPhase", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawPlanFinishTime", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawActualFinishTime", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@chargePersonName", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@difDay", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@hashCode", SqlDbType.VarChar,-1)
             };

            parameters[0].Value = model.PT_ID;
            parameters[1].Value = model.id;
            parameters[2].Value = model.ztbm;
            parameters[3].Value = model.createDt;
            parameters[4].Value = model.editDt;
            parameters[5].Value = model.isDeleted;
            parameters[6].Value = model.deleteDt;
            parameters[7].Value = model.productPlanId;
            parameters[8].Value = model.drawingNo;
            parameters[9].Value = model.name;
            parameters[10].Value = model.type;
            parameters[11].Value = model.nodeDate;
            parameters[12].Value = model.finishDate;
            parameters[13].Value = model.ruleConfig;
            parameters[14].Value = model.status;
            parameters[15].Value = model.progressStatus;
            parameters[16].Value = model.confirmStatus;
            parameters[17].Value = model.sentKey2Wms;
            parameters[18].Value = model.wmsMid;
            parameters[19].Value = model.startDate;
            parameters[20].Value = model.actualStartDate;
            parameters[21].Value = model.nodeId;
            parameters[22].Value = model.nodeName;
            parameters[23].Value = model.isMaterialPreparation;
            parameters[24].Value = model.materialVersion;
            parameters[25].Value = model.usedEquipment;
            parameters[26].Value = model.pauseReason;
            parameters[27].Value = model.describe;
            parameters[28].Value = model.bomInfo;
            parameters[29].Value = model.recordId;
            parameters[30].Value = model.isOutsourcing;
            parameters[31].Value = model.hbFinishDate;
            parameters[32].Value = model.outsourcingSituation;
            parameters[33].Value = model.outsourcingSetTime;
            parameters[34].Value = model.finishUserId;
            parameters[35].Value = model.finishUserName;
            parameters[36].Value = model.startUserId;
            parameters[37].Value = model.startUserName;
            parameters[38].Value = model.pauseDuration;
            parameters[39].Value = model.drawPhase;
            parameters[40].Value = model.drawPlanFinishTime;
            parameters[41].Value = model.drawActualFinishTime;
            parameters[42].Value = model.chargePersonName;
            parameters[43].Value = model.difDay;
            parameters[44].Value = model.hashCode;
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
            strSql.Append("delete from PT_MES_SCZJH_nodeList ");
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
        public bool DeleteList(string PT_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PT_MES_SCZJH_nodeList ");
            strSql.Append(" where ID in (" + PT_IDlist + ")  ");
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
        public Pine_sTool.Model.PT_MES_SCZJH_nodeList GetModel(int PT_ID = 1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PT_ID, id, ztbm, createDt, editDt, isDeleted, deleteDt, productPlanId, drawingNo, name, type, nodeDate, finishDate, ruleConfig, status, progressStatus, confirmStatus, sentKey2Wms, wmsMid, startDate, actualStartDate, nodeId, nodeName, isMaterialPreparation, materialVersion, usedEquipment, pauseReason, describe, bomInfo, recordId, isOutsourcing, hbFinishDate, outsourcingSituation, outsourcingSetTime, finishUserId, finishUserName, startUserId, startUserName, pauseDuration, drawPhase, drawPlanFinishTime, drawActualFinishTime, chargePersonName, difDay, hashCode  ");
            strSql.Append("  from PT_MES_SCZJH_nodeList ");
            strSql.Append($" where PT_ID={PT_ID}");
            SqlParameter[] parameters = {
             };

            Pine_sTool.Model.PT_MES_SCZJH_nodeList model = new Pine_sTool.Model.PT_MES_SCZJH_nodeList();

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
        public Pine_sTool.Model.PT_MES_SCZJH_nodeList DataRowToModel(DataRow row)
        {
            Pine_sTool.Model.PT_MES_SCZJH_nodeList model = new Pine_sTool.Model.PT_MES_SCZJH_nodeList();
            if (row != null)
            {
                //|int|True|int
                if (row["PT_ID"] != DBNull.Value && !string.IsNullOrEmpty(row["PT_ID"].ToString()))
                {
                    model.PT_ID = int.Parse(row["PT_ID"].ToString());
                }

                //|string|False|varchar
                if (row["id"] != DBNull.Value)
                {
                    model.id = row["id"].ToString();
                }

                //|string|False|varchar
                if (row["ztbm"] != DBNull.Value)
                {
                    model.ztbm = row["ztbm"].ToString();
                }

                //|string|False|varchar
                if (row["createDt"] != DBNull.Value)
                {
                    model.createDt = row["createDt"].ToString();
                }

                //|string|False|varchar
                if (row["editDt"] != DBNull.Value)
                {
                    model.editDt = row["editDt"].ToString();
                }

                //|string|False|varchar
                if (row["isDeleted"] != DBNull.Value)
                {
                    model.isDeleted = row["isDeleted"].ToString();
                }

                //|string|False|varchar
                if (row["deleteDt"] != DBNull.Value)
                {
                    model.deleteDt = row["deleteDt"].ToString();
                }

                //|string|False|varchar
                if (row["productPlanId"] != DBNull.Value)
                {
                    model.productPlanId = row["productPlanId"].ToString();
                }

                //|string|False|varchar
                if (row["drawingNo"] != DBNull.Value)
                {
                    model.drawingNo = row["drawingNo"].ToString();
                }

                //|string|False|varchar
                if (row["name"] != DBNull.Value)
                {
                    model.name = row["name"].ToString();
                }

                //|string|False|varchar
                if (row["type"] != DBNull.Value)
                {
                    model.type = row["type"].ToString();
                }

                //|string|False|varchar
                if (row["nodeDate"] != DBNull.Value)
                {
                    model.nodeDate = row["nodeDate"].ToString();
                }

                //|string|False|varchar
                if (row["finishDate"] != DBNull.Value)
                {
                    model.finishDate = row["finishDate"].ToString();
                }

                //|string|False|varchar
                if (row["ruleConfig"] != DBNull.Value)
                {
                    model.ruleConfig = row["ruleConfig"].ToString();
                }

                //|string|False|varchar
                if (row["status"] != DBNull.Value)
                {
                    model.status = row["status"].ToString();
                }

                //|string|False|varchar
                if (row["progressStatus"] != DBNull.Value)
                {
                    model.progressStatus = row["progressStatus"].ToString();
                }

                //|string|False|varchar
                if (row["confirmStatus"] != DBNull.Value)
                {
                    model.confirmStatus = row["confirmStatus"].ToString();
                }

                //|string|False|varchar
                if (row["sentKey2Wms"] != DBNull.Value)
                {
                    model.sentKey2Wms = row["sentKey2Wms"].ToString();
                }

                //|string|False|varchar
                if (row["wmsMid"] != DBNull.Value)
                {
                    model.wmsMid = row["wmsMid"].ToString();
                }

                //|string|False|varchar
                if (row["startDate"] != DBNull.Value)
                {
                    model.startDate = row["startDate"].ToString();
                }

                //|string|False|varchar
                if (row["actualStartDate"] != DBNull.Value)
                {
                    model.actualStartDate = row["actualStartDate"].ToString();
                }

                //|string|False|varchar
                if (row["nodeId"] != DBNull.Value)
                {
                    model.nodeId = row["nodeId"].ToString();
                }

                //|string|False|varchar
                if (row["nodeName"] != DBNull.Value)
                {
                    model.nodeName = row["nodeName"].ToString();
                }

                //|string|False|varchar
                if (row["isMaterialPreparation"] != DBNull.Value)
                {
                    model.isMaterialPreparation = row["isMaterialPreparation"].ToString();
                }

                //|string|False|varchar
                if (row["materialVersion"] != DBNull.Value)
                {
                    model.materialVersion = row["materialVersion"].ToString();
                }

                //|string|False|varchar
                if (row["usedEquipment"] != DBNull.Value)
                {
                    model.usedEquipment = row["usedEquipment"].ToString();
                }

                //|string|False|varchar
                if (row["pauseReason"] != DBNull.Value)
                {
                    model.pauseReason = row["pauseReason"].ToString();
                }

                //|string|False|varchar
                if (row["describe"] != DBNull.Value)
                {
                    model.describe = row["describe"].ToString();
                }

                //|string|False|varchar
                if (row["bomInfo"] != DBNull.Value)
                {
                    model.bomInfo = row["bomInfo"].ToString();
                }

                //|string|False|varchar
                if (row["recordId"] != DBNull.Value)
                {
                    model.recordId = row["recordId"].ToString();
                }

                //|string|False|varchar
                if (row["isOutsourcing"] != DBNull.Value)
                {
                    model.isOutsourcing = row["isOutsourcing"].ToString();
                }

                //|string|False|varchar
                if (row["hbFinishDate"] != DBNull.Value)
                {
                    model.hbFinishDate = row["hbFinishDate"].ToString();
                }

                //|string|False|varchar
                if (row["outsourcingSituation"] != DBNull.Value)
                {
                    model.outsourcingSituation = row["outsourcingSituation"].ToString();
                }

                //|string|False|varchar
                if (row["outsourcingSetTime"] != DBNull.Value)
                {
                    model.outsourcingSetTime = row["outsourcingSetTime"].ToString();
                }

                //|string|False|varchar
                if (row["finishUserId"] != DBNull.Value)
                {
                    model.finishUserId = row["finishUserId"].ToString();
                }

                //|string|False|varchar
                if (row["finishUserName"] != DBNull.Value)
                {
                    model.finishUserName = row["finishUserName"].ToString();
                }

                //|string|False|varchar
                if (row["startUserId"] != DBNull.Value)
                {
                    model.startUserId = row["startUserId"].ToString();
                }

                //|string|False|varchar
                if (row["startUserName"] != DBNull.Value)
                {
                    model.startUserName = row["startUserName"].ToString();
                }

                //|string|False|varchar
                if (row["pauseDuration"] != DBNull.Value)
                {
                    model.pauseDuration = row["pauseDuration"].ToString();
                }

                //|string|False|varchar
                if (row["drawPhase"] != DBNull.Value)
                {
                    model.drawPhase = row["drawPhase"].ToString();
                }

                //|string|False|varchar
                if (row["drawPlanFinishTime"] != DBNull.Value)
                {
                    model.drawPlanFinishTime = row["drawPlanFinishTime"].ToString();
                }

                //|string|False|varchar
                if (row["drawActualFinishTime"] != DBNull.Value)
                {
                    model.drawActualFinishTime = row["drawActualFinishTime"].ToString();
                }

                //|string|False|varchar
                if (row["chargePersonName"] != DBNull.Value)
                {
                    model.chargePersonName = row["chargePersonName"].ToString();
                }

                //|string|False|varchar
                if (row["difDay"] != DBNull.Value)
                {
                    model.difDay = row["difDay"].ToString();
                }

                //|string|False|varchar
                if (row["hashCode"] != DBNull.Value)
                {
                    model.hashCode = row["hashCode"].ToString();
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
            strSql.Append(" FROM PT_MES_SCZJH_nodeList ");
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
            strSql.Append(" FROM PT_MES_SCZJH_nodeList ");
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
            strSql.Append("select count(1) FROM PT_MES_SCZJH_nodeList ");
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
            strSql.Append(")AS Row, T.*  from PT_MES_SCZJH_nodeList T ");
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
            public static string PT_ID = "PT_ID";
            public static string id = "id";
            public static string ztbm = "ztbm";
            public static string createDt = "createDt";
            public static string editDt = "editDt";
            public static string isDeleted = "isDeleted";
            public static string deleteDt = "deleteDt";
            public static string productPlanId = "productPlanId";
            public static string drawingNo = "drawingNo";
            public static string name = "name";
            public static string type = "type";
            public static string nodeDate = "nodeDate";
            public static string finishDate = "finishDate";
            public static string ruleConfig = "ruleConfig";
            public static string status = "status";
            public static string progressStatus = "progressStatus";
            public static string confirmStatus = "confirmStatus";
            public static string sentKey2Wms = "sentKey2Wms";
            public static string wmsMid = "wmsMid";
            public static string startDate = "startDate";
            public static string actualStartDate = "actualStartDate";
            public static string nodeId = "nodeId";
            public static string nodeName = "nodeName";
            public static string isMaterialPreparation = "isMaterialPreparation";
            public static string materialVersion = "materialVersion";
            public static string usedEquipment = "usedEquipment";
            public static string pauseReason = "pauseReason";
            public static string describe = "describe";
            public static string bomInfo = "bomInfo";
            public static string recordId = "recordId";
            public static string isOutsourcing = "isOutsourcing";
            public static string hbFinishDate = "hbFinishDate";
            public static string outsourcingSituation = "outsourcingSituation";
            public static string outsourcingSetTime = "outsourcingSetTime";
            public static string finishUserId = "finishUserId";
            public static string finishUserName = "finishUserName";
            public static string startUserId = "startUserId";
            public static string startUserName = "startUserName";
            public static string pauseDuration = "pauseDuration";
            public static string drawPhase = "drawPhase";
            public static string drawPlanFinishTime = "drawPlanFinishTime";
            public static string drawActualFinishTime = "drawActualFinishTime";
            public static string chargePersonName = "chargePersonName";
            public static string difDay = "difDay";
            public static string hashCode = "hashCode";
        }
    }
}