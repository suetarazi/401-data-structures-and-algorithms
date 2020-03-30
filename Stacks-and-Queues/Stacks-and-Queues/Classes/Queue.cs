using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues.Classes
{
    /// <summary>
    /// Queue class for all queue methods
    /// </summary>
    public class Queue
    {
        Node front = null;
        Node rear = null;

        /// <summary>
        /// enqueue method to add node to the rear of the queue and assign it a value
        /// </summary>
        /// <param name="rear"></param>
        /// <param name="value"></param>
        public void Enqueue(Node rear, int value)
        {
            Node node = new Node();
            node.Value = value;
            node.rear = node;
            node = rear;

        }

        /// <summary>
        /// dequeue method removes the node from the front of the line and returns its value
        /// </summary>
        /// <returns>value</returns>
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
    
        /// <summary>
        /// peek method to see value of node at front of the queue
        /// </summary>
        /// <returns>value of the node at the front of the queue</returns>
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
    
        /// <summary>
        /// boolean method to see if queue is empty
        /// </summary>
        /// <returns>true or false</returns>
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
