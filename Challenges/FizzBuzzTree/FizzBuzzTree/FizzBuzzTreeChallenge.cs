using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    class FizzBuzzTreeChallenge
    {

        public BinaryTree binaryTree(Node root)
        {
            BinaryTree FizzBuzzTree = new BinaryTree();

            if(root.Value = null)
            {
                return null;
            }
            if(root.Value %15 == 0)
            {
                FizzBuzzTree.root.Value = "FizzBuzz";
            }
            if(root.Value %3 == 0)
            {
                FizzBuzzTree.root.Value = "Fizz";
            }
            if (root.Value % 5 == 0)
            {
                FizzBuzzTree.root.Value = "Buzz";
            }
            else
                FizzBuzzTree.root.Value.ToString();
        }

            return FizzBuzzTree;

    }

}
}
