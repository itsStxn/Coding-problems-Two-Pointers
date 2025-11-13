# Trapping Rain Water

## Description
Given `n` non-negative integers representing an elevation map where the width of each bar is `1`, compute how much water it can trap after raining.

### Example 1
***Input***: `height` = [0,1,0,2,1,0,1,3,2,1,2,1]  
***Output***: 6  
***Explanation***: 
- The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1].
- In this case, 6 units of rain water (blue section) are being trapped.

### Example 2
***Input***: `height` = [4,2,0,3,2,5]  
***Output***: 9

### Constraints
`n` == `height.length`  
1 <= `n` <= 2 * 10^4  
0 <= height[i] <= 105

## Strategy
Use two pointers on the right and left. Use them to index `height` and record the highest peaks they find. Costantly compare the two pointers. If the height on the right is higher than the one on the left, the left pointer moves forward and viceversa.

Compare the current height indexed by a pointer to its recorded peak and update it when the current height is higher. Sum the difference between the peak and current height into the `trappedWater` variable.

The operation stops when the pointers meet or get past each other.

## Time Complexity - O(n)
Each element in `height` is processed once.

## Space Complexity - O(1)
No data structure variables with `n` size are used.
