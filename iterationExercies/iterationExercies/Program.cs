using System;
using System.Collections.Generic;

namespace iterationExercies
{
    class Program
    {
        static void Main()
        {
            //1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each string in the Array, 
            //adding the user’s text to the string.Then create a loop that prints off each string in the Array on a separate line.
            string[] arrString = new string[] { "string 1", "string 2", "string 3" };
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            int i = 0;
            while (i < arrString.Length)
            {
                arrString[i] = arrString[i] + text;
                i++;
            }

            i = 0;
            while (i < arrString.Length)
            {
                Console.WriteLine(arrString[i]);
                i++;
            }

            Console.ReadLine();

            //2.Create an infinite loop.
            //i = 0;
            //while (i < arrString.Length)
            //{
            //    Console.WriteLine(arrString[i]);                
            //}

            //3.Fix the infinite loop so it will execute.
            i = 0;
            while (i < arrString.Length)
            {
                Console.WriteLine(arrString[i]);
                i++;
            }

            Console.ReadLine();

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            i = 0;
            while (i < arrString.Length)
            {
                Console.WriteLine(arrString[i]);
                i++;
            }

            Console.ReadLine();
            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            i = 0;
            while (i <= arrString.Length - 1)
            {
                Console.WriteLine(arrString[i]);
                i++;
            }

            Console.ReadLine();
            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.
            //Create a loop that iterates through the loop (list?) and then displays the index of the array that contains matching text on the screen.
            List<string> states = new List<string>();
            states.Add("CO");
            states.Add("FL");
            states.Add("CA");
            states.Add("NY");

            Console.WriteLine("Enter state: ");
            string search = Console.ReadLine();
            Boolean found = false;
            i = 0;

            foreach (string state in states)
            {
                if (search == states[i])
                {
                    Console.WriteLine("index of " + states[i] + ": " + i);
                    Console.ReadLine();
                    found = true;
                    break;
                }
                i++;
            }         

            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            if (found == false)
            {
                Console.WriteLine(search + " is not in the list.");
                Console.ReadLine();
            }

            //8.Add code to that above loop that stops it from executing once a match has been found.

            // Added break statement


            //9.Create a List of strings that has at least two identical strings in the List. 
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Harry");
            names.Add("Michael");
            names.Add("Harry");
            names.Add("Matt");

            // Ask the user to select text to search for in the List.
            Console.WriteLine("Enter name: ");
            search = Console.ReadLine();
            found = false;
            i = 0;
                       
            // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            foreach (string name in names)
            {
                if (search == names[i])
                {
                    Console.WriteLine("index of " + names[i] + ": " + i);
                    Console.ReadLine();
                    found = true;
                }
                i++;
            }

            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            if (found == false)
            {
                Console.WriteLine(search + " is not in the list.");
                Console.ReadLine();
            }
            //11.Create a List of strings that has at least two identical strings in the List. 
            List<string> countries = new List<string>();
            countries.Add("USA");
            countries.Add("Thailand");
            countries.Add("USA");
            countries.Add("France");
            countries.Add("Israel");
            countries.Add("China");

            // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> countriesFresh = new List<string>();
            List<string> countriesDup = new List<string>();

            foreach (string country in countries)
            {
                if (!countriesFresh.Contains(country))
                {
                    countriesFresh.Add(country);
                    Console.WriteLine(country + " has not appeared in the list");
                }
                else
                {
                    countriesDup.Add(country);
                    Console.WriteLine(country + " has appeared in the list");
                }
            }
            Console.ReadLine();
        }
    }
}
