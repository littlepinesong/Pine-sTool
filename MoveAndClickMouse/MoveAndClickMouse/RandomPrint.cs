using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using MoveAndClickMouse;
using System.Windows.Forms;
using System.Threading;

namespace MoveAndClickMouse
{
    class RandomPrint
    {
        public delegate void FormMsgHandle(string strmsg);
        public event FormMsgHandle ShowMessage;
        public void randomPrint()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string[] excelFiles = Directory.GetFiles(desktopPath, "*.xlsx");

            Random random = new Random();

            foreach (string excelFile in excelFiles)
            {
                Console.WriteLine($"Reading data from {excelFile}...");
                ShowMessage($"Reading data from {excelFile}...");

                Excel.Application excel = null;
                Excel.Workbook workbook = null;

                try
                {
                    excel = new Excel.Application();
                    workbook = excel.Workbooks.Open(excelFile);

                    //随机选择一个工作表
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[random.Next(1, workbook.Sheets.Count + 1)];

                    StringBuilder sb = new StringBuilder();//可变字符字符串
                    int rowCount = worksheet.UsedRange.Rows.Count;
                    int columnCount = worksheet.UsedRange.Columns.Count;

                    //将工作表中的单元格内容读取为字符串
                    for (int i = 1; i < rowCount; i++)
                    {
                        for (int j = 1; j < columnCount; j++)
                        {
                            Excel.Range cell = worksheet.Cells[i, j];
                            if (cell != null && cell.Value2 != null)
                            {
                                sb.Append(cell.Value2.ToString());
                            }
                        }
                    }

                    ////随机选择一部分字符串并打印到控制台
                    //string allText = sb.ToString();
                    //int outputLength = random.Next(1, allText.Length + 1);
                    //while (outputLength > 0)
                    //{
                    //    int startIndex = random.Next(0, allText.Length - outputLength + 1);
                    //    string outputText = allText.Substring(startIndex, outputLength);
                    //    Console.WriteLine(outputText);
                    //    outputLength -= outputText.Length;
                    //}

                    //选择全部字符串并打印到控制台
                    string allText = sb.ToString();
                    int lineLength = 20;//每行包含的字符数
                    usedPrint(allText, lineLength);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error:{ex.Message}");
                    ShowMessage($"Error:{ex.Message}");
                }
                finally
                {
                    if (workbook != null)
                    {
                        workbook.Close(false);
                        Marshal.ReleaseComObject(workbook);
                    }
                    if (excel != null)
                    {
                        excel.Quit();
                        Marshal.ReleaseComObject(excel);
                    }
                }
            }
            Console.WriteLine("Done.");
            ShowMessage("Done.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="allText"></param>
        /// <param name="lineLength"></param>
        private void usedPrint(string allText, int lineLength)
        {
            for (int i = 0; i < allText.Length; i += lineLength)
            {
                int length = Math.Min(lineLength, allText.Length - i);
                string line = allText.Substring(i, length);
                Console.WriteLine(line);
                ShowMessage(line);
            }
        }
    }
}
