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
* 文    件： PT_MES_SCZJH_data.cs
* 功    能： 数据库操作_DAL 
* 类    名： PT_MES_SCZJH_data
* 创建时间： 2024/9/5 17:41:48
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/  

using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.DBUtility;

namespace Pine_sTool.DAL  
{
	//PT_MES_SCZJH_data 
 	public partial class PT_MES_SCZJH_data
 	{
         public static string TableName="PT_MES_SCZJH_data";
         
         DbHelperSQLP DbHelperSQL = new DbHelperSQLP(PineConn.SqlConnAuto);
         
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
 		    return DbHelperSQL.GetMaxID("ID", "PT_MES_SCZJH_data"); 
 		}
 
 	  	/// <summary>
 		/// 是否存在该记录
 		/// </summary>
 		public bool Exists()
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("select count(1) from PT_MES_SCZJH_data");
 			strSql.Append(" where ");
 			            
             			SqlParameter[] parameters = {
 			};
 
 			return DbHelperSQL.Exists(strSql.ToString(),parameters);
 		}
 		
 	 
 		/// <summary>
 		/// 增加一条数据
 		/// </summary>
 		public int Add(Pine_sTool.Model.PT_MES_SCZJH_data model)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("insert into PT_MES_SCZJH_data(");			
             strSql.Append("id,ztbm,createDt,editDt,isDeleted,deleteDt,productNo,serialNum,model,pcNumName,pcCodeName,contractNo,drawingNo,customerName,noTaxAmount,dateEnd,edition,madeMode,schedulingStatus,transferStatus,project_name,count,stateName,planMatched,planMatchedTime,materialName,processPlanSource,designSource,usingTime,importmentLevel,urgentLevel,outPut,taxPrice,timeLimitId,timeLimitName,lastSyncwms,salesReply,salesEndReply,salesPerson,workShop,trialShop,orderIssuedTime,orderFirstIssuedTime,planStartDate,oilAddMaterialStatus,pauseReason,completionTime,month,year,projectManager,tentativeTime,tentativeEndTime,isExportProduct,voltageClass,planCompletime,productLink,productionSite,nodeList,processStatus,actualStartTime,isRepair,limitRelation");
 			strSql.Append(") values (");
             strSql.Append("@id,@ztbm,@createDt,@editDt,@isDeleted,@deleteDt,@productNo,@serialNum,@model,@pcNumName,@pcCodeName,@contractNo,@drawingNo,@customerName,@noTaxAmount,@dateEnd,@edition,@madeMode,@schedulingStatus,@transferStatus,@project_name,@count,@stateName,@planMatched,@planMatchedTime,@materialName,@processPlanSource,@designSource,@usingTime,@importmentLevel,@urgentLevel,@outPut,@taxPrice,@timeLimitId,@timeLimitName,@lastSyncwms,@salesReply,@salesEndReply,@salesPerson,@workShop,@trialShop,@orderIssuedTime,@orderFirstIssuedTime,@planStartDate,@oilAddMaterialStatus,@pauseReason,@completionTime,@month,@year,@projectManager,@tentativeTime,@tentativeEndTime,@isExportProduct,@voltageClass,@planCompletime,@productLink,@productionSite,@nodeList,@processStatus,@actualStartTime,@isRepair,@limitRelation");            
             strSql.Append(") ");            
             strSql.Append(";select @@IDENTITY");		
 			SqlParameter[] parameters = {
 			            new SqlParameter("@id", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@ztbm", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@createDt", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@editDt", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@isDeleted", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@deleteDt", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@productNo", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@serialNum", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@model", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@pcNumName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@pcCodeName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@contractNo", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@drawingNo", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@customerName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@noTaxAmount", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@dateEnd", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@edition", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@madeMode", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@schedulingStatus", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@transferStatus", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@project_name", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@count", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@stateName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@planMatched", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@planMatchedTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@materialName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@processPlanSource", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@designSource", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@usingTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@importmentLevel", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@urgentLevel", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@outPut", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@taxPrice", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@timeLimitId", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@timeLimitName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@lastSyncwms", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@salesReply", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@salesEndReply", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@salesPerson", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@workShop", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@trialShop", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@orderIssuedTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@orderFirstIssuedTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@planStartDate", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@oilAddMaterialStatus", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@pauseReason", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@completionTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@month", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@year", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@projectManager", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@tentativeTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@tentativeEndTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@isExportProduct", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@voltageClass", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@planCompletime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@productLink", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@productionSite", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@nodeList", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@processStatus", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@actualStartTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@isRepair", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@limitRelation", SqlDbType.VarChar,-1)             
               
             };
 			            
             parameters[0].Value = model.id;                        
             parameters[1].Value = model.ztbm;                        
             parameters[2].Value = model.createDt;                        
             parameters[3].Value = model.editDt;                        
             parameters[4].Value = model.isDeleted;                        
             parameters[5].Value = model.deleteDt;                        
             parameters[6].Value = model.productNo;                        
             parameters[7].Value = model.serialNum;                        
             parameters[8].Value = model.model;                        
             parameters[9].Value = model.pcNumName;                        
             parameters[10].Value = model.pcCodeName;                        
             parameters[11].Value = model.contractNo;                        
             parameters[12].Value = model.drawingNo;                        
             parameters[13].Value = model.customerName;                        
             parameters[14].Value = model.noTaxAmount;                        
             parameters[15].Value = model.dateEnd;                        
             parameters[16].Value = model.edition;                        
             parameters[17].Value = model.madeMode;                        
             parameters[18].Value = model.schedulingStatus;                        
             parameters[19].Value = model.transferStatus;                        
             parameters[20].Value = model.project_name;                        
             parameters[21].Value = model.count;                        
             parameters[22].Value = model.stateName;                        
             parameters[23].Value = model.planMatched;                        
             parameters[24].Value = model.planMatchedTime;                        
             parameters[25].Value = model.materialName;                        
             parameters[26].Value = model.processPlanSource;                        
             parameters[27].Value = model.designSource;                        
             parameters[28].Value = model.usingTime;                        
             parameters[29].Value = model.importmentLevel;                        
             parameters[30].Value = model.urgentLevel;                        
             parameters[31].Value = model.outPut;                        
             parameters[32].Value = model.taxPrice;                        
             parameters[33].Value = model.timeLimitId;                        
             parameters[34].Value = model.timeLimitName;                        
             parameters[35].Value = model.lastSyncwms;                        
             parameters[36].Value = model.salesReply;                        
             parameters[37].Value = model.salesEndReply;                        
             parameters[38].Value = model.salesPerson;                        
             parameters[39].Value = model.workShop;                        
             parameters[40].Value = model.trialShop;                        
             parameters[41].Value = model.orderIssuedTime;                        
             parameters[42].Value = model.orderFirstIssuedTime;                        
             parameters[43].Value = model.planStartDate;                        
             parameters[44].Value = model.oilAddMaterialStatus;                        
             parameters[45].Value = model.pauseReason;                        
             parameters[46].Value = model.completionTime;                        
             parameters[47].Value = model.month;                        
             parameters[48].Value = model.year;                        
             parameters[49].Value = model.projectManager;                        
             parameters[50].Value = model.tentativeTime;                        
             parameters[51].Value = model.tentativeEndTime;                        
             parameters[52].Value = model.isExportProduct;                        
             parameters[53].Value = model.voltageClass;                        
             parameters[54].Value = model.planCompletime;                        
             parameters[55].Value = model.productLink;                        
             parameters[56].Value = model.productionSite;                        
             parameters[57].Value = model.nodeList;                        
             parameters[58].Value = model.processStatus;                        
             parameters[59].Value = model.actualStartTime;                        
             parameters[60].Value = model.isRepair;                        
             parameters[61].Value = model.limitRelation;                        
 			   
 			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);			
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
 		public bool Update(Pine_sTool.Model.PT_MES_SCZJH_data model)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("update PT_MES_SCZJH_data set ");
 			                                                
             strSql.Append(" id = @id , ");                                    
             strSql.Append(" ztbm = @ztbm , ");                                    
             strSql.Append(" createDt = @createDt , ");                                    
             strSql.Append(" editDt = @editDt , ");                                    
             strSql.Append(" isDeleted = @isDeleted , ");                                    
             strSql.Append(" deleteDt = @deleteDt , ");                                    
             strSql.Append(" productNo = @productNo , ");                                    
             strSql.Append(" serialNum = @serialNum , ");                                    
             strSql.Append(" model = @model , ");                                    
             strSql.Append(" pcNumName = @pcNumName , ");                                    
             strSql.Append(" pcCodeName = @pcCodeName , ");                                    
             strSql.Append(" contractNo = @contractNo , ");                                    
             strSql.Append(" drawingNo = @drawingNo , ");                                    
             strSql.Append(" customerName = @customerName , ");                                    
             strSql.Append(" noTaxAmount = @noTaxAmount , ");                                    
             strSql.Append(" dateEnd = @dateEnd , ");                                    
             strSql.Append(" edition = @edition , ");                                    
             strSql.Append(" madeMode = @madeMode , ");                                    
             strSql.Append(" schedulingStatus = @schedulingStatus , ");                                    
             strSql.Append(" transferStatus = @transferStatus , ");                                    
             strSql.Append(" project_name = @project_name , ");                                    
             strSql.Append(" count = @count , ");                                    
             strSql.Append(" stateName = @stateName , ");                                    
             strSql.Append(" planMatched = @planMatched , ");                                    
             strSql.Append(" planMatchedTime = @planMatchedTime , ");                                    
             strSql.Append(" materialName = @materialName , ");                                    
             strSql.Append(" processPlanSource = @processPlanSource , ");                                    
             strSql.Append(" designSource = @designSource , ");                                    
             strSql.Append(" usingTime = @usingTime , ");                                    
             strSql.Append(" importmentLevel = @importmentLevel , ");                                    
             strSql.Append(" urgentLevel = @urgentLevel , ");                                    
             strSql.Append(" outPut = @outPut , ");                                    
             strSql.Append(" taxPrice = @taxPrice , ");                                    
             strSql.Append(" timeLimitId = @timeLimitId , ");                                    
             strSql.Append(" timeLimitName = @timeLimitName , ");                                    
             strSql.Append(" lastSyncwms = @lastSyncwms , ");                                    
             strSql.Append(" salesReply = @salesReply , ");                                    
             strSql.Append(" salesEndReply = @salesEndReply , ");                                    
             strSql.Append(" salesPerson = @salesPerson , ");                                    
             strSql.Append(" workShop = @workShop , ");                                    
             strSql.Append(" trialShop = @trialShop , ");                                    
             strSql.Append(" orderIssuedTime = @orderIssuedTime , ");                                    
             strSql.Append(" orderFirstIssuedTime = @orderFirstIssuedTime , ");                                    
             strSql.Append(" planStartDate = @planStartDate , ");                                    
             strSql.Append(" oilAddMaterialStatus = @oilAddMaterialStatus , ");                                    
             strSql.Append(" pauseReason = @pauseReason , ");                                    
             strSql.Append(" completionTime = @completionTime , ");                                    
             strSql.Append(" month = @month , ");                                    
             strSql.Append(" year = @year , ");                                    
             strSql.Append(" projectManager = @projectManager , ");                                    
             strSql.Append(" tentativeTime = @tentativeTime , ");                                    
             strSql.Append(" tentativeEndTime = @tentativeEndTime , ");                                    
             strSql.Append(" isExportProduct = @isExportProduct , ");                                    
             strSql.Append(" voltageClass = @voltageClass , ");                                    
             strSql.Append(" planCompletime = @planCompletime , ");                                    
             strSql.Append(" productLink = @productLink , ");                                    
             strSql.Append(" productionSite = @productionSite , ");                                    
             strSql.Append(" nodeList = @nodeList , ");                                    
             strSql.Append(" processStatus = @processStatus , ");                                    
             strSql.Append(" actualStartTime = @actualStartTime , ");                                    
             strSql.Append(" isRepair = @isRepair , ");                                    
             strSql.Append(" limitRelation = @limitRelation  ");            	
             
 			strSql.Append(" where  ");
 						
             SqlParameter[] parameters = {
 			            new SqlParameter("@PT_ID", SqlDbType.Int,4) ,            
                         new SqlParameter("@id", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@ztbm", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@createDt", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@editDt", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@isDeleted", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@deleteDt", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@productNo", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@serialNum", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@model", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@pcNumName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@pcCodeName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@contractNo", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@drawingNo", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@customerName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@noTaxAmount", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@dateEnd", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@edition", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@madeMode", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@schedulingStatus", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@transferStatus", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@project_name", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@count", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@stateName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@planMatched", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@planMatchedTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@materialName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@processPlanSource", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@designSource", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@usingTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@importmentLevel", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@urgentLevel", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@outPut", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@taxPrice", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@timeLimitId", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@timeLimitName", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@lastSyncwms", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@salesReply", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@salesEndReply", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@salesPerson", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@workShop", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@trialShop", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@orderIssuedTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@orderFirstIssuedTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@planStartDate", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@oilAddMaterialStatus", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@pauseReason", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@completionTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@month", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@year", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@projectManager", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@tentativeTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@tentativeEndTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@isExportProduct", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@voltageClass", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@planCompletime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@productLink", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@productionSite", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@nodeList", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@processStatus", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@actualStartTime", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@isRepair", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@limitRelation", SqlDbType.VarChar,-1)             
               
             };
 						            
             parameters[0].Value = model.PT_ID;                        
             parameters[1].Value = model.id;                        
             parameters[2].Value = model.ztbm;                        
             parameters[3].Value = model.createDt;                        
             parameters[4].Value = model.editDt;                        
             parameters[5].Value = model.isDeleted;                        
             parameters[6].Value = model.deleteDt;                        
             parameters[7].Value = model.productNo;                        
             parameters[8].Value = model.serialNum;                        
             parameters[9].Value = model.model;                        
             parameters[10].Value = model.pcNumName;                        
             parameters[11].Value = model.pcCodeName;                        
             parameters[12].Value = model.contractNo;                        
             parameters[13].Value = model.drawingNo;                        
             parameters[14].Value = model.customerName;                        
             parameters[15].Value = model.noTaxAmount;                        
             parameters[16].Value = model.dateEnd;                        
             parameters[17].Value = model.edition;                        
             parameters[18].Value = model.madeMode;                        
             parameters[19].Value = model.schedulingStatus;                        
             parameters[20].Value = model.transferStatus;                        
             parameters[21].Value = model.project_name;                        
             parameters[22].Value = model.count;                        
             parameters[23].Value = model.stateName;                        
             parameters[24].Value = model.planMatched;                        
             parameters[25].Value = model.planMatchedTime;                        
             parameters[26].Value = model.materialName;                        
             parameters[27].Value = model.processPlanSource;                        
             parameters[28].Value = model.designSource;                        
             parameters[29].Value = model.usingTime;                        
             parameters[30].Value = model.importmentLevel;                        
             parameters[31].Value = model.urgentLevel;                        
             parameters[32].Value = model.outPut;                        
             parameters[33].Value = model.taxPrice;                        
             parameters[34].Value = model.timeLimitId;                        
             parameters[35].Value = model.timeLimitName;                        
             parameters[36].Value = model.lastSyncwms;                        
             parameters[37].Value = model.salesReply;                        
             parameters[38].Value = model.salesEndReply;                        
             parameters[39].Value = model.salesPerson;                        
             parameters[40].Value = model.workShop;                        
             parameters[41].Value = model.trialShop;                        
             parameters[42].Value = model.orderIssuedTime;                        
             parameters[43].Value = model.orderFirstIssuedTime;                        
             parameters[44].Value = model.planStartDate;                        
             parameters[45].Value = model.oilAddMaterialStatus;                        
             parameters[46].Value = model.pauseReason;                        
             parameters[47].Value = model.completionTime;                        
             parameters[48].Value = model.month;                        
             parameters[49].Value = model.year;                        
             parameters[50].Value = model.projectManager;                        
             parameters[51].Value = model.tentativeTime;                        
             parameters[52].Value = model.tentativeEndTime;                        
             parameters[53].Value = model.isExportProduct;                        
             parameters[54].Value = model.voltageClass;                        
             parameters[55].Value = model.planCompletime;                        
             parameters[56].Value = model.productLink;                        
             parameters[57].Value = model.productionSite;                        
             parameters[58].Value = model.nodeList;                        
             parameters[59].Value = model.processStatus;                        
             parameters[60].Value = model.actualStartTime;                        
             parameters[61].Value = model.isRepair;                        
             parameters[62].Value = model.limitRelation;                        
             int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
 			
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("delete from PT_MES_SCZJH_data ");
 			strSql.Append(" where ");
 						SqlParameter[] parameters = {
 			};
 
 
 			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
 		public bool DeleteList(string PT_IDlist )
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("delete from PT_MES_SCZJH_data ");
 			strSql.Append(" where ID in ("+PT_IDlist + ")  ");
 			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
 		public Pine_sTool.Model.PT_MES_SCZJH_data GetModel(int PT_ID = 1)
 		{
 			
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("select PT_ID, id, ztbm, createDt, editDt, isDeleted, deleteDt, productNo, serialNum, model, pcNumName, pcCodeName, contractNo, drawingNo, customerName, noTaxAmount, dateEnd, edition, madeMode, schedulingStatus, transferStatus, project_name, count, stateName, planMatched, planMatchedTime, materialName, processPlanSource, designSource, usingTime, importmentLevel, urgentLevel, outPut, taxPrice, timeLimitId, timeLimitName, lastSyncwms, salesReply, salesEndReply, salesPerson, workShop, trialShop, orderIssuedTime, orderFirstIssuedTime, planStartDate, oilAddMaterialStatus, pauseReason, completionTime, month, year, projectManager, tentativeTime, tentativeEndTime, isExportProduct, voltageClass, planCompletime, productLink, productionSite, nodeList, processStatus, actualStartTime, isRepair, limitRelation  ");			
 			strSql.Append("  from PT_MES_SCZJH_data ");
 			strSql.Append($" where PT_ID={PT_ID}");
 						SqlParameter[] parameters = {
 			};
 
 			
 			Pine_sTool.Model.PT_MES_SCZJH_data model=new Pine_sTool.Model.PT_MES_SCZJH_data();
 			
 			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
 			
 			if(ds.Tables[0].Rows.Count>0)
 			{
 			    var row=ds.Tables[0].Rows[0];
 			    
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
 		public Pine_sTool.Model.PT_MES_SCZJH_data DataRowToModel(DataRow row)
 		{
 			Pine_sTool.Model.PT_MES_SCZJH_data model=new Pine_sTool.Model.PT_MES_SCZJH_data();
 			if (row != null)
 			{
 			
               //|int|True|int
               if(row["PT_ID"]!=DBNull.Value && !string.IsNullOrEmpty(row["PT_ID"].ToString()))
               {
                 model.PT_ID=int.Parse(row["PT_ID"].ToString());
               }
 
               //|string|False|varchar
               if(row["id"]!=DBNull.Value)
               {
                 model.id=row["id"].ToString();
               }
 
               //|string|False|varchar
               if(row["ztbm"]!=DBNull.Value)
               {
                 model.ztbm=row["ztbm"].ToString();
               }
 
               //|string|False|varchar
               if(row["createDt"]!=DBNull.Value)
               {
                 model.createDt=row["createDt"].ToString();
               }
 
               //|string|False|varchar
               if(row["editDt"]!=DBNull.Value)
               {
                 model.editDt=row["editDt"].ToString();
               }
 
               //|string|False|varchar
               if(row["isDeleted"]!=DBNull.Value)
               {
                 model.isDeleted=row["isDeleted"].ToString();
               }
 
               //|string|False|varchar
               if(row["deleteDt"]!=DBNull.Value)
               {
                 model.deleteDt=row["deleteDt"].ToString();
               }
 
               //|string|False|varchar
               if(row["productNo"]!=DBNull.Value)
               {
                 model.productNo=row["productNo"].ToString();
               }
 
               //|string|False|varchar
               if(row["serialNum"]!=DBNull.Value)
               {
                 model.serialNum=row["serialNum"].ToString();
               }
 
               //|string|False|varchar
               if(row["model"]!=DBNull.Value)
               {
                 model.model=row["model"].ToString();
               }
 
               //|string|False|varchar
               if(row["pcNumName"]!=DBNull.Value)
               {
                 model.pcNumName=row["pcNumName"].ToString();
               }
 
               //|string|False|varchar
               if(row["pcCodeName"]!=DBNull.Value)
               {
                 model.pcCodeName=row["pcCodeName"].ToString();
               }
 
               //|string|False|varchar
               if(row["contractNo"]!=DBNull.Value)
               {
                 model.contractNo=row["contractNo"].ToString();
               }
 
               //|string|False|varchar
               if(row["drawingNo"]!=DBNull.Value)
               {
                 model.drawingNo=row["drawingNo"].ToString();
               }
 
               //|string|False|varchar
               if(row["customerName"]!=DBNull.Value)
               {
                 model.customerName=row["customerName"].ToString();
               }
 
               //|string|False|varchar
               if(row["noTaxAmount"]!=DBNull.Value)
               {
                 model.noTaxAmount=row["noTaxAmount"].ToString();
               }
 
               //|string|False|varchar
               if(row["dateEnd"]!=DBNull.Value)
               {
                 model.dateEnd=row["dateEnd"].ToString();
               }
 
               //|string|False|varchar
               if(row["edition"]!=DBNull.Value)
               {
                 model.edition=row["edition"].ToString();
               }
 
               //|string|False|varchar
               if(row["madeMode"]!=DBNull.Value)
               {
                 model.madeMode=row["madeMode"].ToString();
               }
 
               //|string|False|varchar
               if(row["schedulingStatus"]!=DBNull.Value)
               {
                 model.schedulingStatus=row["schedulingStatus"].ToString();
               }
 
               //|string|False|varchar
               if(row["transferStatus"]!=DBNull.Value)
               {
                 model.transferStatus=row["transferStatus"].ToString();
               }
 
               //|string|False|varchar
               if(row["project_name"]!=DBNull.Value)
               {
                 model.project_name=row["project_name"].ToString();
               }
 
               //|string|False|varchar
               if(row["count"]!=DBNull.Value)
               {
                 model.count=row["count"].ToString();
               }
 
               //|string|False|varchar
               if(row["stateName"]!=DBNull.Value)
               {
                 model.stateName=row["stateName"].ToString();
               }
 
               //|string|False|varchar
               if(row["planMatched"]!=DBNull.Value)
               {
                 model.planMatched=row["planMatched"].ToString();
               }
 
               //|string|False|varchar
               if(row["planMatchedTime"]!=DBNull.Value)
               {
                 model.planMatchedTime=row["planMatchedTime"].ToString();
               }
 
               //|string|False|varchar
               if(row["materialName"]!=DBNull.Value)
               {
                 model.materialName=row["materialName"].ToString();
               }
 
               //|string|False|varchar
               if(row["processPlanSource"]!=DBNull.Value)
               {
                 model.processPlanSource=row["processPlanSource"].ToString();
               }
 
               //|string|False|varchar
               if(row["designSource"]!=DBNull.Value)
               {
                 model.designSource=row["designSource"].ToString();
               }
 
               //|string|False|varchar
               if(row["usingTime"]!=DBNull.Value)
               {
                 model.usingTime=row["usingTime"].ToString();
               }
 
               //|string|False|varchar
               if(row["importmentLevel"]!=DBNull.Value)
               {
                 model.importmentLevel=row["importmentLevel"].ToString();
               }
 
               //|string|False|varchar
               if(row["urgentLevel"]!=DBNull.Value)
               {
                 model.urgentLevel=row["urgentLevel"].ToString();
               }
 
               //|string|False|varchar
               if(row["outPut"]!=DBNull.Value)
               {
                 model.outPut=row["outPut"].ToString();
               }
 
               //|string|False|varchar
               if(row["taxPrice"]!=DBNull.Value)
               {
                 model.taxPrice=row["taxPrice"].ToString();
               }
 
               //|string|False|varchar
               if(row["timeLimitId"]!=DBNull.Value)
               {
                 model.timeLimitId=row["timeLimitId"].ToString();
               }
 
               //|string|False|varchar
               if(row["timeLimitName"]!=DBNull.Value)
               {
                 model.timeLimitName=row["timeLimitName"].ToString();
               }
 
               //|string|False|varchar
               if(row["lastSyncwms"]!=DBNull.Value)
               {
                 model.lastSyncwms=row["lastSyncwms"].ToString();
               }
 
               //|string|False|varchar
               if(row["salesReply"]!=DBNull.Value)
               {
                 model.salesReply=row["salesReply"].ToString();
               }
 
               //|string|False|varchar
               if(row["salesEndReply"]!=DBNull.Value)
               {
                 model.salesEndReply=row["salesEndReply"].ToString();
               }
 
               //|string|False|varchar
               if(row["salesPerson"]!=DBNull.Value)
               {
                 model.salesPerson=row["salesPerson"].ToString();
               }
 
               //|string|False|varchar
               if(row["workShop"]!=DBNull.Value)
               {
                 model.workShop=row["workShop"].ToString();
               }
 
               //|string|False|varchar
               if(row["trialShop"]!=DBNull.Value)
               {
                 model.trialShop=row["trialShop"].ToString();
               }
 
               //|string|False|varchar
               if(row["orderIssuedTime"]!=DBNull.Value)
               {
                 model.orderIssuedTime=row["orderIssuedTime"].ToString();
               }
 
               //|string|False|varchar
               if(row["orderFirstIssuedTime"]!=DBNull.Value)
               {
                 model.orderFirstIssuedTime=row["orderFirstIssuedTime"].ToString();
               }
 
               //|string|False|varchar
               if(row["planStartDate"]!=DBNull.Value)
               {
                 model.planStartDate=row["planStartDate"].ToString();
               }
 
               //|string|False|varchar
               if(row["oilAddMaterialStatus"]!=DBNull.Value)
               {
                 model.oilAddMaterialStatus=row["oilAddMaterialStatus"].ToString();
               }
 
               //|string|False|varchar
               if(row["pauseReason"]!=DBNull.Value)
               {
                 model.pauseReason=row["pauseReason"].ToString();
               }
 
               //|string|False|varchar
               if(row["completionTime"]!=DBNull.Value)
               {
                 model.completionTime=row["completionTime"].ToString();
               }
 
               //|string|False|varchar
               if(row["month"]!=DBNull.Value)
               {
                 model.month=row["month"].ToString();
               }
 
               //|string|False|varchar
               if(row["year"]!=DBNull.Value)
               {
                 model.year=row["year"].ToString();
               }
 
               //|string|False|varchar
               if(row["projectManager"]!=DBNull.Value)
               {
                 model.projectManager=row["projectManager"].ToString();
               }
 
               //|string|False|varchar
               if(row["tentativeTime"]!=DBNull.Value)
               {
                 model.tentativeTime=row["tentativeTime"].ToString();
               }
 
               //|string|False|varchar
               if(row["tentativeEndTime"]!=DBNull.Value)
               {
                 model.tentativeEndTime=row["tentativeEndTime"].ToString();
               }
 
               //|string|False|varchar
               if(row["isExportProduct"]!=DBNull.Value)
               {
                 model.isExportProduct=row["isExportProduct"].ToString();
               }
 
               //|string|False|varchar
               if(row["voltageClass"]!=DBNull.Value)
               {
                 model.voltageClass=row["voltageClass"].ToString();
               }
 
               //|string|False|varchar
               if(row["planCompletime"]!=DBNull.Value)
               {
                 model.planCompletime=row["planCompletime"].ToString();
               }
 
               //|string|False|varchar
               if(row["productLink"]!=DBNull.Value)
               {
                 model.productLink=row["productLink"].ToString();
               }
 
               //|string|False|varchar
               if(row["productionSite"]!=DBNull.Value)
               {
                 model.productionSite=row["productionSite"].ToString();
               }
 
               //|string|False|varchar
               if(row["nodeList"]!=DBNull.Value)
               {
                 model.nodeList=row["nodeList"].ToString();
               }
 
               //|string|False|varchar
               if(row["processStatus"]!=DBNull.Value)
               {
                 model.processStatus=row["processStatus"].ToString();
               }
 
               //|string|False|varchar
               if(row["actualStartTime"]!=DBNull.Value)
               {
                 model.actualStartTime=row["actualStartTime"].ToString();
               }
 
               //|string|False|varchar
               if(row["isRepair"]!=DBNull.Value)
               {
                 model.isRepair=row["isRepair"].ToString();
               }
 
               //|string|False|varchar
               if(row["limitRelation"]!=DBNull.Value)
               {
                 model.limitRelation=row["limitRelation"].ToString();
               }
 			}
 			return model;
 		}
 		
 		/// <summary>
 		/// 获得数据列表
 		/// </summary>
 		public DataSet GetList(string strWhere)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("select * ");
 			strSql.Append(" FROM PT_MES_SCZJH_data ");
 			if(strWhere.Trim()!="")
 			{
 				strSql.Append(" where "+strWhere);
 			}
 			return DbHelperSQL.Query(strSql.ToString());
 		}
 		
 		/// <summary>
 		/// 获得前几行数据
 		/// </summary>
 		public DataSet GetList(int Top,string strWhere,string filedOrder)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("select ");
 			if(Top>0)
 			{
 				strSql.Append(" top "+Top.ToString());
 			}
 			strSql.Append(" * ");
 			strSql.Append(" FROM PT_MES_SCZJH_data ");
 			if(strWhere.Trim()!="")
 			{
 				strSql.Append(" where "+strWhere);
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
             strSql.Append("select count(1) FROM PT_MES_SCZJH_data ");
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
             strSql.Append(")AS Row, T.*  from PT_MES_SCZJH_data T ");
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
             public static string productNo = "productNo";
             public static string serialNum = "serialNum";
             public static string model = "model";
             public static string pcNumName = "pcNumName";
             public static string pcCodeName = "pcCodeName";
             public static string contractNo = "contractNo";
             public static string drawingNo = "drawingNo";
             public static string customerName = "customerName";
             public static string noTaxAmount = "noTaxAmount";
             public static string dateEnd = "dateEnd";
             public static string edition = "edition";
             public static string madeMode = "madeMode";
             public static string schedulingStatus = "schedulingStatus";
             public static string transferStatus = "transferStatus";
             public static string project_name = "project_name";
             public static string count = "count";
             public static string stateName = "stateName";
             public static string planMatched = "planMatched";
             public static string planMatchedTime = "planMatchedTime";
             public static string materialName = "materialName";
             public static string processPlanSource = "processPlanSource";
             public static string designSource = "designSource";
             public static string usingTime = "usingTime";
             public static string importmentLevel = "importmentLevel";
             public static string urgentLevel = "urgentLevel";
             public static string outPut = "outPut";
             public static string taxPrice = "taxPrice";
             public static string timeLimitId = "timeLimitId";
             public static string timeLimitName = "timeLimitName";
             public static string lastSyncwms = "lastSyncwms";
             public static string salesReply = "salesReply";
             public static string salesEndReply = "salesEndReply";
             public static string salesPerson = "salesPerson";
             public static string workShop = "workShop";
             public static string trialShop = "trialShop";
             public static string orderIssuedTime = "orderIssuedTime";
             public static string orderFirstIssuedTime = "orderFirstIssuedTime";
             public static string planStartDate = "planStartDate";
             public static string oilAddMaterialStatus = "oilAddMaterialStatus";
             public static string pauseReason = "pauseReason";
             public static string completionTime = "completionTime";
             public static string month = "month";
             public static string year = "year";
             public static string projectManager = "projectManager";
             public static string tentativeTime = "tentativeTime";
             public static string tentativeEndTime = "tentativeEndTime";
             public static string isExportProduct = "isExportProduct";
             public static string voltageClass = "voltageClass";
             public static string planCompletime = "planCompletime";
             public static string productLink = "productLink";
             public static string productionSite = "productionSite";
             public static string nodeList = "nodeList";
             public static string processStatus = "processStatus";
             public static string actualStartTime = "actualStartTime";
             public static string isRepair = "isRepair";
             public static string limitRelation = "limitRelation";
         }
     }
 }
 
