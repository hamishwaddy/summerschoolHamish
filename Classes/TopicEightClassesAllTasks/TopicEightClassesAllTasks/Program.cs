using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicEightClassesAllTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("******************** TOPIC EIGHT: Classes ********************");
            Console.WriteLine("**************************************************************\n");

            bool displayMenu = true;
            while (displayMenu)
                displayMenu = MainMenu();

        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("******************** TOPIC EIGHT: Classes ********************");
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("Type the number of the task you'd like to view.");
            Console.WriteLine("\n1 - Cars\n2 - Create A Person\n3 - Animal with Random ID\n4 - The Animal Says...\n5 - Employee\n6 - Exit");

            string result = Console.ReadLine();

            if (result == "1")
            {
                TaskOne();
                return true;
            }
            else if (result == "2")
            {
                TaskTwo();
                return true;
            }
            else if (result == "3")
            {
                TaskThree();
                return true;
            }
            else if (result == "4")
            {
                TaskFour();
                return true;
            }

            else if (result == "5")
            {
                TaskFive();
                return true;
            }
            else if (result == "6")
                return false;
            else
                return true;
        }

        public static void TaskOne()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("********************* Cars ********************");
            Console.WriteLine("***********************************************");

            Car c1 = new Car("Ford", "Ranger", "White", "HWC438");
            Car c2 = new Car("Mazda", "Axela", "Silver", "HZU511");
            Car c3 = new Car("Ford", "Cortina", "Green", "IT9086");
            Car c4 = new Car("Chevrolet", "Impala", "Cream", "DF234");
            Car c5 = new Car("Holden", "Kingswood", "Blue", "FR6582");


            Console.WriteLine("\nCar Collection");
            Console.WriteLine("Make: {0}\nModel: {1}\nColor: {2}\nRego: {3}", c1.Make, c1.Model, c1.Color, c1.Rego);
            Console.WriteLine("\nMake: {0}\nModel: {1}\nColor: {2}\nRego: {3}", c2.Make, c2.Model, c2.Color, c2.Rego);
            Console.WriteLine("\nMake: {0}\nModel: {1}\nColor: {2}\nRego: {3}", c3.Make, c3.Model, c3.Color, c3.Rego);
            Console.WriteLine("\nMake: {0}\nModel: {1}\nColor: {2}\nRego: {3}", c4.Make, c4.Model, c4.Color, c4.Rego);
            Console.WriteLine("\nMake: {0}\nModel: {1}\nColor: {2}\nRego: {3}", c5.Make, c5.Model, c5.Color, c5.Rego);


            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
        public class Car
        {
            private string make;
            private string model;
            private string color;
            private string rego;

            public string Make
            {
                get { return make; }
                set { make = value; }
            }
            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            public string Color
            {
                get { return color; }
                set { color = value; }
            }
            public string Rego
            {
                get { return rego; }
                set { rego = value; }
            }
            public Car(string _make, string _model, string _color, string _rego)
            {
                Make = _make;
                Model = _model;
                Color = _color;
                Rego = _rego;
            }
        }


        public static void TaskTwo()
        {
            Console.Clear();
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
            Console.WriteLine("\n>>> USER DETAILS <<<");
            Console.WriteLine("Full Name: {0} {1}", p1.Fname, p1.Lname);
            p1.DisplayAge();


            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
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
                Console.WriteLine("Age: " + Age);
            }

        }

        public static void TaskThree()
        {
            Random rand = new Random();
            Console.Clear();
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
            foreach (Animal y in list1)
            {
                Console.WriteLine(y.Name + "\t" + y.Type + "\t" + y.RandomId);
            }

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
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
        static public int RandId(Random rand)
        {

            return rand.Next(1000, 9999);
        }

        public static void TaskFour()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************* The Animal Says... **************");
            Console.WriteLine("***********************************************");

            string userResponse = "";
            do
            {
                Console.Write("\nPlease type the name of an animal: ");
                string aniName = Console.ReadLine();
                Console.Write("Type the sound that this animal makes: ");
                string aniSound = Console.ReadLine();

                AnimalWhoSpeaks a1 = new AnimalWhoSpeaks(aniName, aniSound);
                a1.AniSays();

                Console.WriteLine("\nWould you like to have another turn - y/n?");
                userResponse = Console.ReadLine().ToLower();

            } while (userResponse == "y");

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }
        class AnimalWhoSpeaks
        {
            private string aniName;
            private string aniSound;

            public string AniName { get { return aniName; } set { aniName = value; } }
            public string AniSound { get { return aniSound; } set { aniSound = value; } }

            public void AniSays()
            {
                Console.WriteLine("The {0} says '{1}'.", AniName, AniSound);
            }

            public AnimalWhoSpeaks(string _aniName, string _aniSound)
            {
                AniName = _aniName;
                AniSound = _aniSound;
            }
        }

        public static void TaskFive()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("****************** Employee *******************");
            Console.WriteLine("***********************************************");

            Console.Write("\nPlease type your first name and press enter: ");
            string fname = Console.ReadLine();
            Console.Write("Please enter your last name and press enter: ");
            string lname = Console.ReadLine();
            Console.Write("Now enter your gross annual salary: $");
            decimal grossAnnualSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please enter your tax rate (percent): ");
            decimal taxRate = Convert.ToDecimal(Console.ReadLine());

            Employee e1 = new Employee(fname, lname, grossAnnualSalary, taxRate);

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("****************** Employee *******************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n>>> EMPLOYEE DETAILS <<<");
            Console.WriteLine("Name: " + e1.Fname + " " + e1.Lname + "\nGross Annual Salary: $" + e1.GrossAnnualSalary + "\nTax Rate (percent): " + e1.TaxRate + "\nNet Income: $" + e1.NetSalary());

            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadLine();
        }
        class Employee
        {
            private string fname;
            private string lname;
            private decimal grossAnnualSalary;
            private decimal taxRate;

            public string Fname { get; set; }
            public string Lname { get; set; }
            public decimal GrossAnnualSalary { get; set; }
            public decimal TaxRate { get; set; }

            public decimal NetSalary()
            {
                decimal taxDeduction = (TaxRate / 100) * GrossAnnualSalary;
                decimal netIncome = GrossAnnualSalary - taxDeduction;
                return netIncome;
            }

            public Employee(string _fname, string _lname, decimal _grossAnnualSalary, decimal _taxRate)
            {
                Fname = _fname;
                Lname = _lname;
                GrossAnnualSalary = _grossAnnualSalary;
                TaxRate = _taxRate;
            }
        }

    }
}
