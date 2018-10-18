using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Enter an Integer:");
            int num = Convert.ToInt32(Console.ReadLine());

            //3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.
            IntMethods IntMethod = new IntMethods();

            Console.WriteLine(num + " + 5 = " + IntMethod.Add5(num));
            Console.WriteLine(num + " - 5 = " + IntMethod.Subtract5(num));
            Console.WriteLine(num + " * 5 = " + IntMethod.Mult5(num));
            Console.ReadLine();
        }
    }
}
