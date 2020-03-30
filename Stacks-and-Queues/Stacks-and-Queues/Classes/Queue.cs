using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues.Classes
{
    public class Queue
    {
        Node front = null;
        Node rear = null;

        public void Enqueue(Node rear, int value)
        {
            Node node = new Node();
            node.Value = value;
            node.rear = node;
            node = rear;

        }

        public int Dequeue()
        {
            if (front != null)
            {
                var temp = node.front;
                node.front = node.front.next;
                temp.next = None;
                return temp.Value;
            }
            else
                throw new Exception("error: empty queue");
        }
    
        public int Peek()
        {
            if (front != null)
            {
                int value = front.value;
                return value;

            }
            else
                throw new Exception("error: empty queue");
        }
    
        public bool isEmpty()
        {
            if (front == null)
            {
                return true;

            }
            else
                return false;
        }
    }
}
