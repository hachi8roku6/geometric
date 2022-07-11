using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    abstract class ThreeDimensionalShape : shape
    {
        public ThreeDimensionalShape(double a) : base(a)
        {

        }
        public override abstract double Area { get; }
        public abstract double Volume { get; }
        public override string ToString()
        {
            return string.Format(" is a Three Dimensional Shape");
        }
    }
}
