using breadth_first_graph.Classes;
using System;
using System.Collections.Generic;

namespace breadth_first_graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Graph<string> graph = new Graph<string>();
        }

    public static List<AdjacencyList> results GetEdge(Graph graph, string[] cities)
        {
            foreach (string city in cities)
            {
                List<AdjacencyList>.Add(graph.GetNeighbors(city));
            }
                return results;   
        }
    }

}