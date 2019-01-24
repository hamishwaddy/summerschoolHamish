using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicNineCollectionsAllTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("****************** TOPIC NINE: Collections *******************");
            Console.WriteLine("**************************************************************\n");

            bool displayMenu = true;
            while (displayMenu)
                displayMenu = MainMenu();
        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("****************** TOPIC NINE: Collections *******************");
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("Type the number of the task you'd like to view.");
            Console.WriteLine("\n1 - Arrays Revision 1\n2 - Arrays Revision 2\n3 - Arrays Revision 3\n4 - 50 Random Numbers\n5 - Fruit Dictionary\n6 - Cities Dictionary\n7 - Person Dictionary\n8 - Animals List\n9 - Names List\n10 - Exit");
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
            {
                TaskSix();
                return true;
            }
            else if (result == "7")
            {
                TaskSeven();
                return true;
            }
            else if (result == "8")
            {
                TaskEight();
                return true;
            }
            else if (result == "9")
            {
                TaskNine();
                return true;
            }
            else if (result == "10")
                return false;

            else
                return true;
        }

        public static void TaskOne()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 1 ************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app holds 5 peoples names. It uses an array to hold five names that are entered by the user at runtime.\n");

            Console.WriteLine("Please type a name and press enter: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Please type a second name and press enter: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Please type a third name and press enter: ");
            string name3 = Console.ReadLine();
            Console.WriteLine("Please type a fourth name and press enter: ");
            string name4 = Console.ReadLine();
            Console.WriteLine("Please type a fifth name and press enter: ");
            string name5 = Console.ReadLine();

            string[] fiveNames = { name1, name2, name3, name4, name5 };

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 1 ************");
            Console.WriteLine("***********************************************\n");
            Console.WriteLine("The names entered were: " + fiveNames[0] + ", " + fiveNames[1] + ", " + fiveNames[2] + ", " + fiveNames[3] + " & " + fiveNames[4]);
            
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();

        }

        public static void TaskTwo()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 2 ************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app uses a loop to fill an int array of size 10 with random numbers between 1 to 10. After this the average is calculated by looping/iterating through the array.\n");

            int[] nums = new int[10];
            int total = 0;

            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 10);
                total += nums[i];
            }
            
            foreach (int x in nums)
                Console.WriteLine(x);

            Console.WriteLine("The average is equal to: {0}.", total / nums.Length);
            

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static void TaskThree()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 3 ************");
            Console.WriteLine("***********************************************");

            int[] nums = new int[20];

            Random rand = new Random();

            Console.WriteLine("\nOriginal unsorted array:");
            for (int i = 1; i <= nums.Length; i++)
            {
                nums[i - 1] = rand.Next(0, 100);
                Console.Write(nums[i - 1] + " ");
                if (i % 10 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine("\nSorted array:");
            for (int x = 1; x < nums.Length; x++)
            {
                Array.Sort(nums);
                Console.Write(nums[x - 1] + " ");
                if (x % 10 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static void TaskFour()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** ARRAY REVISION: Task 4 ************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app uses an array that can hold 50 random numbers between 1 and 100. It uses an Array Class method to find the index of one of the numbers that is displayed in the array.The original array is then copied to a new array. This copied array is then displayed having been sorted both 'ascending' and 'descending'.\n");
            
            int[] nums = new int[50];

            Random rand = new Random();

            for (int x = 1; x <= nums.Length; x++)
            {
                nums[x - 1] = rand.Next(1, 100);
                Console.Write(nums[x - 1] + " ");
                if (x % 10 == 0)
                    Console.WriteLine();
            }

            Console.Write("\nChoose a number from the list above and enter it here: ");
            int userInput = int.Parse(Console.ReadLine());

            int numPosition = Array.IndexOf(nums, userInput);

            Console.WriteLine("The number you selected was in index position: {0}", numPosition);

            int[] nums2 = new int[50];
            Array.Copy(nums, nums2, 50);

            Console.WriteLine("\nThis is a copied version of the array above - sorted ascending.");
            for (int i = 1; i <= nums2.Length; i++)
            {
                Array.Sort(nums2);
                Console.Write(nums2[i - 1] + " ");
                if (i % 10 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine("\n\nThis is a copied version of the array above - sorted descending.");
            for (int i = 1; i <= nums2.Length; i++)
            {
                Array.Sort(nums2);
                Array.Reverse(nums2);
                Console.Write(nums2[i - 1] + " ");
                if (i % 10 == 0)
                    Console.WriteLine();
            }
            
            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static void TaskFive()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************** Fruit Dictionary ***************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app uses a dictionary to hold info about fruit. The dictionary contains the fruit type and the cost.\n");

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Apple", "$1.25");
            dict.Add("Banana", "$2.25");
            dict.Add("Kiwifruit", "$4.20");
            dict.Add("Watermelon", "$3.95");
            dict.Add("Oranges", "$2.55");

            Console.WriteLine(">>>FRUIT PRICES PER KG<<<");

            foreach (KeyValuePair<string, string> item in dict)
            {
                Console.WriteLine("Fruit: {0}, Price: {1}", item.Key, item.Value);
            }

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static void TaskSix()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** City Dictionary ***************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app will ask you to enter the names of your ten favourite cities.");

            Dictionary<int, string> citiesDict = new Dictionary<int, string>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a city: ");
                citiesDict.Add(i, Console.ReadLine());
            }


            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** City Dictionary ***************");
            Console.WriteLine("***********************************************\n");
            Console.WriteLine(">>> Cities Dictionary <<<");
            foreach (KeyValuePair<int, string> item in citiesDict)
            {
                Console.WriteLine("Key: {0}\tValue: {1}", item.Key, item.Value);
            }

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static void TaskSeven()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************** Person Dictionary **************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app contains a Person class which has properties for first name, last name and age. The app uses a dictionary to store the person objects that are created. The key is a 4 digit number and is populated by using a loop. 5 person objects have been created with the necessary properties filled in.\n");

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

        public static void TaskEight()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Animals List ****************");
            Console.WriteLine("***********************************************\n");

            List<string> Animals = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Type the name of an animal: ");
                Animals.Add(Console.ReadLine());
            }
            
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Animals List ****************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("Here is the list of animals you entered:");
            foreach (string animalType in Animals)
            {
                Console.WriteLine("\t" + animalType);
            }

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static void TaskNine()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Names List ******************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app uses a list to store a collection of names input by the user. The app contains a loop that will continuously asks the user for a name, adds it to the list and then asks if the user wants to add another name. If the user wants to add another name it will stay inside of the loop until the user doesn't want to add anymore names at which point the application will break out of the loop and all of the names the user has input will be displayed back to them.\n");

            List<string> Names = new List<string>();

            string userResponse = "y";

            do
            {
                Console.Write("Enter a name: ");
                Names.Add(Console.ReadLine());

                Console.Write("Do you want to add another (y/n): ");
                userResponse = Console.ReadLine().ToLower();

            } while (userResponse == "y");

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Names List ******************");
            Console.WriteLine("***********************************************\n");

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine("\nPress any key to return the main menu.");
            Console.ReadLine();
        }
    }
}
