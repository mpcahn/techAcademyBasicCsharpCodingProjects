using System;

namespace MoreExceptionHandlingExample
{
    //4.Display appropriate error messages if user enters zero or negative numbers.
    public class ZeroException : Exception
    {
        public ZeroException() : base() { }
        public ZeroException(string message) : base(message) { }
    }

    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base() { }
        public NegativeNumberException(string message) : base(message) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1.Ask the user for his age.
                Console.WriteLine("What is your age?");
                var age = Convert.ToInt32(Console.ReadLine());
                if (age == 0) { throw new ZeroException(); }
                if (age < 0) { throw new NegativeNumberException(); }
                //2.Display the year user born.
                var now = new DateTime();
                now = DateTime.Now;
                var year = now.Year - age;
                Console.WriteLine("You were born in the year {0}", year);
                Console.Read();
                
            }
            //3.Exceptions must be handled using "try .. catch".

            //4.Display appropriate error messages if user enters zero or negative numbers.
            catch (ZeroException)
            {
                Console.WriteLine("Pretty Verbose for someone who is 0 years old");
                Console.Read();                
            }
            catch (NegativeNumberException)
            {
                Console.WriteLine("Looks like we have a time traveler");
                Console.Read();
            }
            //5.Display a general message if exception caused by anything else.
            catch (Exception)
            {
                Console.WriteLine("An error has occurred, please contact your SysAdmin");
                Console.Read();
            }
        }
    }
}
