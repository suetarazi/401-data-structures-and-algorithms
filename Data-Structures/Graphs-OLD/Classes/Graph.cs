using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Graph<T>
{
	public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

	private int _size;

	public Graph()
	{
		AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
	}

	// Add Node/Vertex to the graph/Adjacency List

	public Vertex<T> AddNode(T value)
    {
		//step 1: create node
		Vertex<T> node = new Vertex<T>(value);
		//step2: add to adjacency list
		AdjacencyList.Add(node, new List<Edge<T>>());
		_size++;
		return node;
    }

	//add directed edge:
	public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
    {
		AdjacencyList[a].Add(
			new Edge<T>
			{
				Weight = weight,
				Vertex = b
			});

    }

	//add undirected edge:
	public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
    {
		AddDirectedEdge(a, b, weight);
		AddDirectedEdge(b, a, weight);
    }

	public List<Vertex<T>> GetAllVertices()
    {
		//they all live inside adjacency list at the moment
		//traverse all nodes in list and output them
		List<Vertex<T>> vertices = new List<Vertex<T>>();

		foreach(var vertex in AdjacencyList)
        {
			vertices.Add(vertex.Key);
        }
		return vertices;
    }

	//get neighbors of a given vertex
	public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
    {
		//get all edges connected to a vertex
		return AdjacencyList[vertex];
    }

	//return the total number of vertices
	public int Size()
    {
		return _size;
    }

	public void Print()
    {
		foreach(var vertex in AdjacencyList)
        {
			Console.Write($"{vertex.Key.Value} : ");

			foreach(var edge in vertex.Value)
            {
				ConsoleWrite($"{edge.Vertex.Value}, {edge.Weight} -> ");
            }

			Console.WriteLine(" null");
        }
    }
}
