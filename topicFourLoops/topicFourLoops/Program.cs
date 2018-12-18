using System;

namespace topicFourLoops
{
    class Program
    {
        static public void Main(string[] args)
        {

            Console.WriteLine("TOPIC FOUR - Loops\nExercise One:");



            Console.WriteLine(">>> while loop <<<");
            int[] arr = new int[4];
           
           int i = 0;
            while (i >= 3 && i <= 7) {
                Console.WriteLine(arr[0], i);
                i++;
                }

                while (i >= 3 && <= 7) {
                Console.WriteLine(arr[1], i * 10);
                i++;
                }


            Console.ReadKey();
        }
    }
}
