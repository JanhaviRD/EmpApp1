using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace organization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            EmployeeDatabase database = new EmployeeDatabase();
            while (true)
            {
                Console.WriteLine("\n----------------------Employee Management System----------------------");
                Console.WriteLine("1. Create Employee\n");
                Console.WriteLine("2. Display Employee\n");
                Console.WriteLine("3. Delete Employee\n");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.Write("\n Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        database.CreateEmployee();
                        break;
                    case "2":
                        database.DisplayEmployee();
                        break;
                    case "3":
                        database.DeleteEmployee();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
