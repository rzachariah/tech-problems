# tech-problems
Solutions to tech problems

## minSum
### Problem
Given a list of integers, perform some number k of operations. Each operation consists of removing any element from the array,
dividing it by 2 and inserting the ceiling of that result back into the array. 
Minimize the sum of elements in the final array.

### Constraints
```
1 <= num[i] <= 10^4
1 <= n <= 10^5
1 <= k <= 10^7
```

### Algorithm
A naive solution is to halve-ceil the list maximum for k iterations. This has runtime O(kn).

We can reduce runtime cost by storing the list in a hashtable where the hash function is ceil(log2(x)).
Associated with each hash, we will store a list of integers that hash to that value. Since we know that num[i] <= 10^4,
our hash table will have at most 15 values (0 through 14).

Once the data is hashed, we can iterate through the hash values from highest to lowest. For each,
we first sort the associated table in descending order, then iterate through its elements. Each element will be
pushed into the list for the next lower hash. We stop when we reach k=0 or hash=0.

Finally, we combine all the lists from the hashtable and return the sum.

### Runtime
The runtime for the logarithmic hashtable approach is O(log(num[i])*min(n, k)). 

## findSmallestDivisor
Given two strings, s and t, determine if s is divisible by t (ie s can be formed by repetition of t).
If not, return -1.
If so, return the length of the smallest string that is a divisor of both s and t.

## Included
- solution
- unit tests

## Language
C#