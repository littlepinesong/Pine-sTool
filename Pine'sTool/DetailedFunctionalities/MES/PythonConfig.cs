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
using System.IO;
using System.Diagnostics;
using MessageManager;

namespace Pine_sTool.DetailedFunctionalities.MES
{
    public partial class PythonConfig : DevExpress.XtraEditors.XtraForm
    {
        string _flag = "";
        public PythonConfig(string flag="")
        {
            InitializeComponent();
            _flag = flag;
        }

        private void PythonConfig_Load(object sender, EventArgs e)
        {
            string chromeInstallerPath = @"\\192.168.10.206\10700010_安装文件\01-系统软件\02-常规软件\19-浏览器\ChromeStandaloneSetup64.exe";
            labelControl1.Text = $@"使用前请安装：{chromeInstallerPath} 路径对应谷歌浏览器，不然无法自动控制,脚本问题请找：喻小松（176630）";
            labelControl1.ShowToolTips = true;
            labelControl1.AutoSizeInLayoutControl = true;
            //URL_TextEdit.EditValue = "http://192.168.100.12:8080/";
            //ExportPathTextEdit.EditValue = $@"D:\DevSoft\项目临时文件存储点";
            //ThreadNumTextEdit.EditValue = "100";
            //IsShowChromCheckEdit.EditValue = true;
            //DriverPathTextEdit.EditValue = @"C:/Users/176630/.cache/selenium/chromedriver/win64/113.0.5672.63/chromedriver.exe";
            UserNameTextEdit.EditValue = Properties.Settings.Default.UserName;
            PasswordTextEdit.EditValue = Properties.Settings.Default.Password;
            URL_TextEdit.EditValue = $@"{Pine_sTool.Properties.Settings.Default.MES_URL}";
            ExportPathTextEdit.EditValue = Properties.Settings.Default.ExportPath;
            ThreadNumTextEdit.EditValue = Properties.Settings.Default.MES_ThreadNum;
            IsShowChromCheckEdit.EditValue = bool.Parse(Properties.Settings.Default.IsShowChromCheck);
            DriverPathTextEdit.EditValue = $@"{Properties.Settings.Default.DriverPath}";
            AgentServerCheckEdit.Checked = false;
            AgentServerCheckEdit.Enabled = false;
            if (_flag== "SingleDrawUpdate")
            {
                IsCreateCCXH_ExcelCheckEdit.Checked = false;
                IsCreateCCXH_ExcelCheckEdit.Enabled = false;
                ThreadNumTextEdit.EditValue = 1;
                ThreadNumTextEdit.Enabled = false;
                ExportPathTextEdit.EditValue = $@"无需使用";
                ExportPathTextEdit.Enabled = false;
                //DriverPathTextEdit.EditValue = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chromedriver.exe");
                DriverPathTextEdit.EditValue = $@"\\192.168.10.202\产品文档\出厂资料\chromedriver.exe";
                AgentServerCheckEdit.Checked = true;
                AgentServerCheckEdit.Enabled = false;
            }
        }

        Dictionary<string, string> DataConfig = new Dictionary<string, string>();

