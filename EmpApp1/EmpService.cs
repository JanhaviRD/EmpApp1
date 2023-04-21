
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organization
{
    class EmployeeDatabase
    {
        private List<Employee> employees = new List<Employee>();

        public void CreateEmployee()
        {
            Console.WriteLine("----------------------Add Employee------------------------------\n\n");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Enter employee id          : ");
            string id = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Enter employee name        : ");
            string name = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Enter employee designation : ");
            string designation = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Enter employee salary      : ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------");
            Employee employee = new Employee { Id = id, Name = name, Designation = designation, Salary = salary };
            employees.Add(employee);
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("---------------------Display Employee--------------------------------\n");
            Console.Write("Enter employee id: ");
            string id = Console.ReadLine();
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("ID             : " + employee.Id);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Name           : " + employee.Name);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Designation    : " + employee.Designation);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Salary         : " + employee.Salary);
                    Console.WriteLine("------------------------------------------------------");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("---------------------Delete Employee--------------------------------------\n");
            Console.Write("Enter employee id: ");
            string id = Console.ReadLine();
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    employees.Remove(employee);
                    Console.WriteLine(" .........Employee deleted successfully!.............");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }
    }
}
