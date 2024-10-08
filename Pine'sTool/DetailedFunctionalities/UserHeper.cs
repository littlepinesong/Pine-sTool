using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pine_sTool.DetailedFunctionalities
{
    static class UserHeper
    {
        public static DbHelperSQLP DbHelperSQL_data = new DbHelperSQLP("server=192.168.10.203;database=hbcshdb;user=cshadmin;pwd=57Ki)j9-");//连接数据库
        static string userName;
        public static string GetCurrentUserName()
        {
            //通过工号取到姓名            
            string sql1 = $"select fullname from [hbcshdb].[dbo].[hbjs_userinfo] where cardno = '{Environment.UserName}'";
            DataTable Name = DbHelperSQL_data.Query(sql1).Tables[0];
            foreach (DataRow row in Name.Rows)
            {
                if (!string.IsNullOrEmpty(row["fullname"].ToString()))
                {
                    userName = row["fullname"].ToString();
                    break;
                }
            }
            return userName;
        }
    }
}
