using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** BMI Calculator ***************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("\nThis application will work out your BMI (body mass index).");

            Console.Write("\nPlease enter your weight (in kilograms) and press enter: ");
            double userWeight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height (in metres) and press enter: ");
            double userHeight = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** BMI Calculator ***************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Your weight is {0} kilograms.", userWeight);
            Console.WriteLine("Your height is {0} metres.", userHeight);
            double result = BmiCalc(userWeight, userHeight);
            Console.WriteLine("\nYour BMI is: {0}",result );
            Console.WriteLine("\nYour BMI category is {0}.", BmiCategorizer(result));

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static double BmiCalc(double userWeight, double userHeight)
        {
            double result = (userWeight / (userHeight * userHeight));
            result = Math.Round(result, 2);
            return result;
        }

        public static string BmiCategorizer(double BmiCalc)
        {
            string result = "";

            if (BmiCalc < 18.5)
            {
                result = "'underweight'";
            }
            else if (BmiCalc >= 18.5 && BmiCalc < 25)
            {
                result = "'normal weight'";
            }
            else if (BmiCalc >= 25 && BmiCalc < 30)
            {
                result = "'overweight'";
            }
            else
            {
                result = "'obese'";
            }
            return result;
        }
    }
}
