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
* 文    件： PT_MES_SCZJH_nodeList.cs
* 功    能： 数据库操作_Model
* 类    名： PT_MES_SCZJH_nodeList
* 创建时间： 2024/9/2 14:57:14
* 说    明： 代码由模板自动生成，不能手动修改!!!
*/

using System;
using System.Data;

namespace Pine_sTool.Model
{
    //PT_MES_SCZJH_nodeList
    [Serializable]
    public class PT_MES_SCZJH_nodeList
    {
        #region Model

        private int _pt_id;
        private string _id;
        private string _ztbm;
        private string _createdt;
        private string _editdt;
        private string _isdeleted;
        private string _deletedt;
        private string _productplanid;
        private string _drawingno;
        private string _name;
        private string _type;
        private string _nodedate;
        private string _finishdate;
        private string _ruleconfig;
        private string _status;
        private string _progressstatus;
        private string _confirmstatus;
        private string _sentkey2wms;
        private string _wmsmid;
        private string _startdate;
        private string _actualstartdate;
        private string _nodeid;
        private string _nodename;
        private string _ismaterialpreparation;
        private string _materialversion;
        private string _usedequipment;
        private string _pausereason;
        private string _describe;
        private string _bominfo;
        private string _recordid;
        private string _isoutsourcing;
        private string _hbfinishdate;
        private string _outsourcingsituation;
        private string _outsourcingsettime;
        private string _finishuserid;
        private string _finishusername;
        private string _startuserid;
        private string _startusername;
        private string _pauseduration;
        private string _drawphase;
        private string _drawplanfinishtime;
        private string _drawactualfinishtime;
        private string _chargepersonname;
        private string _difday;
        private string _hashcode;

        private DataRow row;

        public PT_MES_SCZJH_nodeList()
        { }

