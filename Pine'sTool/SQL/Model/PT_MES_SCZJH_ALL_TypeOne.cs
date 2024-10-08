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
* 文    件： PT_MES_SCZJH_ALL_TypeOne.cs
* 功    能： 数据库操作_Model 
* 类    名： PT_MES_SCZJH_ALL_TypeOne
* 创建时间： 2024/9/2 17:12:20
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/  

using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

namespace Pine_sTool.Model
{
    //PT_MES_SCZJH_ALL_TypeOne 
     [Serializable]
 	public class PT_MES_SCZJH_ALL_TypeOne
 	{
        #region Model
        private int _pt_id;
        private string _source_str;
        private string _record_date;
        		
        DataRow row;
     
        public PT_MES_SCZJH_ALL_TypeOne(){}
    	
    	public PT_MES_SCZJH_ALL_TypeOne(DataRow row)
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
 		 /// source_str
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string source_str
         {
             get
             { 
             	return _source_str; 
             }
             set
             {
 	            _source_str = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["source_str"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["source_str"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// record_date
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string record_date
         {
             get
             { 
             	return _record_date; 
             }
             set
             {
 	            _record_date = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["record_date"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["record_date"] = value;
 		            }
 	            }
             }
         }          
 		 #endregion Model
 	}
 }