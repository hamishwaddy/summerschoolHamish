using System;

namespace topicThreeExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Topic 3: \nPART ONE\nConditional Statements and Program Flow");

            /* ------------ Task 1 ------------ */

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

            Console.Write("Task 1 complete. Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
                    
            /* ------------ End of task 1 ------------ */





            /* ------------ Task 2 ------------ */

            Console.WriteLine("PART TWO");
            int myNum = 7;

            Console.WriteLine("Guess My Number - any number between 1 & 10");
            int userNum = int.Parse(Console.ReadLine());

                if (userNum == myNum) //The right answer
                Console.WriteLine("Bingo! You've guessed the correct number!");
                else if (userNum > myNum) //Guess was too high
                Console.WriteLine("Too high, you should have tried with a lower number...");
                else //guess was too low
                Console.WriteLine("Too low, you should have tried with a higher number...");


            Console.WriteLine("Task two finished. Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
            /* ------------ End of task 2 ------------ */





            /* ------------ Task 3 ------------ */

            Console.WriteLine("PART THREE");
            Console.WriteLine("Please enter your final mark for your course.");
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

            Console.WriteLine("Task 3 finished! Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
            /* ------------ End of task 3 ------------ */





            /* ------------ Task 4 ------------ */

            Console.WriteLine("PART FOUR");
            Console.WriteLine("For my next trick, I will determine whether the number you enter is odd or even.");
            Console.Write("Please enter a number and press enter: ");
            int userNumOddEven = int.Parse(Console.ReadLine());

            if (userNumOddEven % 2 == 0)
                Console.WriteLine("The number you chose was an even number.");
            else
                Console.WriteLine("The number you chose was an odd number.");

            Console.WriteLine("Task 4 is finished. Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            /* ------------ End of task 4 ------------ */





            /* ------------ Task 5 ------------ */

            Console.WriteLine("PART FIVE");
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

            Console.WriteLine("Task 5 finished. Please press ENTER to finish.");
            Console.ReadLine();
            Console.Clear();
            /* ------------ End of task 5 ------------ */




            /* ------------ Task 6 ------------ */
            Console.WriteLine("PART SIX: Palindrome");
            Console.WriteLine("Think of a 3-letter palindrome.\nIt must begin and end with the same letter and have a vowel as the middle letter.");
            Console.Write("Type the first letter of your palindrome: ");
            string letter1 = Console.ReadLine();
            Console.Write("Type the second letter (a vowel) of your palindrome: ");
            string letter2 = Console.ReadLine();
            Console.Write("Type the third letter of your palindrome: ");
            string letter3 = Console.ReadLine();
            Console.WriteLine("Here is your word: {0}{1}{2}", letter1,letter2,letter3);


            if (letter1 == letter3)
            {
                if (letter2 == "a" || letter2 = "e" || letter2 = "i" || letter2 = "o" || letter2 = "u")
                Console.WriteLine("Well done, your word '{0}{1}{2}' is a palindrome.", letter1, letter2, letter3);
                else 
                Console.WriteLine("This is not an actual word.");
            }
            else
                Console.WriteLine("{0}{1}{2} is NOT a palindrome.", letter1, letter2, letter3);

            Console.WriteLine("This is the end of Task 6");
            Console.ReadLine();
            Console.Clear();

            /* ------------ End of task 6 ------------ */


        }
    }
}
