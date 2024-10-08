using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using MoveAndClickMouse;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraBars;
using Maticsoft.DBUtility;
using System.Data;
using System.Diagnostics;

namespace MoveAndClickMouse
{
    public partial class rotationPrint : DevExpress.XtraEditors.XtraForm
    {
        Tools.AuxiliaryTools auxiliaryTools = new Tools.AuxiliaryTools();
        public static DbHelperSQLP DbHelperSQL_data = new DbHelperSQLP("server=192.168.10.203;database=hbcshdb;user=cshadmin;pwd=57Ki)j9-");//连接数据库
        string userName;
        public rotationPrint()
        {
            InitializeComponent();
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

            //通过按键退出程序(设定为end键)
            this.KeyPress += new KeyPressEventHandler(rotationPrint_KeyPress);
            this.KeyDown += new KeyEventHandler(rotationPrint_KeyDown);
        }

        private void rotationPrint_Load(object sender, EventArgs e)
        {
            //ShowMessage($"***************************");
            ShowMessage($"★ 欢迎使用工作面板 ★");
            ShowMessage($"当前登陆用户：☆{userName}☆");
            //ShowMessage($"***************************");

            LoadAuxiliaryToolsBarListItem();

            //测试方法
            //TestMeasure();

            #region 权限控制
            if (Environment.UserName == "176630")
            {
                TestBarButtonItem.Enabled = true;
                ApplicationTestBarButtonItem.Enabled = true;
            }
            else
            {
                TestBarButtonItem.Enabled = false;
                ApplicationTestBarButtonItem.Enabled = false;
            }
            #endregion
        }

        private void LoadAuxiliaryToolsBarListItem()
        {
            AuxiliaryToolsBarListItem.Strings.Add("记事本");
            AuxiliaryToolsBarListItem.Strings.Add("计算器");
            AuxiliaryToolsBarListItem.Strings.Add("命令提示符");
            AuxiliaryToolsBarListItem.Strings.Add("文件资源管理器");
            AuxiliaryToolsBarListItem.Strings.Add("Edge浏览器");
            AuxiliaryToolsBarListItem.Strings.Add("控制面板");
            AuxiliaryToolsBarListItem.Strings.Add("画图");
            AuxiliaryToolsBarListItem.Strings.Add("Excel");
            AuxiliaryToolsBarListItem.Strings.Add("Word");
            AuxiliaryToolsBarListItem.Strings.Add("PowerPoint");
            AuxiliaryToolsBarListItem.Strings.Add("Media Player");
            AuxiliaryToolsBarListItem.Strings.Add("Skype");
            AuxiliaryToolsBarListItem.Strings.Add("搜狗输入法");
        }

        /// <summary>
        /// 专门用来测试方法的方法
        /// </summary>
        private void TestMeasure()
        {
            BooleanSwitch testSwitch = new BooleanSwitch("测试控制开关", "用于控制哪个方法运行");
            testSwitch.Enabled = true;//如果不设置的话，Enabled的值默认是false
            #region 测试获取文件名的方法
            if (!testSwitch.Enabled)
            {
                string beUsedPath = $@"D:\{Environment.UserName}\Downloads";
                GetFileName(beUsedPath);
            }
            #endregion
        }
        private void GetFileName(string tempExtractPath)
        {
            // 遍历当前文件夹下的所有文件
            string[] files = Directory.GetFiles(tempExtractPath);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string[] parts = fileName.Split('.');
                ShowMessage($"文件名：{fileName}");
                for (int i = 0; i < parts.Length; i++)
                {
                    ShowMessage($"第{i}部分：{parts[i]}");
                }
            }

