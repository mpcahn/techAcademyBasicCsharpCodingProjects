using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndMethods2
{
    class MathOps
    {
        //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
        //1.Create a class. In that class, create a method that will take in an integer, 
        //  do a math operation to it and then return the answer as an integer.
        public int MathOp(int i)
        {
            return i + 5;
        }
        //3. Add a second method to the class, with the same name, that will take in a decimal, 
        //  do a different math operation to it and then return the answer as an integer.
        public double MathOp(double dub)
        {
            return dub / 2;
        }
        //5. Add a third method to the class, with the same name, that will take in a string, 
        //  convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.
        public int MathOp(string str)
        {
            int i = Convert.ToInt32(str);
            return i / 5;
        }

    }
}
