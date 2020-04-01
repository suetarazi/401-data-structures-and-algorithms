using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to see if Node has been created and has type int Value
        /// </summary>
        [Fact]
        public void NodeClassHasValueProperty()
        {
            Node node = new Node();
            Assert.IsType<int>(node.Value);

        }

        /// <summary>
        /// Test creates a new node and assigns the value to 10. Checks to see this happened successfully.
        /// </summary>
        [Fact]
        public void CanGetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;

            Assert.Equal(10, node.Value);

        }

        /// <summary>
        /// Creates new node and sets value to 10, then sets it to 15. Checks to see if it has been changed to 15 successfully.
        /// </summary>
        [Fact]
        public void CanChangeAndSetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            node.Value = 15;

            Assert.Equal(15, node.Value);

        }

        /// <summary>
        /// Looks to see if there is a Next property (note, last node will return Null)
        /// </summary>
        [Fact]
        public void NodeClassHasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }

        /// <summary>
        /// Checks to see if next property can be set on a node
        /// </summary>
        [Fact]
        public void NextPropertyOnNodeCanBeSet()
        {
            Node node = new Node();
            node.Value = 18;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }

        /// <summary>
        /// Creates linked list and then checks for Head property
        /// </summary>
        [Fact]
        public void LinkedListClassHasHeadProperty()
        {
            Linklist linklist = new Linklist();
            Assert.Null(linklist.Head);
        }

        /// <summary>
        /// Creates a new node and checks to see if it at the Head
        /// </summary>
        [Fact]
        public void CanInsertNewNodeToLinkedListAsHead()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            Assert.Equal(10, ll.Head.Value);

        }

        /// <summary>
        /// Checks to see if we successfully inserted a new node at the head of an existing linked list
        /// </summary>
        [Fact]
        public void CanInsertNewNodeAsHeadInLLThatAlreadyHasNodes()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);

            Assert.Equal(20, ll.Head.Value);

        }

        /// <summary>
        /// Looks for specific node within a linked list we created
        /// </summary>
        [Fact]
        public void CanFindNodeWithValueInLL()
        {

            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            bool exists = ll.Includes(30);

            Assert.True(exists);

        }

        /// <summary>
        /// Looks to make sure we can not find a node with a value that does not exist in a list that we created
        /// </summary>
        [Fact]
        public void CannotFindNodewithValueinLL()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            bool exists = ll.Includes(32);

            Assert.False(exists);


        }

        /// <summary>
        /// Looks through linked list we created to find Head value
        /// </summary>
        [Fact]
        public void CanFindHeadValueSucessfullyinLL()
        { 
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            bool exists = ll.Includes(42);
            Assert.True(exists);

        }

        /// <summary>
        /// Looks through the linked list to return the last node value
        /// </summary>
        [Fact]
        public void CanFindLastNodeValueInLL()
        { 
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            bool exists = ll.Includes(10);
            Assert.True(exists);
        }

        /// <summary>
        /// Checks to see whether linked list was correctly converted to a string
        /// </summary>
        [Fact]
        public void CanConvertLinkListToString()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            string testString = ll.ToString();

            string expected = $"42 -> 30 -> 20 -> 10 -> NULL";

            Assert.Equal(expected, testString);


        }

        [Fact]
        public void CanReturnNodeValueOfKthNodeFromEndOfLL()
        {
            Linklist ll = new Linklist();
            ll.Insert(1);
            ll.Insert(3);
            ll.Insert(8);
            ll.Insert(2);

            int k = ll.LLKthFromEnd(2);
            Assert.Equal(3, k);
        }

        public void KValueIsLongerThanLLException()
        {
            Linklist ll = new Linklist();
            ll.Insert(1);
            ll.Insert(3);
            ll.Insert(8);
            ll.Insert(2);

            int k = ll.LLKthFromEnd(6);
            //Assert.Equal(Null, k);
        }
    }
}
