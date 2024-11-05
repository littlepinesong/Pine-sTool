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
* 功    能： 数据库操作_DAL 
* 类    名： 出勤记录
* 创建时间： 2024/10/11 11:53:50
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
	//出勤记录 
 	public partial class 出勤记录
 	{
         public static string TableName="出勤记录";
         
         DbHelperSQLP DbHelperSQL = new DbHelperSQLP(PineConn.SqlConnSwcq);
         
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
 		    return DbHelperSQL.GetMaxID("ID", "出勤记录"); 
 		}
 
 	  	/// <summary>
 		/// 是否存在该记录
 		/// </summary>
 		public bool Exists(int ID)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("select count(1) from 出勤记录");
 			strSql.Append(" where ");
 			                strSql.Append(" ID = @ID ");
                         
             			SqlParameter[] parameters = {
 					new SqlParameter("@ID", SqlDbType.Int,4)
 			};
 			parameters[0].Value = ID;
 
 			return DbHelperSQL.Exists(strSql.ToString(),parameters);
 		}
 		
 	 
 		/// <summary>
 		/// 增加一条数据
 		/// </summary>
 		public int Add(Pine_sTool.Model.出勤记录 model)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("insert into 出勤记录(");			
             strSql.Append("登录名,登记日期,开始时间,星期,结束时间,累计时间,jiaban_ZS,jiaban_T,空闲时间,是否出差,是否请假,是否补签,是否有效,备注,jsID,trip_id,qjType");
 			strSql.Append(") values (");
             strSql.Append("@登录名,@登记日期,@开始时间,@星期,@结束时间,@累计时间,@jiaban_ZS,@jiaban_T,@空闲时间,@是否出差,@是否请假,@是否补签,@是否有效,@备注,@jsID,@trip_id,@qjType");            
             strSql.Append(") ");            
             strSql.Append(";select @@IDENTITY");		
 			SqlParameter[] parameters = {
 			            new SqlParameter("@登录名", SqlDbType.VarChar,50) ,            
                         new SqlParameter("@登记日期", SqlDbType.DateTime2) ,            
                         new SqlParameter("@开始时间", SqlDbType.DateTime2) ,            
                         new SqlParameter("@星期", SqlDbType.NVarChar,255) ,            
                         new SqlParameter("@结束时间", SqlDbType.DateTime2) ,            
                         new SqlParameter("@累计时间", SqlDbType.Float,8) ,            
                         new SqlParameter("@jiaban_ZS", SqlDbType.Float,8) ,            
                         new SqlParameter("@jiaban_T", SqlDbType.Float,8) ,            
                         new SqlParameter("@空闲时间", SqlDbType.Float,8) ,            
                         new SqlParameter("@是否出差", SqlDbType.Bit,1) ,            
                         new SqlParameter("@是否请假", SqlDbType.Bit,1) ,            
                         new SqlParameter("@是否补签", SqlDbType.Bit,1) ,            
                         new SqlParameter("@是否有效", SqlDbType.Bit,1) ,            
                         new SqlParameter("@备注", SqlDbType.NVarChar,255) ,            
                         new SqlParameter("@jsID", SqlDbType.Int,4) ,            
                         new SqlParameter("@trip_id", SqlDbType.Int,4) ,            
                         new SqlParameter("@qjType", SqlDbType.Int,4)             
               
             };
 			            
             parameters[0].Value = model.登录名;                        
             parameters[1].Value = model.登记日期;                        
             parameters[2].Value = model.开始时间;                        
             parameters[3].Value = model.星期;                        
             parameters[4].Value = model.结束时间;                        
             parameters[5].Value = model.累计时间;                        
             parameters[6].Value = model.jiaban_ZS;                        
             parameters[7].Value = model.jiaban_T;                        
             parameters[8].Value = model.空闲时间;                        
             parameters[9].Value = model.是否出差;                        
             parameters[10].Value = model.是否请假;                        
             parameters[11].Value = model.是否补签;                        
             parameters[12].Value = model.是否有效;                        
             parameters[13].Value = model.备注;                        
             parameters[14].Value = model.jsID;                        
             parameters[15].Value = model.trip_id;                        
             parameters[16].Value = model.qjType;                        
 			   
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
 		public bool Update(Pine_sTool.Model.出勤记录 model)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("update 出勤记录 set ");
 			                                                
             strSql.Append(" 登录名 = @登录名 , ");                                    
             strSql.Append(" 登记日期 = @登记日期 , ");                                    
             strSql.Append(" 开始时间 = @开始时间 , ");                                    
             strSql.Append(" 星期 = @星期 , ");                                    
             strSql.Append(" 结束时间 = @结束时间 , ");                                    
             strSql.Append(" 累计时间 = @累计时间 , ");                                    
             strSql.Append(" jiaban_ZS = @jiaban_ZS , ");                                    
             strSql.Append(" jiaban_T = @jiaban_T , ");                                    
             strSql.Append(" 空闲时间 = @空闲时间 , ");                                    
             strSql.Append(" 是否出差 = @是否出差 , ");                                    
             strSql.Append(" 是否请假 = @是否请假 , ");                                    
             strSql.Append(" 是否补签 = @是否补签 , ");                                    
             strSql.Append(" 是否有效 = @是否有效 , ");                                    
             strSql.Append(" 备注 = @备注 , ");                                    
             strSql.Append(" jsID = @jsID , ");                                    
             strSql.Append(" trip_id = @trip_id , ");                                    
             strSql.Append(" qjType = @qjType  ");            	
             
 			strSql.Append(" where ID=@ID ");
 						
             SqlParameter[] parameters = {
 			            new SqlParameter("@ID", SqlDbType.Int,4) ,            
                         new SqlParameter("@登录名", SqlDbType.VarChar,50) ,            
                         new SqlParameter("@登记日期", SqlDbType.DateTime2) ,            
                         new SqlParameter("@开始时间", SqlDbType.DateTime2) ,            
                         new SqlParameter("@星期", SqlDbType.NVarChar,255) ,            
                         new SqlParameter("@结束时间", SqlDbType.DateTime2) ,            
                         new SqlParameter("@累计时间", SqlDbType.Float,8) ,            
                         new SqlParameter("@jiaban_ZS", SqlDbType.Float,8) ,            
                         new SqlParameter("@jiaban_T", SqlDbType.Float,8) ,            
                         new SqlParameter("@空闲时间", SqlDbType.Float,8) ,            
                         new SqlParameter("@是否出差", SqlDbType.Bit,1) ,            
                         new SqlParameter("@是否请假", SqlDbType.Bit,1) ,            
                         new SqlParameter("@是否补签", SqlDbType.Bit,1) ,            
                         new SqlParameter("@是否有效", SqlDbType.Bit,1) ,            
                         new SqlParameter("@备注", SqlDbType.NVarChar,255) ,            
                         new SqlParameter("@jsID", SqlDbType.Int,4) ,            
                         new SqlParameter("@trip_id", SqlDbType.Int,4) ,            
                         new SqlParameter("@qjType", SqlDbType.Int,4)             
               
             };
 						            
             parameters[0].Value = model.ID;                        
             parameters[1].Value = model.登录名;                        
             parameters[2].Value = model.登记日期;                        
             parameters[3].Value = model.开始时间;                        
             parameters[4].Value = model.星期;                        
             parameters[5].Value = model.结束时间;                        
             parameters[6].Value = model.累计时间;                        
             parameters[7].Value = model.jiaban_ZS;                        
             parameters[8].Value = model.jiaban_T;                        
             parameters[9].Value = model.空闲时间;                        
             parameters[10].Value = model.是否出差;                        
             parameters[11].Value = model.是否请假;                        
             parameters[12].Value = model.是否补签;                        
             parameters[13].Value = model.是否有效;                        
             parameters[14].Value = model.备注;                        
             parameters[15].Value = model.jsID;                        
             parameters[16].Value = model.trip_id;                        
             parameters[17].Value = model.qjType;                        
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
 		public bool Delete(int ID)
 		{
 			
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("delete from 出勤记录 ");
 			strSql.Append(" where ID=@ID");
 						SqlParameter[] parameters = {
 					new SqlParameter("@ID", SqlDbType.Int,4)
 			};
 			parameters[0].Value = ID;
 
 
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
 		public bool DeleteList(string IDlist )
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("delete from 出勤记录 ");
 			strSql.Append(" where ID in ("+IDlist + ")  ");
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
 		public Pine_sTool.Model.出勤记录 GetModel(int ID)
 		{
 			
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("select ID, 登录名, 登记日期, 开始时间, 星期, 结束时间, 累计时间, jiaban_ZS, jiaban_T, 空闲时间, 是否出差, 是否请假, 是否补签, 是否有效, 备注, jsID, trip_id, qjType  ");			
 			strSql.Append("  from 出勤记录 ");
 			strSql.Append(" where ID=@ID");
 						SqlParameter[] parameters = {
 					new SqlParameter("@ID", SqlDbType.Int,4)
 			};
 			parameters[0].Value = ID;
 
 			
 			Pine_sTool.Model.出勤记录 model=new Pine_sTool.Model.出勤记录();
 			
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
 		public Pine_sTool.Model.出勤记录 DataRowToModel(DataRow row)
 		{
 			Pine_sTool.Model.出勤记录 model=new Pine_sTool.Model.出勤记录();
 			if (row != null)
 			{
 			
               //|int|True|int
               if(row["ID"]!=DBNull.Value && !string.IsNullOrEmpty(row["ID"].ToString()))
               {
                 model.ID=int.Parse(row["ID"].ToString());
               }
 
               //|string|False|varchar
               if(row["登录名"]!=DBNull.Value)
               {
                 model.登录名=row["登录名"].ToString();
               }
 
               //|DateTime|True|datetime
               if(row["登记日期"]!=DBNull.Value && !string.IsNullOrEmpty(row["登记日期"].ToString()))
               {
                 model.登记日期=DateTime.Parse(row["登记日期"].ToString());
               }
 
               //|DateTime|True|datetime
               if(row["开始时间"]!=DBNull.Value && !string.IsNullOrEmpty(row["开始时间"].ToString()))
               {
                 model.开始时间=DateTime.Parse(row["开始时间"].ToString());
               }
 
               //|string|False|nvarchar
               if(row["星期"]!=DBNull.Value)
               {
                 model.星期=row["星期"].ToString();
               }
 
               //|DateTime|True|datetime
               if(row["结束时间"]!=DBNull.Value && !string.IsNullOrEmpty(row["结束时间"].ToString()))
               {
                 model.结束时间=DateTime.Parse(row["结束时间"].ToString());
               }
 
               //|decimal|True|float
               if(row["累计时间"]!=DBNull.Value && !string.IsNullOrEmpty(row["累计时间"].ToString()))
               {
                 model.累计时间=decimal.Parse(row["累计时间"].ToString());
               }
 
               //|decimal|True|float
               if(row["jiaban_ZS"]!=DBNull.Value && !string.IsNullOrEmpty(row["jiaban_ZS"].ToString()))
               {
                 model.jiaban_ZS=decimal.Parse(row["jiaban_ZS"].ToString());
               }
 
               //|decimal|True|float
               if(row["jiaban_T"]!=DBNull.Value && !string.IsNullOrEmpty(row["jiaban_T"].ToString()))
               {
                 model.jiaban_T=decimal.Parse(row["jiaban_T"].ToString());
               }
 
               //|decimal|True|float
               if(row["空闲时间"]!=DBNull.Value && !string.IsNullOrEmpty(row["空闲时间"].ToString()))
               {
                 model.空闲时间=decimal.Parse(row["空闲时间"].ToString());
               }
 
               //|bool|False|bit
               if(row["是否出差"].ToString()=="1"||row["是否出差"].ToString().ToLower()=="true")
               {
                 model.是否出差=true;
}else{
model.是否出差=false;
}
 
               //|bool|False|bit
               if(row["是否请假"].ToString()=="1"||row["是否请假"].ToString().ToLower()=="true")
               {
                 model.是否请假=true;
}else{
model.是否请假=false;
}
 
               //|bool|False|bit
               if(row["是否补签"].ToString()=="1"||row["是否补签"].ToString().ToLower()=="true")
               {
                 model.是否补签=true;
}else{
model.是否补签=false;
}
 
               //|bool|False|bit
               if(row["是否有效"].ToString()=="1"||row["是否有效"].ToString().ToLower()=="true")
               {
                 model.是否有效=true;
}else{
model.是否有效=false;
}
 
               //|string|False|nvarchar
               if(row["备注"]!=DBNull.Value)
               {
                 model.备注=row["备注"].ToString();
               }
 
               //|int|True|int
               if(row["jsID"]!=DBNull.Value && !string.IsNullOrEmpty(row["jsID"].ToString()))
               {
                 model.jsID=int.Parse(row["jsID"].ToString());
               }
 
               //|int|True|int
               if(row["trip_id"]!=DBNull.Value && !string.IsNullOrEmpty(row["trip_id"].ToString()))
               {
                 model.trip_id=int.Parse(row["trip_id"].ToString());
               }
 
               //|int|True|int
               if(row["qjType"]!=DBNull.Value && !string.IsNullOrEmpty(row["qjType"].ToString()))
               {
                 model.qjType=int.Parse(row["qjType"].ToString());
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
 			strSql.Append(" FROM 出勤记录 ");
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
 			strSql.Append(" FROM 出勤记录 ");
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
             strSql.Append("select count(1) FROM 出勤记录 ");
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
             strSql.Append(")AS Row, T.*  from 出勤记录 T ");
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
             public static string 登录名 = "登录名";
             public static string 登记日期 = "登记日期";
             public static string 开始时间 = "开始时间";
             public static string 星期 = "星期";
             public static string 结束时间 = "结束时间";
             public static string 累计时间 = "累计时间";
             public static string jiaban_ZS = "jiaban_ZS";
             public static string jiaban_T = "jiaban_T";
             public static string 空闲时间 = "空闲时间";
             public static string 是否出差 = "是否出差";
             public static string 是否请假 = "是否请假";
             public static string 是否补签 = "是否补签";
             public static string 是否有效 = "是否有效";
             public static string 备注 = "备注";
             public static string jsID = "jsID";
             public static string trip_id = "trip_id";
             public static string qjType = "qjType";
         }
     }
 }
 
