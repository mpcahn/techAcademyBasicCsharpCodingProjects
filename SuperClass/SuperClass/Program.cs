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
            //1.Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.
            //2. Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]".
            //3. Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
            //4. Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student".
            Employee Employee1 = new Employee() { FirstName="Sample", LastName="Student" };

            //5. Call the superclass method SayName() on the Employee object.
            Employee1.SayName();
            Console.ReadLine();

            //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
            //1.Create an interface called IQuittable and have it define a void method called Quit().
            //2. Have your Employee class from the previous drill inherit that interface and implement 
            //  the Quit() method in any way you choose.
            //3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
            //  Hint: an object can be of an interface type if it implements that specific interface.
            IQuittable quit = Employee1;

            quit.Quit();

        }
    }
}
