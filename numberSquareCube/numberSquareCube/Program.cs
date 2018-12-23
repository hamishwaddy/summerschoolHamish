using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSquareCube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOPIC FOUR: Loops");
            Console.WriteLine("Number\tSquare\tCube\n------\t------\t----");

            //---------- for loop -----------//
            //-------------------------------//

            Console.WriteLine("\n>>> for loop <<<");



            for (int i=0; i<=10; i++)
            {
                int square = i * i;
                int cube = i * i * i;
                Console.WriteLine("{0}\t{1}\t{2}", i, square, cube);
            }


            //--------- while loop ----------//
            //-------------------------------//
            Console.WriteLine("\n>>> while loop <<<");

            int j = 0;
            while(j>=0 && j<=10) {
                int square = j * j;
                int cube = j * j * j;
                Console.WriteLine("{0}\t{1}\t{2}", j, square, cube);
                j++;
            }


            //-------- do while loop --------//
            //-------------------------------//
            Console.WriteLine("\n>>> do while loop <<<");

            int k = 0;
            do
            {
                int square = k * k;
                int cube = k * k * k;
                Console.WriteLine("{0}\t{1}\t{2}", k, square, cube);
                k++;
            } while (k <= 10);

            Console.ReadKey();
        }
    }
}
