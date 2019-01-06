using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("******************* Raffle *******************");
            Console.WriteLine("**********************************************");

         
            int rows = 20;
            int col = 2;

            string[,] raffleTickets = { { "Ticket 1:", "Sam" }, { "Ticket 2:", "Orrin" }, { "Ticket 3:", "Lara" }, { "Ticket 4:", "Hamish" }, { "Ticket 5:", "Pixie" }
            , { "Ticket 6:", "Holly" }, { "Ticket 7:", "Abbey" }, { "Ticket 8:", "Zoe" }, { "Ticket 9:", "Caleb" } , { "Ticket 10:", "Jonathon" }, { "Ticket 11:", "Elena" }
            , { "Ticket 12:", "Josh" }, { "Ticket 13:", "Dan" } , { "Ticket 14:", "Kirsten" }, { "Ticket 15:", "Jimmy" } , { "Ticket 16:", "Rach" }, { "Ticket 17:", "Gregg" }, { "Ticket 18:", "Bear" }, { "Ticket 19:", "Jan" } , { "Ticket 20:", "Bazza" } };
  

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    Console.Write(raffleTickets[x,y] + " ");
                }
                Console.WriteLine();
            }

            Random rnd = new Random();
            int index = rnd.Next(raffleTickets.GetLength(0));
            string randomWinner = raffleTickets[index, 1];
            string randomWinningTicket = raffleTickets[index, 0];

            Console.WriteLine("\nThe winning ticket number is: Ticket " + (index + 1) + ".");
            Console.WriteLine("\n*************************************************");
            Console.WriteLine("\nThe winner of $1,000,000 is {0}.", randomWinner);
            Console.WriteLine("*************************************************");

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadLine();
        }       
    }
}
