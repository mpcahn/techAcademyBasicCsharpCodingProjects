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
            //GENERICS
            //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
            //1.Make the Employee class take a generic type parameter.
            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
            //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
            Employee<string> Employee1 = new Employee<string>();
            Employee1.Things = new List<string>();
            Employee1.Things.Add("List");
            Employee1.Things.Add("of");
            Employee1.Things.Add("Strings");

            for (int i = 0; i < Employee1.Things.Count; i++)
            {
                Console.WriteLine(Employee1.Things[i]);
            }
            Console.ReadLine();

            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
            Employee<int> Employee2 = new Employee<int>();
            Employee2.Things = new List<int>();
            Employee2.Things.Add(1);
            Employee2.Things.Add(3);
            Employee2.Things.Add(2);

            //5. Create a loop that prints all of the Things to the Console.
            for (int i = 0; i < Employee2.Things.Count; i++)
            {
                Console.WriteLine(Employee2.Things[i]);
            }
            Console.ReadLine();
        }
    }
}
