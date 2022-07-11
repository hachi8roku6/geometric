using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    abstract class TwoDimensionalShape : shape
    {
        public TwoDimensionalShape(double a) : base(a)
        {

        }
        public override abstract double Area { get; }
        public override string ToString()
        {
            return string.Format(" is a Two Dimensional Shape");
        }
    }
}
