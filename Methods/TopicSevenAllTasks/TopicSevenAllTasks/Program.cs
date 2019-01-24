using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicSevenAllTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("******************** TOPIC SEVEN: Methods ********************");
            Console.WriteLine("**************************************************************\n");

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("******************** TOPIC SEVEN: Methods ********************");
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("Type the number of the task you'd like to view.");
            Console.WriteLine("\n1 - Task One\n2 - Task Two\n3 - Task Three\n4 - Task Four\n5 - Task Five\n6 - Task Six\n7 - Task Seven\n8 - Task Eight\n9 - Exit");

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
                return false;
            }
            else
                return true;

        }



        public static void TaskOne()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************* Return Opposite Sign ************");
            Console.WriteLine("***********************************************");

            Console.Write("\nEnter a number: ");
            int userNum = int.Parse(Console.ReadLine());

            int swapped = SwapNumber(userNum);

            Console.WriteLine("Your swapped number is: {0}", swapped);
            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static int SwapNumber(int input)
        {
                var swapped = input * -1;
                return swapped;
        }

        public static double SwapNumber(double input)
        {
                return input * -1;
        }


        
        public static void TaskTwo()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************* Convert Miles to KM *************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("Type in the number of miles away you live.");
            double userNum = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************* Convert Miles to KM *************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("The distance in miles is: {0}", userNum);
            Console.WriteLine("The distance in kilometres is: {0}", ConvertToKm(userNum));


            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();

        }

        public static double ConvertToKm(double input)
        {
            return input * 0.62137;
        }



        public static void TaskThree()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******************* Circles *******************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("\nWhat is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******************* Circles *******************");
            Console.WriteLine("***********************************************");
            Console.Write("\nThe radius of your circle was: {0}.", radius);
            Console.WriteLine("\nThe circumference of your circle is: {0}.", ConvertToCircumference(radius));
            Console.WriteLine("The area of your circle is: {0}.", ConvertToArea(radius));

            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();

        }

        public static double ConvertToCircumference(double input)
        {
            return input * 2 * 3.1416;
        }

        public static double ConvertToArea(double input)
        {
            return input * input * 3.1416;
        }



        public static void TaskFour()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("****************** Week Days ******************");
            Console.WriteLine("***********************************************");

            Console.Write("\nEnter a number between 1 & 7 to represent a day of the week: ");
            int userInput = int.Parse(Console.ReadLine()) - 1;

            string convertedDay = DaysOfWeek(userInput);


            Console.WriteLine("The number you chose was {0}. This equates to {1}.", userInput+1, convertedDay);

            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static string DaysOfWeek(int input)
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            string result = weekDays[input];
            return result;

        }



        public static void TaskFive()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** BMI Calculator ***************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("\nThis application will work out your BMI (body mass index).");

            Console.Write("\nPlease enter your weight (in kilograms) and press enter: ");
            double userWeight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height (in metres) and press enter: ");
            double userHeight = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** BMI Calculator ***************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Your weight is {0} kilograms.", userWeight);
            Console.WriteLine("Your height is {0} metres.", userHeight);
            double result = BmiCalc(userWeight, userHeight);
            Console.WriteLine("\nYour BMI is: {0}", result);
            Console.WriteLine("\nYour BMI category is {0}.", BmiCategorizer(result));

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static double BmiCalc(double userWeight, double userHeight)
        {
            double result = (userWeight / (userHeight * userHeight));
            result = Math.Round(result, 2);
            return result;
        }

        public static string BmiCategorizer(double BmiCalc)
        {
            string result = "";

            if (BmiCalc < 18.5)
            {
                result = "'underweight'";
            }
            else if (BmiCalc >= 18.5 && BmiCalc < 25)
            {
                result = "'normal weight'";
            }
            else if (BmiCalc >= 25 && BmiCalc < 30)
            {
                result = "'overweight'";
            }
            else
            {
                result = "'obese'";
            }
            return result;
        }



        public static void TaskSix()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Rounding Money ***************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("This application will work out whether to round your change up or down.");
            Console.WriteLine("If the amount ends in a 1, 2, 3, 4 or 5 your total will round down.");
            Console.WriteLine("If the amount ends in a 6, 7, 8 or 9 your total will round up.");
            Console.Write("\nPlease enter the last digit of the cents amount: ");

            int endingCents = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFor this amount you need to {0}.", RoundingDecision(endingCents));

            Console.WriteLine("\n" +
                "Press any key to return to the main menu.");
            Console.ReadLine();
        }

        public static string RoundingDecision(int endingCents)
        {
            string result = "";

            switch (endingCents)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    result = "round down";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    result = "round up";
                    break;
            }
            return result;
        }


        
        public static void TaskSeven()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** Hello Translator **************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("\nThis application will translate the word 'hello' into various languages.");
            Console.WriteLine("\nSelect a number to see the translation:");
            Console.WriteLine("1 - Maori\n2 - Japanese\n3 - Hindi\n4 - French\n5 - Samoan");

            string[] languages = { "Maori", "Japanese", "Hindi", "French", "Samoan" };

            int userInput = int.Parse(Console.ReadLine());
            string result = Translator(userInput);

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*************** Hello Translator **************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Your selection was '{0}'. This translates to '{1}'.", languages[userInput - 1], result);

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();


        }

        public static string Translator(int userInput)
        {
            string[] helloTranslator = { "Kia ora", "Kon'nichiwa", "Namaste", "Bonjour", "Talofa" };

            string result = helloTranslator[userInput - 1];
            return result;

        }



        public static void TaskEight()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Maths Operator ***************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("\nThis application will work out a basic 2-number calculation for you.");

            Console.Write("Please enter your first number: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Select an operator to use: +, -, *, /, or %");
            char userOperator = Convert.ToChar(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Maths Operator ***************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\nHere is the calculation you ordered:");
            Console.WriteLine("{0} {1} {2} = {3}", num1, userOperator, num2, Calculator(num1, num2, userOperator));



            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static decimal Calculator(decimal num1, decimal num2, char userOperator)
        {
            decimal result;

            if (userOperator == '+')
            {
                result = num1 + num2;
            }
            else if (userOperator == '-')
            {
                result = num1 - num2;
            }
            else if (userOperator == '*')
            {
                result = num1 * num2;
            }
            else if (userOperator == '/')
            {
                result = Math.Round(num1 / num2, 2);
            }
            else if (userOperator == '%')
            {
                result = num1 % num2;
            }
            else
            {
                result = 0;
            }


            return result;
        }


    }
}
