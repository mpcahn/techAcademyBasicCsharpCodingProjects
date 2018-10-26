using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask a user for a number.
            Console.WriteLine("Wanna see a magic trick? Enter an integer:");
            string str = Console.ReadLine();
            //2.Log that number to a text file.
            File.WriteAllText(@"C:\Users\Matt\logs\log.txt", str);
            //3.Print the text file back to the user.
            string log = File.ReadAllText(@"C:\Users\Matt\logs\log.txt");
            Console.WriteLine("You entered {0}", log);
            Console.Read();
        }
    }
}
