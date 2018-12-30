using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topicFourLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu;
            }
        }
        
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Type the number of the task and press enter.");
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

        private static void TaskOne()
        {
            Console.WriteLine("TOPIC FOUR - Loops\nTask One:");

            Console.WriteLine("N\t10*N\t100*N\t100*N");
            Console.WriteLine("-\t----\t-----\t------");


            Console.WriteLine("\n>>> for loop <<<");

            for (int n = 3; n >= 3 && n <= 7; n++)
            {
                Console.WriteLine(n + "\t" + n * 10 + "\t" + n * 100 + "\t" + n * 1000);
            }


            Console.WriteLine("\n>>> while loop <<<");

            int i = 3;
            while (i >= 3 && i <= 7) {
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


            Console.ReadKey();
        }

        private static void TaskTwo()
        {

        }

        private static void TaskThree()
        {

        }
    }
}

