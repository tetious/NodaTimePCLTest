using System;
using NodaTime;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IClock clock = SystemClock.Instance; // red squiggly for missing mscorlib. 
            Console.WriteLine("Hello world {0}.", clock.Now.ToString());
        }
    }
}
