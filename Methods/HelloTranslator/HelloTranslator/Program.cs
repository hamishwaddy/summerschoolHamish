using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** Hello Translator **************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("\nThis application will translate the word 'hello' into various languages.");
            Console.WriteLine("\nSelect a number to see the translation:");
            Console.WriteLine("1 - Maori\n2 - Japanese\n3 - Hindi\n4 - French\n5 - Samoan");

            string[] languages = {"Maori", "Japanese", "Hindi", "French", "Samoan" };

            int userInput = int.Parse(Console.ReadLine());
            string result = Translator(userInput);

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** Hello Translator **************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Your selection was '{0}'. This translates to '{1}'.", languages[userInput-1], result);

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();


        }
        public static string Translator(int userInput)
        {
            string[] helloTranslator = { "Kia ora", "Kon'nichiwa" , "Namaste" , "Bonjour" , "Talofa" };

            string result = helloTranslator[userInput-1];
            return result;
            
        }
    }
}