            // 遍历当前文件夹下的所有子文件夹
            string[] subFolders = Directory.GetDirectories(tempExtractPath);
            foreach (string subFolder in subFolders)
            {
                GetFileName(subFolder); // 递归调用遍历子文件夹
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult messageResult = MessageBox.Show("Pine:写的不好，先废弃掉。\r\n点击确定继续运行。", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            BooleanSwitch testSwitch = new BooleanSwitch("测试控制开关", "用于控制哪个方法运行");
            if (messageResult == DialogResult.OK)
            {
                testSwitch.Enabled = false;//如果不设置的话，Enabled的值默认是false
            }
            if (messageResult == DialogResult.Cancel)
            {
                testSwitch.Enabled = true;
            }
            if (!testSwitch.Enabled)
            {
                RandomPrint randomPrint = new RandomPrint();
                randomPrint.ShowMessage += new RandomPrint.FormMsgHandle(ShowMessage);
                randomPrint.randomPrint();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM--dd HH:mm:ss"));
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BooleanSwitch testSwitch = new BooleanSwitch("测试控制开关", "用于控制哪个方法运行");
            DialogResult messageResult = MessageBox.Show("按下Esc退出自动点击程序\r\n点击确定继续运行。", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //this.Hide();
            //使用最小化到通知栏而非直接隐藏
            if (messageResult == DialogResult.OK)
            {
                testSwitch.Enabled = false;//如果不设置的话，Enabled的值默认是false
            }
            if (messageResult == DialogResult.Cancel)
            {
                testSwitch.Enabled = true;
            }
            if (!testSwitch.Enabled)
            {
                this.WindowState = FormWindowState.Minimized;
                intervalDuration fm = new intervalDuration();
                fm.MyEvent += new intervalDuration.MyDelegate(SetIntervalDurationValue);
                fm.ShowDialog();
                MoveAndClickMouse.MouseClick.Click(duration);
            }
            //this.Show();
        }

        double duration = 120000;

        private void SetIntervalDurationValue(string value)
        {
            double interval = 1;
            if (double.TryParse(value, out interval))
            {
                duration = interval * 1000;
            }
            else
            {
                MessageBox.Show($"转化错误，请联系处理(使用默认间隔时间{duration}ms)", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rotationPrint_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        #region 通过按下end键退出程序
        private void rotationPrint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.End)
            {
                Application.Exit();
            }
        }
        private void rotationPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                Application.Exit();
            }
        }
        #endregion

        private void IPandHostNameBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IPandHostName.IPandHostName fm = new IPandHostName.IPandHostName();
            fm.ShowMessage += new MoveAndClickMouse.IPandHostName.IPandHostName.FormMsgHandle(ShowMessage);
            fm.Show();
        }

        private void ShowMessage(string message)
        {
            Application.DoEvents();
            message = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":  " + message;
            MessageListBoxControl.Items.Add(message);
            MessageListBoxControl.SelectedIndex = MessageListBoxControl.Items.Count - 1;
        }

        private void AuxiliaryToolsBarListItem_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            //MessageBox.Show(e.Index.ToString());
            try
            {
                switch (e.Index)
                {
                    case 0:
                        Process.Start("notepad.exe");
                        break;
                    case 1:
                        Process.Start("calc.exe");
                        break;
                    case 2:
                        Process.Start("cmd.exe");
                        break;
                    case 3:
                        Process.Start("explorer.exe");
                        break;
                    case 4:
                        Process.Start("microsoft-edge:");
                        break;
                    case 5:
                        Process.Start("control.exe");
                        break;
                    case 6:
                        Process.Start("mspaint.exe");
                        break;
                    case 7:
                        Process.Start("excel.exe");
                        break;
                    case 8:
                        Process.Start("winword.exe");
                        break;
                    case 9:
                        Process.Start("pwoerpnt.exe");
                        break;
                    case 10:
                        Process.Start("wmplayer.exe");
                        break;
                    case 11:
                        Process.Start("skype.exe");
                        break;
                    case 12:
                        Process.Start("SogouInput.exe");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            //string releasePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string releasePath = Application.StartupPath;
            string exePath = System.IO.Path.Combine(releasePath, "re\\虚假工作.exe");
            Process.Start(exePath);
        }

        private void TestBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            //UInew.JHKZ_DLL1.UI.质量问题.UInew_FrmSFPnew fm = new UInew.JHKZ_DLL1.UI.质量问题.UInew_FrmSFPnew(1, 1, 1);
            //fm.ShowDialog();
        }

        private void ApplicationTestBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            startInfo.FileName = "JHKZ_DLL1_UI_质量问题_FrmSFPnew.exe";
            startInfo.Arguments = "1,2,3";
            startInfo.RedirectStandardOutput = true;//是否重定向标准输出
            startInfo.UseShellExecute = false;//是否使用操作系统shell启动应用程序

            process.Start();
            process.WaitForExit();//等待应用程序退出

            int exitCode = process.ExitCode;//获取应用程序的返回值
            string output = process.StandardOutput.ReadToEnd();//获取应用程序的输出
            string[] args = output.Split(',');//将输出按','分割成多个字符串
            string argS = args[0];
            string argF = args[1];
            string argP = args[2];
            string argRPI = args[3];
        }
    }
}
