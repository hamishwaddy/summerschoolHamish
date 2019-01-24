using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicSixAllTasks
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
            Console.WriteLine("TOPIC SIX: ARRAYS");
            Console.WriteLine("\nType the number of the task you'd like to see and press enter.");
            Console.WriteLine("\nBasic Array Practice");
            Console.WriteLine("1 - CrankWorx Medal Awards");
            Console.WriteLine("2 - Names");
            Console.WriteLine("3 - Raffle");
            Console.WriteLine("4 - Translator");
            Console.WriteLine("5 - Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                CrankWorx();
                return true;
            }
            else if (result == "2")
            {
                Names();
                return true;
            }
            else if (result == "3")
            {
                Raffle();
                return true;
            }
            else if (result == "4")
            {
                Translator();
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static void CrankWorx()
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("****Welcome to the CrankWork Medal Awards****");
            Console.WriteLine("*********************************************");


            Console.WriteLine("\nEnter the name of the GOLD medal winner.");
            string goldMedal = Console.ReadLine();

            Console.WriteLine("\nEnter the name of the SILVER medal winner.");
            string silverMedal = Console.ReadLine();

            Console.WriteLine("\nEnter the name of the BRONZE medal winner.");
            string bronzeMedal = Console.ReadLine();

            string[] names = new string[]
           {
               goldMedal, silverMedal, bronzeMedal
           };

            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("****Welcome to the CrankWork Medal Awards****");
            Console.WriteLine("*********************************************");
            Console.Write("\nWhich medal holder would you like to see displayed? (enter 1, 2 or 3)");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThat medal winner is: {names[userInput - 1]}");

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
            
        }

        public static void Names()
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("******************* Names *******************");
            Console.WriteLine("*********************************************");

            Console.WriteLine("You are going to be asked to type five names.");
            Console.Write("\nPlease type the first name and press enter: ");
            string name1 = Console.ReadLine();
            Console.Write("Please type the second name and press enter: ");
            string name2 = Console.ReadLine();
            Console.Write("Please type the third name and press enter: ");
            string name3 = Console.ReadLine();
            Console.Write("Please type the fourth name and press enter: ");
            string name4 = Console.ReadLine();
            Console.Write("Please type the fifth name and press enter: ");
            string name5 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("******************* Names *******************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Here are the five names you entered:");
            Console.WriteLine("1- " + name1);
            Console.WriteLine("2- " + name2);
            Console.WriteLine("3- " + name3);
            Console.WriteLine("4- " + name4);
            Console.WriteLine("5- " + name5);


            string[] names = new string[]
                { name1, name2, name3, name4, name5 };

            Console.WriteLine("\nThe first name entered is: " + names[0]);
            Console.WriteLine("The last name entered is: " + names[4]);

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }

        public static void Raffle()
        {
            Console.Clear();
            Console.WriteLine("**********************************************");
            Console.WriteLine("******************* Raffle *******************");
            Console.WriteLine("**********************************************");


            int rows = 20;
            int col = 2;

            string[,] raffleTickets = { { "Ticket 1:", "Sam" }, { "Ticket 2:", "Orrin" }, { "Ticket 3:", "Lara" }, { "Ticket 4:", "Hamish" }, { "Ticket 5:", "Pixie" }
            , { "Ticket 6:", "Holly" }, { "Ticket 7:", "Abbey" }, { "Ticket 8:", "Zoe" }, { "Ticket 9:", "Caleb" } , { "Ticket 10:", "Jonathon" }, { "Ticket 11:", "Elena" }
            , { "Ticket 12:", "Josh" }, { "Ticket 13:", "Dan" } , { "Ticket 14:", "Kirsten" }, { "Ticket 15:", "Jimmy" } , { "Ticket 16:", "Rach" }, { "Ticket 17:", "Gregg" }, { "Ticket 18:", "Bear" }, { "Ticket 19:", "Jan" } , { "Ticket 20:", "Bazza" } };


            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    Console.Write(raffleTickets[x, y] + " ");
                }
                Console.WriteLine();
            }

            Random rnd = new Random();
            int index = rnd.Next(raffleTickets.GetLength(0));
            string randomWinner = raffleTickets[index, 1];

            Console.WriteLine("\nThe winning ticket number is: Ticket " + (index + 1) + ".");
            Console.WriteLine("\n*************************************************");
            Console.WriteLine("\nThe winner of $1,000,000 is {0}.", randomWinner);
            Console.WriteLine("*************************************************");

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();

        }
        
        public static void Translator()
        {
            Console.Clear();
            Console.WriteLine("**********************************************");
            Console.WriteLine("***************** Translator *****************");
            Console.WriteLine("**********************************************");

            Console.WriteLine("\nI can translate 'hello' in 5 different languages.");
            Console.WriteLine("1. Maori\n2. Japanese\n3. Hindi\n4. French\n5. Samoan");
            Console.WriteLine("\nWhich language translation would you like to see (1 to 5)?");

            int input = int.Parse(Console.ReadLine());

            string[] helloTranslator = { "Kia ora", "Kon'nichiwa", "Namaste", "Bonjour", "Talofa" };

            Console.Clear();
            Console.WriteLine("**********************************************");
            Console.WriteLine("***************** Translator *****************");
            Console.WriteLine("**********************************************");
            Console.WriteLine($"\nYour selected translation: {input}\n");
            Console.WriteLine($"Hello is translated as: " + helloTranslator[input - 1]);




            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadLine();


        }

    }
}
