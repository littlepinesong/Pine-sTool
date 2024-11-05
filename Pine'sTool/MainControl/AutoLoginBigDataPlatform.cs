using MessageManager;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Pine_sTool.MainControl
{
    public class AutoLoginBigDataPlatform
    {
        public delegate void ControlPanelMessage(string message);

        public event ControlPanelMessage ShowMessage;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, [In] INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Sequential)]
        private struct INPUT
        {
            public uint Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public KEYBDINPUT Keybd;

            //[FieldOffset(0)]
            //public MOUSEINPUT Mouse;
            //[FieldOffset(0)]
            //public HARDWAREINPUT Hardware;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const int KEYEVENTF_KEYUP = 0x0002;
        private const int VK_CONTROL = 0x11;
        private const int VK_V = 0x56;
        private bool _test;

        public ChromeDriver driver = null;
        public string userCardNo = "";
        public string password = "";

        public AutoLoginBigDataPlatform(bool test = false)
        {
            _test = test;
            //LoginBigDataPlatform();
        }

        private int cycleInt = 0;

        public void LoginBigDataPlatform(ref DateTime _day, ref bool isLogin)
        {
            isLogin = true;//表示在运行登录程序了
            List<DateTime> randomTimes = GetRandomTimesOfDay(9);
            SendHelper sendHelper = new SendHelper();
            string msg = $@"服务器今天会在：{randomTimes[0]}陈鹏、{randomTimes[1]}刘金波、{randomTimes[2]}陈博、{randomTimes[3]}陈鹏、{randomTimes[4]}刘金波、{randomTimes[5]}陈博、{randomTimes[6]}陈鹏、{randomTimes[7]}刘金波、{randomTimes[8]}陈博 自动登录大数据平台";
            ShowMessage($"{msg}");
            sendHelper.SendSimpleMsg("今日登录计划", msg, "176630", "Message001");
            int count = 0;
            if (_test)
            {
                for (int i = 0; i < 5; i++)
                {
                    cycleInt = i + 1;
                    //Thread thread = new Thread(new ParameterizedThreadStart(EveryDayLoginBigDataPlatform));
                    EveryDayLoginBigDataPlatform(0);
                    EveryDayLoginBigDataPlatform(1);
                    EveryDayLoginBigDataPlatform(2);
                    EveryDayLoginBigDataPlatform(3);
                    EveryDayLoginBigDataPlatform(4);
                    EveryDayLoginBigDataPlatform(5);
                    EveryDayLoginBigDataPlatform(6);
                    EveryDayLoginBigDataPlatform(7);
                    EveryDayLoginBigDataPlatform(8);
                }
            }
            else
            {
                while (true)
                {
                    foreach (DateTime time in randomTimes)
                    {
                        if (DateTime.Now.ToString("HH:mm:ss") == time.ToString("HH:mm:ss"))
                        {
                            //每日自动登录大数据平台
                            EveryDayLoginBigDataPlatform(count);
                            count++;
                            //Console.WriteLine(time.ToString("HH:mm:ss"));
                        }
                    }
                    if (count == randomTimes.Count)
                    {
                        break;
                    }
                }
            }
            //#if DEBUG
            //            EveryDayLoginBigDataPlatform(0);
            //            EveryDayLoginBigDataPlatform(1);
            //            EveryDayLoginBigDataPlatform(2);
            //            EveryDayLoginBigDataPlatform(3);
            //            EveryDayLoginBigDataPlatform(4);
            //            EveryDayLoginBigDataPlatform(5);
            //            EveryDayLoginBigDataPlatform(6);
            //            EveryDayLoginBigDataPlatform(7);
            //            EveryDayLoginBigDataPlatform(8);
            //#endif
            //            while (true)
            //            {
            //                foreach (DateTime time in randomTimes)
            //                {
            //                    if (DateTime.Now.ToString("HH:mm:ss") == time.ToString("HH:mm:ss"))
            //                    {
            //                        //每日自动登录大数据平台
            //                        EveryDayLoginBigDataPlatform(count);
            //                        count++;
            //                        //Console.WriteLine(time.ToString("HH:mm:ss"));
            //                    }
            //                }
            //                if (count == randomTimes.Count)
            //                {
            //                    break;
            //                }
            //            }
        }

        private List<DateTime> GetRandomTimesOfDay(int count)
        {
            List<DateTime> randomTimes = new List<DateTime>();
            Random rnd = new Random();
            DateTime today = DateTime.Today; // 获取今天的日期部分，时间为00:00:00
            // 生成指定数量的随机时间
            while (randomTimes.Count < count)
            {
                //计算时间差
                TimeSpan timeSpan = DateTime.Now - today;
                //将时间差转化为秒数
                int secondsDifference = (int)timeSpan.TotalSeconds;
                // 生成一个随机的秒数（从0到86399，即23小时59分钟59秒）
                //int randomSeconds = rnd.Next(0, 86400);
                int randomSeconds = rnd.Next(secondsDifference, 86400);
                // 将随机秒数转换为TimeSpan，然后添加到今天的日期上
                DateTime randomTime = today.AddSeconds(randomSeconds);
                //DateTime randomTime = today.AddSeconds(secondsDifference + randomSeconds);
                // 检查这个时间是否已经存在于列表中，避免重复
                if (!randomTimes.Contains(randomTime))
                {
                    randomTimes.Add(randomTime);
                }
            }
            return randomTimes;
        }

        private void EveryDayLoginBigDataPlatform(int count)
        {
            bool shouldUse = false;
            //string userCardNo = "";
            //string password = "";
            switch (count)
            {
                case 0:
                    userCardNo = "189298";//陈鹏
                    shouldUse = true;
                    password = "Cp189298";
                    break;

                case 1:
                    userCardNo = "588632";//刘金波
                    shouldUse = true;
                    password = "Ljb588632";
                    break;

                case 2:
                    userCardNo = "589360";//陈博
                    shouldUse = true;
                    password = "Cb123456";
                    break;

                case 3:
                    userCardNo = "189298";//陈鹏
                    shouldUse = true;
                    password = "Cp189298";
                    break;

                case 4:
                    userCardNo = "588632";//刘金波
                    shouldUse = true;
                    password = "Ljb588632";
                    break;

                case 5:
                    userCardNo = "589360";//陈博
                    shouldUse = true;
                    password = "Cb123456";
                    break;

                case 6:
                    userCardNo = "189298";//陈鹏
                    shouldUse = true;
                    password = "Cp189298";
                    break;

                case 7:
                    userCardNo = "588632";//刘金波
                    shouldUse = true;
                    password = "Ljb588632";
                    break;

                case 8:
                    userCardNo = "589360";//陈博
                    shouldUse = true;
                    password = "Cb123456";
                    break;
                //case "176630":
                //    shouldUse = true;
                //    password = "Yxs176630";
                //    break;
                default:
                    break;
            }
            RunBigDataPlatform(shouldUse, password);
        }

        private void RunBigDataPlatform(bool shouldUse, string password)
        {
            driver = null;
            if (driver == null)
            {
                ChromeOptions options = new ChromeOptions();
                if (!GlobalValue.IsSeleniumShow)
                {
                    options.AddArgument("--headless"); // 设置 Chrome 为无头模式
                }
                options.AddArgument("--disable-gpu"); // 禁用 GPU 加速
                options.AddArgument("--window-size=1920,1080"); // 设置窗口大小（可选）

                //IWebDriver driver = new ChromeDriver(options);
                //driver.Navigate().GoToUrl("https://www.example.com");

                //// 执行自动化操作

                //driver.Quit(); // 关闭浏览器

                //设置ChromeDriver的路径
                string releasePath = Application.StartupPath;
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(releasePath);
                //隐藏命令提示窗口
                chromeDriverService.HideCommandPromptWindow = true;
                //创建ChromeDriver实例
                driver = new ChromeDriver(chromeDriverService, options);
            }
            if (shouldUse)
            {
                // 在 Chrome 浏览器中打开指定的网址
                driver.Navigate().GoToUrl("http://10.97.0.10/#/login");
                //Thread.Sleep(2000);
                driver.FindElementByXPath("//*[@id=\"app\"]/div/div/form/div[2]/div/div[1]/input").SendKeys($"{userCardNo}");
                driver.FindElementByXPath("//*[@id=\"app\"]/div/div/form/div[3]/div/div[1]/input").SendKeys($"{password}");
                driver.FindElementByXPath("//*[@id=\"app\"]/div/div/form/button").Click();
                //SendKeys.SendWait($"{userCardNo}");
                //SendKeys.SendWait("\t");
                //SendKeys.SendWait($"{password}");
                //SendKeys.SendWait("{ENTER}");
                Thread.Sleep(5000);
                SendHelper sendToAdmin = new SendHelper();
                string msg = $"{DateTime.Now},服务器现在在自动登录{CardNOsTOUserNames.GetUserNames(userCardNo)}的大数据平台账号";
                ShowMessage($"{msg}");
                ShowMessage($"所处第{cycleInt}个轮回!");
                sendToAdmin.SendSimpleMsg("每日自动登录大数据平台",
                    msg,
                    "176630", "Message001");
                //driver.Close();
                driver.Dispose();
            }
        }
    }
}