using System;
using node.classes;

namespace LLMerge
{
    public Node Head { get; set; }
    private Node Current { get; set; }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LLMerge(List1, List2);
        }

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


            static void LLMerge(Linklist List1, Linklist List2)
            {
                Head = Current;
                Node refA = List1.Current.Next;
                Node refB = List2.Current.Next;
                List1.Current = Head;
                while (List1.Value != null && List2.Value != null)
                    //traverse List2 and call insert before for each node into List1
                    while (List1.next != null)
                    {
                        List1.Current.Next = refA;
                        List2.Current.Next = refB;

                        List1.Current.Next = List2.Current;
                        List2.Current.Next = refA;
                        refA.Current.Next = refB;

                    }
            }


        }
    }
}
