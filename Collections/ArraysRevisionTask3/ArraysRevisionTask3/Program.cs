using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevisionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 3 ************");
            Console.WriteLine("***********************************************");

            int[] nums = new int[20];
            //int total = 0;

            Random rand = new Random();

            Console.WriteLine("Original unsorted array:");
            for (int i= 1;i<=nums.Length; i++)
            {
                nums[i-1] = rand.Next(0, 100);
                Console.Write(nums[i-1] + " ");
                if (i % 10 == 0)
                    Console.WriteLine();
                //total += nums[i-1];
            }
            //Console.WriteLine("Average of this array = {0} ", total/nums.Length);

            Console.WriteLine("\nSorted array:");
            for (int x=1;x<nums.Length;x++)
            {
                Array.Sort(nums);
                Console.Write(nums[x-1] + " ");
                if (x % 10 == 0)
                    Console.WriteLine();
            }
            
            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
