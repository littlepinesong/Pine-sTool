using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveAndClickMouse
{
    public partial class intervalDuration : DevExpress.XtraEditors.XtraForm
    {
        public intervalDuration()
        {
            InitializeComponent();
        }

        private void intervalDuration_Load(object sender, EventArgs e)
        {

        }

        #region 委托传值
        public delegate void MyDelegate(string value);

        public event MyDelegate MyEvent;
        
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MyEvent!=null)
            {
                MyEvent(textEdit1.Text);
            }
            this.Close();
        }
    }
}