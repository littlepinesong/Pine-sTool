using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Pine_sTool.DetailedFunctionalities.AutomatonTool
{
    public class AutoChromeHelpler
    {
        private static ChromeDriver driver = null;
        private string plmUser = Properties.Settings.Default.PLM_User;
        private string plmPassword = Properties.Settings.Default.PLM_Password;
        //定义一个委托类型，用于输出每个字符串元素。
        public delegate void ElementOutputDelegate(string element);
        // 定义一个委托实例
        public ElementOutputDelegate OnElementOutput;
        /// <summary>
        /// 获取当前Driver
        /// </summary>
        /// <returns></returns>
        public ChromeDriver GetDriver()
        {
            return driver;
        }

        /// <summary>
        /// 连接PLM
        /// </summary>
        /// <returns></returns>
        public bool ConnectPLM()
        {
            if (driver == null)
            {
                //设置ChromeDriver的路径
                string releasePath = Application.StartupPath;
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(releasePath);
                ChromeOptions options = new ChromeOptions();
                //options.AddArgument("--headless"); // 设置 Chrome 为无头模式
                //隐藏命令提示窗口
                chromeDriverService.HideCommandPromptWindow = true;
                //创建ChromeDriver实例
                //driver = new ChromeDriver(chromeDriverService);
                driver = new ChromeDriver(chromeDriverService, options);
                //driver = new ChromeDriver();
            }
            try
            {
                // 在 Chrome 浏览器中打开指定的网址 账号密码嵌入URL
                driver.Navigate().GoToUrl($"http://{plmUser}:{plmPassword}@plmnew.tbea-hb.com.cn/Windchill/app/");
                return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }

        }
        /// <summary>
        /// 进入流程审计管理
        /// 
        /// 进行左右键点击
        /// Actions action = new Actions(driver);
        /// action.ContextClick(quickLinkButton).Perform();//右键点击
        /// action.Click(quickLinkButton).Perform();//左键点击
        /// </summary>
        /// <returns></returns>
        public bool intoLCSJGL()
        {
            Thread.Sleep(2000);
            IWebElement quickLinkButton = driver.FindElement(By.XPath("//*[@id=\"quickLinksButton\"]"));
            quickLinkButton.Click();//点击快速链接
            try
            {
                Thread.Sleep(2000);
                for (int i = 1000; i < 9999; i++)
                {
                    IWebElement element = null;
                    try
                    { element = driver.FindElement(By.XPath($"//*[@id=\"ext-comp-{i}\"]")); }
                    catch (Exception) { }
                    if (element != null && element.Text == "流程审计管理")
                    { element.Click(); break; }
                }
                return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
        }

        //写一个使用HTMLAgilityPack进行爬虫抓取网页数据的方法
        public void GetHtmlData()
        {
            //获取当前页面的源代码
            string html = driver.PageSource;//driver.PageSource是什么意思？
            //创建一个HtmlDocument对象
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //加载html源代码
            doc.LoadHtml(html);
            //获取所有的tr节点
            HtmlNodeCollection trs = doc.DocumentNode.SelectNodes("//tr");
            
            //遍历所有的tr节点
            foreach (var tr in trs)
            {
                //获取tr节点下的所有td节点
                HtmlNodeCollection tds = tr.SelectNodes("td");
                //遍历所有的td节点
                foreach (var td in tds)
                {
                    //输出td节点的文本
                    System.Console.WriteLine(td.InnerText);
                    // 通过委托发送每个元素
                    OnElementOutput?.Invoke(td.InnerText);
                }
            }
        }
    }
}