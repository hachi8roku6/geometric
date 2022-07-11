using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric
{
    abstract class shape
    {
        public shape (double sideSize)
        {
            side = sideSize; 
        }

        public double side { get; set; }
        public abstract double Area { get; }
        public abstract override string ToString();
    }
}
