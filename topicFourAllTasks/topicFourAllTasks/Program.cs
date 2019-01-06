using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topicFourAllTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("TOPIC FOUR: LOOPS");
            Console.WriteLine("Type the number of the task you want to view and press ENTER: ");
            Console.WriteLine("\n1 - Task One");
            Console.WriteLine("2 - Task Two");
            Console.WriteLine("3 - Task Three");
            Console.WriteLine("4 - Exit");


            string result = Console.ReadLine();
            if (result == "1")
            {
                TaskOne();
                return true;
            }
            else if (result == "2")
            {
                TaskTwo();
                return true;
            }
            else if (result == "3")
            {
                TaskThree();
                return true;
            }
            else if (result == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void TaskOne()
        {
            Console.Clear();
            Console.WriteLine("Task One:");
            Console.WriteLine("N\t10*N\t100*N\t100*N");
            Console.WriteLine("-\t----\t-----\t------");

            Console.WriteLine("\n>>> for loop <<<");
            for (int n = 3; n >= 3 && n <= 7; n++)
            {
                Console.WriteLine(n + "\t" + n * 10 + "\t" + n * 100 + "\t" + n * 1000);
            }

            Console.WriteLine("\n>>> while loop <<<");
            int i = 3;
            while (i >= 3 && i <= 7)
            {
                Console.WriteLine(i + "\t" + i * 10 + "\t" + i * 100 + "\t" + i * 1000);
                i++;
            }

            Console.WriteLine("\n>>> do while loop <<<");
            int x = 3;
            do
            {
                Console.WriteLine(x + "\t" + x * 10 + "\t" + x * 100 + "\t" + x * 1000);
                x++;
            } while (x <= 7);

            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }

        public static void TaskTwo()
        {
            Console.Clear();
            Console.WriteLine("Task Two: Times-Tables Machine");
            Console.WriteLine("\nEnter a number between 1 & 10");

            int userInput = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(userInput + " TIMES TABLES\n----------------");

            //-----------------------------//
            //----------for loop-----------//
            //-----------------------------//
            Console.WriteLine(">>> for loop <<<");

            for (int x = 1; x <= 12; x++)
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

            do
            {
                int answer = n * userInput;
                Console.WriteLine("{0} x {1} = {2}", n, userInput, answer);
                n++;
            } while (n <= 12);

            Console.WriteLine("\nThanks for playing! Press any key to return to the main menu.");
            Console.ReadKey();
        }

        public static void TaskThree()
        {
            Console.Clear();
            Console.WriteLine("TOPIC FOUR: Loops");
            Console.WriteLine("\nNumber\tSquare\tCube\n------\t------\t----");

            //---------- for loop -----------//
            //-------------------------------//

            Console.WriteLine("\n>>> for loop <<<");



            for (int i = 0; i <= 10; i++)
            {
                int square = i * i;
                int cube = i * i * i;
                Console.WriteLine("{0}\t{1}\t{2}", i, square, cube);
            }


            //--------- while loop ----------//
            //-------------------------------//
            Console.WriteLine("\n>>> while loop <<<");

            int j = 0;
            while (j >= 0 && j <= 10)
            {
                int square = j * j;
                int cube = j * j * j;
                Console.WriteLine("{0}\t{1}\t{2}", j, square, cube);
                j++;
            }


            //-------- do while loop --------//
            //-------------------------------//
            Console.WriteLine("\n>>> do while loop <<<");

            int k = 0;
            do
            {
                int square = k * k;
                int cube = k * k * k;
                Console.WriteLine("{0}\t{1}\t{2}", k, square, cube);
                k++;
            } while (k <= 10);

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
