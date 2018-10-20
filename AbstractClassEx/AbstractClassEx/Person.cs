using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx
{
    public abstract class Person
    {
        //1.Create an abstract class called Person with two properties: string firstName and string lastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //2. Give it the method SayName().
        public abstract void SayName();       
    }
}
