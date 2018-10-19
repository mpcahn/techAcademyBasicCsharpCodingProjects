using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndMethods4
{   
    class MathOps
    {
        //1.Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.
        public void DevideBy2(int i, out int output)
        {
            output = i / 2;
        }

        //4. Create a method with output parameters.
        //5. Overload a method.
        public void DevideBy2(double i, out double output)
        {
            output = i / 2;
        }       
    }

}
