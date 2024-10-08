using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UInew.JHKZ_DLL1.UI.质量问题;

namespace UInew
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int S, F, P;
            try
            {
                string myArgs = args[0];
                string[] myArgValues = myArgs.Split(',');
                S = int.Parse(myArgValues[0]);
                F = int.Parse(myArgValues[1]);
                P = int.Parse(myArgValues[2]);
            }
            catch (Exception)
            {
                S = 1;
                F = 1;
                P = 1;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UInew_FrmSFPnew(S,F,P));

            //由于要接受到返回值，因此额外进行设定
            var context = new UInew_FrmSFPnewApplicationContext(S, F, P);

            //Application.Run(context);

            //获取返回值
            int reS = context.ReturnValueS;
            int reF = context.ReturnValueF;
            int reP = context.ReturnValueP;
            int reRPI = context.ReturnValueRPI;

            Console.WriteLine($"{reS},{reF},{reP},{reRPI}");
            //退出程序，并返回0
            Environment.Exit(0);

            
        }
    }

    class UInew_FrmSFPnewApplicationContext : ApplicationContext
    {
        public int ReturnValueS { get; set; }
        public int ReturnValueF { get; set; }
        public int ReturnValueP { get; set; }
        public int ReturnValueRPI { get; set; }


        public UInew_FrmSFPnewApplicationContext(int S,int F,int P)
        {
            //创建应用窗体
            UInew_FrmSFPnew form = new UInew_FrmSFPnew(S, F, P);
            //显示窗体
            form.ShowDialog();
            //在窗体关闭时，获取其返回值
            if (form.DialogResult == DialogResult.OK)
            {
                ReturnValueS = form.ReturnS;
                ReturnValueF = form.ReturnF;
                ReturnValueP = form.ReturnP;
                ReturnValueRPI = form.ReturnRPI;
            }
            else
            {
                ReturnValueS = 0;
                ReturnValueF = 0;
                ReturnValueP = 0;
                ReturnValueRPI = 0;
                ExitThread();
            }

            //不要忘了在这里也要退出应用程序！！！！！！！
            this.ExitThreadCore();
            ExitThread();
        }
    }
}
