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
* 功    能： 数据库操作_Model 
* 类    名： PT_MES_SCZJH_data
* 创建时间： 2024/9/5 17:41:48
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/  

using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

namespace Pine_sTool.Model
{
    //PT_MES_SCZJH_data 
     [Serializable]
 	public class PT_MES_SCZJH_data
 	{
        #region Model
        private int _pt_id;
        private string _id;
        private string _ztbm;
        private string _createdt;
        private string _editdt;
        private string _isdeleted;
        private string _deletedt;
        private string _productno;
        private string _serialnum;
        private string _model;
        private string _pcnumname;
        private string _pccodename;
        private string _contractno;
        private string _drawingno;
        private string _customername;
        private string _notaxamount;
        private string _dateend;
        private string _edition;
        private string _mademode;
        private string _schedulingstatus;
        private string _transferstatus;
        private string _project_name;
        private string _count;
        private string _statename;
        private string _planmatched;
        private string _planmatchedtime;
        private string _materialname;
        private string _processplansource;
        private string _designsource;
        private string _usingtime;
        private string _importmentlevel;
        private string _urgentlevel;
        private string _output;
        private string _taxprice;
        private string _timelimitid;
        private string _timelimitname;
        private string _lastsyncwms;
        private string _salesreply;
        private string _salesendreply;
        private string _salesperson;
        private string _workshop;
        private string _trialshop;
        private string _orderissuedtime;
        private string _orderfirstissuedtime;
        private string _planstartdate;
        private string _oiladdmaterialstatus;
        private string _pausereason;
        private string _completiontime;
        private string _month;
        private string _year;
        private string _projectmanager;
        private string _tentativetime;
        private string _tentativeendtime;
        private string _isexportproduct;
        private string _voltageclass;
        private string _plancompletime;
        private string _productlink;
        private string _productionsite;
        private string _nodelist;
        private string _processstatus;
        private string _actualstarttime;
        private string _isrepair;
        private string _limitrelation;
        		
        DataRow row;
     
        public PT_MES_SCZJH_data(){}
    	
    	public PT_MES_SCZJH_data(DataRow row)
    	{
    		this.row = row;
    	}	
    	
