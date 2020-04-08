using System;
using System.Collections.Generic;
using System.Text;
using BinaryTree_BreadthFirst.Classes;

namespace BinaryTree_BreadthFirst
{
    class BreadthFirst
    {
        public List<int> BreadthFirst(BinaryTree binaryTree)
        {
            List<int> ReturnList = new List<int>();

            Queue breadth = new Queue();

            Node node = new Node();

            Node front = null;
            Node rear = null;

            int root = binaryTree.root.Value;
            breadth.Enqueue(root);

            while(breadth.Peek() != null)
            {
                node.front = breadth.Dequeue();
                front.Value = ReturnList.Add(Value);

                if(front.Left != null)
                {
                    breadth.Enqueue(front.Left.Value);
                }
                if(front.Right != null)
                {
                    breadth.Enqueue(front.Right.Value);
                }
            }
                return ReturnList; 

        }
    }

    public class BinaryTree
    {
    }
}
