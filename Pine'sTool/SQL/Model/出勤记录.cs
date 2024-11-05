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
* 文    件： 出勤记录.cs
* 功    能： 数据库操作_Model 
* 类    名： 出勤记录
* 创建时间： 2024/10/11 11:53:50
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/  

using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

namespace Pine_sTool.Model
{
    //出勤记录 
     [Serializable]
 	public class 出勤记录
 	{
        #region Model
        private int _id;
        private string _登录名;
        private DateTime _登记日期;
        private DateTime _开始时间;
        private string _星期;
        private DateTime _结束时间;
        private decimal _累计时间;
        private decimal? _jiaban_zs;
        private decimal? _jiaban_t;
        private decimal? _空闲时间;
        private bool _是否出差;
        private bool _是否请假;
        private bool _是否补签;
        private bool _是否有效;
        private string _备注;
        private int? _jsid;
        private int? _trip_id;
        private int? _qjtype;
        		
        DataRow row;
     
        public 出勤记录(){}
    	
    	public 出勤记录(DataRow row)
    	{
    		this.row = row;
    	}	
    	
       	 /// <summary>
 		 /// ID
 		 ///Nullable:False valueType:True 
         /// </summary>		
         public int ID
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
 		            	row["ID"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["ID"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 登录名
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public string 登录名
         {
             get
             { 
             	return _登录名; 
             }
             set
             {
 	            _登录名 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["登录名"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["登录名"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 登记日期
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public DateTime 登记日期
         {
             get
             { 
             	return _登记日期; 
             }
             set
             {
 	            _登记日期 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["登记日期"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["登记日期"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 开始时间
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public DateTime 开始时间
         {
             get
             { 
             	return _开始时间; 
             }
             set
             {
 	            _开始时间 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["开始时间"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["开始时间"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 星期
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public string 星期
         {
             get
             { 
             	return _星期; 
             }
             set
             {
 	            _星期 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["星期"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["星期"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 结束时间
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public DateTime 结束时间
         {
             get
             { 
             	return _结束时间; 
             }
             set
             {
 	            _结束时间 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["结束时间"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["结束时间"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 累计时间
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public decimal 累计时间
         {
             get
             { 
             	return _累计时间; 
             }
             set
             {
 	            _累计时间 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["累计时间"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["累计时间"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 李向群20241011,部门要求把加班时间按时段周末等进行折算,在结算时把折算后的时长记入此字段
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public decimal? jiaban_ZS
         {
             get
             { 
             	return _jiaban_zs; 
             }
             set
             {
 	            _jiaban_zs = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["jiaban_ZS"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["jiaban_ZS"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 折算后减去空闲时间,按冠军的说法,是减去空闲时间占比
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public decimal? jiaban_T
         {
             get
             { 
             	return _jiaban_t; 
             }
             set
             {
 	            _jiaban_t = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["jiaban_T"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["jiaban_T"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 空闲时间
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public decimal? 空闲时间
         {
             get
             { 
             	return _空闲时间; 
             }
             set
             {
 	            _空闲时间 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["空闲时间"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["空闲时间"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 是否出差
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public bool 是否出差
         {
             get
             { 
             	return _是否出差; 
             }
             set
             {
 	            _是否出差 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["是否出差"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["是否出差"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 是否请假
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public bool 是否请假
         {
             get
             { 
             	return _是否请假; 
             }
             set
             {
 	            _是否请假 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["是否请假"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["是否请假"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 是否补签
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public bool 是否补签
         {
             get
             { 
             	return _是否补签; 
             }
             set
             {
 	            _是否补签 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["是否补签"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["是否补签"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 是否有效
 		 ///Nullable:False valueType:False 
         /// </summary>		
         public bool 是否有效
         {
             get
             { 
             	return _是否有效; 
             }
             set
             {
 	            _是否有效 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["是否有效"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["是否有效"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 备注
 		 ///Nullable:True valueType:False 
         /// </summary>		
         public string 备注
         {
             get
             { 
             	return _备注; 
             }
             set
             {
 	            _备注 = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["备注"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["备注"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// 李向群2020-04-28添加，为工资结算用，ID为[hbcshdb].[dbo].[sjbgz_JieSuan]的ID
 		 ///Nullable:True valueType:True 
         /// </summary>		
         public int? jsID
         {
             get
             { 
             	return _jsid; 
             }
             set
             {
 	            _jsid = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["jsID"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["jsID"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// trip_id
 		 ///Nullable:True valueType:True 
         /// </summary>		
         public int? trip_id
         {
             get
             { 
             	return _trip_id; 
             }
             set
             {
 	            _trip_id = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["trip_id"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["trip_id"] = value;
 		            }
 	            }
             }
         }          
 		 /// <summary>
 		 /// [hbcshdb].[dbo].[sjgl_overtime]中的请假类别,也可以做别的类别中的小类
 		 ///Nullable:True valueType:True 
         /// </summary>		
         public int? qjType
         {
             get
             { 
             	return _qjtype; 
             }
             set
             {
 	            _qjtype = value;
 	            if( row != null)
 	            {
 		            if(value == null)
 		            {
 		            	row["qjType"] = DBNull.Value;
 		            }
 		            else
 		            {
 		            	row["qjType"] = value;
 		            }
 	            }
             }
         }          
 		 #endregion Model
 	}
 }