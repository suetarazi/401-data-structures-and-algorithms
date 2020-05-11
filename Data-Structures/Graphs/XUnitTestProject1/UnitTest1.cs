using System;
using System.Collections.Generic;
using Xunit;
using Graphs.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        private int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }


        [Fact]
        public void TestAddNode()
        {
            node actual = Graph<T>.AddNode(T 7);
            node expected = 7;
            Assert.Equal(expected, actual);
        }
    }
}
