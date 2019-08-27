using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine($"The result is: {ChangeSign(input)}");



        }

        static double ChangeSign(double userinput)
        { return userinput * -1;
        }
    }
}
