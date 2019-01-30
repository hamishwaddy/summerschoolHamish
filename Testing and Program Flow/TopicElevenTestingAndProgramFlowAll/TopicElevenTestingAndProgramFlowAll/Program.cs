using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicElevenTestingAndProgramFlowAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("****************** TOPIC ELEVEN: Testing & Program Flow *******************");
            Console.WriteLine("***************************************************************************\n");

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("****************** TOPIC ELEVEN: Testing & Program Flow *******************");
            Console.WriteLine("***************************************************************************\n");
            Console.WriteLine("Type the number of the task you'd like to view.");
            Console.WriteLine("\n1 - Sum of Numbers\n2 - Three Options\n3 - Exit");
            int result = int.Parse(Console.ReadLine());

            if (result == 1)
            {
                TaskOne();
                return true;
            }
            else if (result == 2)
            {
                TaskTwo();
                return true;
            }
            else if (result == 3)
                return false;
            else
                return true;
        }

        public static void TaskOne()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************** Add Two Numbers ****************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app will ask for 2 numbers and will then calculate the sum of all the numbers between those 2 numbers.\n");
            Console.Write("Please enter the first (lowest) number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second (highest) number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int total = 0;
            for (int i = num1 + 1; i < num2; i++)
            {
                total = total + i;
            }
            Console.WriteLine("\nThe sum of all numbers between {0} and {1} is: {2}", num1, num2, total);

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadLine();
        }

        public static void TaskTwo()
        {


            string userDecision = "";
            do
            {
                Console.Clear();
                Console.WriteLine("******************************************************");
                Console.WriteLine("**************** TASK TWO: main menu *****************");
                Console.WriteLine("******************************************************\n");
                Console.WriteLine("\nFirstly, choose whether you'd like to complete this task using a 'if-else' or a 'switch statement'.\n1 - if-else statement\n2 - switch statement");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        UsingIfElse();
                        break;
                    case "2":
                        UsingSwitch();
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Try Again.");
                        break;
                }

                Console.WriteLine("\nWould you like to return to the main menu - y/n?");
                userDecision = Console.ReadLine().ToLower();
            } while (userDecision == "y");

        }
        static int Choice()
        {
            Console.Clear();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("**************** TASK TWO: sub menu *****************");
            Console.WriteLine("*****************************************************\n");
            Console.WriteLine("\nChoose an option from below.");
            Console.WriteLine("\n1 - Option 1\n2 - Option 2\n3 - Option 3\n4 - Exit");
            int menuItem = int.Parse(Console.ReadLine());


            return menuItem;
        }

        static void UsingSwitch()
        {
            int menuItem = Choice();
            switch (menuItem)
            {
                case 1:
                    OptionOne();
                    break;
                case 2:
                    OptionTwo();
                    break;
                case 3:
                    OptionThree();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("\nThat entry is invalid.");
                    break;
            }
        }

        static void UsingIfElse()
        {
            int menuItem = Choice();
            if (menuItem == 1)
            {
                Console.Clear();
                OptionOne();
            }
            else if (menuItem == 2)
            {
                Console.Clear();
                OptionTwo();
            }
            else if (menuItem == 3)
            {
                Console.Clear();
                OptionThree();
            }
            else if (menuItem == 4)
            {
            }
            else
                Console.WriteLine("\nThat entry is invalid.");

            //Console.WriteLine("\nPress any key to return to the main menu.");
            //Console.ReadLine();
        }

        public static void OptionOne()
        {
            Console.Clear();
            Console.WriteLine("This is Option 1. It doesn't actually do anything.");
        }

        public static void OptionTwo()
        {
            Console.Clear();
            Console.WriteLine("This is Option 2. It doesn't actually do anything.");
        }

        public static void OptionThree()
        {
            Console.Clear();
            Console.WriteLine("This is Option 3. It doesn't actually do anything.");
        }
    }
    
}
