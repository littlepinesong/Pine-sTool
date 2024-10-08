using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveAndClickMouse.Tools
{
    class AuxiliaryTools
    {
        public void Show_Form(string FrmName,int n)
        {
            if (n==1)
            {
                if (FrmName=="计算器")
                {
                    System.Diagnostics.Process.Start("calc.exe");
                }
                if (FrmName=="记事本")
                {
                    System.Diagnostics.Process.Start("notepad.exe");
                }
            }
        }
    }
}
