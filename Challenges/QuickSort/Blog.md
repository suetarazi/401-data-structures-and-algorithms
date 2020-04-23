# Quick Sort
## Sue Tarazi

Quick Sort is used to sort elements in an array and was created by the English Computer Scientist Tony Hoare in 1959. The algorithm chooses a pivot point and then creates partitions within the array, splitting it into two parts and then further into more parts as it compares the values to the pivot point as carries out its sorting recursively. 

There are three portions to the algorithm:

1. Select an element in the array as the pivot point (often the element at the far left is chosen).
1. Partition the elements and compare each element to the pivot point element. If the element is lower than the pivot point element, it is moved to the left. If it is larger, it is moved to the right. 
1. Apply recursion to the partitions until sorted. 

Note, each time the array is split into subarrays, the pivot point can be changed in order to compare new values against this fixed point. 

BigO time efficiency of O(n log n) and space efficiency of O(1). 

Take the following array: [8,4,23,42,16,15]

[4, 8, 15, 16, 23, 42] final sorted array

Below is the whiteboard showing the workflow of the algorithm:

![Quick Sort](https://i.imgur.com/RsqEAMx.jpg)
