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
* 功    能： 数据库操作_DAL 
* 类    名： PT_IntranetLeaveFactoryDataTable
* 创建时间： 2024/9/3 9:14:52
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
	//PT_IntranetLeaveFactoryDataTable 
 	public partial class PT_IntranetLeaveFactoryDataTable
 	{
         public static string TableName="PT_IntranetLeaveFactoryDataTable";
         
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
 		    return DbHelperSQL.GetMaxID("ID", "PT_IntranetLeaveFactoryDataTable"); 
 		}
 
 	  	/// <summary>
 		/// 是否存在该记录
 		/// </summary>
 		public bool Exists(long index)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("select count(1) from PT_IntranetLeaveFactoryDataTable");
 			strSql.Append(" where ");
 			                strSql.Append(" index = @index ");
                         
             			SqlParameter[] parameters = {
 					new SqlParameter("@index", SqlDbType.BigInt,8)			};
 			parameters[0].Value = index;
 
 			return DbHelperSQL.Exists(strSql.ToString(),parameters);
 		}
 		
 	 
 		/// <summary>
 		/// 增加一条数据
 		/// </summary>
 		public void Add(Pine_sTool.Model.PT_IntranetLeaveFactoryDataTable model)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("insert into PT_IntranetLeaveFactoryDataTable(");			
             strSql.Append("index,rmk,cust_nm_full,ISRT_DT,supy_nm,rowSelected,item_nm,lot_no,FIN_FLAG,type,id,draw_no,ISRT_EMP_NO,plan_no,mus_dt");
 			strSql.Append(") values (");
             strSql.Append("@index,@rmk,@cust_nm_full,@ISRT_DT,@supy_nm,@rowSelected,@item_nm,@lot_no,@FIN_FLAG,@type,@id,@draw_no,@ISRT_EMP_NO,@plan_no,@mus_dt");            
             strSql.Append(") ");            
             		
 			SqlParameter[] parameters = {
 			            new SqlParameter("@index", SqlDbType.BigInt,8) ,            
                         new SqlParameter("@rmk", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@cust_nm_full", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@ISRT_DT", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@supy_nm", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@rowSelected", SqlDbType.Bit,1) ,            
                         new SqlParameter("@item_nm", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@lot_no", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@FIN_FLAG", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@type", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@id", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@draw_no", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@ISRT_EMP_NO", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@plan_no", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@mus_dt", SqlDbType.VarChar,-1)             
               
             };
 			            
             parameters[0].Value = model.index;                        
             parameters[1].Value = model.rmk;                        
             parameters[2].Value = model.cust_nm_full;                        
             parameters[3].Value = model.ISRT_DT;                        
             parameters[4].Value = model.supy_nm;                        
             parameters[5].Value = model.rowSelected;                        
             parameters[6].Value = model.item_nm;                        
             parameters[7].Value = model.lot_no;                        
             parameters[8].Value = model.FIN_FLAG;                        
             parameters[9].Value = model.type;                        
             parameters[10].Value = model.id;                        
             parameters[11].Value = model.draw_no;                        
             parameters[12].Value = model.ISRT_EMP_NO;                        
             parameters[13].Value = model.plan_no;                        
             parameters[14].Value = model.mus_dt;                        
 			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
             			
 		}
 		
 		
 		/// <summary>
 		/// 更新一条数据
 		/// </summary>
 		public bool Update(Pine_sTool.Model.PT_IntranetLeaveFactoryDataTable model)
 		{
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("update PT_IntranetLeaveFactoryDataTable set ");
 			                        
             strSql.Append(" index = @index , ");                                    
             strSql.Append(" rmk = @rmk , ");                                    
             strSql.Append(" cust_nm_full = @cust_nm_full , ");                                    
             strSql.Append(" ISRT_DT = @ISRT_DT , ");                                    
             strSql.Append(" supy_nm = @supy_nm , ");                                    
             strSql.Append(" rowSelected = @rowSelected , ");                                    
             strSql.Append(" item_nm = @item_nm , ");                                    
             strSql.Append(" lot_no = @lot_no , ");                                    
             strSql.Append(" FIN_FLAG = @FIN_FLAG , ");                                    
             strSql.Append(" type = @type , ");                                    
             strSql.Append(" id = @id , ");                                    
             strSql.Append(" draw_no = @draw_no , ");                                    
             strSql.Append(" ISRT_EMP_NO = @ISRT_EMP_NO , ");                                    
             strSql.Append(" plan_no = @plan_no , ");                                    
             strSql.Append(" mus_dt = @mus_dt  ");            	
             
 			strSql.Append(" where index=@index  ");
 						
             SqlParameter[] parameters = {
 			            new SqlParameter("@index", SqlDbType.BigInt,8) ,            
                         new SqlParameter("@rmk", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@cust_nm_full", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@ISRT_DT", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@supy_nm", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@rowSelected", SqlDbType.Bit,1) ,            
                         new SqlParameter("@item_nm", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@lot_no", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@FIN_FLAG", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@type", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@id", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@draw_no", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@ISRT_EMP_NO", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@plan_no", SqlDbType.VarChar,-1) ,            
                         new SqlParameter("@mus_dt", SqlDbType.VarChar,-1)             
               
             };
 						            
             parameters[0].Value = model.index;                        
             parameters[1].Value = model.rmk;                        
             parameters[2].Value = model.cust_nm_full;                        
             parameters[3].Value = model.ISRT_DT;                        
             parameters[4].Value = model.supy_nm;                        
             parameters[5].Value = model.rowSelected;                        
             parameters[6].Value = model.item_nm;                        
             parameters[7].Value = model.lot_no;                        
             parameters[8].Value = model.FIN_FLAG;                        
             parameters[9].Value = model.type;                        
             parameters[10].Value = model.id;                        
             parameters[11].Value = model.draw_no;                        
             parameters[12].Value = model.ISRT_EMP_NO;                        
             parameters[13].Value = model.plan_no;                        
             parameters[14].Value = model.mus_dt;                        
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
 		public bool Delete(long index)
 		{
 			
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("delete from PT_IntranetLeaveFactoryDataTable ");
 			strSql.Append(" where index=@index ");
 						SqlParameter[] parameters = {
 					new SqlParameter("@index", SqlDbType.BigInt,8)			};
 			parameters[0].Value = index;
 
 
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
 		/// 得到一个对象实体
 		/// </summary>
 		public Pine_sTool.Model.PT_IntranetLeaveFactoryDataTable GetModel(long index)
 		{
 			
 			StringBuilder strSql=new StringBuilder();
 			strSql.Append("select index, rmk, cust_nm_full, ISRT_DT, supy_nm, rowSelected, item_nm, lot_no, FIN_FLAG, type, id, draw_no, ISRT_EMP_NO, plan_no, mus_dt  ");			
 			strSql.Append("  from PT_IntranetLeaveFactoryDataTable ");
 			strSql.Append(" where index=@index ");
 						SqlParameter[] parameters = {
 					new SqlParameter("@index", SqlDbType.BigInt,8)			};
 			parameters[0].Value = index;
 
 			
 			Pine_sTool.Model.PT_IntranetLeaveFactoryDataTable model=new Pine_sTool.Model.PT_IntranetLeaveFactoryDataTable();
 			
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
 		public Pine_sTool.Model.PT_IntranetLeaveFactoryDataTable DataRowToModel(DataRow row)
 		{
 			Pine_sTool.Model.PT_IntranetLeaveFactoryDataTable model=new Pine_sTool.Model.PT_IntranetLeaveFactoryDataTable();
 			if (row != null)
 			{
 			
               //|long|True|bigint
               if(row["index"]!=DBNull.Value && !string.IsNullOrEmpty(row["index"].ToString()))
               {
                 model.index=long.Parse(row["index"].ToString());
               }
 
               //|string|False|varchar
               if(row["rmk"]!=DBNull.Value)
               {
                 model.rmk=row["rmk"].ToString();
               }
 
               //|string|False|varchar
               if(row["cust_nm_full"]!=DBNull.Value)
               {
                 model.cust_nm_full=row["cust_nm_full"].ToString();
               }
 
               //|string|False|varchar
               if(row["ISRT_DT"]!=DBNull.Value)
               {
                 model.ISRT_DT=row["ISRT_DT"].ToString();
               }
 
               //|string|False|varchar
               if(row["supy_nm"]!=DBNull.Value)
               {
                 model.supy_nm=row["supy_nm"].ToString();
               }
 
               //|bool|False|bit
               if(row["rowSelected"].ToString()=="1"||row["rowSelected"].ToString().ToLower()=="true")
               {
                 model.rowSelected=true;
}else{
model.rowSelected=false;
}
 
               //|string|False|varchar
               if(row["item_nm"]!=DBNull.Value)
               {
                 model.item_nm=row["item_nm"].ToString();
               }
 
               //|string|False|varchar
               if(row["lot_no"]!=DBNull.Value)
               {
                 model.lot_no=row["lot_no"].ToString();
               }
 
               //|string|False|varchar
               if(row["FIN_FLAG"]!=DBNull.Value)
               {
                 model.FIN_FLAG=row["FIN_FLAG"].ToString();
               }
 
               //|string|False|varchar
               if(row["type"]!=DBNull.Value)
               {
                 model.type=row["type"].ToString();
               }
 
               //|string|False|varchar
               if(row["id"]!=DBNull.Value)
               {
                 model.id=row["id"].ToString();
               }
 
               //|string|False|varchar
               if(row["draw_no"]!=DBNull.Value)
               {
                 model.draw_no=row["draw_no"].ToString();
               }
 
               //|string|False|varchar
               if(row["ISRT_EMP_NO"]!=DBNull.Value)
               {
                 model.ISRT_EMP_NO=row["ISRT_EMP_NO"].ToString();
               }
 
               //|string|False|varchar
               if(row["plan_no"]!=DBNull.Value)
               {
                 model.plan_no=row["plan_no"].ToString();
               }
 
               //|string|False|varchar
               if(row["mus_dt"]!=DBNull.Value)
               {
                 model.mus_dt=row["mus_dt"].ToString();
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
 			strSql.Append(" FROM PT_IntranetLeaveFactoryDataTable ");
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
 			strSql.Append(" FROM PT_IntranetLeaveFactoryDataTable ");
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
             strSql.Append("select count(1) FROM PT_IntranetLeaveFactoryDataTable ");
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
             strSql.Append(")AS Row, T.*  from PT_IntranetLeaveFactoryDataTable T ");
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
             public static string index = "index";
             public static string rmk = "rmk";
             public static string cust_nm_full = "cust_nm_full";
             public static string ISRT_DT = "ISRT_DT";
             public static string supy_nm = "supy_nm";
             public static string rowSelected = "rowSelected";
             public static string item_nm = "item_nm";
             public static string lot_no = "lot_no";
             public static string FIN_FLAG = "FIN_FLAG";
             public static string type = "type";
             public static string id = "id";
             public static string draw_no = "draw_no";
             public static string ISRT_EMP_NO = "ISRT_EMP_NO";
             public static string plan_no = "plan_no";
             public static string mus_dt = "mus_dt";
         }
     }
 }
 
