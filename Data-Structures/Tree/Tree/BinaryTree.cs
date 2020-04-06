using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree
    {

        public Node root = null;
        

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
        /// <returns></returns>
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
        /// traverses left>>root>>right
        /// </summary>
        /// <returns></returns>
        //public int InOrder()
        //{
        //    if(node.Left != null)
        //    {
        //        InOrder(node.Left);
        //    }
            
        //    return node.Value;
            
        //    if(node.Right != Null)
        //    {
        //        InOrder(node.Right);
        //    }

        //}

        ///// <summary>
        ///// traverses left>>right>>root
        ///// </summary>
        ///// <returns></returns>
        //public int PostOrder()
        //{
        //    if(node.Left != null)
        //    {
        //        InOrder(node.Left);
        //    }
        //    if(node.Right != null)
        //    {
        //        InOrder(node.Right);
        //    }
        //    return node.Value;
        //}
    }
}
