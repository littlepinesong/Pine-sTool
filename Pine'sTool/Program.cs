using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pine_sTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Press Esc key to exit...");
            XtraMessageBox.Show("按下Esc+Q键即可退出本程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("按下Esc键可退出本程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //应该要为其单独创建一个运行进程
            AutoResetEvent resetEvent = new AutoResetEvent(false);

            // 注册全局键盘钩子
            IntPtr hookId = SetHook(_proc);

            Pine_sTool.MainControl.ControlPanel controlPanel = new MainControl.ControlPanel();
            //提供一个回调函数来处理按F8线程终止
            Action onThreadTerminate = () =>
            {
                //controlPanel.AbortThread();
                MessageBoxOptions options = MessageBoxOptions.DefaultDesktopOnly;
                //DevExpress.XtraEditors.XtraMessageBox.Show("鼠标点击程序线程已终止", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                MessageBox.Show("鼠标点击程序\r\n线程已终止", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,options);
            };
            //在类中订阅回调函数（这个地方是自身订阅自身事件）,用于终止鼠标点击程序
            Program.OnthreadTerminate += onThreadTerminate;

            Action<int> showKeyOnScreen = (e) =>
            {
                //将整数值转换为Keys枚举中的值
                Keys key = (Keys)e;
                //controlPanel.ShowMessage($"KeyCode: {e.ToString()},所按按键：{key},总计：{Properties.Settings.Default.WholeKeyValue} {key}");
                //controlPanel.ShowMessage($"KeyCode: {e.ToString()},所按按键：{key}");
                //Properties.Settings.Default.WholeKeyValue += $" {key}";
                Properties.Settings.Default.Save();
            };
            //在类中订阅回调函数（同样是自身订阅自身事件），用于在主界面中记录按键
            Program.ShowKeyOnScreen += showKeyOnScreen;

            Application.Run(controlPanel);

            // 卸载全局键盘钩子
            UnhookWindowsHookEx(hookId);
        }
        #region 封装的关闭程序快捷键方法
        public static event Action OnthreadTerminate;//在类中订阅回调函数（这个地方是自身订阅自身事件）,用于终止鼠标点击程序
        public static event Action<int> ShowKeyOnScreen;//在类中订阅回调函数（同样是自身订阅自身事件），用于在主界面中记录按键
        //定义静态字段来保存回调函数的引用
        private static LowLevelKeyboardProc _proc = HookCallback;

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101; // WM_KEYUP消息的常量值
        private const int VK_ESCAPE = 0x1B;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        /// <summary>
        /// 按下ESC退出程序
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        //private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        //{
        //    if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
        //    {
        //        int vkCode = Marshal.ReadInt32(lParam);
        //        Console.WriteLine("KeyCode: {0}", vkCode);
        //        //在主界面上记录所按按键
        //        ShowKeyOnScreen?.Invoke(vkCode);

        //        if (vkCode == VK_ESCAPE)//按Esc退出程序
        //        {
        //            //Application.Exit();//由于进入无限循环时使用Application.Exit()无法退出，所以使用强制停止
        //            //强制停止当前进程
        //            Process.GetCurrentProcess().Kill();
        //            return new IntPtr(1);//拦截消息，防止其他程序接收到该消息
        //        }
        //        if (vkCode == 119)//按下F8
        //        {
        //            //不行，这样把整个进程都杀掉了，和按Esc的效果一样了。
        //            //Process.GetProcessById(Pine_sTool.DetailedFunctionalities.MouseClickProgram.MouseClickClass.GetProcessID()).Kill();
        //            try
        //            {
        //                //按下F8键，触发事件，执行回调函数来终止线程
        //                OnthreadTerminate?.Invoke();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //            return new IntPtr(1);//拦截消息，防止其他程序接收到该消息
        //        }
        //    }
        //    return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        //}

        private static bool escPressed = false;
        private static bool qPressed = false;
        /// <summary>
        /// 按下ESC+Q退出程序
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Console.WriteLine("KeyCode: {0}", vkCode);
                //在主界面上记录所按按键
                ShowKeyOnScreen?.Invoke(vkCode);

                if (vkCode == VK_ESCAPE)
                {
                    escPressed = true;
                }
                else if (vkCode == (int)'Q')
                {
                    qPressed = true;
                }

                // 检查是否同时按下ESC和Q键
                if (escPressed && qPressed)
                {
                    // 强制停止当前进程
                    Process.GetCurrentProcess().Kill();
                    return new IntPtr(1); // 拦截消息，防止其他程序接收到该消息
                }
            }
            else if (wParam == (IntPtr)WM_KEYUP)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode == VK_ESCAPE)
                {
                    escPressed = false;
                }
                else if (vkCode == (int)'Q')
                {
                    qPressed = false;
                }
            }

            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }

        //点击鼠标的进程
        #endregion 
    }
}
