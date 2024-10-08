using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UInew
{
    public class IntEventArgs:EventArgs
    {
        public int Value
        {
            get;
            private set;
        }

        public IntEventArgs(int value)
        {
            Value = value;
        }
    }
}
