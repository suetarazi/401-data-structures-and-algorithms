using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinarySearchTree
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
            if(root == null)
            {
                root.Value = Value;

            }
            else if (Value <root.Value)
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

        /// <summary>
        /// traverses the tree and looks for your Value; returns true if found, false if not found
        /// </summary>
        /// <param name="Value">int to search the tree for</param>
        /// <returns>true or false</returns>
        public bool Contains(int Value)
        {
            if (Value == root.Value)
            {
                return true;
            }
            else
                return false;
        }
    }
}
