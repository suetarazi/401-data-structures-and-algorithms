using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class NodeString
    {
        public NodeString(string Value)
        {
            this.Value = Value;

        }

        public Node Left;
        public Node Right;
        public string Value;
    }
}
