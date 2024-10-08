using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Pine_sTool.DetailedFunctionalities.MES
{
    class 直接扒MES界面的HTML转化为DataTable
    {
        // 1. 通过浏览器的开发者工具，查看网页的HTML代码
        // 2. 将HTML代码复制到剪贴板
        // 3. 使用DataTable的ReadHtml方法，将HTML代码转化为DataTable
        // 4. 将DataTable转化为Excel文件
        // 5. 使用Excel文件进行数据处理
        // 6. 将处理后的数据转化为DataTable
        // 7. 使用DataTable的WriteHtml方法，将DataTable转化为HTML代码
        // 8. 将HTML代码复制到剪贴板
        // 9. 将HTML代码粘贴到MES界面，完成数据更新

        public void Main()
        {
            // 3. 使用DataTable的ReadHtml方法，将HTML代码转化为DataTable
            DataTable dt = new DataTable();
            dt.ReadHtml("HTML代码");

            // 4. 将DataTable转化为Excel文件
            dt.WriteExcel("Excel文件路径");

            // 6. 将处理后的数据转化为DataTable
            DataTable newDt = new DataTable();
            newDt.ReadExcel("Excel文件路径");

            // 7. 使用DataTable的WriteHtml方法，将DataTable转化为HTML代码
            string html = newDt.WriteHtml();

            // 8. 将HTML代码复制到剪贴板
            System.Windows.Clipboard.SetText(html);
        }

        public class DataTable
        {
            public void ReadHtml(string html)
            {
                // 3. 使用DataTable的ReadHtml方法，将HTML代码转化为DataTable
                DataTable dt = new DataTable();
                //打开文件浏览器
                OpenFileDialog openFileDialog = new OpenFileDialog();

            }

            public void WriteExcel(string path)
            {
                // 4. 将DataTable转化为Excel文件
            }

            public void ReadExcel(string path)
            {
                // 6. 将处理后的数据转化为DataTable
            }

            public string WriteHtml()
            {
                // 7. 使用DataTable的WriteHtml方法，将DataTable转化为HTML代码
                return "";
            }
        }
    }
}
