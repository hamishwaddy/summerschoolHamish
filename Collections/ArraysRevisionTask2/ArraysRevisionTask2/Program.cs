using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevisionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 2 ************");
            Console.WriteLine("***********************************************");

            int[] nums = new int[10];
            int total = 0;

            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 10);
                total += nums[i];
            }
            

            foreach (int x in nums)
                Console.WriteLine(x);

            Console.WriteLine("Average is equal to: {0}.", total/nums.Length);
            


            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
