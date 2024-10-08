using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using Maticsoft.DBUtility;

namespace Pine_sTool.DetailedFunctionalities.Windchill登陆器
{
    public partial class WindchilLogin : DevExpress.XtraEditors.XtraForm
    {
        public static DbHelperSQLP DbHelperSQL_data = new DbHelperSQLP("server=192.168.10.203;database=hbcshdb;user=cshadmin;pwd=57Ki)j9-");//连接数据库
        public static ChromeDriver driver = null;

        public WindchilLogin()
        {
            InitializeComponent();
        }
        private void WindchilLogin_Load(object sender, EventArgs e)
        {
            TBEAHB.Controls.Choose.MakeChoose(searchLookUpEdit1, TBEAHB.Controls.enumChoose.user);
        }
        string WindchillUserCard = "";
        private void LoginSimpleButton_Click(object sender, EventArgs e)
        {
            //设置ChromeDriver的路径
            string releasePath = Application.StartupPath;
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(releasePath);
            //隐藏命令提示窗口
            chromeDriverService.HideCommandPromptWindow = true;
            //床架ChromeDriver实例
            driver = new ChromeDriver(chromeDriverService);
            WindchillUserCard = MessageManager.UserHelper.GetCarNOByID(int.Parse(searchLookUpEdit1.EditValue.ToString()));
            //1.尝试首字母
            string userPass = getPassWord()+"123456";
            try
            {
                //driver.Navigate().GoToUrl($"http://219523:Lh187114@plmnew.tbea-hb.com.cn/Windchill/app/");
                string url = $"http://"+$"{WindchillUserCard}:{userPass}@plmnew.tbea-hb.com.cn/Windchill/app/";
                driver.Navigate().GoToUrl(url);
                IWebElement searchBox = driver.FindElement(By.Id("gloabalSearchField"));
            }
            catch (Exception)
            {
                driver.Close();
                driver = new ChromeDriver(chromeDriverService);
                userPass = "Hb" + $"{WindchillUserCard}";
                string url = $"http://" + $"{WindchillUserCard}:{userPass}@plmnew.tbea-hb.com.cn/Windchill/app/";
                driver.Navigate().GoToUrl(url);
                try
                {
                    IWebElement searchBox = driver.FindElement(By.Id("gloabalSearchField"));
                }
                catch (Exception)
                {
                    driver.Close();
                    MessageBox.Show("这两个密码都不对", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            WindchillUserCard = MessageManager.UserHelper.GetCarNOByID(int.Parse(searchLookUpEdit1.EditValue.ToString()));
            //1.尝试首字母+123456
            string userPass1 = getPassWord() + "123456";
            //2.尝试Hb+工号
            string userPass2= "Hb" + $"{WindchillUserCard}";
            memoEdit1.Text += $"\r\n{MessageManager.UserHelper.GetUserNamesByCarNO(WindchillUserCard)}:{WindchillUserCard}";
            memoEdit1.Text += $"\r\n密码1:{userPass1}";
            memoEdit1.Text += $"\r\n密码2:{userPass2}";
        }

        private string getPassWord()
        {
            string password = "";
            DataTable table = DbHelperSQL_data.Query(getSQL()).Tables[0];
            foreach (DataRow row in table.Rows)
            {
                if (WindchillUserCard == row["yggh"].ToString())
                {
                    password = row["quanpin"].ToString();
                    break;
                }
            }
            //保持首字母大写
            password = password.ToLower();
            password = char.ToUpper(password[0]) + password.Substring(1);
            return password;
        }

        private string getSQL()
        {
            StringBuilder varname1 = new StringBuilder();
            varname1.Append("SELECT TOP (1000) [userId] \n");
            varname1.Append("      ,[Id] \n");
            varname1.Append("      ,[sjhm] \n");
            varname1.Append("      ,[sfzhm] \n");
            varname1.Append("      ,[hzhm] \n");
            varname1.Append("      ,[hzdqrq] \n");
            varname1.Append("      ,[xb] \n");
            varname1.Append("      ,[mz] \n");
            varname1.Append("      ,[csrq] \n");
            varname1.Append("      ,[nl] \n");
            varname1.Append("      ,[hyzk] \n");
            varname1.Append("      ,[zzmm] \n");
            varname1.Append("      ,[jgszd] \n");
            varname1.Append("      ,[hkszdxxdz] \n");
            varname1.Append("      ,[gw] \n");
            varname1.Append("      ,[rzzg] \n");
            varname1.Append("      ,[zj] \n");
            varname1.Append("      ,[zd] \n");
            varname1.Append("      ,[jszc] \n");
            varname1.Append("      ,[zylb] \n");
            varname1.Append("      ,[pdsj] \n");
            varname1.Append("      ,[dyxl] \n");
            varname1.Append("      ,[dyxlxx] \n");
            varname1.Append("      ,[dyxlzy] \n");
            varname1.Append("      ,[zgxl] \n");
            varname1.Append("      ,[zgxlxx] \n");
            varname1.Append("      ,[zgxlzy] \n");
            varname1.Append("      ,[wyyz] \n");
            varname1.Append("      ,[wyzslx] \n");
            varname1.Append("      ,[jrhbsj] \n");
            varname1.Append("      ,[jrhbgznx] \n");
            varname1.Append("      ,[hbAge] \n");
            varname1.Append("      ,[jrsjbsj] \n");
            varname1.Append("      ,[jrsjbgznx] \n");
            varname1.Append("      ,[sjbAge] \n");
            varname1.Append("      ,[gwzt] \n");
            varname1.Append("      ,[gwbgsj] \n");
            varname1.Append("      ,[gwbgsjyy] \n");
            varname1.Append("      ,[bz] \n");
            varname1.Append("      ,[dyxlbysj] \n");
            varname1.Append("      ,[zgxlbysj] \n");
            varname1.Append("      ,[sfph] \n");
            varname1.Append("      ,[sfzdqrq] \n");
            varname1.Append("      ,[sjhmqt] \n");
            varname1.Append("      ,[bgsdh] \n");
            varname1.Append("      ,[rzzgcj] \n");
            varname1.Append("      ,[sfzfj] \n");
            varname1.Append("      ,[wyzsqt] \n");
            varname1.Append("      ,[grzpfj] \n");
            varname1.Append("      ,[hzfj] \n");
            varname1.Append("      ,[hkfj] \n");
            varname1.Append("      ,[dyxlfj] \n");
            varname1.Append("      ,[jszczsfj] \n");
            varname1.Append("      ,[wyzsfj] \n");
            varname1.Append("      ,[qtzsfj] \n");
            varname1.Append("      ,[zgxlfj] \n");
            varname1.Append("      ,[yxnj] \n");
            varname1.Append("      ,[yggh] \n");
            varname1.Append("      ,[xmpy] \n");
            varname1.Append("      ,[yjbmid] \n");
            varname1.Append("      ,[yjbm] \n");
            varname1.Append("      ,[ejbmid] \n");
            varname1.Append("      ,[ejbm] \n");
            varname1.Append("      ,[fullname] \n");
            varname1.Append("      ,[cusindex] \n");
            varname1.Append("      ,[gwbgsj_bm] \n");
            varname1.Append("      ,[height] \n");
            varname1.Append("      ,[jrstsj] \n");
            varname1.Append("      ,[jrstgznx] \n");
            varname1.Append("      ,[status] \n");
            varname1.Append("      ,[dwgw] \n");
            varname1.Append("      ,[dwejbm] \n");
            varname1.Append("      ,[dwbz] \n");
            varname1.Append("      ,[quanpin] \n");
            varname1.Append("      ,[is211] \n");
            varname1.Append("      ,[is985] \n");
            varname1.Append("      ,[email] \n");
            varname1.Append("  FROM [hbcshdb].[dbo].[View_userinfoNew]");
            return varname1.ToString();
        }

        
    }
}