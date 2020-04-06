using System;
using Xunit;
using Tree;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public BinaryTree TestTree()
        {
            BinaryTree TestTree = new BinaryTree();
            TestTree.root = new Node(1);
            TestTree.root.Left = new Node(2);
            TestTree.root.Right = new Node(3);
            TestTree.root.Left.Left = new Node(4);
            TestTree.root.Left.Right = new Node(5);
            TestTree.root.Right.Left = new Node(6);
            return TestTree;
        }
        
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

        [Fact]
        public void CanPreOrderTraverse()
        {
            BinaryTree tree = TestTree();
            int[] outputArray = tree.PreOrder();
            string testString = string.Join(",", outputArray);
            Assert.Equal("1,2,4,5,3,6", testString);
        }

        [Fact]
        public void CanInOrderTraverse()
        {
            BinaryTree tree = TestTree();
            int[] outputArray = tree.InOrder();
            string testString = string.Join(",", outputArray);
            Assert.Equal("4,2,5,1,6,3", testString);
        }

        [Fact]
        public void CanPostOrderTraverse()
        {
            BinaryTree tree = TestTree();
            int[] outputArray = tree.PostOrder();
            string testString = string.Join(",", outputArray);
            Assert.Equal("4,5,2,6,3,1", testString);
        }
    }
}
