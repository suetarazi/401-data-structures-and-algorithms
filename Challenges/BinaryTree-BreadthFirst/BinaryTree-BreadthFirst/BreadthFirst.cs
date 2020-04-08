using System;
using System.Collections.Generic;
using System.Text;
using BinaryTree_BreadthFirst.Classes;

namespace BinaryTree_BreadthFirst
{
    class BreadthFirst
    {
        /// <summary>
        /// This method creates a queue and uses the Enqueue and Dequeue methods of a queue to travserse each layer of the tree and populate a list that is instantiated with the values of the tree using the breadth first approach.
        /// </summary>
        /// <param name="binaryTree"></param>
        /// <returns>A list of values from the tree</returns>
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

 
}
