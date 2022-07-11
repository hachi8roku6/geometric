using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    class Circle : TwoDimensionalShape
    {
        public Circle(double a) : base(a)
        {

        }

        public override double Area
        {
            get { return Math.PI * base.side; }
        }

        public override string ToString()
        {
            return String.Format("Circle") + base.ToString();
        }
    }
}
