using System;

namespace switchStatements
{
    class Program
    {
        public static void Main(string[] args)
        {
            //-----------------------------------------//
            //---------------TOPIC THREE---------------//
            //------------Switch Statements------------//
            //-----------------------------------------//

            Console.WriteLine("Topic 3: SWITCH STATEMENTS");

            //----------Guess My Favorite Pet----------//

            Random numberGenerator = new Random();

            string favePet01 = "dog";

            Console.WriteLine("Guess My Favourite Pet");
            string answer = (Console.ReadLine());

            if (answer == favePet01)
            {
                Console.WriteLine("Woof! You guessed correctly.");
            }
            else
            {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("No, not that animal!");
                        break;
                    case 2:
                        Console.WriteLine("Sorry, that's not right.");
                        break;
                    case 3:
                        Console.WriteLine("You'll have to try again.");
                        break;
                    default:
                        Console.WriteLine($"An unexpected value({responseIndex})");
                        break;
                }


                Console.WriteLine("This is the end of this task. Press ENTER to continue.");
                Console.ReadLine();
                Console.Clear();





                //------What is the price of the fruit?------//

                //Console.WriteLine("Welcome to the next task where you can search for the per kilogram price of some different fruits.");


                //const double Apples = 1.25;
                //const double Bananas = 3.15;
                //const double Kiwifruit = 4.65;
                //const double Oranges = 2.75;

                //Console.WriteLine("Enter the type of fruit you'd like tp price-check.");
                //string userInput = Convert.ToString(Console.ReadLine());

                //switch(fruitName)
                //{ 
                //case 1:
                //    Console.WriteLine(1.25);
                //    break;
                //case 2:
                //    Console.WriteLine(3.15);
                //    break;
                //case 3:
                //    Console.WriteLine(4.65);
                //    break;
                //case 4:
                //    Console.WriteLine(2.75);
                //    break;
                //default:
                //Console.WriteLine($"An unexpected value has been entered({fruitName})");
                //break;
                //}
            }
        }
    }
}
