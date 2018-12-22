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
           
           int i = 3;
            while (i >= 3 && i <= 7) {
                Console.WriteLine(i+"\t"+i*10+"\t"+i*100+"\t"+i*1000);
                i++;
                }
            
            Console.ReadKey();
        }
    }
}
