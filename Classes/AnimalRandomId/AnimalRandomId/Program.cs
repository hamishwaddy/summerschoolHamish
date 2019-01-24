using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRandomId
{
    class Animal
    {
        //Attributes/properties
        private string type;
        private string name;
        private int randomId;

        //Getters & setters
        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int RandomId { get { return randomId; } set { randomId = value; } }

        //Constructor
        public Animal(string _type, string _name, int _rand)
        {
            Type = _type;
            Name = _name;
            RandomId = _rand;
        }
        
        //DisplayAll Method
        public string DisplayAll()
        {
            return type + " " + name + randomId;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************ Animal with Random ID ************");
            Console.WriteLine("***********************************************");

            Animal a1 = new Animal("dog", "Rex", RandId(rand));
            Animal a2 = new Animal("dog", "Butch", RandId(rand));
            Animal a3 = new Animal("dog", "Patch", RandId(rand));

            Animal[] ani = new Animal[3];
            ani[0] = a1;
            ani[1] = a2;
            ani[2] = a3;

            List<Animal> list1 = new List<Animal>();
            list1.Add(new Animal("Cat", "Puss", RandId(rand)));
            list1.Add(new Animal("Cat", "Fluff", RandId(rand)));
            list1.Add(new Animal("Cat", "Scratch", RandId(rand)));

                Console.WriteLine("\nAnimals created via 'Animal class' and stored in array.");
            foreach (Animal x in ani)
            {
                Console.WriteLine(x.Name + "\t" + x.Type + "\t" + x.RandomId);
            }

                Console.WriteLine("\nAnimals created via 'List'.");
            foreach(Animal y in list1)
            {
                Console.WriteLine(y.Name + "\t" + y.Type + "\t" + y.RandomId);
            }
            
            Console.ReadLine();
        }

        static public int RandId( Random rand)
        {
            
            return rand.Next(1000, 9999);
        }
    }
}
