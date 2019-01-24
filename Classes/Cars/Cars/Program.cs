using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
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
}
