using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndMethods3
{
    class MathOps
    {
        //1.Create a class. In that class, create a method that takes two integers as parameters.
        //  Make one of them optional.Have the method do a math operation and return a integer result.
        public int MathOp (int int1, int int2 = 1)
        {
            return int1 + int2;
        }
    }
}
