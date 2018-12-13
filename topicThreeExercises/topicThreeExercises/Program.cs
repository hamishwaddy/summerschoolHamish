using System;

namespace topicThreeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Topic 3: Conditional Statements and Program Flow");
            Console.WriteLine("Please type a number and press the ENTER key.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type another number and press the ENTER key");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            { 
                Console.WriteLine(num1 + " is larger than " + num2);
            }

            else if (num2 > num1)
            {
                Console.WriteLine(num2 + " is larger than " + num1);
            }
            Console.Write("Task 1 complete. Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
