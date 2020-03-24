using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{ 
public class Linklist
{
        public Node Head { get; set; }
        private Node Current { get; set; }


        /// <summary>
        /// A singly linked list with adding a new node at the beginning. This has the BigO of O(1)
        /// 1. Node is created (instantiated), 2. Value assigned to new node, 3. Head is set to this new node.
        /// </summary>
        /// <param name="value">the integer value of the new node to be added</param>
        //Method to insert a new node at the beginning of the LinkedList
        public void Insert(int value)
        {
            //Node instantiation
            Node node = new Node();

            //Value assigned
            node.Value = value;

            //Set next to Head
            node.Next = Head;

        //The new node is now set as Head
        Head = node;

        }

        /// <summary>
        /// A boolean method that checks whether or not a linked list includes a node of a specific value.
        /// </summary>
        /// <param name="value">The value that is being searched for in the list</param>
        /// <returns>true if node is found, otherwise returns false</returns>
        public bool Includes(int value)
        {
            //Current is set to Head
            Current = Head;


            //while loop to search through linked list
            while(Current != null)
            {
                //conditional to see if current value is the value we are searching for and returns true if it is
                if (Current.Value == value)
                {
                    return true;
                }
                //moves to the next node and loops again
                Current = Current.Next;
            }
            //returns false if not found at all in the list
            return false;

        }

        /// <summary>
        /// This is a method that takes in no args and returns a string of all the node values in the linked list
        /// </summary>
        /// <returns>a string of all the node values in the linked list</returns>
        public override string ToString()
        {
            //set current to the head
            Current = Head;

            //using StringBuilder to build our string of node values
            StringBuilder sb = new StringBuilder();

            //using a while loop to move through the linked list
            while (Current != null)
            {
                //grabbing each value of the node and appending it to a string with a " -> " afterwards
                sb.Append($"{Current.Value} -> ");
                //Move to the next node
                Current = Current.Next;

            }

            //adding the string "NULL" at the end of our string
            sb.Append("NULL");
            //return the string
            return sb.ToString();

        }
        
        /// <summary>
        /// Method to append a node to the end of the linked list
        /// </summary>
        /// <param name="value">value is an integer and is the value of the node being added</param>
        public void Append (int value)
        {
            while(Current != null)
            {
                if (Current.Next != null)
                {
                    Current = Current.Next;
                }
                else
                {
                    Node node = new Node();
                    Current.Next = node;
                    node.Value = value;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Searches the list for a node with a specific value and inserts a new node before it with an assigned value 
        /// </summary>
        /// <param name="value">value to search for in the list</param>
        /// <param name="newVal">value to assign to the newly created node</param>
        public void InsertBefore(int value, int newVal)
        {
            if(Node.Next.Value = new Value)
            {
                new Node.Next = Current.Next;
                Current.Next = new Node();
            }
        }


        /// <summary>
        /// Searches the list for a node with a specific value and inserts a new node after it with an assigned value
        /// </summary>
        /// <param name="value">value to search for in the list</param>
        /// <param name="newVal">value to assign to the newly created node</param>
        public void InsertAfter(int value, int newVal)
        {


        }
}
}
