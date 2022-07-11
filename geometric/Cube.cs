using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    class Cube:ThreeDimensionalShape
    {
        public Cube(double a) : base(a)
        {

        }
        public override double Area
        {
            get { return 6 * Math.Pow(base.side, 2); }
        }
        public override double Volume
        {
            get { return  Math.Pow(base.side, 3); }
        }
        public override string ToString()
        {
            return String.Format("Cube") + base.ToString();
        }
    }
}
