using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace geometric
{
    class Program
    {
        static void Main(string[] args)
        {
            shape[] shape = new shape[4];
            shape[0] = new Square(5);
            shape[1] = new Circle(5);
            shape[2] = new Cube(5);
            shape[3] = new Sphere(5);

            foreach(shape element in shape)
            {
                if (element is TwoDimensionalShape)
                {
                    Console.WriteLine(element);
                    Console.WriteLine(string.Format("The area is {0:N}\n", element.Area));
                }
                else
                {
                    ThreeDimensionalShape threeDshape = (ThreeDimensionalShape)element;
                    Console.WriteLine(element);
                    Console.WriteLine(string.Format("The area is {0:N}", element.Area));
                    Console.WriteLine(string.Format("The volume is {0:N}\n", threeDshape.Volume));
                }
            }
            Console.ReadKey();
        }
    }
}
