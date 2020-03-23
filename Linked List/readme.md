# Singly LinkedList

Linked Lists are containers of data that live on the heap. They are different than arrays in that they do not have indexes. There are two types of linked lists: singly and doubly. 
This challenge is for a singly linked list, which means the list only moves in one direction.

## References:
[Linked Lists from Code401](https://github.com/codefellows/seattle-dotnet-401d10/tree/master/Class05/demo)
## Challenge Summary:
A Node class is created with the properties for the value stored in the Node and a pointer to the next Node.

The Linked List has a Head property. 

There are 3 methods: one to insert, one to check to see if a value exists in a linked list and one that returns the list as a string.
* The Insert method take in a value and adds a new node with that value and assigns it to the Head.
* The Includes method takes in a value and returns true or false, depending on whether or not the value was found in the linked list.
* toString takes all the values of the linked list and returns a string with -> between each node.

##XUnit Testing:
[Test Results](https://i.imgur.com/GaQE58u.png)

## Efficiency

BigO for inserting a node at the beginning is O(1).

## API
* Insert method: takes in a value as an argument and adds a new node with that value and assigns it to the Head.
* Includes method: takes in a value as an argument and returns true or false, depending on whether or not the value was found in the linked list.
* toString method: takes in no arguments and returns the values of the linked list as a string with -> between each node. 
