# Hashtable
*Author: Sue Tarazi*

---

## Hashtable information
A hashtable is an array of nodes that is often used for security (passwords, personal information, etc). It is often used as a supporting data structure and is very secure. A hashtable is like an array where each value in the array is a bucket. Each bucket can then contain a linked list of nodes with key:value pairs. The hashtable takes in the key and performs a hashing algorithm which is performed as follows:
* instantiate a hashtable array that is a large size (ex. 2000)
* take in key (ex. "cat") and convert it to ASCII and sum the values ("cat" becomes 1390)
* multiply this value by a large prime number (ex. 599)
* Divide this value by the length of the hashtable array 
* This is the array index that the node containing the key:value pair will be placed

### From here, we can perform the following methods:
Add() - takes in a node with a key:value and adds it to the hashtable
Get() - takes in a key and returns the value
Contains() - a boolean method to see if a given key exists

### XUnit testing has been performed on all methods.

---

### Inputs and Expected Outputs:

| Method | Input | Expected Output |
| :----------- | :----------- | :----------- |
| Add() | Node(key, value) | none |
| Get() | key | value |
| Contains() | key | true/false |
 

---

### Big O for looking up an item in a hashtable


| Time | Space |
| :----------- | :----------- |
| O(1) | O(1) |


---

### Change Log

