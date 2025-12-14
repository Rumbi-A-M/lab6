using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Class1
    {
        protected int a;
        public int A
            {
            get { return a; }
            set { if (value > 0) a = value;
                else a = -value;
            }
        }

    }
}
