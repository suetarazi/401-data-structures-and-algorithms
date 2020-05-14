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

        /// <summary>
        /// method to take in graph and array and return true if connect & return length of edge; else return false.
        /// </summary>
    public static List<AdjacencyList> results GetEdge(Graph graph, string[] cities)
        {
            foreach (string city in cities)
            {
                results.Add(graph.GetNeighbors(city));
            
                if (results.Contains(city)
                    {
                    return ("true", Edge); 
                    }
                else
                {
                    return false;
                }
            }
        }
    }

}