        public PT_MES_SCZJH_nodeList(DataRow row)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
                if (row != null)
                {
                    if (value == null)
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
        /// productPlanId
        ///Nullable:True valueType:False
        /// </summary>
        public string productPlanId
        {
            get
            {
                return _productplanid;
            }
            set
            {
                _productplanid = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["productPlanId"] = DBNull.Value;
                    }
                    else
                    {
                        row["productPlanId"] = value;
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
                if (row != null)
                {
                    if (value == null)
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
        /// name
        ///Nullable:True valueType:False
        /// </summary>
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["name"] = DBNull.Value;
                    }
                    else
                    {
                        row["name"] = value;
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
                if (row != null)
                {
                    if (value == null)
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
        /// nodeDate
        ///Nullable:True valueType:False
        /// </summary>
        public string nodeDate
        {
            get
            {
                return _nodedate;
            }
            set
            {
                _nodedate = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["nodeDate"] = DBNull.Value;
                    }
                    else
                    {
                        row["nodeDate"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// finishDate
        ///Nullable:True valueType:False
        /// </summary>
        public string finishDate
        {
            get
            {
                return _finishdate;
            }
            set
            {
                _finishdate = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["finishDate"] = DBNull.Value;
                    }
                    else
                    {
                        row["finishDate"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// ruleConfig
        ///Nullable:True valueType:False
        /// </summary>
        public string ruleConfig
        {
            get
            {
                return _ruleconfig;
            }
            set
            {
                _ruleconfig = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["ruleConfig"] = DBNull.Value;
                    }
                    else
                    {
                        row["ruleConfig"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// status
        ///Nullable:True valueType:False
        /// </summary>
        public string status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["status"] = DBNull.Value;
                    }
                    else
                    {
                        row["status"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// progressStatus
        ///Nullable:True valueType:False
        /// </summary>
        public string progressStatus
        {
            get
            {
                return _progressstatus;
            }
            set
            {
                _progressstatus = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["progressStatus"] = DBNull.Value;
                    }
                    else
                    {
                        row["progressStatus"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// confirmStatus
        ///Nullable:True valueType:False
        /// </summary>
        public string confirmStatus
        {
            get
            {
                return _confirmstatus;
            }
            set
            {
                _confirmstatus = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["confirmStatus"] = DBNull.Value;
                    }
                    else
                    {
                        row["confirmStatus"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// sentKey2Wms
        ///Nullable:True valueType:False
        /// </summary>
        public string sentKey2Wms
        {
            get
            {
                return _sentkey2wms;
            }
            set
            {
                _sentkey2wms = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["sentKey2Wms"] = DBNull.Value;
                    }
                    else
                    {
                        row["sentKey2Wms"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// wmsMid
        ///Nullable:True valueType:False
        /// </summary>
        public string wmsMid
        {
            get
            {
                return _wmsmid;
            }
            set
            {
                _wmsmid = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["wmsMid"] = DBNull.Value;
                    }
                    else
                    {
                        row["wmsMid"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// startDate
        ///Nullable:True valueType:False
        /// </summary>
        public string startDate
        {
            get
            {
                return _startdate;
            }
            set
            {
                _startdate = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["startDate"] = DBNull.Value;
                    }
                    else
                    {
                        row["startDate"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// actualStartDate
        ///Nullable:True valueType:False
        /// </summary>
        public string actualStartDate
        {
            get
            {
                return _actualstartdate;
            }
            set
            {
                _actualstartdate = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["actualStartDate"] = DBNull.Value;
                    }
                    else
                    {
                        row["actualStartDate"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// nodeId
        ///Nullable:True valueType:False
        /// </summary>
        public string nodeId
        {
            get
            {
                return _nodeid;
            }
            set
            {
                _nodeid = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["nodeId"] = DBNull.Value;
                    }
                    else
                    {
                        row["nodeId"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// nodeName
        ///Nullable:True valueType:False
        /// </summary>
        public string nodeName
        {
            get
            {
                return _nodename;
            }
            set
            {
                _nodename = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["nodeName"] = DBNull.Value;
                    }
                    else
                    {
                        row["nodeName"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// isMaterialPreparation
        ///Nullable:True valueType:False
        /// </summary>
        public string isMaterialPreparation
        {
            get
            {
                return _ismaterialpreparation;
            }
            set
            {
                _ismaterialpreparation = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["isMaterialPreparation"] = DBNull.Value;
                    }
                    else
                    {
                        row["isMaterialPreparation"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// materialVersion
        ///Nullable:True valueType:False
        /// </summary>
        public string materialVersion
        {
            get
            {
                return _materialversion;
            }
            set
            {
                _materialversion = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["materialVersion"] = DBNull.Value;
                    }
                    else
                    {
                        row["materialVersion"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// usedEquipment
        ///Nullable:True valueType:False
        /// </summary>
        public string usedEquipment
        {
            get
            {
                return _usedequipment;
            }
            set
            {
                _usedequipment = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["usedEquipment"] = DBNull.Value;
                    }
                    else
                    {
                        row["usedEquipment"] = value;
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
                if (row != null)
                {
                    if (value == null)
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
        /// describe
        ///Nullable:True valueType:False
        /// </summary>
        public string describe
        {
            get
            {
                return _describe;
            }
            set
            {
                _describe = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["describe"] = DBNull.Value;
                    }
                    else
                    {
                        row["describe"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// bomInfo
        ///Nullable:True valueType:False
        /// </summary>
        public string bomInfo
        {
            get
            {
                return _bominfo;
            }
            set
            {
                _bominfo = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["bomInfo"] = DBNull.Value;
                    }
                    else
                    {
                        row["bomInfo"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// recordId
        ///Nullable:True valueType:False
        /// </summary>
        public string recordId
        {
            get
            {
                return _recordid;
            }
            set
            {
                _recordid = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["recordId"] = DBNull.Value;
                    }
                    else
                    {
                        row["recordId"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// isOutsourcing
        ///Nullable:True valueType:False
        /// </summary>
        public string isOutsourcing
        {
            get
            {
                return _isoutsourcing;
            }
            set
            {
                _isoutsourcing = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["isOutsourcing"] = DBNull.Value;
                    }
                    else
                    {
                        row["isOutsourcing"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// hbFinishDate
        ///Nullable:True valueType:False
        /// </summary>
        public string hbFinishDate
        {
            get
            {
                return _hbfinishdate;
            }
            set
            {
                _hbfinishdate = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["hbFinishDate"] = DBNull.Value;
                    }
                    else
                    {
                        row["hbFinishDate"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// outsourcingSituation
        ///Nullable:True valueType:False
        /// </summary>
        public string outsourcingSituation
        {
            get
            {
                return _outsourcingsituation;
            }
            set
            {
                _outsourcingsituation = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["outsourcingSituation"] = DBNull.Value;
                    }
                    else
                    {
                        row["outsourcingSituation"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// outsourcingSetTime
        ///Nullable:True valueType:False
        /// </summary>
        public string outsourcingSetTime
        {
            get
            {
                return _outsourcingsettime;
            }
            set
            {
                _outsourcingsettime = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["outsourcingSetTime"] = DBNull.Value;
                    }
                    else
                    {
                        row["outsourcingSetTime"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// finishUserId
        ///Nullable:True valueType:False
        /// </summary>
        public string finishUserId
        {
            get
            {
                return _finishuserid;
            }
            set
            {
                _finishuserid = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["finishUserId"] = DBNull.Value;
                    }
                    else
                    {
                        row["finishUserId"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// finishUserName
        ///Nullable:True valueType:False
        /// </summary>
        public string finishUserName
        {
            get
            {
                return _finishusername;
            }
            set
            {
                _finishusername = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["finishUserName"] = DBNull.Value;
                    }
                    else
                    {
                        row["finishUserName"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// startUserId
        ///Nullable:True valueType:False
        /// </summary>
        public string startUserId
        {
            get
            {
                return _startuserid;
            }
            set
            {
                _startuserid = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["startUserId"] = DBNull.Value;
                    }
                    else
                    {
                        row["startUserId"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// startUserName
        ///Nullable:True valueType:False
        /// </summary>
        public string startUserName
        {
            get
            {
                return _startusername;
            }
            set
            {
                _startusername = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["startUserName"] = DBNull.Value;
                    }
                    else
                    {
                        row["startUserName"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// pauseDuration
        ///Nullable:True valueType:False
        /// </summary>
        public string pauseDuration
        {
            get
            {
                return _pauseduration;
            }
            set
            {
                _pauseduration = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["pauseDuration"] = DBNull.Value;
                    }
                    else
                    {
                        row["pauseDuration"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// drawPhase
        ///Nullable:True valueType:False
        /// </summary>
        public string drawPhase
        {
            get
            {
                return _drawphase;
            }
            set
            {
                _drawphase = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["drawPhase"] = DBNull.Value;
                    }
                    else
                    {
                        row["drawPhase"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// drawPlanFinishTime
        ///Nullable:True valueType:False
        /// </summary>
        public string drawPlanFinishTime
        {
            get
            {
                return _drawplanfinishtime;
            }
            set
            {
                _drawplanfinishtime = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["drawPlanFinishTime"] = DBNull.Value;
                    }
                    else
                    {
                        row["drawPlanFinishTime"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// drawActualFinishTime
        ///Nullable:True valueType:False
        /// </summary>
        public string drawActualFinishTime
        {
            get
            {
                return _drawactualfinishtime;
            }
            set
            {
                _drawactualfinishtime = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["drawActualFinishTime"] = DBNull.Value;
                    }
                    else
                    {
                        row["drawActualFinishTime"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// chargePersonName
        ///Nullable:True valueType:False
        /// </summary>
        public string chargePersonName
        {
            get
            {
                return _chargepersonname;
            }
            set
            {
                _chargepersonname = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["chargePersonName"] = DBNull.Value;
                    }
                    else
                    {
                        row["chargePersonName"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// difDay
        ///Nullable:True valueType:False
        /// </summary>
        public string difDay
        {
            get
            {
                return _difday;
            }
            set
            {
                _difday = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["difDay"] = DBNull.Value;
                    }
                    else
                    {
                        row["difDay"] = value;
                    }
                }
            }
        }

        /// <summary>
        /// hashCode
        ///Nullable:True valueType:False
        /// </summary>
        public string hashCode
        {
            get
            {
                return _hashcode;
            }
            set
            {
                _hashcode = value;
                if (row != null)
                {
                    if (value == null)
                    {
                        row["hashCode"] = DBNull.Value;
                    }
                    else
                    {
                        row["hashCode"] = value;
                    }
                }
            }
        }

        #endregion Model
    }
}