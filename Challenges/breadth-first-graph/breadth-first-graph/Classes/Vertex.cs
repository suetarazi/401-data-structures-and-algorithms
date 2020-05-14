using System;
using System.Collections.Generic;
using System.Text;

namespace breadth_first_graph.Classes
{
    
    public class Vertex<T>
    {
        public T Value { get; set; }

        public Vertex(T value)
        {
            Value = value;
        }
    }
    
}
