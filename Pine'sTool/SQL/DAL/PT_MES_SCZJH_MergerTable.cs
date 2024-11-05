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
* 文    件： PT_MES_SCZJH_MergerTable.cs
* 功    能： 数据库操作_DAL
* 类    名： PT_MES_SCZJH_MergerTable
* 创建时间： 2024/9/4 10:15:50
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/

using Maticsoft.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Pine_sTool.DAL
{
    //PT_MES_SCZJH_MergerTable
    public partial class PT_MES_SCZJH_MergerTable
    {
        public static string TableName = "PT_MES_SCZJH_MergerTable";

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
            return DbHelperSQL.GetMaxID("ID", "PT_MES_SCZJH_MergerTable");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PT_MES_SCZJH_MergerTable");
            strSql.Append(" where ");

            SqlParameter[] parameters = {
             };

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Pine_sTool.Model.PT_MES_SCZJH_MergerTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PT_MES_SCZJH_MergerTable(");
            strSql.Append("id主干,ztbm主干,createDt主干,editDt主干,isDeleted主干,deleteDt主干,productNo主干,serialNum主干,model主干,pcNumName主干,pcCodeName主干,contractNo主干,drawingNo主干,customerName主干,noTaxAmount主干,dateEnd主干,edition主干,madeMode主干,schedulingStatus主干,transferStatus主干,project_name主干,count主干,stateName主干,planMatched主干,planMatchedTime主干,materialName主干,processPlanSource主干,designSource主干,usingTime主干,importmentLevel主干,urgentLevel主干,outPut主干,taxPrice主干,timeLimitId主干,timeLimitName主干,lastSyncwms主干,salesReply主干,salesEndReply主干,salesPerson主干,workShop主干,trialShop主干,orderIssuedTime主干,orderFirstIssuedTime主干,planStartDate主干,oilAddMaterialStatus主干,pauseReason主干,completionTime主干,month主干,year主干,projectManager主干,tentativeTime主干,tentativeEndTime主干,isExportProduct主干,voltageClass主干,planCompletime主干,productLink主干,productionSite主干,nodeList主干,processStatus主干,actualStartTime主干,isRepair主干,limitRelation主干,id节点,ztbm节点,createDt节点,editDt节点,isDeleted节点,deleteDt节点,productPlanId节点,drawingNo节点,name节点,type节点,nodeDate节点,finishDate节点,ruleConfig节点,status节点,progressStatus节点,confirmStatus节点,sentKey2Wms节点,wmsMid节点,startDate节点,actualStartDate节点,nodeId节点,nodeName节点,isMaterialPreparation节点,materialVersion节点,usedEquipment节点,pauseReason节点,describe节点,bomInfo节点,recordId节点,isOutsourcing节点,hbFinishDate节点,outsourcingSituation节点,outsourcingSetTime节点,finishUserId节点,finishUserName节点,startUserId节点,startUserName节点,pauseDuration节点,drawPhase节点,drawPlanFinishTime节点,drawActualFinishTime节点,chargePersonName节点,difDay节点");
            strSql.Append(") values (");
            strSql.Append("@id主干,@ztbm主干,@createDt主干,@editDt主干,@isDeleted主干,@deleteDt主干,@productNo主干,@serialNum主干,@model主干,@pcNumName主干,@pcCodeName主干,@contractNo主干,@drawingNo主干,@customerName主干,@noTaxAmount主干,@dateEnd主干,@edition主干,@madeMode主干,@schedulingStatus主干,@transferStatus主干,@project_name主干,@count主干,@stateName主干,@planMatched主干,@planMatchedTime主干,@materialName主干,@processPlanSource主干,@designSource主干,@usingTime主干,@importmentLevel主干,@urgentLevel主干,@outPut主干,@taxPrice主干,@timeLimitId主干,@timeLimitName主干,@lastSyncwms主干,@salesReply主干,@salesEndReply主干,@salesPerson主干,@workShop主干,@trialShop主干,@orderIssuedTime主干,@orderFirstIssuedTime主干,@planStartDate主干,@oilAddMaterialStatus主干,@pauseReason主干,@completionTime主干,@month主干,@year主干,@projectManager主干,@tentativeTime主干,@tentativeEndTime主干,@isExportProduct主干,@voltageClass主干,@planCompletime主干,@productLink主干,@productionSite主干,@nodeList主干,@processStatus主干,@actualStartTime主干,@isRepair主干,@limitRelation主干,@id节点,@ztbm节点,@createDt节点,@editDt节点,@isDeleted节点,@deleteDt节点,@productPlanId节点,@drawingNo节点,@name节点,@type节点,@nodeDate节点,@finishDate节点,@ruleConfig节点,@status节点,@progressStatus节点,@confirmStatus节点,@sentKey2Wms节点,@wmsMid节点,@startDate节点,@actualStartDate节点,@nodeId节点,@nodeName节点,@isMaterialPreparation节点,@materialVersion节点,@usedEquipment节点,@pauseReason节点,@describe节点,@bomInfo节点,@recordId节点,@isOutsourcing节点,@hbFinishDate节点,@outsourcingSituation节点,@outsourcingSetTime节点,@finishUserId节点,@finishUserName节点,@startUserId节点,@startUserName节点,@pauseDuration节点,@drawPhase节点,@drawPlanFinishTime节点,@drawActualFinishTime节点,@chargePersonName节点,@difDay节点");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                         new SqlParameter("@id主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ztbm主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@createDt主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@editDt主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isDeleted主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@deleteDt主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productNo主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@serialNum主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@model主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pcNumName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pcCodeName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@contractNo主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawingNo主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@customerName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@noTaxAmount主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@dateEnd主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@edition主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@madeMode主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@schedulingStatus主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@transferStatus主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@project_name主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@count主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@stateName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@planMatched主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@planMatchedTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@materialName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@processPlanSource主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@designSource主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@usingTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@importmentLevel主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@urgentLevel主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outPut主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@taxPrice主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@timeLimitId主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@timeLimitName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@lastSyncwms主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@salesReply主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@salesEndReply主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@salesPerson主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@workShop主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@trialShop主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@orderIssuedTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@orderFirstIssuedTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@planStartDate主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@oilAddMaterialStatus主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseReason主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@completionTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@month主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@year主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@projectManager主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@tentativeTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@tentativeEndTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isExportProduct主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@voltageClass主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@planCompletime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productLink主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productionSite主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeList主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@processStatus主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@actualStartTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isRepair主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@limitRelation主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@id节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ztbm节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@createDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@editDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isDeleted节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@deleteDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productPlanId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawingNo节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@name节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@type节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ruleConfig节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@status节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@progressStatus节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@confirmStatus节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@sentKey2Wms节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@wmsMid节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@actualStartDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isMaterialPreparation节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@materialVersion节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@usedEquipment节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseReason节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@describe节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@bomInfo节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@recordId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isOutsourcing节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@hbFinishDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outsourcingSituation节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outsourcingSetTime节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseDuration节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawPhase节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawPlanFinishTime节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawActualFinishTime节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@chargePersonName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@difDay节点", SqlDbType.VarChar,-1)
             };

            parameters[0].Value = model.id主干;
            parameters[1].Value = model.ztbm主干;
            parameters[2].Value = model.createDt主干;
            parameters[3].Value = model.editDt主干;
            parameters[4].Value = model.isDeleted主干;
            parameters[5].Value = model.deleteDt主干;
            parameters[6].Value = model.productNo主干;
            parameters[7].Value = model.serialNum主干;
            parameters[8].Value = model.model主干;
            parameters[9].Value = model.pcNumName主干;
            parameters[10].Value = model.pcCodeName主干;
            parameters[11].Value = model.contractNo主干;
            parameters[12].Value = model.drawingNo主干;
            parameters[13].Value = model.customerName主干;
            parameters[14].Value = model.noTaxAmount主干;
            parameters[15].Value = model.dateEnd主干;
            parameters[16].Value = model.edition主干;
            parameters[17].Value = model.madeMode主干;
            parameters[18].Value = model.schedulingStatus主干;
            parameters[19].Value = model.transferStatus主干;
            parameters[20].Value = model.project_name主干;
            parameters[21].Value = model.count主干;
            parameters[22].Value = model.stateName主干;
            parameters[23].Value = model.planMatched主干;
            parameters[24].Value = model.planMatchedTime主干;
            parameters[25].Value = model.materialName主干;
            parameters[26].Value = model.processPlanSource主干;
            parameters[27].Value = model.designSource主干;
            parameters[28].Value = model.usingTime主干;
            parameters[29].Value = model.importmentLevel主干;
            parameters[30].Value = model.urgentLevel主干;
            parameters[31].Value = model.outPut主干;
            parameters[32].Value = model.taxPrice主干;
            parameters[33].Value = model.timeLimitId主干;
            parameters[34].Value = model.timeLimitName主干;
            parameters[35].Value = model.lastSyncwms主干;
            parameters[36].Value = model.salesReply主干;
            parameters[37].Value = model.salesEndReply主干;
            parameters[38].Value = model.salesPerson主干;
            parameters[39].Value = model.workShop主干;
            parameters[40].Value = model.trialShop主干;
            parameters[41].Value = model.orderIssuedTime主干;
            parameters[42].Value = model.orderFirstIssuedTime主干;
            parameters[43].Value = model.planStartDate主干;
            parameters[44].Value = model.oilAddMaterialStatus主干;
            parameters[45].Value = model.pauseReason主干;
            parameters[46].Value = model.completionTime主干;
            parameters[47].Value = model.month主干;
            parameters[48].Value = model.year主干;
            parameters[49].Value = model.projectManager主干;
            parameters[50].Value = model.tentativeTime主干;
            parameters[51].Value = model.tentativeEndTime主干;
            parameters[52].Value = model.isExportProduct主干;
            parameters[53].Value = model.voltageClass主干;
            parameters[54].Value = model.planCompletime主干;
            parameters[55].Value = model.productLink主干;
            parameters[56].Value = model.productionSite主干;
            parameters[57].Value = model.nodeList主干;
            parameters[58].Value = model.processStatus主干;
            parameters[59].Value = model.actualStartTime主干;
            parameters[60].Value = model.isRepair主干;
            parameters[61].Value = model.limitRelation主干;
            parameters[62].Value = model.id节点;
            parameters[63].Value = model.ztbm节点;
            parameters[64].Value = model.createDt节点;
            parameters[65].Value = model.editDt节点;
            parameters[66].Value = model.isDeleted节点;
            parameters[67].Value = model.deleteDt节点;
            parameters[68].Value = model.productPlanId节点;
            parameters[69].Value = model.drawingNo节点;
            parameters[70].Value = model.name节点;
            parameters[71].Value = model.type节点;
            parameters[72].Value = model.nodeDate节点;
            parameters[73].Value = model.finishDate节点;
            parameters[74].Value = model.ruleConfig节点;
            parameters[75].Value = model.status节点;
            parameters[76].Value = model.progressStatus节点;
            parameters[77].Value = model.confirmStatus节点;
            parameters[78].Value = model.sentKey2Wms节点;
            parameters[79].Value = model.wmsMid节点;
            parameters[80].Value = model.startDate节点;
            parameters[81].Value = model.actualStartDate节点;
            parameters[82].Value = model.nodeId节点;
            parameters[83].Value = model.nodeName节点;
            parameters[84].Value = model.isMaterialPreparation节点;
            parameters[85].Value = model.materialVersion节点;
            parameters[86].Value = model.usedEquipment节点;
            parameters[87].Value = model.pauseReason节点;
            parameters[88].Value = model.describe节点;
            parameters[89].Value = model.bomInfo节点;
            parameters[90].Value = model.recordId节点;
            parameters[91].Value = model.isOutsourcing节点;
            parameters[92].Value = model.hbFinishDate节点;
            parameters[93].Value = model.outsourcingSituation节点;
            parameters[94].Value = model.outsourcingSetTime节点;
            parameters[95].Value = model.finishUserId节点;
            parameters[96].Value = model.finishUserName节点;
            parameters[97].Value = model.startUserId节点;
            parameters[98].Value = model.startUserName节点;
            parameters[99].Value = model.pauseDuration节点;
            parameters[100].Value = model.drawPhase节点;
            parameters[101].Value = model.drawPlanFinishTime节点;
            parameters[102].Value = model.drawActualFinishTime节点;
            parameters[103].Value = model.chargePersonName节点;
            parameters[104].Value = model.difDay节点;

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
        public bool Update(Pine_sTool.Model.PT_MES_SCZJH_MergerTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PT_MES_SCZJH_MergerTable set ");

            strSql.Append(" id主干 = @id主干 , ");
            strSql.Append(" ztbm主干 = @ztbm主干 , ");
            strSql.Append(" createDt主干 = @createDt主干 , ");
            strSql.Append(" editDt主干 = @editDt主干 , ");
            strSql.Append(" isDeleted主干 = @isDeleted主干 , ");
            strSql.Append(" deleteDt主干 = @deleteDt主干 , ");
            strSql.Append(" productNo主干 = @productNo主干 , ");
            strSql.Append(" serialNum主干 = @serialNum主干 , ");
            strSql.Append(" model主干 = @model主干 , ");
            strSql.Append(" pcNumName主干 = @pcNumName主干 , ");
            strSql.Append(" pcCodeName主干 = @pcCodeName主干 , ");
            strSql.Append(" contractNo主干 = @contractNo主干 , ");
            strSql.Append(" drawingNo主干 = @drawingNo主干 , ");
            strSql.Append(" customerName主干 = @customerName主干 , ");
            strSql.Append(" noTaxAmount主干 = @noTaxAmount主干 , ");
            strSql.Append(" dateEnd主干 = @dateEnd主干 , ");
            strSql.Append(" edition主干 = @edition主干 , ");
            strSql.Append(" madeMode主干 = @madeMode主干 , ");
            strSql.Append(" schedulingStatus主干 = @schedulingStatus主干 , ");
            strSql.Append(" transferStatus主干 = @transferStatus主干 , ");
            strSql.Append(" project_name主干 = @project_name主干 , ");
            strSql.Append(" count主干 = @count主干 , ");
            strSql.Append(" stateName主干 = @stateName主干 , ");
            strSql.Append(" planMatched主干 = @planMatched主干 , ");
            strSql.Append(" planMatchedTime主干 = @planMatchedTime主干 , ");
            strSql.Append(" materialName主干 = @materialName主干 , ");
            strSql.Append(" processPlanSource主干 = @processPlanSource主干 , ");
            strSql.Append(" designSource主干 = @designSource主干 , ");
            strSql.Append(" usingTime主干 = @usingTime主干 , ");
            strSql.Append(" importmentLevel主干 = @importmentLevel主干 , ");
            strSql.Append(" urgentLevel主干 = @urgentLevel主干 , ");
            strSql.Append(" outPut主干 = @outPut主干 , ");
            strSql.Append(" taxPrice主干 = @taxPrice主干 , ");
            strSql.Append(" timeLimitId主干 = @timeLimitId主干 , ");
            strSql.Append(" timeLimitName主干 = @timeLimitName主干 , ");
            strSql.Append(" lastSyncwms主干 = @lastSyncwms主干 , ");
            strSql.Append(" salesReply主干 = @salesReply主干 , ");
            strSql.Append(" salesEndReply主干 = @salesEndReply主干 , ");
            strSql.Append(" salesPerson主干 = @salesPerson主干 , ");
            strSql.Append(" workShop主干 = @workShop主干 , ");
            strSql.Append(" trialShop主干 = @trialShop主干 , ");
            strSql.Append(" orderIssuedTime主干 = @orderIssuedTime主干 , ");
            strSql.Append(" orderFirstIssuedTime主干 = @orderFirstIssuedTime主干 , ");
            strSql.Append(" planStartDate主干 = @planStartDate主干 , ");
            strSql.Append(" oilAddMaterialStatus主干 = @oilAddMaterialStatus主干 , ");
            strSql.Append(" pauseReason主干 = @pauseReason主干 , ");
            strSql.Append(" completionTime主干 = @completionTime主干 , ");
            strSql.Append(" month主干 = @month主干 , ");
            strSql.Append(" year主干 = @year主干 , ");
            strSql.Append(" projectManager主干 = @projectManager主干 , ");
            strSql.Append(" tentativeTime主干 = @tentativeTime主干 , ");
            strSql.Append(" tentativeEndTime主干 = @tentativeEndTime主干 , ");
            strSql.Append(" isExportProduct主干 = @isExportProduct主干 , ");
            strSql.Append(" voltageClass主干 = @voltageClass主干 , ");
            strSql.Append(" planCompletime主干 = @planCompletime主干 , ");
            strSql.Append(" productLink主干 = @productLink主干 , ");
            strSql.Append(" productionSite主干 = @productionSite主干 , ");
            strSql.Append(" nodeList主干 = @nodeList主干 , ");
            strSql.Append(" processStatus主干 = @processStatus主干 , ");
            strSql.Append(" actualStartTime主干 = @actualStartTime主干 , ");
            strSql.Append(" isRepair主干 = @isRepair主干 , ");
            strSql.Append(" limitRelation主干 = @limitRelation主干 , ");
            strSql.Append(" id节点 = @id节点 , ");
            strSql.Append(" ztbm节点 = @ztbm节点 , ");
            strSql.Append(" createDt节点 = @createDt节点 , ");
            strSql.Append(" editDt节点 = @editDt节点 , ");
            strSql.Append(" isDeleted节点 = @isDeleted节点 , ");
            strSql.Append(" deleteDt节点 = @deleteDt节点 , ");
            strSql.Append(" productPlanId节点 = @productPlanId节点 , ");
            strSql.Append(" drawingNo节点 = @drawingNo节点 , ");
            strSql.Append(" name节点 = @name节点 , ");
            strSql.Append(" type节点 = @type节点 , ");
            strSql.Append(" nodeDate节点 = @nodeDate节点 , ");
            strSql.Append(" finishDate节点 = @finishDate节点 , ");
            strSql.Append(" ruleConfig节点 = @ruleConfig节点 , ");
            strSql.Append(" status节点 = @status节点 , ");
            strSql.Append(" progressStatus节点 = @progressStatus节点 , ");
            strSql.Append(" confirmStatus节点 = @confirmStatus节点 , ");
            strSql.Append(" sentKey2Wms节点 = @sentKey2Wms节点 , ");
            strSql.Append(" wmsMid节点 = @wmsMid节点 , ");
            strSql.Append(" startDate节点 = @startDate节点 , ");
            strSql.Append(" actualStartDate节点 = @actualStartDate节点 , ");
            strSql.Append(" nodeId节点 = @nodeId节点 , ");
            strSql.Append(" nodeName节点 = @nodeName节点 , ");
            strSql.Append(" isMaterialPreparation节点 = @isMaterialPreparation节点 , ");
            strSql.Append(" materialVersion节点 = @materialVersion节点 , ");
            strSql.Append(" usedEquipment节点 = @usedEquipment节点 , ");
            strSql.Append(" pauseReason节点 = @pauseReason节点 , ");
            strSql.Append(" describe节点 = @describe节点 , ");
            strSql.Append(" bomInfo节点 = @bomInfo节点 , ");
            strSql.Append(" recordId节点 = @recordId节点 , ");
            strSql.Append(" isOutsourcing节点 = @isOutsourcing节点 , ");
            strSql.Append(" hbFinishDate节点 = @hbFinishDate节点 , ");
            strSql.Append(" outsourcingSituation节点 = @outsourcingSituation节点 , ");
            strSql.Append(" outsourcingSetTime节点 = @outsourcingSetTime节点 , ");
            strSql.Append(" finishUserId节点 = @finishUserId节点 , ");
            strSql.Append(" finishUserName节点 = @finishUserName节点 , ");
            strSql.Append(" startUserId节点 = @startUserId节点 , ");
            strSql.Append(" startUserName节点 = @startUserName节点 , ");
            strSql.Append(" pauseDuration节点 = @pauseDuration节点 , ");
            strSql.Append(" drawPhase节点 = @drawPhase节点 , ");
            strSql.Append(" drawPlanFinishTime节点 = @drawPlanFinishTime节点 , ");
            strSql.Append(" drawActualFinishTime节点 = @drawActualFinishTime节点 , ");
            strSql.Append(" chargePersonName节点 = @chargePersonName节点 , ");
            strSql.Append(" difDay节点 = @difDay节点  ");

            strSql.Append(" where  ");

            SqlParameter[] parameters = {
                         new SqlParameter("@PT_ID", SqlDbType.Int,4) ,
                         new SqlParameter("@id主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ztbm主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@createDt主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@editDt主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isDeleted主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@deleteDt主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productNo主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@serialNum主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@model主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pcNumName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pcCodeName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@contractNo主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawingNo主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@customerName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@noTaxAmount主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@dateEnd主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@edition主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@madeMode主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@schedulingStatus主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@transferStatus主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@project_name主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@count主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@stateName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@planMatched主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@planMatchedTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@materialName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@processPlanSource主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@designSource主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@usingTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@importmentLevel主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@urgentLevel主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outPut主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@taxPrice主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@timeLimitId主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@timeLimitName主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@lastSyncwms主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@salesReply主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@salesEndReply主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@salesPerson主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@workShop主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@trialShop主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@orderIssuedTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@orderFirstIssuedTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@planStartDate主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@oilAddMaterialStatus主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseReason主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@completionTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@month主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@year主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@projectManager主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@tentativeTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@tentativeEndTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isExportProduct主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@voltageClass主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@planCompletime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productLink主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productionSite主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeList主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@processStatus主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@actualStartTime主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isRepair主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@limitRelation主干", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@id节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ztbm节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@createDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@editDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isDeleted节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@deleteDt节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@productPlanId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawingNo节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@name节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@type节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@ruleConfig节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@status节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@progressStatus节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@confirmStatus节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@sentKey2Wms节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@wmsMid节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@actualStartDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@nodeName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isMaterialPreparation节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@materialVersion节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@usedEquipment节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseReason节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@describe节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@bomInfo节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@recordId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@isOutsourcing节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@hbFinishDate节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outsourcingSituation节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@outsourcingSetTime节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@finishUserName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserId节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@startUserName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@pauseDuration节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawPhase节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawPlanFinishTime节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@drawActualFinishTime节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@chargePersonName节点", SqlDbType.VarChar,-1) ,
                         new SqlParameter("@difDay节点", SqlDbType.VarChar,-1)
             };

            parameters[0].Value = model.PT_ID;
            parameters[1].Value = model.id主干;
            parameters[2].Value = model.ztbm主干;
            parameters[3].Value = model.createDt主干;
            parameters[4].Value = model.editDt主干;
            parameters[5].Value = model.isDeleted主干;
            parameters[6].Value = model.deleteDt主干;
            parameters[7].Value = model.productNo主干;
            parameters[8].Value = model.serialNum主干;
            parameters[9].Value = model.model主干;
            parameters[10].Value = model.pcNumName主干;
            parameters[11].Value = model.pcCodeName主干;
            parameters[12].Value = model.contractNo主干;
            parameters[13].Value = model.drawingNo主干;
            parameters[14].Value = model.customerName主干;
            parameters[15].Value = model.noTaxAmount主干;
            parameters[16].Value = model.dateEnd主干;
            parameters[17].Value = model.edition主干;
            parameters[18].Value = model.madeMode主干;
            parameters[19].Value = model.schedulingStatus主干;
            parameters[20].Value = model.transferStatus主干;
            parameters[21].Value = model.project_name主干;
            parameters[22].Value = model.count主干;
            parameters[23].Value = model.stateName主干;
            parameters[24].Value = model.planMatched主干;
            parameters[25].Value = model.planMatchedTime主干;
            parameters[26].Value = model.materialName主干;
            parameters[27].Value = model.processPlanSource主干;
            parameters[28].Value = model.designSource主干;
            parameters[29].Value = model.usingTime主干;
            parameters[30].Value = model.importmentLevel主干;
            parameters[31].Value = model.urgentLevel主干;
            parameters[32].Value = model.outPut主干;
            parameters[33].Value = model.taxPrice主干;
            parameters[34].Value = model.timeLimitId主干;
            parameters[35].Value = model.timeLimitName主干;
            parameters[36].Value = model.lastSyncwms主干;
            parameters[37].Value = model.salesReply主干;
            parameters[38].Value = model.salesEndReply主干;
            parameters[39].Value = model.salesPerson主干;
            parameters[40].Value = model.workShop主干;
            parameters[41].Value = model.trialShop主干;
            parameters[42].Value = model.orderIssuedTime主干;
            parameters[43].Value = model.orderFirstIssuedTime主干;
            parameters[44].Value = model.planStartDate主干;
            parameters[45].Value = model.oilAddMaterialStatus主干;
            parameters[46].Value = model.pauseReason主干;
            parameters[47].Value = model.completionTime主干;
            parameters[48].Value = model.month主干;
            parameters[49].Value = model.year主干;
            parameters[50].Value = model.projectManager主干;
            parameters[51].Value = model.tentativeTime主干;
            parameters[52].Value = model.tentativeEndTime主干;
            parameters[53].Value = model.isExportProduct主干;
            parameters[54].Value = model.voltageClass主干;
            parameters[55].Value = model.planCompletime主干;
            parameters[56].Value = model.productLink主干;
            parameters[57].Value = model.productionSite主干;
            parameters[58].Value = model.nodeList主干;
            parameters[59].Value = model.processStatus主干;
            parameters[60].Value = model.actualStartTime主干;
            parameters[61].Value = model.isRepair主干;
            parameters[62].Value = model.limitRelation主干;
            parameters[63].Value = model.id节点;
            parameters[64].Value = model.ztbm节点;
            parameters[65].Value = model.createDt节点;
            parameters[66].Value = model.editDt节点;
            parameters[67].Value = model.isDeleted节点;
            parameters[68].Value = model.deleteDt节点;
            parameters[69].Value = model.productPlanId节点;
            parameters[70].Value = model.drawingNo节点;
            parameters[71].Value = model.name节点;
            parameters[72].Value = model.type节点;
            parameters[73].Value = model.nodeDate节点;
            parameters[74].Value = model.finishDate节点;
            parameters[75].Value = model.ruleConfig节点;
            parameters[76].Value = model.status节点;
            parameters[77].Value = model.progressStatus节点;
            parameters[78].Value = model.confirmStatus节点;
            parameters[79].Value = model.sentKey2Wms节点;
            parameters[80].Value = model.wmsMid节点;
            parameters[81].Value = model.startDate节点;
            parameters[82].Value = model.actualStartDate节点;
            parameters[83].Value = model.nodeId节点;
            parameters[84].Value = model.nodeName节点;
            parameters[85].Value = model.isMaterialPreparation节点;
            parameters[86].Value = model.materialVersion节点;
            parameters[87].Value = model.usedEquipment节点;
            parameters[88].Value = model.pauseReason节点;
            parameters[89].Value = model.describe节点;
            parameters[90].Value = model.bomInfo节点;
            parameters[91].Value = model.recordId节点;
            parameters[92].Value = model.isOutsourcing节点;
            parameters[93].Value = model.hbFinishDate节点;
            parameters[94].Value = model.outsourcingSituation节点;
            parameters[95].Value = model.outsourcingSetTime节点;
            parameters[96].Value = model.finishUserId节点;
            parameters[97].Value = model.finishUserName节点;
            parameters[98].Value = model.startUserId节点;
            parameters[99].Value = model.startUserName节点;
            parameters[100].Value = model.pauseDuration节点;
            parameters[101].Value = model.drawPhase节点;
            parameters[102].Value = model.drawPlanFinishTime节点;
            parameters[103].Value = model.drawActualFinishTime节点;
            parameters[104].Value = model.chargePersonName节点;
            parameters[105].Value = model.difDay节点;
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
            strSql.Append("delete from PT_MES_SCZJH_MergerTable ");
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
            strSql.Append("delete from PT_MES_SCZJH_MergerTable ");
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
        public Pine_sTool.Model.PT_MES_SCZJH_MergerTable GetModel()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PT_ID, id主干, ztbm主干, createDt主干, editDt主干, isDeleted主干, deleteDt主干, productNo主干, serialNum主干, model主干, pcNumName主干, pcCodeName主干, contractNo主干, drawingNo主干, customerName主干, noTaxAmount主干, dateEnd主干, edition主干, madeMode主干, schedulingStatus主干, transferStatus主干, project_name主干, count主干, stateName主干, planMatched主干, planMatchedTime主干, materialName主干, processPlanSource主干, designSource主干, usingTime主干, importmentLevel主干, urgentLevel主干, outPut主干, taxPrice主干, timeLimitId主干, timeLimitName主干, lastSyncwms主干, salesReply主干, salesEndReply主干, salesPerson主干, workShop主干, trialShop主干, orderIssuedTime主干, orderFirstIssuedTime主干, planStartDate主干, oilAddMaterialStatus主干, pauseReason主干, completionTime主干, month主干, year主干, projectManager主干, tentativeTime主干, tentativeEndTime主干, isExportProduct主干, voltageClass主干, planCompletime主干, productLink主干, productionSite主干, nodeList主干, processStatus主干, actualStartTime主干, isRepair主干, limitRelation主干, id节点, ztbm节点, createDt节点, editDt节点, isDeleted节点, deleteDt节点, productPlanId节点, drawingNo节点, name节点, type节点, nodeDate节点, finishDate节点, ruleConfig节点, status节点, progressStatus节点, confirmStatus节点, sentKey2Wms节点, wmsMid节点, startDate节点, actualStartDate节点, nodeId节点, nodeName节点, isMaterialPreparation节点, materialVersion节点, usedEquipment节点, pauseReason节点, describe节点, bomInfo节点, recordId节点, isOutsourcing节点, hbFinishDate节点, outsourcingSituation节点, outsourcingSetTime节点, finishUserId节点, finishUserName节点, startUserId节点, startUserName节点, pauseDuration节点, drawPhase节点, drawPlanFinishTime节点, drawActualFinishTime节点, chargePersonName节点, difDay节点  ");
            strSql.Append("  from PT_MES_SCZJH_MergerTable ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
             };

            Pine_sTool.Model.PT_MES_SCZJH_MergerTable model = new Pine_sTool.Model.PT_MES_SCZJH_MergerTable();

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
        public Pine_sTool.Model.PT_MES_SCZJH_MergerTable DataRowToModel(DataRow row)
        {
            Pine_sTool.Model.PT_MES_SCZJH_MergerTable model = new Pine_sTool.Model.PT_MES_SCZJH_MergerTable();
            if (row != null)
            {
                //|int|True|int
                if (row["PT_ID"] != DBNull.Value && !string.IsNullOrEmpty(row["PT_ID"].ToString()))
                {
                    model.PT_ID = int.Parse(row["PT_ID"].ToString());
                }

                //|string|False|varchar
                if (row["id主干"] != DBNull.Value)
                {
                    model.id主干 = row["id主干"].ToString();
                }

                //|string|False|varchar
                if (row["ztbm主干"] != DBNull.Value)
                {
                    model.ztbm主干 = row["ztbm主干"].ToString();
                }

                //|string|False|varchar
                if (row["createDt主干"] != DBNull.Value)
                {
                    model.createDt主干 = row["createDt主干"].ToString();
                }

                //|string|False|varchar
                if (row["editDt主干"] != DBNull.Value)
                {
                    model.editDt主干 = row["editDt主干"].ToString();
                }

                //|string|False|varchar
                if (row["isDeleted主干"] != DBNull.Value)
                {
                    model.isDeleted主干 = row["isDeleted主干"].ToString();
                }

                //|string|False|varchar
                if (row["deleteDt主干"] != DBNull.Value)
                {
                    model.deleteDt主干 = row["deleteDt主干"].ToString();
                }

                //|string|False|varchar
                if (row["productNo主干"] != DBNull.Value)
                {
                    model.productNo主干 = row["productNo主干"].ToString();
                }

                //|string|False|varchar
                if (row["serialNum主干"] != DBNull.Value)
                {
                    model.serialNum主干 = row["serialNum主干"].ToString();
                }

                //|string|False|varchar
                if (row["model主干"] != DBNull.Value)
                {
                    model.model主干 = row["model主干"].ToString();
                }

                //|string|False|varchar
                if (row["pcNumName主干"] != DBNull.Value)
                {
                    model.pcNumName主干 = row["pcNumName主干"].ToString();
                }

                //|string|False|varchar
                if (row["pcCodeName主干"] != DBNull.Value)
                {
                    model.pcCodeName主干 = row["pcCodeName主干"].ToString();
                }

                //|string|False|varchar
                if (row["contractNo主干"] != DBNull.Value)
                {
                    model.contractNo主干 = row["contractNo主干"].ToString();
                }

                //|string|False|varchar
                if (row["drawingNo主干"] != DBNull.Value)
                {
                    model.drawingNo主干 = row["drawingNo主干"].ToString();
                }

                //|string|False|varchar
                if (row["customerName主干"] != DBNull.Value)
                {
                    model.customerName主干 = row["customerName主干"].ToString();
                }

                //|string|False|varchar
                if (row["noTaxAmount主干"] != DBNull.Value)
                {
                    model.noTaxAmount主干 = row["noTaxAmount主干"].ToString();
                }

                //|string|False|varchar
                if (row["dateEnd主干"] != DBNull.Value)
                {
                    model.dateEnd主干 = row["dateEnd主干"].ToString();
                }

                //|string|False|varchar
                if (row["edition主干"] != DBNull.Value)
                {
                    model.edition主干 = row["edition主干"].ToString();
                }

                //|string|False|varchar
                if (row["madeMode主干"] != DBNull.Value)
                {
                    model.madeMode主干 = row["madeMode主干"].ToString();
                }

                //|string|False|varchar
                if (row["schedulingStatus主干"] != DBNull.Value)
                {
                    model.schedulingStatus主干 = row["schedulingStatus主干"].ToString();
                }

                //|string|False|varchar
                if (row["transferStatus主干"] != DBNull.Value)
                {
                    model.transferStatus主干 = row["transferStatus主干"].ToString();
                }

                //|string|False|varchar
                if (row["project_name主干"] != DBNull.Value)
                {
                    model.project_name主干 = row["project_name主干"].ToString();
                }

                //|string|False|varchar
                if (row["count主干"] != DBNull.Value)
                {
                    model.count主干 = row["count主干"].ToString();
                }

                //|string|False|varchar
                if (row["stateName主干"] != DBNull.Value)
                {
                    model.stateName主干 = row["stateName主干"].ToString();
                }

                //|string|False|varchar
                if (row["planMatched主干"] != DBNull.Value)
                {
                    model.planMatched主干 = row["planMatched主干"].ToString();
                }

                //|string|False|varchar
                if (row["planMatchedTime主干"] != DBNull.Value)
                {
                    model.planMatchedTime主干 = row["planMatchedTime主干"].ToString();
                }

                //|string|False|varchar
                if (row["materialName主干"] != DBNull.Value)
                {
                    model.materialName主干 = row["materialName主干"].ToString();
                }

                //|string|False|varchar
                if (row["processPlanSource主干"] != DBNull.Value)
                {
                    model.processPlanSource主干 = row["processPlanSource主干"].ToString();
                }

                //|string|False|varchar
                if (row["designSource主干"] != DBNull.Value)
                {
                    model.designSource主干 = row["designSource主干"].ToString();
                }

                //|string|False|varchar
                if (row["usingTime主干"] != DBNull.Value)
                {
                    model.usingTime主干 = row["usingTime主干"].ToString();
                }

                //|string|False|varchar
                if (row["importmentLevel主干"] != DBNull.Value)
                {
                    model.importmentLevel主干 = row["importmentLevel主干"].ToString();
                }

                //|string|False|varchar
                if (row["urgentLevel主干"] != DBNull.Value)
                {
                    model.urgentLevel主干 = row["urgentLevel主干"].ToString();
                }

                //|string|False|varchar
                if (row["outPut主干"] != DBNull.Value)
                {
                    model.outPut主干 = row["outPut主干"].ToString();
                }

                //|string|False|varchar
                if (row["taxPrice主干"] != DBNull.Value)
                {
                    model.taxPrice主干 = row["taxPrice主干"].ToString();
                }

                //|string|False|varchar
                if (row["timeLimitId主干"] != DBNull.Value)
                {
                    model.timeLimitId主干 = row["timeLimitId主干"].ToString();
                }

                //|string|False|varchar
                if (row["timeLimitName主干"] != DBNull.Value)
                {
                    model.timeLimitName主干 = row["timeLimitName主干"].ToString();
                }

                //|string|False|varchar
                if (row["lastSyncwms主干"] != DBNull.Value)
                {
                    model.lastSyncwms主干 = row["lastSyncwms主干"].ToString();
                }

                //|string|False|varchar
                if (row["salesReply主干"] != DBNull.Value)
                {
                    model.salesReply主干 = row["salesReply主干"].ToString();
                }

                //|string|False|varchar
                if (row["salesEndReply主干"] != DBNull.Value)
                {
                    model.salesEndReply主干 = row["salesEndReply主干"].ToString();
                }

                //|string|False|varchar
                if (row["salesPerson主干"] != DBNull.Value)
                {
                    model.salesPerson主干 = row["salesPerson主干"].ToString();
                }

                //|string|False|varchar
                if (row["workShop主干"] != DBNull.Value)
                {
                    model.workShop主干 = row["workShop主干"].ToString();
                }

                //|string|False|varchar
                if (row["trialShop主干"] != DBNull.Value)
                {
                    model.trialShop主干 = row["trialShop主干"].ToString();
                }

                //|string|False|varchar
                if (row["orderIssuedTime主干"] != DBNull.Value)
                {
                    model.orderIssuedTime主干 = row["orderIssuedTime主干"].ToString();
                }

                //|string|False|varchar
                if (row["orderFirstIssuedTime主干"] != DBNull.Value)
                {
                    model.orderFirstIssuedTime主干 = row["orderFirstIssuedTime主干"].ToString();
                }

                //|string|False|varchar
                if (row["planStartDate主干"] != DBNull.Value)
                {
                    model.planStartDate主干 = row["planStartDate主干"].ToString();
                }

                //|string|False|varchar
                if (row["oilAddMaterialStatus主干"] != DBNull.Value)
                {
                    model.oilAddMaterialStatus主干 = row["oilAddMaterialStatus主干"].ToString();
                }

                //|string|False|varchar
                if (row["pauseReason主干"] != DBNull.Value)
                {
                    model.pauseReason主干 = row["pauseReason主干"].ToString();
                }

                //|string|False|varchar
                if (row["completionTime主干"] != DBNull.Value)
                {
                    model.completionTime主干 = row["completionTime主干"].ToString();
                }

                //|string|False|varchar
                if (row["month主干"] != DBNull.Value)
                {
                    model.month主干 = row["month主干"].ToString();
                }

                //|string|False|varchar
                if (row["year主干"] != DBNull.Value)
                {
                    model.year主干 = row["year主干"].ToString();
                }

                //|string|False|varchar
                if (row["projectManager主干"] != DBNull.Value)
                {
                    model.projectManager主干 = row["projectManager主干"].ToString();
                }

                //|string|False|varchar
                if (row["tentativeTime主干"] != DBNull.Value)
                {
                    model.tentativeTime主干 = row["tentativeTime主干"].ToString();
                }

                //|string|False|varchar
                if (row["tentativeEndTime主干"] != DBNull.Value)
                {
                    model.tentativeEndTime主干 = row["tentativeEndTime主干"].ToString();
                }

                //|string|False|varchar
                if (row["isExportProduct主干"] != DBNull.Value)
                {
                    model.isExportProduct主干 = row["isExportProduct主干"].ToString();
                }

                //|string|False|varchar
                if (row["voltageClass主干"] != DBNull.Value)
                {
                    model.voltageClass主干 = row["voltageClass主干"].ToString();
                }

                //|string|False|varchar
                if (row["planCompletime主干"] != DBNull.Value)
                {
                    model.planCompletime主干 = row["planCompletime主干"].ToString();
                }

                //|string|False|varchar
                if (row["productLink主干"] != DBNull.Value)
                {
                    model.productLink主干 = row["productLink主干"].ToString();
                }

                //|string|False|varchar
                if (row["productionSite主干"] != DBNull.Value)
                {
                    model.productionSite主干 = row["productionSite主干"].ToString();
                }

                //|string|False|varchar
                if (row["nodeList主干"] != DBNull.Value)
                {
                    model.nodeList主干 = row["nodeList主干"].ToString();
                }

                //|string|False|varchar
                if (row["processStatus主干"] != DBNull.Value)
                {
                    model.processStatus主干 = row["processStatus主干"].ToString();
                }

                //|string|False|varchar
                if (row["actualStartTime主干"] != DBNull.Value)
                {
                    model.actualStartTime主干 = row["actualStartTime主干"].ToString();
                }

                //|string|False|varchar
                if (row["isRepair主干"] != DBNull.Value)
                {
                    model.isRepair主干 = row["isRepair主干"].ToString();
                }

                //|string|False|varchar
                if (row["limitRelation主干"] != DBNull.Value)
                {
                    model.limitRelation主干 = row["limitRelation主干"].ToString();
                }

                //|string|False|varchar
                if (row["id节点"] != DBNull.Value)
                {
                    model.id节点 = row["id节点"].ToString();
                }

                //|string|False|varchar
                if (row["ztbm节点"] != DBNull.Value)
                {
                    model.ztbm节点 = row["ztbm节点"].ToString();
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
                if (row["isDeleted节点"] != DBNull.Value)
                {
                    model.isDeleted节点 = row["isDeleted节点"].ToString();
                }

                //|string|False|varchar
                if (row["deleteDt节点"] != DBNull.Value)
                {
                    model.deleteDt节点 = row["deleteDt节点"].ToString();
                }

                //|string|False|varchar
                if (row["productPlanId节点"] != DBNull.Value)
                {
                    model.productPlanId节点 = row["productPlanId节点"].ToString();
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
                if (row["ruleConfig节点"] != DBNull.Value)
                {
                    model.ruleConfig节点 = row["ruleConfig节点"].ToString();
                }

                //|string|False|varchar
                if (row["status节点"] != DBNull.Value)
                {
                    model.status节点 = row["status节点"].ToString();
                }

                //|string|False|varchar
                if (row["progressStatus节点"] != DBNull.Value)
                {
                    model.progressStatus节点 = row["progressStatus节点"].ToString();
                }

                //|string|False|varchar
                if (row["confirmStatus节点"] != DBNull.Value)
                {
                    model.confirmStatus节点 = row["confirmStatus节点"].ToString();
                }

                //|string|False|varchar
                if (row["sentKey2Wms节点"] != DBNull.Value)
                {
                    model.sentKey2Wms节点 = row["sentKey2Wms节点"].ToString();
                }

                //|string|False|varchar
                if (row["wmsMid节点"] != DBNull.Value)
                {
                    model.wmsMid节点 = row["wmsMid节点"].ToString();
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
                if (row["nodeId节点"] != DBNull.Value)
                {
                    model.nodeId节点 = row["nodeId节点"].ToString();
                }

                //|string|False|varchar
                if (row["nodeName节点"] != DBNull.Value)
                {
                    model.nodeName节点 = row["nodeName节点"].ToString();
                }

                //|string|False|varchar
                if (row["isMaterialPreparation节点"] != DBNull.Value)
                {
                    model.isMaterialPreparation节点 = row["isMaterialPreparation节点"].ToString();
                }

                //|string|False|varchar
                if (row["materialVersion节点"] != DBNull.Value)
                {
                    model.materialVersion节点 = row["materialVersion节点"].ToString();
                }

                //|string|False|varchar
                if (row["usedEquipment节点"] != DBNull.Value)
                {
                    model.usedEquipment节点 = row["usedEquipment节点"].ToString();
                }

                //|string|False|varchar
                if (row["pauseReason节点"] != DBNull.Value)
                {
                    model.pauseReason节点 = row["pauseReason节点"].ToString();
                }

                //|string|False|varchar
                if (row["describe节点"] != DBNull.Value)
                {
                    model.describe节点 = row["describe节点"].ToString();
                }

                //|string|False|varchar
                if (row["bomInfo节点"] != DBNull.Value)
                {
                    model.bomInfo节点 = row["bomInfo节点"].ToString();
                }

                //|string|False|varchar
                if (row["recordId节点"] != DBNull.Value)
                {
                    model.recordId节点 = row["recordId节点"].ToString();
                }

                //|string|False|varchar
                if (row["isOutsourcing节点"] != DBNull.Value)
                {
                    model.isOutsourcing节点 = row["isOutsourcing节点"].ToString();
                }

                //|string|False|varchar
                if (row["hbFinishDate节点"] != DBNull.Value)
                {
                    model.hbFinishDate节点 = row["hbFinishDate节点"].ToString();
                }

                //|string|False|varchar
                if (row["outsourcingSituation节点"] != DBNull.Value)
                {
                    model.outsourcingSituation节点 = row["outsourcingSituation节点"].ToString();
                }

                //|string|False|varchar
                if (row["outsourcingSetTime节点"] != DBNull.Value)
                {
                    model.outsourcingSetTime节点 = row["outsourcingSetTime节点"].ToString();
                }

                //|string|False|varchar
                if (row["finishUserId节点"] != DBNull.Value)
                {
                    model.finishUserId节点 = row["finishUserId节点"].ToString();
                }

                //|string|False|varchar
                if (row["finishUserName节点"] != DBNull.Value)
                {
                    model.finishUserName节点 = row["finishUserName节点"].ToString();
                }

                //|string|False|varchar
                if (row["startUserId节点"] != DBNull.Value)
                {
                    model.startUserId节点 = row["startUserId节点"].ToString();
                }

                //|string|False|varchar
                if (row["startUserName节点"] != DBNull.Value)
                {
                    model.startUserName节点 = row["startUserName节点"].ToString();
                }

                //|string|False|varchar
                if (row["pauseDuration节点"] != DBNull.Value)
                {
                    model.pauseDuration节点 = row["pauseDuration节点"].ToString();
                }

                //|string|False|varchar
                if (row["drawPhase节点"] != DBNull.Value)
                {
                    model.drawPhase节点 = row["drawPhase节点"].ToString();
                }

                //|string|False|varchar
                if (row["drawPlanFinishTime节点"] != DBNull.Value)
                {
                    model.drawPlanFinishTime节点 = row["drawPlanFinishTime节点"].ToString();
                }

                //|string|False|varchar
                if (row["drawActualFinishTime节点"] != DBNull.Value)
                {
                    model.drawActualFinishTime节点 = row["drawActualFinishTime节点"].ToString();
                }

                //|string|False|varchar
                if (row["chargePersonName节点"] != DBNull.Value)
                {
                    model.chargePersonName节点 = row["chargePersonName节点"].ToString();
                }

                //|string|False|varchar
                if (row["difDay节点"] != DBNull.Value)
                {
                    model.difDay节点 = row["difDay节点"].ToString();
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
            strSql.Append(" FROM PT_MES_SCZJH_MergerTable ");
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
            strSql.Append(" FROM PT_MES_SCZJH_MergerTable ");
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
            strSql.Append("select count(1) FROM PT_MES_SCZJH_MergerTable ");
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
            strSql.Append(")AS Row, T.*  from PT_MES_SCZJH_MergerTable T ");
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
            public static string id主干 = "id主干";
            public static string ztbm主干 = "ztbm主干";
            public static string createDt主干 = "createDt主干";
            public static string editDt主干 = "editDt主干";
            public static string isDeleted主干 = "isDeleted主干";
            public static string deleteDt主干 = "deleteDt主干";
            public static string productNo主干 = "productNo主干";
            public static string serialNum主干 = "serialNum主干";
            public static string model主干 = "model主干";
            public static string pcNumName主干 = "pcNumName主干";
            public static string pcCodeName主干 = "pcCodeName主干";
            public static string contractNo主干 = "contractNo主干";
            public static string drawingNo主干 = "drawingNo主干";
            public static string customerName主干 = "customerName主干";
            public static string noTaxAmount主干 = "noTaxAmount主干";
            public static string dateEnd主干 = "dateEnd主干";
            public static string edition主干 = "edition主干";
            public static string madeMode主干 = "madeMode主干";
            public static string schedulingStatus主干 = "schedulingStatus主干";
            public static string transferStatus主干 = "transferStatus主干";
            public static string project_name主干 = "project_name主干";
            public static string count主干 = "count主干";
            public static string stateName主干 = "stateName主干";
            public static string planMatched主干 = "planMatched主干";
            public static string planMatchedTime主干 = "planMatchedTime主干";
            public static string materialName主干 = "materialName主干";
            public static string processPlanSource主干 = "processPlanSource主干";
            public static string designSource主干 = "designSource主干";
            public static string usingTime主干 = "usingTime主干";
            public static string importmentLevel主干 = "importmentLevel主干";
            public static string urgentLevel主干 = "urgentLevel主干";
            public static string outPut主干 = "outPut主干";
            public static string taxPrice主干 = "taxPrice主干";
            public static string timeLimitId主干 = "timeLimitId主干";
            public static string timeLimitName主干 = "timeLimitName主干";
            public static string lastSyncwms主干 = "lastSyncwms主干";
            public static string salesReply主干 = "salesReply主干";
            public static string salesEndReply主干 = "salesEndReply主干";
            public static string salesPerson主干 = "salesPerson主干";
            public static string workShop主干 = "workShop主干";
            public static string trialShop主干 = "trialShop主干";
            public static string orderIssuedTime主干 = "orderIssuedTime主干";
            public static string orderFirstIssuedTime主干 = "orderFirstIssuedTime主干";
            public static string planStartDate主干 = "planStartDate主干";
            public static string oilAddMaterialStatus主干 = "oilAddMaterialStatus主干";
            public static string pauseReason主干 = "pauseReason主干";
            public static string completionTime主干 = "completionTime主干";
            public static string month主干 = "month主干";
            public static string year主干 = "year主干";
            public static string projectManager主干 = "projectManager主干";
            public static string tentativeTime主干 = "tentativeTime主干";
            public static string tentativeEndTime主干 = "tentativeEndTime主干";
            public static string isExportProduct主干 = "isExportProduct主干";
            public static string voltageClass主干 = "voltageClass主干";
            public static string planCompletime主干 = "planCompletime主干";
            public static string productLink主干 = "productLink主干";
            public static string productionSite主干 = "productionSite主干";
            public static string nodeList主干 = "nodeList主干";
            public static string processStatus主干 = "processStatus主干";
            public static string actualStartTime主干 = "actualStartTime主干";
            public static string isRepair主干 = "isRepair主干";
            public static string limitRelation主干 = "limitRelation主干";
            public static string id节点 = "id节点";
            public static string ztbm节点 = "ztbm节点";
            public static string createDt节点 = "createDt节点";
            public static string editDt节点 = "editDt节点";
            public static string isDeleted节点 = "isDeleted节点";
            public static string deleteDt节点 = "deleteDt节点";
            public static string productPlanId节点 = "productPlanId节点";
            public static string drawingNo节点 = "drawingNo节点";
            public static string name节点 = "name节点";
            public static string type节点 = "type节点";
            public static string nodeDate节点 = "nodeDate节点";
            public static string finishDate节点 = "finishDate节点";
            public static string ruleConfig节点 = "ruleConfig节点";
            public static string status节点 = "status节点";
            public static string progressStatus节点 = "progressStatus节点";
            public static string confirmStatus节点 = "confirmStatus节点";
            public static string sentKey2Wms节点 = "sentKey2Wms节点";
            public static string wmsMid节点 = "wmsMid节点";
            public static string startDate节点 = "startDate节点";
            public static string actualStartDate节点 = "actualStartDate节点";
            public static string nodeId节点 = "nodeId节点";
            public static string nodeName节点 = "nodeName节点";
            public static string isMaterialPreparation节点 = "isMaterialPreparation节点";
            public static string materialVersion节点 = "materialVersion节点";
            public static string usedEquipment节点 = "usedEquipment节点";
            public static string pauseReason节点 = "pauseReason节点";
            public static string describe节点 = "describe节点";
            public static string bomInfo节点 = "bomInfo节点";
            public static string recordId节点 = "recordId节点";
            public static string isOutsourcing节点 = "isOutsourcing节点";
            public static string hbFinishDate节点 = "hbFinishDate节点";
            public static string outsourcingSituation节点 = "outsourcingSituation节点";
            public static string outsourcingSetTime节点 = "outsourcingSetTime节点";
            public static string finishUserId节点 = "finishUserId节点";
            public static string finishUserName节点 = "finishUserName节点";
            public static string startUserId节点 = "startUserId节点";
            public static string startUserName节点 = "startUserName节点";
            public static string pauseDuration节点 = "pauseDuration节点";
            public static string drawPhase节点 = "drawPhase节点";
            public static string drawPlanFinishTime节点 = "drawPlanFinishTime节点";
            public static string drawActualFinishTime节点 = "drawActualFinishTime节点";
            public static string chargePersonName节点 = "chargePersonName节点";
            public static string difDay节点 = "difDay节点";
        }
    }
}