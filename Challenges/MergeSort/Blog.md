# Merge Sort
## Sue Tarazi

An array of integers is given and must be sorted using the merge sort algorithm. This algorithm uses the minimum number of comparisons and treats the given array as two lists, sorts them and then merges them into one. 
There are three portions to the algorithm:

1. Recursively sort the first half of the array
1. Recursively sort the second half the array
1. Merge the two sorted halves into one sorted array

The time efficiency for a merge sort is O(nlogn) and space of O(1).

An example is as follows: 

[8,4,23,42,16,15] initial array

[8, 4, 23] left half [42, 16, 15] right half

[4, 8, 23] sorted left half [15, 16, 42] sorted right half

[4, 8, 15, 23, 16, 42] merging the two arrays

[4, 8, 15, 16, 23, 42] final sorted array

