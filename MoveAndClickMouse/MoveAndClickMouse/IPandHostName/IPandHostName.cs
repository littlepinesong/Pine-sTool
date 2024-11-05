using System;
using System.Net;
using System.Windows.Forms;

namespace MoveAndClickMouse.IPandHostName
{
    public partial class IPandHostName : DevExpress.XtraEditors.XtraForm
    {
        public delegate void FormMsgHandle(string strmsg);

        public event FormMsgHandle ShowMessage;

        public IPandHostName()
        {
            InitializeComponent();
        }

        private void IPandHostName_Load(object sender, EventArgs e)
        {
        }

        private void IPtoHostNameSimpleButton_Click(object sender, EventArgs e)
        {
            IPHostEntry hostInfo;
            try
            {
                hostInfo = Dns.Resolve(this.IPtextEdit.Text);
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
                ShowMessage($"根据IP地址：{IPtextEdit.Text}");
                ShowMessage(ey.Message);
                this.IPtextEdit.Focus();
                this.IPtextEdit.SelectAll();
                return;
            }
            this.HostNameTextEdit.Text = hostInfo.HostName;
            ShowMessage($"根据IP地址：{IPtextEdit.Text}");
            ShowMessage($"获取到主机名：{HostNameTextEdit.Text}");
        }

        private void HostNametoIPsimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(HostNameTextEdit1.Text);
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)//返回IPv4地址
                    {
                        IPtextEdit1.Text = ip.ToString();
                        ShowMessage($"根据主机名：{HostNameTextEdit1.Text}");
                        ShowMessage($"获取到IP地址：{IPtextEdit1.Text}");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ShowMessage($"根据主机名：{HostNameTextEdit1.Text}");
                ShowMessage(ex.Message);
                this.HostNameTextEdit1.Focus();
                this.HostNameTextEdit1.SelectAll();
                return;
            }
        }
    }
}