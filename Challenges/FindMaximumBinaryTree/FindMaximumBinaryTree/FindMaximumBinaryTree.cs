using System;
using System.Collections.Generic;
using System.Text;
using FindMaximumBinaryTree.Classes;

namespace FindMaximumBinaryTree
{
    class FindMaximumBinaryTree
    {
        public int BreadthFirst(BinaryTree binaryTree)
        {
            int max = 0;

            Queue queue = new Queue();

            Node node = new Node();

            Node front = null;
            Node rear = null;

            int root = binaryTree.root.Value;
            queue.Enqueue(root);
            root.value = max;
            
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
                if (front.Value > max)
                {
                    front.Value = max;
                }

            }
            return max;


        }
    }
}
