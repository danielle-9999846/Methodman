using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of miles:  ");
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine($"The result is: {ConvertToKms(input)}");


        }
        static double ConvertToKms(double userinput)
        { return userinput / 0.62137;
        }

    }
}
