﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues.Classes
{
    class Stack
    {
        Node Top = null;


        public void Push(int value)
        {
            Node node = new Node();
            node.Value = value;
            node.Next = Top;
            Top = node;
        }

        public int Pop()
        {

            if (Top != null)
            {
                int value = Top.Value;
                Top = Top.Next;
                return value;
            }
            else
                throw new Exception("error: empty stack");
        
        }

        public int Peek()
        {
            if (Top != null)
            {
                int value = Top.Value;
                return value;
            }
            else
                throw new Exception("error: empty stack");
        }
    
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
