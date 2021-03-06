﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues.Classes
{
    /// <summary>
    /// Stack class for all stack methods
    /// </summary>
    public class Stack
    {
        Node Top = null;

        /// <summary>
        /// method to push a value onto the stack
        /// </summary>
        /// <param name="value">int value of node being pushed</param>
        public void Push(int value)
        {
            Node node = new Node();
            node.Value = value;
            node.Next = Top;
            Top = node;
            
        }

        /// <summary>
        /// Pop method to pop a node off a stack and return its value
        /// </summary>
        /// <returns>value of popped node</returns>
        public int Pop()
        {

            if (Top != null)
            {
                int value = Top.Value;
                Top = Top.Next;
                return value;
            }
            else
                throw new Exception();

        }

        /// <summary>
        /// peek method to peek at value of top node
        /// </summary>
        /// <returns>value of top node</returns>
        public int Peek()
        {
            if (Top != null)
            {
                int value = Top.Value;
                return value;
            }
            else
                throw new Exception();
        }
    
        /// <summary>
        /// boolean method to check if stack is empty
        /// </summary>
        /// <returns>true or false</returns>
        public bool isEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            else
                return false;
        }
    
    
    }
}
