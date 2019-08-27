using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of a circle: ");
            double rad = double.Parse(Console.ReadLine());
            Console.WriteLine(Circumference(rad));



        }
        static double Circumference(double rad)
        { return 2 * Math.PI * rad;
        }
        static double Area(double rad)
        { return Math.PI * rad * rad;
        }

         


    }
}
