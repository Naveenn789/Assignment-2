using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Employee ID:");
            int employeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string employeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender (M/F):");
            char employeeGender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary:");
            double employeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Joining (DD/MM/YYYY):");
            DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            double taxRate = (employeeSalary > 90000) ? 0.3 : 0.15;
            double taxAmount = employeeSalary * taxRate;


            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Employee ID: {employeeId}");
            Console.WriteLine($"Employee Name: {employeeName}");
            Console.WriteLine($"Employee Gender: {employeeGender}");
            Console.WriteLine($"Employee Salary: {employeeSalary:C}");
            Console.WriteLine($"Date of Joining: {doj:dd/MM/yyyy}");
            Console.WriteLine("\nTax Calculation:");
            Console.WriteLine($"Tax Rate: {taxRate:P}");
            Console.WriteLine($"Tax Amount: {taxAmount:C}");
            Console.WriteLine($"You have to pay: {employeeSalary - taxAmount:C}");




            Console.ReadKey();

        }
    }
}
