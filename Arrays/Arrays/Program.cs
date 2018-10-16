using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //1.Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] week = new string[7];
            week[0] = "Sunday";
            week[1] = "Monday";
            week[2] = "Tuesday";
            week[3] = "Wednesday";
            week[4] = "Thursday";
            week[5] = "Friday";
            week[6] = "Saturday";

            Console.WriteLine("Choose a number between 0 and 6: ");
            int selection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(week[selection]);
            Console.ReadLine();

            //2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] intArr = new int[4];

            intArr[0] = 1;
            intArr[1] = 1;
            intArr[2] = 2;
            intArr[3] = 4;

            Console.WriteLine("Choose a number between 0 and 3: ");
            selection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(intArr[selection]);
            Console.ReadLine();

            //3. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Denver");
            cities.Add("Bangkok");
            cities.Add("Paris");

            Console.WriteLine("Choose a number between 0 and 3: ");
            selection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(cities[selection]);
            Console.ReadLine();
        }
    }
}
