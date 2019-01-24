using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDictionaryTaskThree
{
    class Person
    {
        //Getters/setters
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        //Constructor
        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("************** Person Dictionary **************");
            Console.WriteLine("***********************************************\n");

            Dictionary<int, Person> peopleDictionary = new Dictionary<int, Person>();
            Random rand = new Random();

            Person p1 = new Person("Kane", "Williamson", 29);
            Person p2 = new Person("Martin", "Guptil", 32);
            Person p3 = new Person("Ross", "Taylor", 35);
            Person p4 = new Person("Trent", "Boult", 26);
            Person p5 = new Person("Lockie", "Ferguson", 23);


            peopleDictionary.Add(RandId(rand), p1);
            peopleDictionary.Add(RandId(rand), p2);
            peopleDictionary.Add(RandId(rand), p3);
            peopleDictionary.Add(RandId(rand), p4);
            peopleDictionary.Add(RandId(rand), p5);

            foreach (KeyValuePair<int, Person> x in peopleDictionary)
            {
                Console.WriteLine("ID: {0}\t{1} {2}, Age: {3}", x.Key, x.Value.Fname, x.Value.Lname, x.Value.Age);
            }


            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        static int RandId(Random rand)
        {
            return rand.Next(1000, 9999);
        }
    }

    
}
