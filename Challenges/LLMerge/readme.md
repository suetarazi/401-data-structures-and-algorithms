# Merging Two Unsorted LinkedList

Linked Lists are containers of data that live on the heap. They are different than arrays in that they do not have indexes. There are two types of linked lists: singly and doubly. 
This challenge is for two singly linked list. They are two be 'zipped' together, alternating nodes with a reference assigned to the head of the zipped list.

## Challenge Summary:
Write a method called MergeLists which takes in two linkedlists as arguments and 'zip' the two lists into one list, alternating nodes. Return a reference to the head of the zipped list.

There are 6 methods in the linkedlist folder that we may be using here: 
* The Insert method take in a value and adds a new node with that value and assigns it to the Head.
* The Includes method takes in a value and returns true or false, depending on whether or not the value was found in the linked list.
* toString takes all the values of the linked list and returns a string with -> between each node.
* The Append method will add a node to the end of the linked list and assign it a value.
* The InsertBefore method will add a node before a node with a specific value
* The InsertAfter method will add a node after a node with a specific value
* The Return Value of Kth Node From the End will search for the Kth node from the end of the linked list and return its value

### Inputs and Expected Outputs

| Input | Expected Output |
| :----------- | :----------- |
| [1,3,2] [5,9,4] | [1,5, 3, 9, 2, 4] |
| [1, 3] [5, 9, 4] | [1, 5, 3, 9, 4] |


## Whiteboards:
[Merging Two Unsorted Linked Lists](https://share.icloud.com/photos/0puab4kJwcgOh7SGpuASK-Sog)

## XUnit Testing:
[Test Results]()

## Efficiency

BigO for zipping two linked lists is O(1).


## API
* Insert method: takes in a value as an argument and adds a new node with that value and assigns it to the Head.
* Includes method: takes in a value as an argument and returns true or false, depending on whether or not the value was found in the linked list.
* toString method: takes in no arguments and returns the values of the linked list as a string with -> between each node. 
* Append method: takes in a value as an argument and adds a new node to the end of the linked list with that value assigned to it.
* InsertBefore method: searches the linked list for a given value and inserts a new node immediately preceeding it with an assigned value.
* InsertAfter method: searches the linked list for a given value and inserts a new node immediately following it with an assigned value.
* LLKthFromEnd method: takes in a value K and searches for the Kth node from the end of the list, returning its value.
