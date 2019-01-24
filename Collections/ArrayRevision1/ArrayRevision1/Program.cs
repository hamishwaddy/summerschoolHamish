using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRevision1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 1 ************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("Please type a name and press enter: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Please type a second name and press enter: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Please type a third name and press enter: ");
            string name3 = Console.ReadLine();
            Console.WriteLine("Please type a fourth name and press enter: ");
            string name4 = Console.ReadLine();
            Console.WriteLine("Please type a fifth name and press enter: ");
            string name5 = Console.ReadLine();

            string[] fiveNames = { name1, name2, name3, name4, name5 };

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 1 ************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("The names entered were: " + fiveNames[0] + ", " + fiveNames[1] + ", " + fiveNames[2] + ", " + fiveNames[3] + "& " + fiveNames[4]);



            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();

        }
    }
}
