using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class Node
    {
        public Node(int Value)
        {
            this.Value = Value;

        }

        public Node Left;
        public Node Right;
        public int Value;

    }
}
