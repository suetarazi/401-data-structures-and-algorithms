using System;
using Xunit;
using Tree;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyTree()
        {
            BinaryTree empty = new BinaryTree();
            //empty.PreOrder();
            Assert.Equal(new int[0], empty.PreOrder());
        }

        [Fact]
        public void CanSuccessfullyInstantiateTreeWithSingleRootNode()
        {
            BinaryTree singleNode = new BinaryTree();
            singleNode.root = new Node(7);
            Assert.Equal(new int[] { 7 }, singleNode.PreOrder());
        }
    }
}
