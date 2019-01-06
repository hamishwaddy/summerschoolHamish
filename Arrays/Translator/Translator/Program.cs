using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********************************************");
            Console.WriteLine("***************** Translator *****************");
            Console.WriteLine("**********************************************");

            Console.WriteLine("\nI can translate 'hello' in 5 different languages.");
            Console.WriteLine("1. Maori\n2. Japanese\n3. Hindi\n4. French\n5. Samoan" );
            Console.WriteLine("\nWhich language translation would you like to see (1 to 5)?");

            int input = int.Parse(Console.ReadLine());

            string[] helloTranslator = {"Kia ora", "Kon'nichiwa", "Namaste", "Bonjour", "Talofa" };

            Console.Clear();
            Console.WriteLine("**********************************************");
            Console.WriteLine("***************** Translator *****************");
            Console.WriteLine("**********************************************");
            Console.WriteLine($"\nYour selected translation: {input}\n");
            Console.WriteLine($"Hello is translated as: " + helloTranslator[input -1]);




            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadLine();


        }
    }
}
