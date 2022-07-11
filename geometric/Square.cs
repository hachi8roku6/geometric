using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    class Square : TwoDimensionalShape
    {
        public Square(double a) : base(a)
        {

        }

        public override double Area
        {
            get { return Math.Pow(base.side,2); }
        }

        public override string ToString()
        {
            return String.Format("Square") + base.ToString();
        }
    }
}
