using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitDictionaryTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("************** Fruit Dictionary ***************");
            Console.WriteLine("***********************************************\n");

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Apple", "$1.25");
            dict.Add("Banana", "$2.25");
            dict.Add("Kiwifruit", "$4.20");
            dict.Add("Watermelon", "$3.95");
            dict.Add("Oranges", "$2.55");

            Console.WriteLine(">>>FRUIT PRICES PER KG<<<");

            foreach (KeyValuePair<string,string> item in dict)
            {
            Console.WriteLine("Fruit: {0}, Price: {1}", item.Key, item.Value);
            }

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
