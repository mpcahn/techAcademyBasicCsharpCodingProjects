using System;
using System.Text;

namespace funWithStrings
{
    class Program
    {
        static void Main()
        {
            //Concatenate three strings.
            string str1 = "Are you ready kids?";
            string str2 = "\n Aye-aye captain.";
            string str3 = "\n I can't hear you!";
            string concat = str1 + str2 + str3;
            Console.WriteLine(concat);
            Console.ReadLine();

            //Convert a string to uppercase.
            string str2Upper = str2.ToUpper();
            Console.WriteLine(str2Upper);
            Console.ReadLine();

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append("Ohhhhhh!Who lives in a pineapple under the sea?");
            string sponge = "\n        SpongeBob SquarePants!";
            sb.Append(sponge);
            sb.Append("\n    Absorbent and yellow and porous is he!");
            sb.Append(sponge);

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
