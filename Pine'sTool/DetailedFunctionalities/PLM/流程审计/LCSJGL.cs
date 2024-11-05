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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace Pine_sTool.DetailedFunctionalities.PLM.流程审计
{
    public partial class LCSJGL : DevExpress.XtraEditors.XtraForm
    {
        private static ChromeDriver driver = null;
        IWebElement element = null;
        public LCSJGL()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 同步到流程审计管理界面
        /// </summary>
        /// <returns></returns>
        private bool intoLCSJGL()
        {
            try
            {
                AutomatonTool.AutoChromeHelpler autoChromeHelpler = new AutomatonTool.AutoChromeHelpler();
                autoChromeHelpler.ConnectPLM();//连接PLM
                autoChromeHelpler.intoLCSJGL();//进入流程审计管理
                driver = autoChromeHelpler.GetDriver();
                return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
        }
        /// <summary>
        /// 同步主材单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZCD_ALL_Button_Click(object sender, EventArgs e)
        {
            if (driver == null) { intoLCSJGL(); }
            Thread.Sleep(2000);
            element = driver.FindElement(By.XPath($"//*[@id=\"templateName_TBEA\"]"));
            element.Click();//点击模板名称
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"templateName_TBEA_TBEAHB_u20027__u26448__u21333__u27969__u31243_\"]"));
            element.Click();//点击主材单流程
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"processSearchButton\"]"));
            element.Click();//点击提交
            Thread.Sleep(100);
            Thread.Sleep(15000);//等待数据查询加载出来//*[@id="x-menu-el-P7761103754061456__tbea.auditManage.list"]//*[@id="ext-gen577"]
            element = driver.FindElement(By.XPath($"//*[@id=\"object_audit table actions__tbea.auditManage.list__tbea.auditManage.list\"]"));
            element.Click();//点击操作
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"ext-gen578\"]"));
            for (int i = 0; i < 999; i++)
            {
                IWebElement element = null;
                try { element = driver.FindElement(By.XPath($"//*[@id=\"ext-gen{i}\"]")); }
                catch (Exception) { }
                if (element != null && element.Text == "导出列表至 XLSX")
                { element.Click(); break; }//点击导出列表
            }
        }
        /// <summary>
        /// 同步数据数据审签(已执行)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SJSQ_Executed_Button_Click(object sender, EventArgs e)
        {
            if (driver == null) { intoLCSJGL(); }
            Thread.Sleep(2000);
            element = driver.FindElement(By.XPath($"//*[@id=\"templateName_TBEA\"]"));
            element.Click();//点击模板名称
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"templateName_TBEA_TBEAHB_u35774__u35745__u25968__u25454__u23457__u31614__u27969__u31243_\"]"));
            element.Click();//点击数据签署
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"state_TBEA\"]"));
            element.Click();//点击流程状态
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"state_TBEA_CLOSED_COMPLETED_EXECUTED\"]"));
            element.Click();//点击已执行
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"processSearchButton\"]"));
            element.Click();//点击提交
            Thread.Sleep(100);
            Thread.Sleep(15000);//等待数据查询加载出来//*[@id="x-menu-el-P7761103754061456__tbea.auditManage.list"]//*[@id="ext-gen577"]
            element = driver.FindElement(By.XPath($"//*[@id=\"object_audit table actions__tbea.auditManage.list__tbea.auditManage.list\"]"));
            element.Click();//点击操作
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"ext-gen578\"]"));
            for (int i = 0; i < 999; i++)
            {
                IWebElement element = null;
                try { element = driver.FindElement(By.XPath($"//*[@id=\"ext-gen{i}\"]")); }
                catch (Exception) { }
                if (element != null && element.Text == "导出列表至 XLSX")
                { element.Click(); break; }//点击导出列表
            }
        }

        private void SJSQ_Running_Button_Click(object sender, EventArgs e)
        {
            if (driver == null) { intoLCSJGL(); }
            Thread.Sleep(2000);
            element = driver.FindElement(By.XPath($"//*[@id=\"templateName_TBEA\"]"));
            element.Click();//点击模板名称
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"templateName_TBEA_TBEAHB_u35774__u35745__u25968__u25454__u23457__u31614__u27969__u31243_\"]"));
            element.Click();//点击数据签署
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"state_TBEA\"]"));
            element.Click();//点击流程状态
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"state_TBEA_OPEN_RUNNING\"]"));
            element.Click();//点击正在运行
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"processSearchButton\"]"));
            element.Click();//点击提交
            Thread.Sleep(100);
            Thread.Sleep(15000);//等待数据查询加载出来//*[@id="x-menu-el-P7761103754061456__tbea.auditManage.list"]//*[@id="ext-gen577"]
            element = driver.FindElement(By.XPath($"//*[@id=\"object_audit table actions__tbea.auditManage.list__tbea.auditManage.list\"]"));
            element.Click();//点击操作
            Thread.Sleep(100);
            element = driver.FindElement(By.XPath($"//*[@id=\"ext-gen578\"]"));
            for (int i = 0; i < 999; i++)
            {
                IWebElement element = null;
                try { element = driver.FindElement(By.XPath($"//*[@id=\"ext-gen{i}\"]")); }
                catch (Exception) { }
                if (element != null && element.Text == "导出列表至 XLSX")
                { element.Click(); break; }//点击导出列表
            }
        }
    }
}