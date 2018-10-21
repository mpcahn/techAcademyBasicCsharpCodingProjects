using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClass
{
    class Employee : Person, IQuittable
    {
        //3. Create another class called Employee and have it inherit from the Person class. 
        //   Give the Employee class a property called Id and have it be of data type int.
        public int Id { get; set; }

        //2. Have your Employee class from the previous drill inherit that interface and implement 
        //  the Quit() method in any way you choose.
        public void Quit()
        {
            Console.WriteLine("Quit");
            Console.ReadLine();
        }
    }
}
