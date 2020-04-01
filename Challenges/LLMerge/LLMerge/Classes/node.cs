using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge
{
    class node
    {
        /// <summary>
        /// This class exists to set "global" variables for Value (type int) and Next (type node) that we can get and set 
        /// </summary>
        public class Node
        {

            public int Value { get; set; }
            public Node Next { get; set; }

        }
    }





}
}
