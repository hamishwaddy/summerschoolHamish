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
            /*
            Random numberGenerator = new Random();

            
            string favePet01 = "dog";
            string favePet02 = "cat";
            string favePet03 = "sheep";

            Console.WriteLine("Guess My Favourite Pet");
            string answer = Console.ReadLine();

            if (answer == favePet01)
            {
                Console.WriteLine("Woof! You guessed correctly.");
            }
            else if (answer == favePet02)
            {
                Console.WriteLine("Sorry, no. Cat is not the correct answer.");
            }
            else if (answer == favePet03)
            {
                Console.WriteLine("Baaaa! The correct answer is not sheep.");
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

            }

    */

                //------What is the price of the fruit?------//

                Console.WriteLine("Welcome to the next task where you can search for the per kilogram price of some different fruits.");
                Random numberGenerator = new Random();


                const double apples = 1.25;
                const double bananas = 3.15;
                const double kiwifruit = 4.65;
                const double oranges = 2.75;

                Console.WriteLine("Enter the type of fruit you'd like to price-check.");
                double userInput = Convert.ToDouble(Console.ReadLine());

            if (userInput == "apples") {
                Console.WriteLine("Apples cost $1.25 per kilogram");
            } else if (userInput == bananas) {
                Console.WriteLine("The price of bananas is $3.15 per kg.");
            } else if (userInput == kiwifruit) {
                Console.WriteLine("Kiwifruit is $4.65 per kg.");
            } else if (userInput == oranges) {
                Console.WriteLine("Oranges will cost you $2.75 per kilogram.");
            } else {
                int responseIndex = numberGenerator.Next(1, 3);
            
                switch (responseIndex)
                { 
                case 1:
                    Console.WriteLine("We don't have a price for that fruit.");
                    break;
                case 2:
                    Console.WriteLine("Sorry, that fruit is not in stock.");
                    break;
                default:
                Console.WriteLine($"An unexpected value has been entered({responseIndex})");
                break;
                }
            }

        }
    }
}
