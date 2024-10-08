using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TEST
{
    class Class1
    {
    }
    class Program1
    {
        static void Main()
        {
            var threadClass = new ThreadClass();
            threadClass.StartThread();
            // 在主线程中等待一段时间，然后尝试中止目标线程
            Thread.Sleep(2000);
            if (threadClass.IsThreadRunning)
            {
                Console.WriteLine("Requesting target thread termination...");
                threadClass.AbortThread(); // 请求目标线程终止
                Console.WriteLine("Target thread has been requested to terminate.");
            }
        }
    }
    class ThreadClass
    {
        private Thread targetThread;
        private readonly object lockObj = new object();
        private bool isRunning = false;
        private int threadId;
        public void StartThread()
        {
            targetThread = new Thread(Work);
            targetThread.Name = "TargetThread";
            targetThread.Start();
            isRunning = true;
            threadId = targetThread.ManagedThreadId;
        }
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
        public bool IsThreadRunning => isRunning; // 返回线程是否仍在运行中的标志位
        public void Work()
        {
            try
            {
                // 模拟一些工作...
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Working on thread: " + Thread.CurrentThread.Name);
                    Thread.Sleep(500); // 模拟耗时操作
                }
            }
            catch (ThreadAbortException)
            {
                // 处理线程被中止的情况
                Console.WriteLine("Thread was aborted.");
                isRunning = false; // 设置标志表示线程已终止完成并清理资源
            }
        }
    }
}
