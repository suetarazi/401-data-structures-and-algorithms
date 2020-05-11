# Graphs
*Author: Sue Tarazi*

---

## Graph information
A graph is a collection of vertices (nodes) and edges (connections between the vertices). 

### The graph is represented as an adjacency list, and includes the following methods:

1. AddNode()
Adds a new node to the graph
Takes in the value of that node
Returns the added node
1. AddEdge()
Adds a new edge between two nodes in the graph
Include the ability to have a “weight”
Takes in the two nodes to be connected by the edge
Both nodes should already be in the Graph
1. GetNodes()
Returns all of the nodes in the graph as a collection (set, list, or similar)
1. GetNeighbors()
Returns a collection of edges connected to the given node
Takes in a given node
Include the weight of the connection in the returned collection
1. Size()
Returns the total number of nodes in the graph

### XUnit testing has been performed on all methods.

---

### Inputs and Expected Outputs:

| Method | Input | Expected Output |
| :----------- | :----------- | :----------- |
| AddNode() | Node(value) | added node |
| AddEdge() | Two nodes | adds and edge |
| GetNodes() | none | all nodes as a collection |
| GetNeighbors() | node | all connections to that node |
| Size() | none | total number of nodes in the graph |
 

---

### Big O


| Time | Space |
| :----------- | :----------- |
| O(1) | O(1) |


---

### Change Log

