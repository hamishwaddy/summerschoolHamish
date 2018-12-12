using System;

namespace startingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            do
            {
                Console.WriteLine("Type a 2-digit number");
                num1 = int.Parse(Console.ReadLine());
            } while (num1 <= 9 || num1 >= 100);


            int num2 = 0;
            do
            {
                Console.WriteLine("Next, type a 3-digit number");
                num2 = int.Parse(Console.ReadLine());
            } while (num2 <= 99 || num2 >= 1000);

            Console.WriteLine("FULL EQUATION");
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{1} / {0} = {2}", num2, num1, num2 / num1);
        }

    }
}
