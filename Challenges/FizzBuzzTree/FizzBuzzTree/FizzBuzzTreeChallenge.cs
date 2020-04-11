using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    class FizzBuzzTreeChallenge
    {

        public void HelperBinaryTree(Node root, NodeString FizzBuzzRoot)
        {
            //   BinaryTree FizzBuzzTree = new BinaryTree();

            while (root != null)
            {
                if (root.Value % 15 == 0)
                {
                    FizzBuzzRoot.Value = "FizzBuzz";
                }
                if (root.Value % 3 == 0)
                {
                    FizzBuzzRoot.Value = "Fizz";
                }
                if (root.Value % 5 == 0)
                {
                    FizzBuzzRoot.Value = "Buzz";
                }
                else
                    FizzBuzzRoot.Value.ToString();
            }
           
        }



        public StringBinaryTree ReturnTree(BinaryTree binaryTree)
        {
            StringBinaryTree FizzBuzzTree = new StringBinaryTree();
            HelperBinaryTree(binaryTree.root, FizzBuzzTree.root);

            return FizzBuzzTree;
        }
    }
}