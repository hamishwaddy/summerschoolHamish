using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAPerson
{
    class Person
    {
        private string fname;
        private string lname;
        private int age;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { private get { return age; } set { age = value; } }

        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }

        public void DisplayAge()
        {
            Console.WriteLine("Age: \t\t" + Age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** Create a Person ***************");
            Console.WriteLine("***********************************************");

            Console.Write("Please enter your first name and press enter: ");
            string userFirstName = Console.ReadLine();
            Console.Write("Please enter your last name and press enter: ");
            string userLastName = Console.ReadLine();
            Console.Write("Please enter your age and press enter: ");
            int userAge = int.Parse(Console.ReadLine());

            Person p1 = new Person(userFirstName, userLastName, userAge);

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** Create a Person ***************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\nUser Details:");
            Console.WriteLine("Full Name: \t{0} {1}\n", p1.Fname, p1.Lname);
            p1.DisplayAge();


            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
