using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDictionaryTaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** City Dictionary ***************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app will ask you to enter the names of your ten favourite cities.");

            Dictionary<int, string> citiesDict = new Dictionary<int, string>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a city: ");
                citiesDict.Add(i, Console.ReadLine());
            }
            

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** City Dictionary ***************");
            Console.WriteLine("***********************************************\n");
            Console.WriteLine(">>> Cities Dictionary <<<");
            foreach (KeyValuePair<int,string> item in citiesDict)
            {
                Console.WriteLine("Key: {0}\tValue: {1}",item.Key,item.Value);
            }

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
