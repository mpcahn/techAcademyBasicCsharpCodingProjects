using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
            //1.Create a class. In that class, create a void method that takes two integers as parameters.
            //Have the method do a math operation on the first integer and display the second integer to the screen.
            //2. In the Main() method of the console app, instantiate the class.
            IntMethods intMethod = new IntMethods();
            //3. Call the method in the class, passing in two numbers.
            intMethod.integers(4, 3);
            //4. Call the method in the class, specifying the parameters by name.
            intMethod.integers(int1: 4,int2: 3);
        }
    }
}
