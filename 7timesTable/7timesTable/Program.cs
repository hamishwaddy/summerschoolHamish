using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7timesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOPIC FOUR: Loops\nTimes-Tables Machine");
            Console.WriteLine("Enter a number between 1 & 10");

            int userInput = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(userInput + " TIMES TABLES\n----------------");

            //-----------------------------//
            //----------for loop-----------//
            //-----------------------------//
            Console.WriteLine(">>> for loop <<<");

            for (int x = 1; x<=12; x++)
            {
               int answer = x * userInput;
        Console.WriteLine("{0} x {1} = {2}", x, userInput, answer);
            }

            //-----------------------------//
            //----------while loop---------//
            //-----------------------------//            
            Console.WriteLine("\n>>> while loop <<<");
            int i = 0;
            while (++i <= 12)
            {
                int answer = i * userInput;
                Console.WriteLine("{0} x {1} = {2}", i, userInput, answer);
            }

            //-----------------------------//
            //-------do while loop---------//
            //-----------------------------//
            Console.WriteLine("\n>>> do while loop <<<");
            int n = 1;
            int answer = n * userInput;

            do
            {
                Console.WriteLine("{0} x {1} = {2}", n, userInput, answer);
                n++;
            } while (n <= 12);

            
            Console.ReadKey();
        }
    }
}
