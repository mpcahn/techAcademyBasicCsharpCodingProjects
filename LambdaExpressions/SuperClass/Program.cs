using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
            //1. In the Main() method, create a list of at least 10 employees.
            // Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".            
            var employeeList = new List<Employee>()
            {
                new Employee() { FirstName = "Joe", LastName = "Smith", Id = 1 },
                new Employee() { FirstName = "Jane", LastName = "Smith", Id = 2 },
                new Employee() { FirstName = "Mark", LastName = "Smith", Id = 3 },
                new Employee() { FirstName = "Matt", LastName = "Smith", Id = 4 },
                new Employee() { FirstName = "Joe", LastName = "Smith", Id = 5 },
                new Employee() { FirstName = "Joe", LastName = "Smith", Id = 6 },
                new Employee() { FirstName = "Jill", LastName = "Smith", Id = 7 },
                new Employee() { FirstName = "Cole", LastName = "Smith", Id = 8 },
                new Employee() { FirstName = "Kimberly", LastName = "Smith", Id = 9 },
                new Employee() { FirstName = "Ron", LastName = "Smith", Id = 10 }
            };

            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".
            var JoeList = new List<Employee>();

            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }

            //3. Do the same thing again, but this time with a lambda expression.
            List<Employee> JoeLambda = employeeList.Where(x => x.FirstName == "Joe").ToList();

            //4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> idOver5 = employeeList.Where(x => x.Id > 5).ToList();            
        }
    }
}
