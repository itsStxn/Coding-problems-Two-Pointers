# Container With Most Water

You are given an integer array height of length `n`. There are `n` vertical lines drawn such that the two endpoints of the ith line are **(i, 0)** and **(`i`,` height[i]`)**.

Find two lines that together with the x-axis form a container, such that the container contains the most water.

*Return the maximum amount of water a container can store.*
- Notice that you may not slant the container.

### Example 1
***Input:*** `height` = [1,8,6,2,5,4,8,3,7]  
***Output:*** 49  
***Explanation:***
- The above vertical lines are represented by array `[1,8,6,2,5,4,8,3,7]`
- In this case, the max area of water (blue section) the container can contain is 49.

### Example 2
***Input:*** `height` = [1,1]  
***Output:*** 1

### Constraints
- n == `height.length`
- 2 <= `n` <= 10^5
- 0 <= `height[i]` <= 10^4

## Strategy
Use a left and right pointer at the edges of the `height` array. Use the *greedy approach* to move forward (or backward) the pointer that points to the smaller height. Keep calculating the area of the current rectangle:
- The width is equal to the difference between right and left
- The height is equal to the smallest one between right and left

Store the largest area.

## Time Complexity - O(n)
Each element is traversed once.

## Space Complexity - O(1)
No data structure variables with `n` size are used.
