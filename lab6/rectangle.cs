using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class rectangle : Class1
    {

        protected int b;
        public int B
        {
            get { return b; }
            set { b = value > 0 ? value : -value; }

            public virtual int Area()
        {
            return a * b;
        }
    

    }
}
