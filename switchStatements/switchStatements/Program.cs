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
                    

                    Console.WriteLine("Guess My Favourite Pet\nChoose between sheep / dog / horse.");
                    string pet = Console.ReadLine().ToLower();

                    switch (pet) {
                        case "sheep":
                        case "dog":
                            Console.WriteLine("Sorry, incorrect.");
                            break;
                        case "horse":
                            Console.WriteLine("That's the one - you guessed right!");
                        break;
                        default:
                            Console.WriteLine("Sorry, that response wasn't an option.");
                    break;     
                    }

                        Console.WriteLine("This is the end of this task. Press ENTER to continue.");
                        Console.ReadLine();
                        Console.Clear();

                    



                //------What is the price of the fruit?------//

            Console.WriteLine("Welcome to the next task where you can search for the per kilogram price of some different fruits.\nChoose between apples, bananas, kiwifruit & oranges.");
            Console.Write("type in the name of the fruit you'd like to check: ");
            string fruit = Console.ReadLine().ToLower();
            string response;

            switch (fruit)
            {
                case "apples":
                    response = "\nApples\t$1.25 per kg";
                    break;
                case "bananas":
                    response = "\nBananas\t$3.15 per kg";
                    break;
                case "kiwifruit":
                    response = "\nKiwifruit\t$4.65 per kg";
                    break;
                case "oranges":
                    response = "\nOranges\t$2.75 per kg";
                    break;
                default:
                    response = "\nThat entry is invalid.";
                    break;
            }
            Console.WriteLine(response);


            Console.ReadKey();

            
            

        }
    }
}