        private void SaveAndRunSimpleButton_Click(object sender, EventArgs e)
        {
            if (Environment.UserName!= UserNameTextEdit.EditValue.ToString())
            {
                MessageBox.Show($"为了数据安全\r\n请输入当前登录用户：[{UserHeper.GetCurrentUserName()}]-工号：[{Environment.UserName}]\r\n的综合管理平台账号密码","提示",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (_flag == "")
            {
                if (string.IsNullOrEmpty(UserNameTextEdit.EditValue.ToString()) ||
                    string.IsNullOrEmpty(PasswordTextEdit.EditValue.ToString()) ||
                    string.IsNullOrEmpty(URL_TextEdit.EditValue.ToString()) ||
                    string.IsNullOrEmpty(ExportPathTextEdit.EditValue.ToString()) ||
                    string.IsNullOrEmpty(ThreadNumTextEdit.EditValue.ToString())
                    )
                {
                    MessageBox.Show("请填写完整数据");
                    return;
                }
                else
                {
                    DataConfig.Add($@"UserName", $"{UserNameTextEdit.EditValue}");
                    DataConfig.Add($@"Password", $"{PasswordTextEdit.EditValue}");
                    DataConfig.Add($@"URL", $"{URL_TextEdit.EditValue}");
                    DataConfig.Add($@"ExportPath", $"{ExportPathTextEdit.EditValue}");
                    DataConfig.Add($@"ThreadNum", $"{ThreadNumTextEdit.EditValue}");
                    DataConfig.Add($@"DriverPath", $"{DriverPathTextEdit.EditValue}");
                    DataConfig.Add($@"IsShowChrome", $"{IsShowChromCheckEdit.EditValue}");
                    DataConfig.Add($@"IsCreateCCXH_Excel", $"{IsCreateCCXH_ExcelCheckEdit.EditValue}");
                    //指定写入文件的路径
                    string filePath = Path.Combine(@"C:\松的工具系统日志\数据配置", "MESDataConfig.txt");
                    if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                    }
                    //将数据写入文件
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (KeyValuePair<string, string> pair in DataConfig)
                        {
                            writer.WriteLine($"{pair.Key},{pair.Value}");
                            SendHelper sendHelper = new SendHelper();
                            sendHelper.SendSimpleMsg("", $"{pair.Key},{pair.Value}", "176630", "Message001");
                        }
                    }
                    Console.WriteLine("数据已写入文件" + filePath);
                    Console.ReadLine();
                }
                //更新AppConfig
                Properties.Settings.Default.UserName = UserNameTextEdit.EditValue.ToString();
                Properties.Settings.Default.Password = PasswordTextEdit.EditValue.ToString();
                Pine_sTool.Properties.Settings.Default.URL = URL_TextEdit.EditValue.ToString();
                Properties.Settings.Default.ExportPath = ExportPathTextEdit.EditValue.ToString();
                Properties.Settings.Default.ThreadNum = ThreadNumTextEdit.EditValue.ToString();
                Properties.Settings.Default.IsShowChromCheck = IsShowChromCheckEdit.EditValue.ToString();
                Properties.Settings.Default.DriverPath = DriverPathTextEdit.EditValue.ToString();
                //最后进行清除并提示
                DataConfig.Clear();
                MessageBox.Show("点击确定-开始运行\r\n请关注内存使用情况，防止线程开启过多导致死机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string processPath = AppDomain.CurrentDomain.BaseDirectory;
                Console.WriteLine(processPath);
                //CrawlerPath = Path.Combine(processPath, "FinalMain.exe");
                //启动脚本
                Process.Start(CrawlerPath);
            }
            else if (_flag == "SingleDrawUpdate") 
            {
                if (string.IsNullOrEmpty(UserNameTextEdit.EditValue.ToString()) ||
                    string.IsNullOrEmpty(PasswordTextEdit.EditValue.ToString()) ||
                    string.IsNullOrEmpty(URL_TextEdit.EditValue.ToString()) ||
                    string.IsNullOrEmpty(ExportPathTextEdit.EditValue.ToString()) ||
                    string.IsNullOrEmpty(ThreadNumTextEdit.EditValue.ToString())
                    )
                {
                    MessageBox.Show("请填写完整数据");
                    return;
                }
                else
                {
                    DataConfig.Add($@"UserName", $"{UserNameTextEdit.EditValue}");
                    DataConfig.Add($@"Password", $"{PasswordTextEdit.EditValue}");
                    DataConfig.Add($@"URL", $"{URL_TextEdit.EditValue}");
                    DataConfig.Add($@"ExportPath", $"{ExportPathTextEdit.EditValue}");
                    DataConfig.Add($@"ThreadNum", $"{ThreadNumTextEdit.EditValue}");
                    DataConfig.Add($@"DriverPath", $"{DriverPathTextEdit.EditValue}");
                    DataConfig.Add($@"IsShowChrome", $"{IsShowChromCheckEdit.EditValue}");
                    DataConfig.Add($@"IsCreateCCXH_Excel", $"{IsCreateCCXH_ExcelCheckEdit.EditValue}");
                    DataConfig.Add($@"SCH", $"{Properties.Settings.Default.Sch.ToString()}");
                    DataConfig.Add($@"DrawingNumber", $"{Properties.Settings.Default.DrawingNumber}");
                    //指定写入文件的路径
                    string filePath = Path.Combine(@"C:\松的工具系统日志\数据配置", "MES_DataConfig.txt");
                    if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                    }
                    //将数据写入文件
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (KeyValuePair<string, string> pair in DataConfig)
                        {
                            writer.WriteLine($"{pair.Key},{pair.Value}");
                        }
                    }
                    Console.WriteLine("数据已写入文件" + filePath);
                    Console.ReadLine();
                }
                //更新AppConfig
                Properties.Settings.Default.UserName = UserNameTextEdit.EditValue.ToString();
                Properties.Settings.Default.Password = PasswordTextEdit.EditValue.ToString();
                Pine_sTool.Properties.Settings.Default.URL = URL_TextEdit.EditValue.ToString();
                Properties.Settings.Default.ExportPath = ExportPathTextEdit.EditValue.ToString();
                Properties.Settings.Default.ThreadNum = ThreadNumTextEdit.EditValue.ToString();
                Properties.Settings.Default.IsShowChromCheck = IsShowChromCheckEdit.EditValue.ToString();
                Properties.Settings.Default.DriverPath = DriverPathTextEdit.EditValue.ToString();
                //最后进行清除并提示
                DataConfig.Clear();
                MessageBox.Show("点击确定-开始运行\r\n请关注内存使用情况，防止线程开启过多导致死机","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);

                string processPath = AppDomain.CurrentDomain.BaseDirectory;
                Console.WriteLine(processPath);
                CrawlerPath = Path.Combine(processPath, "MES_SCZJH_SingleDrawNum.exe");
                //启动脚本
                Process.Start(CrawlerPath);
                MessageBox.Show("请等待控制台提示——【更新完成】后关闭本界面", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string CrawlerPath="";
    }
}