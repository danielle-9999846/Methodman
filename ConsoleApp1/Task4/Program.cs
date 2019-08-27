using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight in kg's: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height in cm's: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"BMI: {BMI((height/100),weight)}");
            Console.WriteLine(Category(BMI((height/100),weight)));
            Console.ReadLine();


           


        }
        static double BMI(double h, double w)
        { return w / (h * h);

        }

        static string Category(double total)
        { string result = "";
            if (total < 18.5)
                result = "underweight";
            else if (total >= 18.5 && total < 25)
                result = "normal weight";
            else if (total >= 25 && total < 30)
                result = "overweight";
            else
                result = "obese";
            return result;

        }



     

        

    }
}
