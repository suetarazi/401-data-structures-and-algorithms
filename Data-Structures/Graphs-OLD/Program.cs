using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void GraphExample()
            {
                Graph<string> graph = new Graph<string>();

                var nd = graph.AddNode("North Dakota");
                var mt = graph.AddNode("Montana");
                var ga = graph.AddNode("Georgia");
                var ca = graph.AddNode("California");
                var wa = graph.AddNode("Washington");

                graph.AddDirectedEdge(wa, nd, 125);
                graph.AddUndirectedEdge(ca, mt, 100);
                graph.AddDirectedEdge(ga, mt, 72);
                graph.AddUndirectedEdge(wa, ca, 11);
                graph.AddDirectedEdge(nd, mt, 7);

                graph.Print();

                var neighbors = graph.GetNeighbors(wa);

                var getAll = graph.GetAllVertices();
            }
    }
}
