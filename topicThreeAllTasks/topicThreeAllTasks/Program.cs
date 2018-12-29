using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topicThreeAllTasks
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
            Console.WriteLine("TASK 3 ACTIVITIES");
            Console.WriteLine("\n1 - Which number is Larger?");
            Console.WriteLine("2 - Guess my number");
            Console.WriteLine("3 - What grade did I get?");
            Console.WriteLine("4 - Odd or even?");
            Console.WriteLine("5 - Enter your PIN");
            Console.WriteLine("6 - Write a palindrome");
            Console.WriteLine("7 - Exit");
            Console.Write("\nType the number of the game you'd like to play: ");
            
            string result = Console.ReadLine();
            if (result == "1")
            {
                WhichNumberIsLarger();
                return true;
            }
            else if (result == "2")
            {
                GuessMyNumber();
                return true;
            }
            else if (result == "3")
            {
                WhatGradeDidIGet();
                return true;
            }
            else if (result == "4")
            {
                OddOrEven();
                return true;
            }
            else if (result == "5")
            {
                EnterYourPin();
                return true;
            }
            else if (result == "6")
            {
                WriteAPalindrome();
                return true;
            }
            else if (result == "7")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void WhichNumberIsLarger()
        {
            Console.Clear();
            Console.WriteLine("Activity 1: Which number is larger?");
            Console.WriteLine("Please type a number and press the ENTER key.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type another number and press the ENTER key");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is larger than " + num2);
            }

            else if (num2 > num1)
            {
                Console.WriteLine(num2 + " is larger than " + num1);
            }
            else if (num1 == num2)
                Console.WriteLine("These numbers are equal");
            
            Console.WriteLine("\nTask 1 complete. Press any key to return to the main menu.");
            Console.ReadLine();
        }

        private static void GuessMyNumber()
        {
            Console.Clear();
            Console.WriteLine("Activity 2: Guess my number.");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess My Number - type any number between 1 & 10: ");
                int userNum = int.Parse(Console.ReadLine());
                guesses++;
                if (userNum == randomNumber) //The right answer
                    incorrect = false;
                else if (userNum > randomNumber) //Guess was too high
                    Console.WriteLine("Too high, you should have tried with a lower number...");
                else //Guess was too low
                    Console.WriteLine("Too low, you should have tried with a higher number...");

            } while (incorrect);

            Console.WriteLine("Bingo! You've guessed the correct number! It took you {0} guesses.", guesses );




            Console.WriteLine("\nTask 2 finished. Press any key to return to the main menu.");
            Console.ReadLine();
        }

        private static void WhatGradeDidIGet()
        {
            Console.Clear();
            Console.WriteLine("Activity 3: What grade did I get?");

            Console.WriteLine("Please enter your final mark for your course: ");
            float mark = float.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Your grade is an A+");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("Your grade is an A");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("Your grade is a B+");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("Your grade is a B");
            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("Your grade is a C");
            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("Your grade is a D");
            else if (mark >= 0 && mark <= 39)
                Console.WriteLine("Your grade is an F");
            else
                Console.WriteLine("There was a problem with the mark you entred.");

            Console.WriteLine("\nTask 3 finished! Press any key to return to the main menu.");
            Console.ReadLine();
        }

        private static void OddOrEven()
        {
            Console.Clear();
            Console.WriteLine("Activity 4: Odd or even?");
            Console.WriteLine("For my next trick, I will determine whether the number you enter is odd or even.");
            Console.Write("Please enter a number and press enter: ");
            int userNumOddEven = int.Parse(Console.ReadLine());

            if (userNumOddEven % 2 == 0)
                Console.WriteLine("The number you chose was an even number.");
            else
                Console.WriteLine("The number you chose was an odd number.");

            Console.WriteLine("\nTask 4 is finished. Press any key to return to the main menu.");
            Console.ReadLine();
        }

        private static void EnterYourPin()
        {
            Console.Clear();
            Console.WriteLine("Activity 5: Enter your PIN.");
            Console.Write("Enter a 4-digit PIN number and press ENTER: ");
            int pin1 = int.Parse(Console.ReadLine());

            if (pin1 > 1000 && pin1 < 9999)
            {
                Console.Write("Please re-enter your 4-digit PIN number: ");
                int pin2 = int.Parse(Console.ReadLine());

                if (pin1 == pin2)
                    Console.WriteLine("Your PIN has been set!");

                else
                    Console.WriteLine("This PIN number is not within the right parameters");
            }
            else
                Console.WriteLine("Error! Your PIN numbers did not match. Your PIN was not set");

            Console.WriteLine("\nTask 5 is complete. Press any key to return to the main menu.");
            Console.ReadLine();
        }

        private static void WriteAPalindrome()
        {
            Console.Clear();
            Console.WriteLine("Activity 6: Write a palindrome.");
            Console.WriteLine("Think of a 3-letter palindrome.\nIt must begin and end with the same letter and have a vowel as the middle letter.");
            
            Console.Write("Type the first letter of your palindrome: ");
            string letter1 = Console.ReadLine();
            Console.Write("Type the second letter (a vowel) of your palindrome: ");
            string letter2 = Console.ReadLine();
            Console.Write("Type the third letter of your palindrome: ");
            string letter3 = Console.ReadLine();
            //Console.WriteLine("Here is your word: {0}-{1}-{2}", letter1,letter2,letter3);
            
            if (letter1 == letter3)
            {
                if (letter2 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u")
                    Console.WriteLine("Well done, your word: '{0}{1}{2}' is a palindrome.", letter1, letter2, letter3);
                else
                    Console.WriteLine("This is not an actual word.");
            }
            else
                Console.WriteLine("{0}{1}{2} is NOT a palindrome.", letter1, letter2, letter3);

            Console.WriteLine("\nTask 6 finished! Press any key to return to the main menu.");
            Console.ReadLine();
        }

        

    }
}
