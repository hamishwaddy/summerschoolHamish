using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyRandomNumbersTaskFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 4 ************");
            Console.WriteLine("***********************************************");

            int[] nums = new int[50];

            Random rand = new Random();

            for (int x = 1; x <= nums.Length; x++)
            {
                nums[x-1] = rand.Next(1, 100);
                Console.Write(nums[x-1] + " ");
                if (x % 10 == 0)
                    Console.WriteLine();
            }

            Console.Write("\nChoose a number from the list above and enter it here: ");
            int userInput = int.Parse(Console.ReadLine());

            int numPosition = Array.IndexOf(nums, userInput);

            Console.WriteLine("The number you selected was in index position: {0}", numPosition);

            int[] nums2 = new int[50];
            Array.Copy(nums, nums2, 50);

            Console.WriteLine("\nCopied array - sorted ascending.");
            for (int i = 1; i <= nums2.Length; i++)
            {
                Array.Sort(nums2);
                Console.Write(nums2[i-1] + " ");
                if (i%10 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine("\n\nCopied array - sorted descending.");
            for (int i = 1; i <= nums2.Length; i++)
            {
                Array.Sort(nums2);
                Array.Reverse(nums2);
                Console.Write(nums2[i-1] + " ");
                if (i%10 == 0)
                    Console.WriteLine();
            }


            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
