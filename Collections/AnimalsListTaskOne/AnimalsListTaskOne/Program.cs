using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsListTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Animals List ****************");
            Console.WriteLine("***********************************************\n");

            List<string> Animals = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Type the name of an animal: ");
                Animals.Add(Console.ReadLine());
            }


            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Animals List ****************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("Here is the list of animals you entered:");
            foreach (string animalType in Animals)
            {
                Console.WriteLine("\t" + animalType);
            }
            
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
