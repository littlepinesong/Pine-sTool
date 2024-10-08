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
* 功    能： 数据库操作_Model 
* 类    名： PT_MES_SCZJH_MergerTable
* 创建时间： 2024/9/4 10:15:50
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/  

using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

namespace Pine_sTool.Model
{
    //PT_MES_SCZJH_MergerTable 
     [Serializable]
 	public class PT_MES_SCZJH_MergerTable
 	{
        #region Model
        private int _pt_id;
        private string _id主干;
        private string _ztbm主干;
        private string _createdt主干;
        private string _editdt主干;
        private string _isdeleted主干;
        private string _deletedt主干;
        private string _productno主干;
        private string _serialnum主干;
        private string _model主干;
        private string _pcnumname主干;
        private string _pccodename主干;
        private string _contractno主干;
        private string _drawingno主干;
        private string _customername主干;
        private string _notaxamount主干;
        private string _dateend主干;
        private string _edition主干;
        private string _mademode主干;
        private string _schedulingstatus主干;
        private string _transferstatus主干;
        private string _project_name主干;
        private string _count主干;
        private string _statename主干;
        private string _planmatched主干;
        private string _planmatchedtime主干;
        private string _materialname主干;
        private string _processplansource主干;
        private string _designsource主干;
        private string _usingtime主干;
        private string _importmentlevel主干;
        private string _urgentlevel主干;
        private string _output主干;
        private string _taxprice主干;
        private string _timelimitid主干;
        private string _timelimitname主干;
        private string _lastsyncwms主干;
        private string _salesreply主干;
        private string _salesendreply主干;
        private string _salesperson主干;
        private string _workshop主干;
        private string _trialshop主干;
        private string _orderissuedtime主干;
        private string _orderfirstissuedtime主干;
        private string _planstartdate主干;
        private string _oiladdmaterialstatus主干;
        private string _pausereason主干;
        private string _completiontime主干;
        private string _month主干;
        private string _year主干;
        private string _projectmanager主干;
        private string _tentativetime主干;
        private string _tentativeendtime主干;
        private string _isexportproduct主干;
        private string _voltageclass主干;
        private string _plancompletime主干;
        private string _productlink主干;
        private string _productionsite主干;
        private string _nodelist主干;
        private string _processstatus主干;
        private string _actualstarttime主干;
        private string _isrepair主干;
        private string _limitrelation主干;
        private string _id节点;
        private string _ztbm节点;
        private string _createdt节点;
        private string _editdt节点;
        private string _isdeleted节点;
        private string _deletedt节点;
        private string _productplanid节点;
        private string _drawingno节点;
        private string _name节点;
        private string _type节点;
        private string _nodedate节点;
        private string _finishdate节点;
        private string _ruleconfig节点;
        private string _status节点;
        private string _progressstatus节点;
        private string _confirmstatus节点;
        private string _sentkey2wms节点;
        private string _wmsmid节点;
        private string _startdate节点;
        private string _actualstartdate节点;
        private string _nodeid节点;
        private string _nodename节点;
        private string _ismaterialpreparation节点;
        private string _materialversion节点;
        private string _usedequipment节点;
        private string _pausereason节点;
        private string _describe节点;
        private string _bominfo节点;
        private string _recordid节点;
        private string _isoutsourcing节点;
        private string _hbfinishdate节点;
        private string _outsourcingsituation节点;
        private string _outsourcingsettime节点;
        private string _finishuserid节点;
        private string _finishusername节点;
        private string _startuserid节点;
        private string _startusername节点;
        private string _pauseduration节点;
        private string _drawphase节点;
        private string _drawplanfinishtime节点;
        private string _drawactualfinishtime节点;
        private string _chargepersonname节点;
        private string _difday节点;
        		
        DataRow row;
     
        public PT_MES_SCZJH_MergerTable(){}
    	
