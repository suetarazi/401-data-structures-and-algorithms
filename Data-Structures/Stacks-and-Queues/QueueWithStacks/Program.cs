using System;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    class Program : PseudoQueue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PseudoQueue pseudoqueue = new PseudoQueue();
            
            pseudoqueue.Enqueue(3);
            pseudoqueue.Dequeue();
        }

    }
}