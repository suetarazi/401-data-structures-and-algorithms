using System;
using System.Collections.Generic;
using System.Text;
using QueueWithStacks.Classes;

namespace QueueWithStacks.Classes

{
    public class PseudoQueue
    {
        Stack stack = new Stack();
        Node Top = null;

        public void Enqueue(int value)
        {
            stack.Push(value);

        }

        public int Dequeue()
        {

            while (Top.Next != null)
            {
                stack.Pop();
            }
            return Top.Value;
        }
    }

}
