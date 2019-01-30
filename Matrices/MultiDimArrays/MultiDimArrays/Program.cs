using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("*************** TOPIC 10: Matrices & 2D Arrays ***************");
            Console.WriteLine("**************************************************************\n");

            Random rand = new Random();

            int[,] array1 = new int[3,3];

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = rand.Next(1, 20);
                }
                //Console.WriteLine();
            }
            Console.WriteLine("Array 1");
            Display(array1);


            int[,] array2 = new int[3, 3];

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = rand.Next(21, 40);
                }
                //Console.WriteLine();
            }
            Console.WriteLine("\nArray 2");
            Display(array2);

            Console.WriteLine("\nArrays added together");

            for (int i = 0; i <=2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(array1[i, j] + array2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        public static void Display(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
