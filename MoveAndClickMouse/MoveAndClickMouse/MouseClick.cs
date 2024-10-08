﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace MoveAndClickMouse
{
    public static class MouseClick
    {
        #region 导入Windows API函数
        [DllImport("user32.dll",CharSet=CharSet.Auto)]
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
        #endregion

        private static void mClick(int i,int mun,double duration)
        {
            for (int j = 0; j < mun; j++)
            {
                Console.WriteLine($"第{i}次点击");
                //DialogResult result = MessageBox.Show($"第{i}次点击", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEECENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
                i++;
                Thread.Sleep((int)duration);
            }            
        }

        #region 循环点击
        public static void Click(double duration)
        {
            int i = 1;
            while (true)
            {
                #region 处理点击
                //创建一个AutoResetEvent对象，用于等待子线程完成
                AutoResetEvent resetEvent = new AutoResetEvent(false);
                
                //创建一个新线程，并在其中显示消息框
                Thread thread = new Thread(() =>
                {
                    //位置移动语句有几条num就填几
                    mClick(i, 4,duration);                    
                    //设置事件状态，以便主线程知道子线程已完成
                    resetEvent.Set();
                });
                #endregion

                #region 处理移动
                //创建一个AutoResetEvent对象，用于等待子线程完成
                AutoResetEvent resetEvent2 = new AutoResetEvent(false);

                //创建一个新线程，并在其中处理移动
                Thread thread2 = new Thread(() =>
                {
                    #region 鼠标呈圆周运动移动
                    ////获取屏幕中心点
                    //Point center = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);

                    ////设置半径和角度步长
                    //double radius = 200;
                    //double angleStep = 0.1;

                    ////计算新的鼠标位置并设置鼠标(呈圆周运动)
                    //for (double angle = 0; angle < 360; angle += angleStep)
                    //{
                    //    double radians = angle * Math.PI / 180;
                    //    int x = (int)(center.X + radius * Math.Cos(radians));
                    //    int y = (int)(center.Y + radius * Math.Sin(radians));
                    //    Cursor.Position = new Point(x, y);
                    //    Thread.Sleep((int)duration);//降低移动速度(120000指每两分钟才移动一次)
                    //}
                    #endregion

                    #region 在鼠标当前位置移动
                    //获取鼠标当前位置,并向左向上移动1像素（计算机屏幕坐标原点在左上角）
                    POINT p;
                    GetCursorPos(out p);
                    Cursor.Position = new Point(1275, 740);
                    //Cursor.Position = new Point(1283, 728);
                    //Thread.Sleep((int)duration);
                    //Cursor.Position = new Point(p.X-1, p.Y-1);
                    //Thread.Sleep((int)duration);
                    //Cursor.Position = new Point(p.X+1, p.Y+1);
                    //Thread.Sleep((int)duration);
                    //Cursor.Position = new Point(p.X, p.Y);
                    Thread.Sleep((int)duration);
                    #endregion

                    //设置事件状态，以便主线程知道子线程已完成
                    resetEvent2.Set();
                });
                #endregion

                //启动新线程
                thread.Start();
                thread2.Start();

                //在主线程中等待指定的时间后，如果子线程仍在运行，则尝试关闭消息框，其中!resetEvent.WaitOne(120000)中的120000可以决定点击间隔时间，!resetEvent2.WaitOne(120000)影响移动的总时长
                if (!resetEvent.WaitOne((int)duration) && !resetEvent2.WaitOne((int)duration)) 
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
        #endregion
    }
}
