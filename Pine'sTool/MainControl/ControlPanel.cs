using DevExpress.XtraTab;
using Pine_sTool.DetailedFunctionalities.IntranetDataDownload;
using Pine_sTool.DetailedFunctionalities.Windchill登陆器;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Pine_sTool.MainControl
{
    public partial class ControlPanel : DevExpress.XtraEditors.XtraForm
    {
        private DateTime _day = DateTime.Today;
        XtraTableControl xtraTableControl1 = new XtraTableControl();

        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            ShowMessage("程序启动：Pine's control panel");
            ShowMessage($"登录域：{Environment.UserDomainName}");
            ShowMessage($"登录用户：{Environment.UserName}");
            ShowMessage($"自身进程号：{Process.GetCurrentProcess().Id.ToString()}");
            ShowMessage($"自身线程号：{Thread.CurrentThread.ManagedThreadId.ToString()}");
            PineNotifyIcon.Visible = false;
            SeleniumBarEditItem.EditValue = true;
            HandleImage();
            InitializeImageTimer();

            layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private Dictionary<string, string> elementDic = new Dictionary<string, string>();

        private void LoadFrmPage(Form Fm, string pname)
        {
            MainViewlayoutControl.Controls.Clear();
            MainViewlayoutControl.Controls.Add(xtraTableControl1);
            foreach (XtraTabPage page1 in xtraTableControl1.MainXtraTabControl.TabPages)
            {
                if (page1.Text == pname)
                {
                    xtraTableControl1.MainXtraTabControl.SelectedTabPage = page1;//显示该页
                    return;
                }
            }
            //增加tabpage
            XtraTabPage page = new XtraTabPage();
            page.Name = pname;
            page.Text = pname;

            Fm.TopLevel = false;
            Fm.Dock = System.Windows.Forms.DockStyle.Fill;
            Fm.FormBorderStyle = FormBorderStyle.None;
            Fm.Visible = true;
            //Fm.Dock = DockStyle.Fill;
            page.Controls.Add(Fm);//添加要增加的控件
            xtraTableControl1.MainXtraTabControl.TabPages.Add(page);
            xtraTableControl1.MainXtraTabControl.SelectedTabPage = page;//显示该页
            Fm.Show();
            this.Focus();


        }

        public void ShowMessage(string message)
        {
            Application.DoEvents();
            message = DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒") + ":  " + message;
            //MessageListBoxControl.Items.Add(message);
            //MessageListBoxControl.SelectedIndex = MessageListBoxControl.Items.Count - 1;
            if (MessageListBoxControl.InvokeRequired)
            {
                // 因为调用方法于创建控件所在的线程以外的线程中，要使另一个线程的数据能能够传递给这个线程的控件进行使用，从而实现子线程访问
                MessageListBoxControl.Invoke(
                    new Action(
                        () =>
                        {
                            if (MessageListBoxControl.Items.Count > 5000)
                            {
                                MessageListBoxControl.Items.Clear();
                            }
                            MessageListBoxControl.Items.Add(message);
                            MessageListBoxControl.SelectedIndex = MessageListBoxControl.Items.Count - 1;
                        }
                        )
                    );
            }
            else
            {
                if (MessageListBoxControl.Items.Count > 5000)
                {
                    MessageListBoxControl.Items.Clear();
                }
                MessageListBoxControl.Items.Add(message);
                MessageListBoxControl.SelectedIndex = MessageListBoxControl.Items.Count - 1;
            }

            MessageLogger.Instance.WriteLog(message);
        }

        //private void OldToolsSimpleButton_Click(object sender, EventArgs e)
        //{
        //    MoveAndClickMouse.rotationPrint fm = new MoveAndClickMouse.rotationPrint();
        //    DialogResult result = MessageBox.Show("旧版操作面板，存在诸多bug，是否继续？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (result == DialogResult.Yes) { fm.Show(); }
        //    else { }
        //}

        //private void HandleDuplicateRowsSimpleButton_Click(object sender, EventArgs e)
        //{
        //    Pine_sTool.DetailedFunctionalities.HandleDuplicateRows fm = new DetailedFunctionalities.HandleDuplicateRows();
        //    fm.ShowMessage += new DetailedFunctionalities.HandleDuplicateRows.ControlPanelMessage(ShowMessage);
        //    fm.Show();
        //}

        //private void ProcessControlSimpleButton_Click(object sender, EventArgs e)
        //{
        //    Pine_sTool.DetailedFunctionalities.ProcessControl fm = new DetailedFunctionalities.ProcessControl();
        //    fm.ShowMessage += new DetailedFunctionalities.ProcessControl.ControlPanelMessage(ShowMessage);
        //    fm.Show();
        //}

        private Thread targetThread;
        private readonly object lockObj = new object();
        private bool isRunning = false;
        private int threadId;

        public void AbortThread()
        {
            lock (lockObj) // 同步以避免竞态条件
            {
                if (isRunning) // 确保线程仍在运行中
                {
                    targetThread.Abort(); // 请求线程终止
                    isRunning = false; // 设置标志表示线程已终止
                }
            }
        }

        //private void MouseClickButtton_Click(object sender, EventArgs e)
        //{
        //    DevExpress.XtraEditors.XtraMessageBox.Show("按下“F8”键可终止鼠标点击程序\r\n按下“Esc”键可退出本程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    Pine_sTool.DetailedFunctionalities.MouseClickProgram.ClickSettingForm fm = new DetailedFunctionalities.MouseClickProgram.ClickSettingForm();
        //    fm.myEvent += new DetailedFunctionalities.MouseClickProgram.ClickSettingForm.MyDelegate(ApplySetting);
        //    fm.ShowDialog();
        //    try
        //    {
        //        if (elementDic.Count > 0)
        //        {
        //            if (elementDic["最小化到通知栏"] == "是")
        //            {
        //                this.WindowState = FormWindowState.Minimized;
        //                PineNotifyIcon.Visible = true;
        //                //this.Hide();
        //            }
        //            //创建一个新线程，处理点击事件
        //            targetThread = new Thread(() =>
        //            {
        //                HandleClick();
        //                //resetEvent.Set();
        //            });
        //            targetThread.Name = "MouseClickThread";
        //            targetThread.Start();
        //            isRunning = true;
        //            threadId = targetThread.ManagedThreadId;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void HandleClick()
        {
            string mode = elementDic["点击模式"];
            int spanDuration;
            int switchScale = 1000;//时间转换比例
            bool hasSpanDuration = int.TryParse(elementDic["指定位置点击-点击间隔"], out spanDuration);
            if (!hasSpanDuration) { spanDuration = 30; }
            int X_axis;
            bool hasX_axis = int.TryParse(elementDic["指定位置点击-X轴"], out X_axis);
            if (!hasX_axis) { X_axis = 1275; }
            int Y_axis;
            bool hasY_axis = int.TryParse(elementDic["指定位置点击-Y轴"], out Y_axis);
            if (!hasY_axis) { Y_axis = 740; }
            int syncClickNum;
            bool hasSyncClickNum = int.TryParse(elementDic["同时刻点击次数"], out syncClickNum);
            if (!hasSyncClickNum) { syncClickNum = 1; }
            Pine_sTool.DetailedFunctionalities.MouseClickProgram.MouseClickClass.ShowMessage += (msg) =>
            {
                ShowMessage(msg);
            };
            Pine_sTool.DetailedFunctionalities.MouseClickProgram.MouseClickClass.Click(mode, spanDuration * switchScale, X_axis, Y_axis, syncClickNum);
        }

        private void ApplySetting(Dictionary<string, string> dic)
        {
            elementDic = dic;
        }

        private void PineNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PineNotifyIcon.Visible = false;
        }

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WholeKeyValue = null;
            Properties.Settings.Default.Save();
        }

        private void ProcessControlSimpleButton_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pine_sTool.DetailedFunctionalities.ProcessControl fm = new DetailedFunctionalities.ProcessControl();
            fm.ShowMessage += new DetailedFunctionalities.ProcessControl.ControlPanelMessage(ShowMessage);
            fm.Show();
        }

        private void HandleDuplicateRowsSimpleButton_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pine_sTool.DetailedFunctionalities.HandleDuplicateRows fm = new DetailedFunctionalities.HandleDuplicateRows();
            fm.ShowMessage += new DetailedFunctionalities.HandleDuplicateRows.ControlPanelMessage(ShowMessage);
            fm.Show();
        }

        private void MouseClickButtton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("按下“F8”键可终止鼠标点击程序\r\n按下“Esc+Q”键可退出本程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Pine_sTool.DetailedFunctionalities.MouseClickProgram.ClickSettingForm fm = new DetailedFunctionalities.MouseClickProgram.ClickSettingForm();
            fm.myEvent += new DetailedFunctionalities.MouseClickProgram.ClickSettingForm.MyDelegate(ApplySetting);
            fm.ShowDialog();
            try
            {
                if (elementDic.Count > 0)
                {
                    if (elementDic["最小化到通知栏"] == "是")
                    {
                        this.WindowState = FormWindowState.Minimized;
                        PineNotifyIcon.Visible = true;
                        //this.Hide();
                    }
                    //创建一个新线程，处理点击事件
                    targetThread = new Thread(() =>
                    {
                        HandleClick();
                        //resetEvent.Set();
                    });
                    targetThread.Name = "MouseClickThread";
                    targetThread.Start();
                    isRunning = true;
                    threadId = targetThread.ManagedThreadId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OldToolsSimpleButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoveAndClickMouse.rotationPrint fm = new MoveAndClickMouse.rotationPrint();
            DialogResult result = MessageBox.Show("旧版操作面板，存在诸多bug，是否继续？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { fm.Show(); }
            else { }
        }

        private void AutoLoginBigDataPlatForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Environment.UserName == "176630") { }
            else
            {
                MessageBox.Show("无权限");
                return;
            }
            GlobalValue._isTest = false;
#if DEBUG
            timer2.Interval = 1 * 1000;   //测试计时器时间为10秒
#else
             timer2.Interval = 60 * 1000;   // 正常运行计时器为60秒
#endif
            TimerStart();
        }

        private void TimerStart()
        {
            timer2.Start();
            MessageListBoxControl.Text = "      计时器状态：  已启动";
            ShowMessage($"定时器启动");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //1、处理每日自动登录大数据平台
            Thread loginThread = new Thread(new ParameterizedThreadStart(ThreadLoginBigDataPlatForm));
            loginThread.Start(null);
        }

        private void ThreadLoginBigDataPlatForm(object obj)
        {
            DateTime day = DateTime.Today;
            //如果天数不一样或者今天没登过
            if (!day.Equals(_day) || !GlobalValue._isLogin)
            {
                //_day = day;
                //_isLogin = true;
                AutoLoginBigDataPlatform autoLoginBigDataPlatform = new AutoLoginBigDataPlatform(GlobalValue._isTest);
                autoLoginBigDataPlatform.ShowMessage += new AutoLoginBigDataPlatform.ControlPanelMessage(ShowMessage);
                autoLoginBigDataPlatform.LoginBigDataPlatform(ref _day, ref GlobalValue._isLogin);
            }
            else
            {
                ShowMessage("...");
            }
        }

        private void sotpAllAutoOptions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Environment.UserName == "176630") { }
            else
            {
                MessageBox.Show("无权限");
                return;
            }
            timer2.Stop();
            MessageListBoxControl.Text = "      计时器状态：  已停止";
            ShowMessage($"定时器停止");

            try
            {
                string processPath = AppDomain.CurrentDomain.BaseDirectory;
                Console.WriteLine(processPath);
                string CrawlerPath = Path.Combine(processPath, "FinalMain.exe");
                //关闭脚本(内网出场资料下载)
                Process[] processes = Process.GetProcessesByName("FinalMain");
                foreach (Process process in processes)
                { process.Kill(); }
            }
            catch (Exception) { }
        }

        private void TestAutoLoginBigDataPlatForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Environment.UserName == "176630") { }
            else
            {
                MessageBox.Show("无权限");
                return;
            }
            GlobalValue._isTest = true;
            timer2.Interval = 10 * 1000;   //测试计时器时间为10秒
            TimerStart();
        }

        private void SeleniumBarEditItem_EditValueChanged(object sender, EventArgs e)
        {
            GlobalValue.IsSeleniumShow = (bool)SeleniumBarEditItem.EditValue;
        }

        #region 处理图片

        private void HandleImage()
        {
            GreatImageSlider.ImageList = imageCollection1;
            GreatImageSlider.AnimationTime = 1000;
            ImageHelper.AddImagesFromResource(imageCollection1);
        }

        private void InitializeImageTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 3000; // 设置轮播间隔，单位为毫秒，这里设置为3秒
            timer1.Tick += Timer1_Tick;
            timer1.Start(); // 开始定时器
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //// 每次定时器触发时，切换到下一张图片
            //GreatImageSlider.SlideNext();

            // Get the total number of images in the ImageSlider
            int totalImages = imageCollection1.Images.Count;

            // Check if there are any images in the ImageSlider
            if (totalImages > 0)
            {
                // Get the current index
                int currentIndex = GreatImageSlider.CurrentImageIndex;

                // Determine the next index
                int nextIndex = (currentIndex + 1) % totalImages;

                // Set the next index
                GreatImageSlider.SetCurrentImageIndex(nextIndex);
            }

            #endregion 处理图片
        }

        private void NWZL_DownloadBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Environment.UserName == "176630") { }
            else
            {
                MessageBox.Show("无权限");
                return;
            }
            PythonConfig pythonConfig = new PythonConfig();
            pythonConfig.Show();
        }

        private void DownloadTableBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DownloadTable downloadTable = new DownloadTable();
            downloadTable.Show();
        }

        private void WindchillLoginButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Environment.UserName == "176630") { }
            else
            {
                MessageBox.Show("无权限");
                return;
            }
            WindchilLogin windchilLogin = new WindchilLogin();
            //windchilLogin.TopMost = true;
            windchilLogin.Show();
        }

        private void HandleJSON_SimpleButton_Click(object sender, EventArgs e)
        {
            //DataTable dt_SCZJH = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_SCZJH();
            //DataTable dt_SCZJH_nodeList = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_SCZJH_nodeList();
            //DataTable dt_JDCX = Pine_sTool.DetailedFunctionalities.JSON.JSON_TO_DataTable.Convert_JDCX();

            //gridControl_SCZJH.DataSource = dt_SCZJH;
            //gridControl_JDB.DataSource = dt_SCZJH_nodeList;
            //gridControl_JDCX.DataSource = dt_JDCX;
        }

        private void MES_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Environment.UserName == "176630") { }
            else
            {
                MessageBox.Show("无权限");
                return;
            }
            //Pine_sTool.DetailedFunctionalities.MES.MES_Manage form = new DetailedFunctionalities.MES.MES_Manage();
            Pine_sTool.DetailedFunctionalities.MES.MES_Manage_New form = new DetailedFunctionalities.MES.MES_Manage_New();
            form.Show();
        }

        private void PLM_LCSJ_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DetailedFunctionalities.PLM.流程审计.LCSJGL fm = new DetailedFunctionalities.PLM.流程审计.LCSJGL();
            LoadFrmPage(fm, "流程审计");
            //fm.Show();
        }

        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //}
    }

    public static class GlobalValue
    {
        public static bool _isLogin = false;
        public static bool _isTest = false;
        public static bool IsSeleniumShow = true;
    }
}