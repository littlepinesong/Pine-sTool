using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace Pine_sTool.MainControl
{
    public partial class XtraTableControl : DevExpress.XtraEditors.XtraUserControl
    {
        //用于包含其它内容的关键控件，切勿删除
        public XtraTableControl()
        {
            InitializeComponent();
        }
        
        private void MainXtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            string name = EArg.Page.Text;//得到关闭的选项卡的Text
            foreach (XtraTabPage page in MainXtraTabControl.TabPages)//遍历得到和关闭选项卡一样的Text
            {
                if (page.Text == name)
                {
                    MainXtraTabControl.TabPages.Remove(page);
                    page.Dispose();
                    return;
                }
            }
        }
    }
}
