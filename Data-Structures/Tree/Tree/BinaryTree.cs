using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree
    {

        public Node root = null;
        
        /// <summary>
        /// helper method for PreOrder method that actually adds the value to the list and builds the tree
        /// </summary>
        /// <param name="root">Node type</param>
        /// <param name="Results">List of ints</param>
        public void PreOrderHelper(Node root, List<int> Results) 
        {
            Results.Add(root.Value);

            if (root.Left != null)
            {
                PreOrderHelper(root.Left, Results);
            }
            if (root.Right != null)
            {
                PreOrderHelper(root.Right, Results);
            }
            
        }

        /// <summary>
        /// traverses root>>left>>right
        /// </summary>
        /// <returns>array of values</returns>
        public int[] PreOrder()
        {
            List<int> Results = new List<int>();
            if (this.root != null)
            {
                PreOrderHelper(this.root, Results);
            }
                 
                return Results.ToArray();
        }

        /// <summary>
        /// helper method for InOrder to add values to the list and build the tree
        /// </summary>
        /// <param name="root">type Node</param>
        /// <param name="Results">list type of values</param>
        public void InOrderHelper(Node root, List<int> Results)
        {
            Results.Add(root.Value);

            if (root.Left != null)
            {
                InOrderHelper(root.Left, Results);
            }

            InOrderHelper(root, Results);

            if (root.Right != null)
            {
                InOrderHelper(root.Right, Results);
            }
        }
        /// <summary>
        /// traverses left>>root>>right
        /// </summary>
        /// <returns>array of values</returns>
        public int[] InOrder()
        {
            List<int> Results = new List<int>();
            if(this.root != null)
            {
                InOrderHelper(this.root, Results);
            }

            return Results.ToArray();

        }

        /// <summary>
        /// helper method to add values to the list and build the tree 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="Results"></param>
        public void PostOrderHelper(Node root, List<int> Results)
        {
            if (root.Left != null)
            {
                PostOrderHelper(root.Left, Results);
            }
            if (root.Right != null)
            {
                PostOrderHelper (root.Right, Results);
            }
            PostOrderHelper(root, Results);
        }

        ///// <summary>
        ///// traverses left>>right>>root
        ///// </summary>
        ///// <returns>array of values</returns>
        public int[] PostOrder()
        {
            List<int> Results = new List<int>();
            
            if(this.root != null)
            {
                PostOrderHelper(this.root, Results);
            }

            return Results.ToArray();
            
        }
    }
}
