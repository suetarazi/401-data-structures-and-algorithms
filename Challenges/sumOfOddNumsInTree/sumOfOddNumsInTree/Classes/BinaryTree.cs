using System;
using System.Collections.Generic;
using System.Text;

namespace sumOfOddNumsInTree.Classes
{
    public class BinaryTree
    {
        public Node root = null;

        /// <summary>
        /// method that takes in a node and value and adds it to the tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public Node Add(Node root, int Value)
        {
            if (root == null)
            {
                root.Value = Value;

            }
            else if (Value < root.Value)
            {
                root.Left = Add(root.Left, Value);
            }
            else
            {
                root.Right = Add(root.Right, Value);
            }
            this.root = root;
            return this.root;

        }
    }
}
