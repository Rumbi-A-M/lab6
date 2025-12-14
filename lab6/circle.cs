using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Circle: square
    {
        public override int  Area()
        {
            return base.Area() * (int)Math.PI;
        }
    }
}
