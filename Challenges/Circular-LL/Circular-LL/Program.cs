﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Transactions;
using Circular_LL.Node.cs;

namespace Circular_LL
{
    class Program 
    {
        //public int Count => throw new NotImplementedException();

        //public bool IsSynchronized => throw new NotImplementedException();

        //public object SyncRoot => throw new NotImplementedException();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList<int> input = new LinkedList<int>();
            Program p = new Program();
            p.LLCircular(input);
            Node node = new Node();
        }

        //public void CopyTo(Array array, int index)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        public bool LLCircular(LinkedList<int> input)
        {
            if(input.Last.Next == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool LLCircularTwoPointers(LinkedList<int> input)
        {
           

            LinkedListNode<int>.Current = LinkedListNode<int>.head;
            //input.Current = input.Head;
            temp = Head;

            current = current.next;

            while(current.next != null)
            {
                if(current.next = temp)
                {
                    return true;
                }
                else
                {
                    current = current.next;
                    temp = temp.next;
                }

                return false;
            }

        }
    }
}
