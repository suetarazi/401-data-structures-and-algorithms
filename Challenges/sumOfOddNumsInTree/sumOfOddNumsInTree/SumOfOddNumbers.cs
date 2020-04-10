using sumOfOddNumsInTree.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace sumOfOddNumsInTree
{
    public class SumOfOddNumbers
    {
        /// <summary>
        /// A method that traverses a binary tree (using breadth first traversal) and returns the sum of all the odd values
        /// </summary>
        /// <param name="binaryTree">takes in a binary tree</param>
        /// <returns>integer sum of all the odd values</returns>
        public int SumOfTreeOddNumbers(BinaryTree binaryTree)
        {
            int sum = 0;

            Queue queue = new Queue();

            Node node = new Node();

            Node front = null;
            Node rear = null;

            int root = binaryTree.root.Value;
            queue.Enqueue(root);
            if (root.Value % 2 != 0)
            {
                root.Value = max;
            }

            while (queue.Peek() != null)
            {
                if (front.Left != null)
                {
                    queue.Enqueue(front.Left.Value);
                }
                if (front.Right != null)
                {
                    queue.Enqueue(front.Right.Value);
                }

                node.front = queue.Dequeue();
                if (front.Value%2 != 0)
                {
                    sum += front.Value;
                }

            }
            return sum;


        }

    }
}
