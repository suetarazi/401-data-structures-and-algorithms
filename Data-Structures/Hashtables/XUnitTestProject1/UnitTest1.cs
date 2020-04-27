using Hashtables;
using Hashtables.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to instantiate a class
        /// </summary>
        [Fact]
        public static void TestInstantiateClass()
        {
            hashtable<object> testTable = new hashtable<object>(50);
            Assert.Equal(50, testTable.Arr.Length);
        }

        /// <summary>
        /// test to see if hash function is working
        /// </summary>
        [Fact]
        public static void TestHashWithKey()
        {
            string key = "cat";
            hashtable<object> testTable = new hashtable<object>(2000);
            int actual = testTable.Hash(key);
            Assert.Equal(1390, actual);
        }

        /// <summary>
        /// Test to see if a node can successfully be added
        /// </summary>
        [Fact]

        public void CanAddNode()
        {
            hashtable<object> testTable = new hashtable<object>(2000);
            string key = "cat";
            string value = "meow";
            Node node = new Node(key, value);
            testTable.Add(key, value);
            string actual = testTable.Get(key);
            Assert.Equal("meow", actual);

        }

        /// <summary>
        /// test to see if a value of a node can be retrieved given a key
        /// </summary>
        [Fact]
        public void CanGetNode()
        {

            hashtable<object> testTable = new hashtable<object>(2000);
            string key = "cat";
            string value = "meow";
            Node node = new Node(key, value);
            testTable.Add(key, value);
            string actual = testTable.Get(key);
            Assert.Equal("meow", actual);

        }

        /// <summary>
        /// boolean test to see if a node exists given a key
        /// </summary>
        [Fact]
        public void ContainsNode()
        {
            hashtable<object> testTable = new hashtable<object>(2000);
            string key = "cat";
            string value = "meow";
            Node node = new Node(key, value);
            testTable.Add(key, value);
            bool actual = testTable.Contains(key);
            Assert.True(actual);
        }
}
}
