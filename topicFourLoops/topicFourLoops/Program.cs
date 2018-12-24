using System;

namespace topicFourLoops
{
    class Program
    {
        static public void Main(string[] args)
        {

            Console.WriteLine("TOPIC FOUR - Loops\nExercise One:");

            Console.WriteLine("N\t10*N\t100*N\t100*N");
            Console.WriteLine("-\t----\t-----\t------");


            Console.WriteLine("\n>>> for loop <<<");
            
            for (int n = 3; n >=3 && n<=7; n++)
            {
                Console.WriteLine(n + "\t" + n * 10 + "\t" + n * 100 + "\t" + n * 1000);
            }


            Console.WriteLine("\n>>> while loop <<<");
           
           int i = 3;
            while (i >= 3 && i <= 7) {
                Console.WriteLine(i+"\t"+i*10+"\t"+i*100+"\t"+i*1000);
                i++;
                }


            Console.WriteLine("\n>>> do while loop <<<");

            int x = 3;
            do
            {
                Console.WriteLine(x + "\t" + x * 10 + "\t" + x * 100 + "\t" + x * 1000);
                x++;
            } while (x <= 7);


            Console.ReadKey();
        }
    }
}
