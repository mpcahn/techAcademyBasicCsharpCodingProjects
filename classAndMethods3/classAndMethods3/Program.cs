using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class. In that class, create a method that takes two integers as parameters.
            //  Make one of them optional.Have the method do a math operation and return a integer result.
            //2. In the Main() method of the console app, instantiate the class.
            MathOps MathOp = new MathOps();
            //3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.
            Console.WriteLine("Input int1:");
            int int1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input int2 (optional):");
            try
            {
                int int2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(MathOp.MathOp(int1: int1, int2: int2));
            }
            catch (FormatException)
            {
                Console.WriteLine(MathOp.MathOp(int1: int1));
            }
            Console.ReadLine();

            //4. Call the method in the class, passing in the one or two numbers entered.
            //5. Try various combinations of numbers on the code, including having no second number.
            Console.WriteLine(MathOp.MathOp(int1: 3, int2: 5));
            Console.WriteLine(MathOp.MathOp(int1: 4, int2: 4));
            Console.WriteLine(MathOp.MathOp(int1: 5, int2: 3));
            Console.WriteLine(MathOp.MathOp(int1: 5));
            Console.ReadLine();
        }
    }
}
