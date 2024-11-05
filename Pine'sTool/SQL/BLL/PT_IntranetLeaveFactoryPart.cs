﻿/*──────────────────────────────────────
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
* 文    件： PT_IntranetLeaveFactoryPart.cs
* 功    能： 数据库操作_BLL
* 类    名： PT_IntranetLeaveFactoryPart
* 创建时间： 2024/8/1 15:48:17
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/

using System.Collections.Generic;
using System.Data;

namespace Pine_sTool.BLL
{
    //PT_IntranetLeaveFactoryPart
    public partial class PT_IntranetLeaveFactoryPart
    {
        public static string TableName = "PT_IntranetLeaveFactoryPart";
        private readonly Pine_sTool.DAL.PT_IntranetLeaveFactoryPart dal = new Pine_sTool.DAL.PT_IntranetLeaveFactoryPart();

        public PT_IntranetLeaveFactoryPart()
        { }

        #region BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxID()
        {
            return dal.GetMaxID();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            return dal.Exists();
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Pine_sTool.Model.PT_IntranetLeaveFactoryPart model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Pine_sTool.Model.PT_IntranetLeaveFactoryPart model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {
            return dal.Delete();
        }

        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Pine_sTool.Model.PT_IntranetLeaveFactoryPart GetModel()
        {
            return dal.GetModel();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Pine_sTool.Model.PT_IntranetLeaveFactoryPart> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Pine_sTool.Model.PT_IntranetLeaveFactoryPart> DataTableToList(DataTable dt)
        {
            List<Pine_sTool.Model.PT_IntranetLeaveFactoryPart> modelList = new List<Pine_sTool.Model.PT_IntranetLeaveFactoryPart>();
            foreach (DataRow row in dt.Rows)
            {
                var model = dal.DataRowToModel(row);
                modelList.Add(model);
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Pine_sTool.Model.PT_IntranetLeaveFactoryPart DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        #endregion BasicMethod
    }
}