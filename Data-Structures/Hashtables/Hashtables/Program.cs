using System;

namespace Hashtables
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            hashtable<object> run = new hashtable<object>(2000);
            run.Hash("test");
        }
    }
}
