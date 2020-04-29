using System;
using System.Collections.Generic;
using System.Text;

namespace tree_intersection.Classes
{
    public class MyNode
    {
        public string Key;
        public string Value;
        public MyNode Left;
        public MyNode Right;


        public MyNode(string key, string value)
        {
            Key = key;
            Value = value;
        
        }

    }

}
