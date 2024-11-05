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
* 文    件： PT_IntranetLeaveFactoryPart.cs
* 功    能： 数据库操作_Model
* 类    名： PT_IntranetLeaveFactoryPart
* 创建时间： 2024/8/1 15:48:17
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/

using System;
using System.Data;

namespace Pine_sTool.Model
{
    //PT_IntranetLeaveFactoryPart
    [Serializable]
    public class PT_IntranetLeaveFactoryPart
    {
        #region Model

        private int _id;
        private string _partname;
        private string _lot_no;
        private string _filesum;
        private string _partpath;
        private string _relativepath;

        private DataRow row;

        public PT_IntranetLeaveFactoryPart()
        { }

        public PT_IntranetLeaveFactoryPart(DataRow row)
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
                if (row != null)
                {
                    if (value == null)
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
        /// PartName
        ///Nullable:True valueType:False
        /// </summary>
        public string PartName
        {
            get
            {
                return _partname;
            }
            set
            {
                _partname = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["PartName"] = DBNull.Value;
                    }
                    else
                    {
                        row["PartName"] = value;
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
                if (row != null)
                {
                    if (value == null)
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
        /// fileSum
        ///Nullable:True valueType:False
        /// </summary>
        public string fileSum
        {
            get
            {
                return _filesum;
            }
            set
            {
                _filesum = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["fileSum"] = DBNull.Value;
                    }
                    else
                    {
                        row["fileSum"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// PartPath
        ///Nullable:True valueType:False
        /// </summary>
        public string PartPath
        {
            get
            {
                return _partpath;
            }
            set
            {
                _partpath = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["PartPath"] = DBNull.Value;
                    }
                    else
                    {
                        row["PartPath"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// RelativePath
        ///Nullable:True valueType:False
        /// </summary>
        public string RelativePath
        {
            get
            {
                return _relativepath;
            }
            set
            {
                _relativepath = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["RelativePath"] = DBNull.Value;
                    }
                    else
                    {
                        row["RelativePath"] = value;
                    }
                }
            }
        }

        #endregion Model
    }
}