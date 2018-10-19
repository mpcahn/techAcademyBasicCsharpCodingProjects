using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndMethods4
{
    class Program
    {
        static void Main(string[] args)
        {
            //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
            //1.Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.
            //2. In the Main() method, instantiate that class.
            MathOps MathOp = new MathOps();

            //3. Have the user enter a number.Call the method on that number.Display the output to the screen. 
            //  It should be the entered number, divided by two.
            Console.WriteLine("Enter an integer:");
            int input = Convert.ToInt16(Console.ReadLine());
            int output;
            MathOp.DevideBy2(input, out output);
            Console.WriteLine("Your integer / 2 = {0}", output);
            Console.ReadLine();

            //4. Create a method with output parameters.
            //5. Overload a method.
            //6. Declare a class to be static. --See staticClass.cs
        }
    }
}
