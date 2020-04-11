using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree_BreadthFirst
{
    public class Queue
    {
        Node front = null;
        Node rear = null;

        /// <summary>
        /// enqueue method to add node to the rear of the queue and assign it a value
        /// </summary>
        /// <param name="rear"></param>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            Node node = new Node();
            if (rear != null)
            {
                node.Value = value;
                rear.Next = node;
                node = rear;
            }
            else
            {
                rear = node;
            }

        }

        /// <summary>
        /// dequeue method removes the node from the front of the line and returns its value
        /// </summary>
        /// <returns>value</returns>
        public Node Dequeue()
        {
            if (front != null)
            {
                var temp = front;
                front = front.Next;
                front.Next = null;
                return front;
            }
            else
                throw new Exception();
        }

        /// <summary>
        /// peek method to see value of node at front of the queue
        /// </summary>
        /// <returns>value of the node at the front of the queue</returns>
        public int Peek()
        {
            if (front != null)
            {

                return front.Value;

            }
            else
                throw new Exception();
        }



    }
}
