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
* 文    件： View_PT_MES_SCZJH_Merger.cs
* 功    能： 数据库操作_Model
* 类    名： View_PT_MES_SCZJH_Merger
* 创建时间： 2024/9/5 16:55:49
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/

using System;
using System.Data;

namespace Pine_sTool.Model
{
    //View_PT_MES_SCZJH_Merger
    [Serializable]
    public class View_PT_MES_SCZJH_Merger
    {
        #region Model

        private string _productno主干;
        private string _model主干;
        private string _plancompletime主干;
        private string _dateend主干;
        private string _drawingno主干;
        private string _customername主干;
        private string _notaxamount主干;
        private string _output主干;
        private string _timelimitname主干;
        private string _count主干;
        private string _statename主干;
        private string _createdt节点;
        private string _editdt节点;
        private string _drawingno节点;
        private string _name节点;
        private string _type节点;
        private string _nodedate节点;
        private string _finishdate节点;
        private string _status节点;
        private string _startdate节点;
        private string _actualstartdate节点;
        private string _hbfinishdate节点;
        private string _startusername节点;
        private string _finishusername节点;

        private DataRow row;

        public View_PT_MES_SCZJH_Merger()
        { }

        public View_PT_MES_SCZJH_Merger(DataRow row)
        {
            this.row = row;
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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

        #endregion Model
    }
}