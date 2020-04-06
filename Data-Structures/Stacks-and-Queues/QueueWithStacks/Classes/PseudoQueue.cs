using System;
using System.Collections.Generic;
using System.Text;
using QueueWithStacks.Classes;

namespace QueueWithStacks.Classes

{
    public class PseudoQueue

    {
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();
        Node Top = null;
        
    public void Enqueue(int value)
        {
            while(stack1.peek() != null)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);

            while(stack2.peek() != null)
            {
                stack1.Push(stack2.Pop());
            }

        }

        public int Dequeue()
        {

            while (stack1.Peek() != null)
            {
                stack1.Pop();
            }
            return value;
        }
        
    }

}
