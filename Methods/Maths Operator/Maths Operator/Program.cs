using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Maths Operator ***************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("\nThis application will work out a basic 2-number calculation for you.");

            Console.Write("Please enter your first number: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Select an operator to use: +, -, *, /, or %");
            char userOperator = Convert.ToChar(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Maths Operator ***************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\nHere is the calculation you ordered:");
            Console.WriteLine("{0} {1} {2} = {3}",num1,userOperator,num2,Calculator(num1,num2,userOperator));



            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static decimal Calculator(decimal num1, decimal num2, char userOperator)
        {
            decimal result;

            if (userOperator == '+')
            {
                result = num1 + num2;
            }
            else if (userOperator == '-')
            {
                result = num1 - num2;
            }
            else if (userOperator == '*')
            {
                result = num1 * num2;
            }
            else if (userOperator == '/')
            {
                result = Math.Round(num1 / num2,2);
            }
            else if (userOperator == '%')
            {
                result = num1 % num2;
            }
            else
            {
                result = 0;
            }
            
            
            return result;
        }
    }
}
