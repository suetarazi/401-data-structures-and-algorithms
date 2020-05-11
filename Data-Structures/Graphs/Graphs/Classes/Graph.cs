using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
	class Graph<T>
	{
		public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

		private int _size;

		public Graph()
		{
			AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
		}

		
		/// <summary>
		/// Add Node/Vertex to the graph/Adjacency List 
		/// </summary>
		/// <param name="value">value of vertex</param>
		/// <returns>node</returns>
		public Vertex<T> AddNode(T value)
		{
			//step 1: create node
			Vertex<T> node = new Vertex<T>(value);
			//step2: add to adjacency list
			AdjacencyList.Add(node, new List<Edge<T>>());
			_size++;
			return node;
		}


		/// <summary>
		/// add directed edge
		/// </summary>
		/// <param name="a">initial vertex</param>
		/// <param name="b">destination vertex</param>
		/// <param name="weight">distance between the two vertices</param>
		public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
		{
			AdjacencyList[a].Add(
				new Edge<T>
				{
					Weight = weight,
					Vertex = b
				});

		}

		/// <summary>
		/// add undirected edge
		/// </summary>
		/// <param name="a">initial vertex</param>
		/// <param name="b">destination vertex</param>
		/// <param name="weight">distance between the two vertices</param>
		public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
		{
			AddDirectedEdge(a, b, weight);
			AddDirectedEdge(b, a, weight);
		}

		/// <summary>
		/// method to return all vertices in an adjacency list
		/// </summary>
		/// <returns>all nodes in an adjacency list</returns>
		public List<Vertex<T>> GetAllVertices()
		{
			//they all live inside adjacency list at the moment
			//traverse all nodes in list and output them
			List<Vertex<T>> vertices = new List<Vertex<T>>();

			foreach (var vertex in AdjacencyList)
			{
				vertices.Add(vertex.Key);
			}
			return vertices;
		}

		/// <summary>
		/// get neighbors of a given vertex
		/// </summary>
		/// <param name="vertex">vertex to start looking for neighbors from</param>
		/// <returns>all neighbors to given vertex</returns>
		public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
		{
			//get all edges connected to a vertex
			return AdjacencyList[vertex];
		}

		/// <summary>
		/// return the total number of vertices
		/// </summary>
		/// <returns>total number of vertices in a graph</returns>
		public int Size()
		{
			return _size;
		}

		/// <summary>
		/// Output to console
		/// </summary>
		public void Print()
		{
			foreach (var vertex in AdjacencyList)
			{
				Console.Write($"{vertex.Key.Value} : ");

				foreach (var edge in vertex.Value)
				{
					Console.Write($"{edge.Vertex.Value}, {edge.Weight} -> ");
				}

				Console.WriteLine(" null");
			}
		}
	}
}