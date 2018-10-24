using System;

namespace Enums
{
    class Program
    {
        //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
        //1.Create an enum for the days of the week.

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main()
        {
            //2. Prompt the user to enter the current day of the week.
            Console.WriteLine("Enter Current Day of Week: ");
            string input = Console.ReadLine();

            //3. Assign the value to a variable of that enum data type you just created.
            try
            {
                DaysOfWeek Day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input);
                Console.WriteLine("You Entered {0}", Day);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            
            //4. Wrap the above statement in a try/catch block and have it print 
            //    "Please enter an actual day of the week." to the console if an error occurs.
            //Note - In the last video, we explained the underlying concepts behinds enums.
            //    Nobody knows everything about a programming language and its features, 
            //    so it's our job as programmers to do research on how to work with various 
            //    data types, classes and libraries. For this drill, you'll need to do some 
            //    additional research on how to parse enums.

        }
    }
}

