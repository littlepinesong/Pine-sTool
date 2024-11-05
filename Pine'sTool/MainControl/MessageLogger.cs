using System;
using System.IO;

namespace Pine_sTool.MainControl
{
    internal class MessageLogger
    {
        private static object logLock;
        private static MessageLogger _instance;
        private static string logFileName;
        public static string logFilePath;

        private MessageLogger()
        { }

        public static MessageLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MessageLogger();
                    logLock = new object();
                    logFileName = Guid.NewGuid() + ".log";
                }
                return _instance;
            }
        }

        public void WriteLog(string logContent, string fileName = null)
        {
            try
            {
                string basePath = @"C:\松的工具系统日志";
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }
                string dataString = DateTime.Now.ToString("yyyy-MM-dd");
                if (!Directory.Exists(basePath + "\\Log\\" + dataString))
                {
                    Directory.CreateDirectory(basePath + "\\Log\\" + dataString);
                }

                string[] logText = new string[] { logContent };
                if (!string.IsNullOrEmpty(fileName))
                {
                    fileName = fileName + "_" + logFileName;
                }
                else
                {
                    fileName = logFileName;
                }

                lock (logLock)
                {
                    logFilePath = basePath + "\\Log\\" + dataString + "\\" + fileName;
                    File.AppendAllLines(logFilePath, logText);
                }
            }
            catch (Exception) { }
        }
    }
}