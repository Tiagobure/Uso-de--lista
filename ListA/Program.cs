using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ListA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?");
            int fun = int.Parse(Console.ReadLine());

            List<Employee> lts = new List<Employee>();


            for (int i = 1; i <= fun; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lts.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = lts.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");

            foreach (Employee obj in lts)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Enter for exit...");
            Console.ReadLine();

        }
    }
}