       	 /// <summary>
 		 /// PT_ID
 		 ///Nullable:False valueType:True 
         /// </summary>		
         public int PT_ID
         {
             get
             { 
             	return _pt_id; 
             }
             set
             {
 	            _pt_id = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["PT_ID"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["PT_ID"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// id
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string id
         {
             get
             { 
             	return _id; 
             }
             set
             {
 	            _id = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["id"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["id"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// ztbm
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string ztbm
         {
             get
             { 
             	return _ztbm; 
             }
             set
             {
 	            _ztbm = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["ztbm"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["ztbm"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// createDt
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string createDt
         {
             get
             { 
             	return _createdt; 
             }
             set
             {
 	            _createdt = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["createDt"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["createDt"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// editDt
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string editDt
         {
             get
             { 
             	return _editdt; 
             }
             set
             {
 	            _editdt = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["editDt"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["editDt"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isDeleted
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isDeleted
         {
             get
             { 
             	return _isdeleted; 
             }
             set
             {
 	            _isdeleted = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isDeleted"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isDeleted"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// deleteDt
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string deleteDt
         {
             get
             { 
             	return _deletedt; 
             }
             set
             {
 	            _deletedt = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["deleteDt"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["deleteDt"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// productNo
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string productNo
         {
             get
             { 
             	return _productno; 
             }
             set
             {
 	            _productno = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["productNo"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["productNo"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// serialNum
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string serialNum
         {
             get
             { 
             	return _serialnum; 
             }
             set
             {
 	            _serialnum = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["serialNum"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["serialNum"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// model
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string model
         {
             get
             { 
             	return _model; 
             }
             set
             {
 	            _model = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["model"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["model"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// pcNumName
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string pcNumName
         {
             get
             { 
             	return _pcnumname; 
             }
             set
             {
 	            _pcnumname = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["pcNumName"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["pcNumName"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// pcCodeName
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string pcCodeName
         {
             get
             { 
             	return _pccodename; 
             }
             set
             {
 	            _pccodename = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["pcCodeName"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["pcCodeName"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// contractNo
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string contractNo
         {
             get
             { 
             	return _contractno; 
             }
             set
             {
 	            _contractno = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["contractNo"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["contractNo"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// drawingNo
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string drawingNo
         {
             get
             { 
             	return _drawingno; 
             }
             set
             {
 	            _drawingno = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["drawingNo"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["drawingNo"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// customerName
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string customerName
         {
             get
             { 
             	return _customername; 
             }
             set
             {
 	            _customername = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["customerName"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["customerName"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// noTaxAmount
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string noTaxAmount
         {
             get
             { 
             	return _notaxamount; 
             }
             set
             {
 	            _notaxamount = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["noTaxAmount"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["noTaxAmount"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// dateEnd
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string dateEnd
         {
             get
             { 
             	return _dateend; 
             }
             set
             {
 	            _dateend = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["dateEnd"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["dateEnd"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// edition
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string edition
         {
             get
             { 
             	return _edition; 
             }
             set
             {
 	            _edition = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["edition"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["edition"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// madeMode
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string madeMode
         {
             get
             { 
             	return _mademode; 
             }
             set
             {
 	            _mademode = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["madeMode"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["madeMode"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// schedulingStatus
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string schedulingStatus
         {
             get
             { 
             	return _schedulingstatus; 
             }
             set
             {
 	            _schedulingstatus = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["schedulingStatus"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["schedulingStatus"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// transferStatus
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string transferStatus
         {
             get
             { 
             	return _transferstatus; 
             }
             set
             {
 	            _transferstatus = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["transferStatus"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["transferStatus"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// project_name
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string project_name
         {
             get
             { 
             	return _project_name; 
             }
             set
             {
 	            _project_name = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["project_name"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["project_name"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// count
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string count
         {
             get
             { 
             	return _count; 
             }
             set
             {
 	            _count = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["count"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["count"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// stateName
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string stateName
         {
             get
             { 
             	return _statename; 
             }
             set
             {
 	            _statename = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["stateName"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["stateName"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// planMatched
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string planMatched
         {
             get
             { 
             	return _planmatched; 
             }
             set
             {
 	            _planmatched = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["planMatched"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["planMatched"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// planMatchedTime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string planMatchedTime
         {
             get
             { 
             	return _planmatchedtime; 
             }
             set
             {
 	            _planmatchedtime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["planMatchedTime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["planMatchedTime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// materialName
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string materialName
         {
             get
             { 
             	return _materialname; 
             }
             set
             {
 	            _materialname = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["materialName"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["materialName"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// processPlanSource
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string processPlanSource
         {
             get
             { 
             	return _processplansource; 
             }
             set
             {
 	            _processplansource = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["processPlanSource"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["processPlanSource"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// designSource
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string designSource
         {
             get
             { 
             	return _designsource; 
             }
             set
             {
 	            _designsource = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["designSource"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["designSource"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// usingTime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string usingTime
         {
             get
             { 
             	return _usingtime; 
             }
             set
             {
 	            _usingtime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["usingTime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["usingTime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// importmentLevel
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string importmentLevel
         {
             get
             { 
             	return _importmentlevel; 
             }
             set
             {
 	            _importmentlevel = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["importmentLevel"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["importmentLevel"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// urgentLevel
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string urgentLevel
         {
             get
             { 
             	return _urgentlevel; 
             }
             set
             {
 	            _urgentlevel = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["urgentLevel"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["urgentLevel"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// outPut
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string outPut
         {
             get
             { 
             	return _output; 
             }
             set
             {
 	            _output = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["outPut"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["outPut"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// taxPrice
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string taxPrice
         {
             get
             { 
             	return _taxprice; 
             }
             set
             {
 	            _taxprice = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["taxPrice"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["taxPrice"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// timeLimitId
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string timeLimitId
         {
             get
             { 
             	return _timelimitid; 
             }
             set
             {
 	            _timelimitid = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["timeLimitId"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["timeLimitId"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// timeLimitName
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string timeLimitName
         {
             get
             { 
             	return _timelimitname; 
             }
             set
             {
 	            _timelimitname = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["timeLimitName"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["timeLimitName"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// lastSyncwms
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string lastSyncwms
         {
             get
             { 
             	return _lastsyncwms; 
             }
             set
             {
 	            _lastsyncwms = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["lastSyncwms"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["lastSyncwms"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// salesReply
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string salesReply
         {
             get
             { 
             	return _salesreply; 
             }
             set
             {
 	            _salesreply = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["salesReply"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["salesReply"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// salesEndReply
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string salesEndReply
         {
             get
             { 
             	return _salesendreply; 
             }
             set
             {
 	            _salesendreply = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["salesEndReply"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["salesEndReply"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// salesPerson
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string salesPerson
         {
             get
             { 
             	return _salesperson; 
             }
             set
             {
 	            _salesperson = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["salesPerson"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["salesPerson"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// workShop
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string workShop
         {
             get
             { 
             	return _workshop; 
             }
             set
             {
 	            _workshop = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["workShop"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["workShop"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// trialShop
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string trialShop
         {
             get
             { 
             	return _trialshop; 
             }
             set
             {
 	            _trialshop = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["trialShop"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["trialShop"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// orderIssuedTime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string orderIssuedTime
         {
             get
             { 
             	return _orderissuedtime; 
             }
             set
             {
 	            _orderissuedtime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["orderIssuedTime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["orderIssuedTime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// orderFirstIssuedTime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string orderFirstIssuedTime
         {
             get
             { 
             	return _orderfirstissuedtime; 
             }
             set
             {
 	            _orderfirstissuedtime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["orderFirstIssuedTime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["orderFirstIssuedTime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// planStartDate
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string planStartDate
         {
             get
             { 
             	return _planstartdate; 
             }
             set
             {
 	            _planstartdate = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["planStartDate"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["planStartDate"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// oilAddMaterialStatus
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string oilAddMaterialStatus
         {
             get
             { 
             	return _oiladdmaterialstatus; 
             }
             set
             {
 	            _oiladdmaterialstatus = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["oilAddMaterialStatus"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["oilAddMaterialStatus"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// pauseReason
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string pauseReason
         {
             get
             { 
             	return _pausereason; 
             }
             set
             {
 	            _pausereason = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["pauseReason"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["pauseReason"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// completionTime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string completionTime
         {
             get
             { 
             	return _completiontime; 
             }
             set
             {
 	            _completiontime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["completionTime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["completionTime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// month
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string month
         {
             get
             { 
             	return _month; 
             }
             set
             {
 	            _month = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["month"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["month"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// year
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string year
         {
             get
             { 
             	return _year; 
             }
             set
             {
 	            _year = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["year"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["year"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// projectManager
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string projectManager
         {
             get
             { 
             	return _projectmanager; 
             }
             set
             {
 	            _projectmanager = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["projectManager"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["projectManager"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// tentativeTime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string tentativeTime
         {
             get
             { 
             	return _tentativetime; 
             }
             set
             {
 	            _tentativetime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["tentativeTime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["tentativeTime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// tentativeEndTime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string tentativeEndTime
         {
             get
             { 
             	return _tentativeendtime; 
             }
             set
             {
 	            _tentativeendtime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["tentativeEndTime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["tentativeEndTime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isExportProduct
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isExportProduct
         {
             get
             { 
             	return _isexportproduct; 
             }
             set
             {
 	            _isexportproduct = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isExportProduct"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isExportProduct"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// voltageClass
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string voltageClass
         {
             get
             { 
             	return _voltageclass; 
             }
             set
             {
 	            _voltageclass = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["voltageClass"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["voltageClass"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// planCompletime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string planCompletime
         {
             get
             { 
             	return _plancompletime; 
             }
             set
             {
 	            _plancompletime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["planCompletime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["planCompletime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// productLink
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string productLink
         {
             get
             { 
             	return _productlink; 
             }
             set
             {
 	            _productlink = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["productLink"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["productLink"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// productionSite
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string productionSite
         {
             get
             { 
             	return _productionsite; 
             }
             set
             {
 	            _productionsite = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["productionSite"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["productionSite"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// nodeList
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string nodeList
         {
             get
             { 
             	return _nodelist; 
             }
             set
             {
 	            _nodelist = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["nodeList"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["nodeList"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// processStatus
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string processStatus
         {
             get
             { 
             	return _processstatus; 
             }
             set
             {
 	            _processstatus = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["processStatus"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["processStatus"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// actualStartTime
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string actualStartTime
         {
             get
             { 
             	return _actualstarttime; 
             }
             set
             {
 	            _actualstarttime = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["actualStartTime"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["actualStartTime"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isRepair
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isRepair
         {
             get
             { 
             	return _isrepair; 
             }
             set
             {
 	            _isrepair = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isRepair"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isRepair"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// limitRelation
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string limitRelation
         {
             get
             { 
             	return _limitrelation; 
             }
             set
             {
 	            _limitrelation = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["limitRelation"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["limitRelation"] = value;
 		            }
 	            }
             }
         }          
 		 #endregion Model
 	}
 }