# Move Zeroes

## Description
Given an integer array `nums`, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

**Note** that *you must do this in-place without making a copy of the array*.

### Example 1
***Input***: `nums` = [0,1,0,3,12]  
***Output***: [1,3,12,0,0]  

### Example 2
***Input***: `nums` = [0]  
***Output***: [0]  

### Constraints
- 1 <= `nums.length` <= 104
- -2^31 <= `nums[i]` <= 2^31 - 1

## Strategy
Keep an index separator. Before the index there will be non zeros, after the index there will be zeros. Increase the separator index when encoutering non zeros.

### Follow up
Keep an index insertor. Traverse the array. If a number is not zero, place it in the array using the insertor index and increase it. After that, loop from the insertor index to the end of the array and keep placing zeros.


## Time Complexity - O(n)
Each number is processed once.

## Space Complexity - O(1)
Everything is handled in-place.
