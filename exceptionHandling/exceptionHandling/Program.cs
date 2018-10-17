using System;
using System.Collections.Generic;

namespace exceptionHandling
{
    class Program
    {
        static void Main()
        {
            //1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            List<int> intList = new List<int>() { 1, 1, 2, 4, 8, 16, 32 };
            Console.WriteLine("Pick an integer, any integer");
            //int devisor = Convert.ToInt32(Console.ReadLine());


            //foreach (var integer in intList)
            //{
            //    Console.WriteLine((float)integer / (float)devisor);
            //}            

            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.
            //RESULTS:
            //Pick an integer, any integer
            //6
            //0.1666667
            //0.1666667
            //0.3333333
            //0.6666667
            //1.333333
            //2.666667
            //5.333333

            //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.
            //RESULTS:
            //Pick an integer, any integer
            //0
            //∞
            //∞
            //∞
            //∞
            //∞
            //∞
            //∞


            //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.
            // RESULTS: Crashed and showed the following: System.FormatException
            //          HResult = 0x80131537
            //Message = Input string was not in a correct format.
            //  Source = mscorlib
            //StackTrace:
            //          at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer & number, NumberFormatInfo info, Boolean parseDecimal)
            // at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
            // at System.Convert.ToInt32(String value)
            // at exceptionHandling.Program.Main() in C: \Users\Matt\Source\Repos\mpcahn\techAcademyBasicCsharpCodingProjects\exceptionHandling\exceptionHandling\Program.cs:line 13

            //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program 
            //                    display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.
            //                    In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.
            //                    Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

            try
            {
                int devisor = Convert.ToInt32(Console.ReadLine());

                foreach (var integer in intList)
                {
                    Console.WriteLine(integer / devisor);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type in a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't devide by zero");
            }

            Console.ReadLine();
        }
    }
}
