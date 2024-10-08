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
* 文    件： PT_IntranetLeaveFactoryDataTable.cs
* 功    能： 数据库操作_Model 
* 类    名： PT_IntranetLeaveFactoryDataTable
* 创建时间： 2024/9/3 9:14:52
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/  

using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

namespace Pine_sTool.Model
{
    //PT_IntranetLeaveFactoryDataTable 
     [Serializable]
 	public class PT_IntranetLeaveFactoryDataTable
 	{
        #region Model
        private long? _index;
        private string _rmk;
        private string _cust_nm_full;
        private string _isrt_dt;
        private string _supy_nm;
        private bool _rowselected;
        private string _item_nm;
        private string _lot_no;
        private string _fin_flag;
        private string _type;
        private string _id;
        private string _draw_no;
        private string _isrt_emp_no;
        private string _plan_no;
        private string _mus_dt;
        		
        DataRow row;
     
        public PT_IntranetLeaveFactoryDataTable(){}
    	
    	public PT_IntranetLeaveFactoryDataTable(DataRow row)
    	{
    		this.row = row;
    	}	
    	
       	 /// <summary>
 		 /// index
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public long? index
         {
             get
             { 
             	return _index; 
             }
             set
             {
 	            _index = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["index"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["index"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// rmk
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string rmk
         {
             get
             { 
             	return _rmk; 
             }
             set
             {
 	            _rmk = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["rmk"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["rmk"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// cust_nm_full
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string cust_nm_full
         {
             get
             { 
             	return _cust_nm_full; 
             }
             set
             {
 	            _cust_nm_full = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["cust_nm_full"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["cust_nm_full"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// ISRT_DT
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string ISRT_DT
         {
             get
             { 
             	return _isrt_dt; 
             }
             set
             {
 	            _isrt_dt = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["ISRT_DT"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["ISRT_DT"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// supy_nm
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string supy_nm
         {
             get
             { 
             	return _supy_nm; 
             }
             set
             {
 	            _supy_nm = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["supy_nm"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["supy_nm"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// rowSelected
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public bool rowSelected
         {
             get
             { 
             	return _rowselected; 
             }
             set
             {
 	            _rowselected = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["rowSelected"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["rowSelected"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// item_nm
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string item_nm
         {
             get
             { 
             	return _item_nm; 
             }
             set
             {
 	            _item_nm = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["item_nm"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["item_nm"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// lot_no
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string lot_no
         {
             get
             { 
             	return _lot_no; 
             }
             set
             {
 	            _lot_no = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["lot_no"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["lot_no"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// FIN_FLAG
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string FIN_FLAG
         {
             get
             { 
             	return _fin_flag; 
             }
             set
             {
 	            _fin_flag = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["FIN_FLAG"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["FIN_FLAG"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// type
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string type
         {
             get
             { 
             	return _type; 
             }
             set
             {
 	            _type = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["type"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["type"] = value;
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
 		 /// draw_no
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string draw_no
         {
             get
             { 
             	return _draw_no; 
             }
             set
             {
 	            _draw_no = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["draw_no"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["draw_no"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// ISRT_EMP_NO
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string ISRT_EMP_NO
         {
             get
             { 
             	return _isrt_emp_no; 
             }
             set
             {
 	            _isrt_emp_no = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["ISRT_EMP_NO"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["ISRT_EMP_NO"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// plan_no
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string plan_no
         {
             get
             { 
             	return _plan_no; 
             }
             set
             {
 	            _plan_no = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["plan_no"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["plan_no"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// mus_dt
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string mus_dt
         {
             get
             { 
             	return _mus_dt; 
             }
             set
             {
 	            _mus_dt = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["mus_dt"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["mus_dt"] = value;
 		            }
 	            }
             }
         }          
 		 #endregion Model
 	}
 }