using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
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
