using Hashtables.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    //create an array of nodes

    public class hashtable<T>
    {
    public LinkedList<Node>[] Arr { get; set; } 
    //public int Size { get; set; }
    
    public hashtable(int size)
        {
         //   Size = size;
            Arr = new LinkedList<Node>[size];
        }
        public static Add(string key, string value)
        {
            Node node = new Node();
            int hashIndex = Hash(key);
            node.key = hashIndex;
            node.value = value;

            if (Arr[hashIndex] == null)
            {
                //instantiate a linked list

                //assign the head to the node
                node = node.head;
                //add value
                node.value = value;
            }

        }

        //public static Get(string key)
        //{
        //    int hashIndex = Hash(key);


        //}


        //public static Contains()
        //{
        //return null;
        //}


        public int Hash(string key)
        {
        int sum = 0;
            key = "amanda";
            for (int i=0; i<key.Length; i++)
            {
                Console.WriteLine((int)key[i]);
                sum += key[i];
            }
            Console.WriteLine(sum);
        int salted = sum * 599;
            Console.WriteLine(salted);
        int hashIndex = salted % Arr.Length;
        return hashIndex;
        
        }
    }
}
