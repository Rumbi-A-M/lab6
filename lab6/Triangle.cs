using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Triangle : rectangle
    {

        public override int Area()
        {
            return this.Area() / 2;
        }
    }
}
