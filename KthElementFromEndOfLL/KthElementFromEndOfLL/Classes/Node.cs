using System;
using System.Collections.Generic;
using System.Text;

namespace KthElementFromEndOfLL.Classes
{
    public class Node
    {
        /// <summary>
        /// This class exists to set "global" variables for Value (type int) and Next (type node) that we can get and set
        /// </summary>
        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
