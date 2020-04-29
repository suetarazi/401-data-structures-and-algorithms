using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using tree_intersection.Classes;

namespace tree_intersection
{
    public class TreeIntersection
    {
        //write a method that takes in 2 binary trees; and returns a list of intersected values.
        public List<string> TreeIntersections(MyNode tree1, MyNode tree2)
        {
            List<string> resultsList = new List<string>();
            //traverse all of tree1 and place the nodes in a hashmap using hashmap.Add(key, value) for each node in the tree
            TraverseBreadthFirstTree(tree1);
            
            //traverse all of tree2 and do an if/else: if(hashmap.Contains(key) of node in tree2, then resultsList.Add(key)
 
            if (tree2 == null) return null;

            Queue queue = new Queue();
            queue.Enqueue(tree2);

            //breadth first traversal:
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if(hashtable.Contains(node.Key) == true)
                    {
                    resultsList.Add(Key);        
                    }

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        //return resultsList
            return resultsList;
        }



        /// <summary>
        /// Helper method to add tree1 to a hashtable
        /// </summary>
        /// <param name="tree">tree of nodes to be added to hashtable</param>
        public static Hashtable TraverseBreadthFirstTree(MyNode tree)
        {
            Hashtable hashtable = new Hashtable();
           

            if (tree == null) return hashtable;

            Queue queue = new Queue();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                hashtable.Add(node.Key, node.Value);

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

        return hashtable;
        }

    }
        /// <summary>
        ///create an array of nodes 
        /// </summary>
        /// <typeparam name="T">object</typeparam>
        public class hashtable<T>
        {

            public LinkedList<Node>[] Arr { get; set; }

            /// <summary>
            /// Create a hashtable
            /// </summary>
            /// <param name="size">int size of hashtable</param>

            public hashtable(int size)
            {
                //   Size = size;
                Arr = new LinkedList<Node>[size];
            }

            /// <summary>
            /// method to add a node to a hashtable
            /// </summary>
            /// <param name="key">string key</param>
            /// <param name="value">string value</param>
            public void Add(string key, string value)
            {
                Node node = new Node(key, value);
                int hashIndex = Hash(key);

                if (Arr[hashIndex] == null)
                {
                    //instantiate a linked list
                    LinkedList<Node> linklist = new LinkedList<Node>();
                    //assign the head to the node
                    Arr[hashIndex] = linklist;
                }
                //use AddFirst built in method to pass in node at array position hashIndex
                Arr[hashIndex].AddFirst(node);

            }

            /// <summary>
            /// method that takes in a key and returns the value as a string
            /// </summary>
            /// <param name="key">string key</param>
            /// <returns>string value</returns>

            public string Get(string key)
            {
                int hashIndex = Hash(key);
                if (Arr[hashIndex] != null)
                {
                    foreach (var node in Arr[hashIndex])
                    {
                        if (node.Key == key)
                        {
                            return node.Value;
                        }
                    }

                }
                return null;
            }


            /// <summary>
            /// method to see if a hashtable contains a node given a key
            /// </summary>
            /// <param name="key">string key</param>
            /// <returns>true or false</returns>
            public bool Contains(string key)
            {
                int hashIndex = Hash(key);
                if (Arr[hashIndex] != null)
                {
                    foreach (var node in Arr[hashIndex])
                    {
                        if (node.Key == key)
                        {
                            return true;
                        }
                    }

                }
                return false;
            }

            /// <summary>
            /// method to perform hash of a given key
            /// </summary>
            /// <param name="key">string key</param>
            /// <returns>hashed value of the key</returns>
            public int Hash(string key)
            {
                int sum = 0;
                
                for (int i = 0; i < key.Length; i++)
                {
                    //Console.WriteLine((int)key[i]);
                    sum += key[i];
                }
                //Console.WriteLine(sum);
                int salted = sum * 599;
                //Console.WriteLine(salted);
                int hashIndex = salted % Arr.Length;
                return hashIndex;

            }


        }
}
