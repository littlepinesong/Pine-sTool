using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace Pine_sTool.DetailedFunctionalities.MouseClickProgram
{
    public static class MouseClickClass
    {
        public delegate void FormMsgHandle(string strmsg);

        public static event FormMsgHandle ShowMessage;

        #region 导入Windows API函数

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT p);

        private const uint WM_CLOSE = 0x0010;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEECENTF_LEFTUP = 0x04;

        #endregion 导入Windows API函数

        private static void mClick(int syncClickNum, double spanDuration)
        {
            for (int j = 0; j < syncClickNum; j++)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEECENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
                Thread.Sleep((int)spanDuration);
            }
        }

        #region 循环点击

        public static void Click(string mode, int spanDuration, int X_axis, int Y_axis, int syncClickNum)
        {
            int i = 1;
            int compare = 0;
            bool stopLoop = false;//是否终止鼠标循环点击的标志
            while (!stopLoop)
            {
                #region 处理点击

                //创建一个AutoResetEvent对象，用于等待子线程完成
                AutoResetEvent resetEvent = new AutoResetEvent(false);

                //创建一个新线程，并在其中显示消息框
                Thread thread = new Thread(() =>
                {
                    if (compare == i)
                    {
                        ShowMessage($"子线程第{i + 1}次点击");
                        compare = i + 1;
                    }
                    else
                    {
                        ShowMessage($"子线程第{i}次点击");
                        compare = i;
                    }
                    //位置移动语句有几条num就填几
                    mClick(syncClickNum, spanDuration);
                    i++;
                    //设置事件状态，以便主线程知道子线程已完成
                    resetEvent.Set();
                });

                #endregion 处理点击

                #region 处理移动

                //创建一个AutoResetEvent对象，用于等待子线程完成
                AutoResetEvent resetEvent2 = new AutoResetEvent(false);
                //创建一个新线程，并在其中处理移动
                Thread thread2 = new Thread(() =>
                {
                    if (mode == "指定位置点击")
                    {
                        #region 在鼠标当前位置移动

                        //设置鼠标目标位置（计算机屏幕坐标原点在左上角）
                        System.Windows.Forms.Cursor.Position = new Point(X_axis, Y_axis);
                        Thread.Sleep((int)spanDuration);

                        #endregion 在鼠标当前位置移动
                    }
                    //设置事件状态，以便主线程知道子线程已完成
                    resetEvent2.Set();
                });

                #endregion 处理移动

                //启动新线程
                thread.Start();
                thread2.Start();

                //在主线程中等待指定的时间后，如果子线程仍在运行，则尝试关闭消息框，其中!resetEvent.WaitOne(120000)中的120000可以决定点击间隔时间，!resetEvent2.WaitOne(120000)影响移动的总时长
                if (!resetEvent.WaitOne((int)spanDuration) && !resetEvent2.WaitOne((int)spanDuration))
                {
                    //查找MessageBox窗口句柄并发送WM_CLOSE消息
                    IntPtr hwnd = FindWindow("#32770", "提示");
                    if (hwnd != IntPtr.Zero)
                    {
                        SendMessage(hwnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                    }
                    thread2.Abort();
                }
            }
        }

        #endregion 循环点击
    }
}