    	public PT_MES_SCZJH_MergerTable(DataRow row)
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
 		 /// id主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string id主干
         {
             get
             { 
             	return _id主干; 
             }
             set
             {
 	            _id主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["id主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["id主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// ztbm主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string ztbm主干
         {
             get
             { 
             	return _ztbm主干; 
             }
             set
             {
 	            _ztbm主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["ztbm主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["ztbm主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// createDt主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string createDt主干
         {
             get
             { 
             	return _createdt主干; 
             }
             set
             {
 	            _createdt主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["createDt主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["createDt主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// editDt主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string editDt主干
         {
             get
             { 
             	return _editdt主干; 
             }
             set
             {
 	            _editdt主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["editDt主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["editDt主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isDeleted主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isDeleted主干
         {
             get
             { 
             	return _isdeleted主干; 
             }
             set
             {
 	            _isdeleted主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isDeleted主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isDeleted主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// deleteDt主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string deleteDt主干
         {
             get
             { 
             	return _deletedt主干; 
             }
             set
             {
 	            _deletedt主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["deleteDt主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["deleteDt主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// productNo主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string productNo主干
         {
             get
             { 
             	return _productno主干; 
             }
             set
             {
 	            _productno主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["productNo主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["productNo主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// serialNum主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string serialNum主干
         {
             get
             { 
             	return _serialnum主干; 
             }
             set
             {
 	            _serialnum主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["serialNum主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["serialNum主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// model主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string model主干
         {
             get
             { 
             	return _model主干; 
             }
             set
             {
 	            _model主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["model主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["model主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// pcNumName主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string pcNumName主干
         {
             get
             { 
             	return _pcnumname主干; 
             }
             set
             {
 	            _pcnumname主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["pcNumName主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["pcNumName主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// pcCodeName主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string pcCodeName主干
         {
             get
             { 
             	return _pccodename主干; 
             }
             set
             {
 	            _pccodename主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["pcCodeName主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["pcCodeName主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// contractNo主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string contractNo主干
         {
             get
             { 
             	return _contractno主干; 
             }
             set
             {
 	            _contractno主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["contractNo主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["contractNo主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// drawingNo主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string drawingNo主干
         {
             get
             { 
             	return _drawingno主干; 
             }
             set
             {
 	            _drawingno主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["drawingNo主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["drawingNo主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// customerName主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string customerName主干
         {
             get
             { 
             	return _customername主干; 
             }
             set
             {
 	            _customername主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["customerName主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["customerName主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// noTaxAmount主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string noTaxAmount主干
         {
             get
             { 
             	return _notaxamount主干; 
             }
             set
             {
 	            _notaxamount主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["noTaxAmount主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["noTaxAmount主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// dateEnd主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string dateEnd主干
         {
             get
             { 
             	return _dateend主干; 
             }
             set
             {
 	            _dateend主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["dateEnd主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["dateEnd主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// edition主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string edition主干
         {
             get
             { 
             	return _edition主干; 
             }
             set
             {
 	            _edition主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["edition主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["edition主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// madeMode主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string madeMode主干
         {
             get
             { 
             	return _mademode主干; 
             }
             set
             {
 	            _mademode主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["madeMode主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["madeMode主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// schedulingStatus主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string schedulingStatus主干
         {
             get
             { 
             	return _schedulingstatus主干; 
             }
             set
             {
 	            _schedulingstatus主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["schedulingStatus主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["schedulingStatus主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// transferStatus主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string transferStatus主干
         {
             get
             { 
             	return _transferstatus主干; 
             }
             set
             {
 	            _transferstatus主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["transferStatus主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["transferStatus主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// project_name主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string project_name主干
         {
             get
             { 
             	return _project_name主干; 
             }
             set
             {
 	            _project_name主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["project_name主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["project_name主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// count主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string count主干
         {
             get
             { 
             	return _count主干; 
             }
             set
             {
 	            _count主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["count主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["count主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// stateName主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string stateName主干
         {
             get
             { 
             	return _statename主干; 
             }
             set
             {
 	            _statename主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["stateName主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["stateName主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// planMatched主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string planMatched主干
         {
             get
             { 
             	return _planmatched主干; 
             }
             set
             {
 	            _planmatched主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["planMatched主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["planMatched主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// planMatchedTime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string planMatchedTime主干
         {
             get
             { 
             	return _planmatchedtime主干; 
             }
             set
             {
 	            _planmatchedtime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["planMatchedTime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["planMatchedTime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// materialName主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string materialName主干
         {
             get
             { 
             	return _materialname主干; 
             }
             set
             {
 	            _materialname主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["materialName主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["materialName主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// processPlanSource主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string processPlanSource主干
         {
             get
             { 
             	return _processplansource主干; 
             }
             set
             {
 	            _processplansource主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["processPlanSource主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["processPlanSource主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// designSource主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string designSource主干
         {
             get
             { 
             	return _designsource主干; 
             }
             set
             {
 	            _designsource主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["designSource主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["designSource主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// usingTime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string usingTime主干
         {
             get
             { 
             	return _usingtime主干; 
             }
             set
             {
 	            _usingtime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["usingTime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["usingTime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// importmentLevel主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string importmentLevel主干
         {
             get
             { 
             	return _importmentlevel主干; 
             }
             set
             {
 	            _importmentlevel主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["importmentLevel主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["importmentLevel主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// urgentLevel主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string urgentLevel主干
         {
             get
             { 
             	return _urgentlevel主干; 
             }
             set
             {
 	            _urgentlevel主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["urgentLevel主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["urgentLevel主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// outPut主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string outPut主干
         {
             get
             { 
             	return _output主干; 
             }
             set
             {
 	            _output主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["outPut主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["outPut主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// taxPrice主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string taxPrice主干
         {
             get
             { 
             	return _taxprice主干; 
             }
             set
             {
 	            _taxprice主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["taxPrice主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["taxPrice主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// timeLimitId主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string timeLimitId主干
         {
             get
             { 
             	return _timelimitid主干; 
             }
             set
             {
 	            _timelimitid主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["timeLimitId主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["timeLimitId主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// timeLimitName主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string timeLimitName主干
         {
             get
             { 
             	return _timelimitname主干; 
             }
             set
             {
 	            _timelimitname主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["timeLimitName主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["timeLimitName主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// lastSyncwms主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string lastSyncwms主干
         {
             get
             { 
             	return _lastsyncwms主干; 
             }
             set
             {
 	            _lastsyncwms主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["lastSyncwms主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["lastSyncwms主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// salesReply主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string salesReply主干
         {
             get
             { 
             	return _salesreply主干; 
             }
             set
             {
 	            _salesreply主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["salesReply主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["salesReply主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// salesEndReply主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string salesEndReply主干
         {
             get
             { 
             	return _salesendreply主干; 
             }
             set
             {
 	            _salesendreply主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["salesEndReply主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["salesEndReply主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// salesPerson主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string salesPerson主干
         {
             get
             { 
             	return _salesperson主干; 
             }
             set
             {
 	            _salesperson主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["salesPerson主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["salesPerson主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// workShop主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string workShop主干
         {
             get
             { 
             	return _workshop主干; 
             }
             set
             {
 	            _workshop主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["workShop主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["workShop主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// trialShop主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string trialShop主干
         {
             get
             { 
             	return _trialshop主干; 
             }
             set
             {
 	            _trialshop主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["trialShop主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["trialShop主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// orderIssuedTime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string orderIssuedTime主干
         {
             get
             { 
             	return _orderissuedtime主干; 
             }
             set
             {
 	            _orderissuedtime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["orderIssuedTime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["orderIssuedTime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// orderFirstIssuedTime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string orderFirstIssuedTime主干
         {
             get
             { 
             	return _orderfirstissuedtime主干; 
             }
             set
             {
 	            _orderfirstissuedtime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["orderFirstIssuedTime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["orderFirstIssuedTime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// planStartDate主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string planStartDate主干
         {
             get
             { 
             	return _planstartdate主干; 
             }
             set
             {
 	            _planstartdate主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["planStartDate主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["planStartDate主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// oilAddMaterialStatus主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string oilAddMaterialStatus主干
         {
             get
             { 
             	return _oiladdmaterialstatus主干; 
             }
             set
             {
 	            _oiladdmaterialstatus主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["oilAddMaterialStatus主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["oilAddMaterialStatus主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// pauseReason主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string pauseReason主干
         {
             get
             { 
             	return _pausereason主干; 
             }
             set
             {
 	            _pausereason主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["pauseReason主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["pauseReason主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// completionTime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string completionTime主干
         {
             get
             { 
             	return _completiontime主干; 
             }
             set
             {
 	            _completiontime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["completionTime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["completionTime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// month主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string month主干
         {
             get
             { 
             	return _month主干; 
             }
             set
             {
 	            _month主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["month主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["month主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// year主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string year主干
         {
             get
             { 
             	return _year主干; 
             }
             set
             {
 	            _year主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["year主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["year主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// projectManager主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string projectManager主干
         {
             get
             { 
             	return _projectmanager主干; 
             }
             set
             {
 	            _projectmanager主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["projectManager主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["projectManager主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// tentativeTime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string tentativeTime主干
         {
             get
             { 
             	return _tentativetime主干; 
             }
             set
             {
 	            _tentativetime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["tentativeTime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["tentativeTime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// tentativeEndTime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string tentativeEndTime主干
         {
             get
             { 
             	return _tentativeendtime主干; 
             }
             set
             {
 	            _tentativeendtime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["tentativeEndTime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["tentativeEndTime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isExportProduct主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isExportProduct主干
         {
             get
             { 
             	return _isexportproduct主干; 
             }
             set
             {
 	            _isexportproduct主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isExportProduct主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isExportProduct主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// voltageClass主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string voltageClass主干
         {
             get
             { 
             	return _voltageclass主干; 
             }
             set
             {
 	            _voltageclass主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["voltageClass主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["voltageClass主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// planCompletime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string planCompletime主干
         {
             get
             { 
             	return _plancompletime主干; 
             }
             set
             {
 	            _plancompletime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["planCompletime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["planCompletime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// productLink主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string productLink主干
         {
             get
             { 
             	return _productlink主干; 
             }
             set
             {
 	            _productlink主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["productLink主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["productLink主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// productionSite主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string productionSite主干
         {
             get
             { 
             	return _productionsite主干; 
             }
             set
             {
 	            _productionsite主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["productionSite主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["productionSite主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// nodeList主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string nodeList主干
         {
             get
             { 
             	return _nodelist主干; 
             }
             set
             {
 	            _nodelist主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["nodeList主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["nodeList主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// processStatus主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string processStatus主干
         {
             get
             { 
             	return _processstatus主干; 
             }
             set
             {
 	            _processstatus主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["processStatus主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["processStatus主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// actualStartTime主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string actualStartTime主干
         {
             get
             { 
             	return _actualstarttime主干; 
             }
             set
             {
 	            _actualstarttime主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["actualStartTime主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["actualStartTime主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isRepair主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isRepair主干
         {
             get
             { 
             	return _isrepair主干; 
             }
             set
             {
 	            _isrepair主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isRepair主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isRepair主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// limitRelation主干
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string limitRelation主干
         {
             get
             { 
             	return _limitrelation主干; 
             }
             set
             {
 	            _limitrelation主干 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["limitRelation主干"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["limitRelation主干"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// id节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string id节点
         {
             get
             { 
             	return _id节点; 
             }
             set
             {
 	            _id节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["id节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["id节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// ztbm节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string ztbm节点
         {
             get
             { 
             	return _ztbm节点; 
             }
             set
             {
 	            _ztbm节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["ztbm节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["ztbm节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// createDt节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string createDt节点
         {
             get
             { 
             	return _createdt节点; 
             }
             set
             {
 	            _createdt节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["createDt节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["createDt节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// editDt节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string editDt节点
         {
             get
             { 
             	return _editdt节点; 
             }
             set
             {
 	            _editdt节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["editDt节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["editDt节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isDeleted节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isDeleted节点
         {
             get
             { 
             	return _isdeleted节点; 
             }
             set
             {
 	            _isdeleted节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isDeleted节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isDeleted节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// deleteDt节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string deleteDt节点
         {
             get
             { 
             	return _deletedt节点; 
             }
             set
             {
 	            _deletedt节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["deleteDt节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["deleteDt节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// productPlanId节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string productPlanId节点
         {
             get
             { 
             	return _productplanid节点; 
             }
             set
             {
 	            _productplanid节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["productPlanId节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["productPlanId节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// drawingNo节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string drawingNo节点
         {
             get
             { 
             	return _drawingno节点; 
             }
             set
             {
 	            _drawingno节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["drawingNo节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["drawingNo节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// name节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string name节点
         {
             get
             { 
             	return _name节点; 
             }
             set
             {
 	            _name节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["name节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["name节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// type节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string type节点
         {
             get
             { 
             	return _type节点; 
             }
             set
             {
 	            _type节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["type节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["type节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// nodeDate节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string nodeDate节点
         {
             get
             { 
             	return _nodedate节点; 
             }
             set
             {
 	            _nodedate节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["nodeDate节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["nodeDate节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// finishDate节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string finishDate节点
         {
             get
             { 
             	return _finishdate节点; 
             }
             set
             {
 	            _finishdate节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["finishDate节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["finishDate节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// ruleConfig节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string ruleConfig节点
         {
             get
             { 
             	return _ruleconfig节点; 
             }
             set
             {
 	            _ruleconfig节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["ruleConfig节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["ruleConfig节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// status节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string status节点
         {
             get
             { 
             	return _status节点; 
             }
             set
             {
 	            _status节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["status节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["status节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// progressStatus节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string progressStatus节点
         {
             get
             { 
             	return _progressstatus节点; 
             }
             set
             {
 	            _progressstatus节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["progressStatus节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["progressStatus节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// confirmStatus节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string confirmStatus节点
         {
             get
             { 
             	return _confirmstatus节点; 
             }
             set
             {
 	            _confirmstatus节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["confirmStatus节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["confirmStatus节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// sentKey2Wms节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string sentKey2Wms节点
         {
             get
             { 
             	return _sentkey2wms节点; 
             }
             set
             {
 	            _sentkey2wms节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["sentKey2Wms节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["sentKey2Wms节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// wmsMid节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string wmsMid节点
         {
             get
             { 
             	return _wmsmid节点; 
             }
             set
             {
 	            _wmsmid节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["wmsMid节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["wmsMid节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// startDate节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string startDate节点
         {
             get
             { 
             	return _startdate节点; 
             }
             set
             {
 	            _startdate节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["startDate节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["startDate节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// actualStartDate节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string actualStartDate节点
         {
             get
             { 
             	return _actualstartdate节点; 
             }
             set
             {
 	            _actualstartdate节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["actualStartDate节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["actualStartDate节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// nodeId节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string nodeId节点
         {
             get
             { 
             	return _nodeid节点; 
             }
             set
             {
 	            _nodeid节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["nodeId节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["nodeId节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// nodeName节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string nodeName节点
         {
             get
             { 
             	return _nodename节点; 
             }
             set
             {
 	            _nodename节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["nodeName节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["nodeName节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isMaterialPreparation节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isMaterialPreparation节点
         {
             get
             { 
             	return _ismaterialpreparation节点; 
             }
             set
             {
 	            _ismaterialpreparation节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isMaterialPreparation节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isMaterialPreparation节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// materialVersion节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string materialVersion节点
         {
             get
             { 
             	return _materialversion节点; 
             }
             set
             {
 	            _materialversion节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["materialVersion节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["materialVersion节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// usedEquipment节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string usedEquipment节点
         {
             get
             { 
             	return _usedequipment节点; 
             }
             set
             {
 	            _usedequipment节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["usedEquipment节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["usedEquipment节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// pauseReason节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string pauseReason节点
         {
             get
             { 
             	return _pausereason节点; 
             }
             set
             {
 	            _pausereason节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["pauseReason节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["pauseReason节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// describe节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string describe节点
         {
             get
             { 
             	return _describe节点; 
             }
             set
             {
 	            _describe节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["describe节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["describe节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// bomInfo节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string bomInfo节点
         {
             get
             { 
             	return _bominfo节点; 
             }
             set
             {
 	            _bominfo节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["bomInfo节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["bomInfo节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// recordId节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string recordId节点
         {
             get
             { 
             	return _recordid节点; 
             }
             set
             {
 	            _recordid节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["recordId节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["recordId节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// isOutsourcing节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string isOutsourcing节点
         {
             get
             { 
             	return _isoutsourcing节点; 
             }
             set
             {
 	            _isoutsourcing节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["isOutsourcing节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["isOutsourcing节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// hbFinishDate节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string hbFinishDate节点
         {
             get
             { 
             	return _hbfinishdate节点; 
             }
             set
             {
 	            _hbfinishdate节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["hbFinishDate节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["hbFinishDate节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// outsourcingSituation节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string outsourcingSituation节点
         {
             get
             { 
             	return _outsourcingsituation节点; 
             }
             set
             {
 	            _outsourcingsituation节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["outsourcingSituation节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["outsourcingSituation节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// outsourcingSetTime节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string outsourcingSetTime节点
         {
             get
             { 
             	return _outsourcingsettime节点; 
             }
             set
             {
 	            _outsourcingsettime节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["outsourcingSetTime节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["outsourcingSetTime节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// finishUserId节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string finishUserId节点
         {
             get
             { 
             	return _finishuserid节点; 
             }
             set
             {
 	            _finishuserid节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["finishUserId节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["finishUserId节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// finishUserName节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string finishUserName节点
         {
             get
             { 
             	return _finishusername节点; 
             }
             set
             {
 	            _finishusername节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["finishUserName节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["finishUserName节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// startUserId节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string startUserId节点
         {
             get
             { 
             	return _startuserid节点; 
             }
             set
             {
 	            _startuserid节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["startUserId节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["startUserId节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// startUserName节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string startUserName节点
         {
             get
             { 
             	return _startusername节点; 
             }
             set
             {
 	            _startusername节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["startUserName节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["startUserName节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// pauseDuration节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string pauseDuration节点
         {
             get
             { 
             	return _pauseduration节点; 
             }
             set
             {
 	            _pauseduration节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["pauseDuration节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["pauseDuration节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// drawPhase节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string drawPhase节点
         {
             get
             { 
             	return _drawphase节点; 
             }
             set
             {
 	            _drawphase节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["drawPhase节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["drawPhase节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// drawPlanFinishTime节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string drawPlanFinishTime节点
         {
             get
             { 
             	return _drawplanfinishtime节点; 
             }
             set
             {
 	            _drawplanfinishtime节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["drawPlanFinishTime节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["drawPlanFinishTime节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// drawActualFinishTime节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string drawActualFinishTime节点
         {
             get
             { 
             	return _drawactualfinishtime节点; 
             }
             set
             {
 	            _drawactualfinishtime节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["drawActualFinishTime节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["drawActualFinishTime节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// chargePersonName节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string chargePersonName节点
         {
             get
             { 
             	return _chargepersonname节点; 
             }
             set
             {
 	            _chargepersonname节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["chargePersonName节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["chargePersonName节点"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// difDay节点
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string difDay节点
         {
             get
             { 
             	return _difday节点; 
             }
             set
             {
 	            _difday节点 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["difDay节点"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["difDay节点"] = value;
 		            }
 	            }
             }
         }          
 		 #endregion Model
 	}
 }