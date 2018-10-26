using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Print the current date and time to the console.
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //2. Asks the user for a number.
            Console.WriteLine("Enter an integer");
            int integer = Convert.ToInt32(Console.ReadLine());

            //3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            DateTime future = now.AddHours(integer);
            Console.WriteLine("In {0} hours the date and time will be {1}", integer, future);
            Console.Read();
        }
    }
}
