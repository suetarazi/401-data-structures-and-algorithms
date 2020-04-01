using System;
using LinkedList.Classes;

namespace LLMerge
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Linklist list1 = new Linklist();
            Linklist list2 = new Linklist();

            LLMerge(list1, list2);
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
