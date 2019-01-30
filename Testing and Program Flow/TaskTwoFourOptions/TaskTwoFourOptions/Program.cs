using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoFourOptions
{
     
    class Program
    {
        static void Main(string[] args)
        {

            string userDecision = "";
            do
            {
                Console.Clear();
                Console.WriteLine("********************************************");
                Console.WriteLine("**************** MAIN MENU *****************");
                Console.WriteLine("********************************************\n");
                Console.WriteLine("\nFirstly, choose whether you'd like to complete this task using a 'for loop' or a 'switch statement'.\n1 - for loop\n2 - switch statement");
                int userChoice = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("********************************************");
                Console.WriteLine("**************** SUB  MENU *****************");
                Console.WriteLine("********************************************\n");
                Console.WriteLine("\nChoose an option from below.");
                Console.WriteLine("\n1 - Option 1\n2 - Option 2\n3 - Option 3\n4 - Exit");
                int menuItem = int.Parse(Console.ReadLine());
           
                switch (userChoice)
                {
                    case 1:
                        UsingForLoop(menuItem);
                        break;
                    case 2:
                        UsingSwitch(menuItem);
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Try Again.");
                        break;
                }

                Console.WriteLine("\nWould you like to return to the main menu - y/n?");
                userDecision = Console.ReadLine().ToLower();
            } while (userDecision == "y");

        }

        static void UsingSwitch(int menuItem)
        {
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

        static void UsingForLoop(int menuItem)
        {
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
