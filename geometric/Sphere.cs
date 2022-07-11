using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    class Sphere : ThreeDimensionalShape
    {
        public Sphere(double a):base(a)
        {

        }
        public override double Area
        {
            get { return Math.PI * 4 * Math.Pow(base.side, 2); }
        }
        public override double Volume
        {
            get { return 4 * Math.PI * 4 * Math.Pow(base.side, 3); }
        }
        public override string ToString()
        {
            return String.Format("Sphere") + base.ToString();
        }
    }
}
