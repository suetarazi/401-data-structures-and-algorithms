# Insertion Sort
## Sue Tarazi

An array of integers is given and must be sorted in place. An algorithm to accomplish this is as follows. There are three portions to the algorithm:

1. Selection of element in the array
1. Swapping of two elements in the array
1. Shifting the counter position in the array

This algorithm requires two nested loops, and therefore has the BigO time efficiency of O(n^2) and space efficiency of O(1). The first loop (i) iterates through the array as a whole. The second loop (j) resets the 'initial' point of the array so values to the left are already in ascending order and the 'initial' point is the value that is being considered for a swap.
Take the following array: [8,4,23,42,16,15]

The algorithm will make 6 passes through this array in order to sort it in place. Below are the 6 rounds and how the numbers will be swapped with each pass. The pipe symbol (|) indicates where the 'index' is being reset.

[8,4,23,42,16,15] initial array
[4, | 8, 23, 42, 16, 15]
[4, 8, | 23, 42, 16, 15]
[4, 8, 15, | 23, 42, 16]
[4, 8, 15, 16, | 23, 42]
[4, 8, 15, 16, 23, | 42]
[4, 8, 15, 16, 23, 42] final sorted array

