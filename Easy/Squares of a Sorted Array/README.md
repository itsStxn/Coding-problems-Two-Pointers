# Squares of a Sorted Array

## Description
Given an integer array `nums` sorted in **non-decreasing** order, return *an array of the squares of each number sorted in **non-decreasing** order*.

### Example 1
***Input***: `nums` = [-4,-1,0,3,10]  
***Output***: [0,1,9,16,100]  
***Explanation***:  
- After squaring, the array becomes [16,1,0,9,100].
- After sorting, it becomes [0,1,9,16,100].

### Example 2
***Input***: `nums` = [-7,-3,2,3,11]  
***Output***: [4,9,9,49,121]  

### Constraints
- 1 <= `nums.length` <= 10^4
- -10^4 <= `nums[i]` <= 10^4
- `nums` is sorted in **non-decreasing order**.

## Strategy
The array is sorted, and there can be negative numbers. That means that at the left and right of `nums` there can be the highest absolute numbers.

Create an array and set a left and right pointer. Calculate the square of their pointed values and insert the lower to the created answer array. Then increase/decrease the pointer of the inserted value. Do this iteratively.

## Time Complexity - O(1)
Each number is processed once on average.

## Space Complexity - O(n)
An array of `n` size is created.
