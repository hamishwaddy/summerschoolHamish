using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("****************** Week Days ******************");
            Console.WriteLine("***********************************************");

            Console.Write("\nEnter a number between 1 & 7 to represent a day of the week: ");
            int userInput = int.Parse(Console.ReadLine()) -1;

            string convertedDay = DaysOfWeek(userInput);


            Console.WriteLine("The number you chose was {0}. This equates to {1}.", userInput, convertedDay);

            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static string DaysOfWeek(int input)
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            string result = weekDays[input];
            return result;
            
        }
    }
}
