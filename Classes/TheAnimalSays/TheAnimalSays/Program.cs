using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAnimalSays
{
    class Animal
    {
        private string aniName;
        private string aniSound;

        public string AniName { get { return aniName; } set { aniName = value;} }
        public string AniSound { get { return aniSound; } set { aniSound = value; } }

        public void aniSays()
        {
            Console.WriteLine("The {0} says {1}.", AniName, AniSound);
        }

        public Animal(string _aniName, string _aniSound)
        {
            AniName = _aniName;
            AniSound = _aniSound;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("************* The Animal Says... **************");
            Console.WriteLine("***********************************************");

            Console.Write("\nPlease type the name of an animal: ");
            string aniName = Console.ReadLine();
            Console.Write("Type the sound that this animal makes: ");
            string aniSound = Console.ReadLine();

            Animal a1 = new Animal(aniName, aniSound);

            a1.aniSays();

            Console.Read();
        }
    }
}
