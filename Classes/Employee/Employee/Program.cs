using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
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
            decimal taxDeduction = (TaxRate / 100)*GrossAnnualSalary;
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

    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("EMPLOYEE DETAILS:");
            Console.WriteLine("Name: " + e1.Fname + " " + e1.Lname + "\nGross Annual Salary: $" + e1.GrossAnnualSalary + "\nTax Rate (percent): " + e1.TaxRate + "\nNet Income: $" + e1.NetSalary());


            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadLine();
        }
    }
}
