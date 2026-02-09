using System;

namespace Squares_of_a_Sorted_Array;

public class Solution {
	public int[] SortedSquares(int[] nums) {
		int n = nums.Length;
		var ans = new int[n];  

		int l = 0;
		int r = n - 1;
		for (int i = n - 1; i >= 0; i--) {
			int lNum = nums[l] * nums[l];
			int rNum = nums[r] * nums[r];
			
			if (lNum > rNum) {
				ans[i] = lNum;
				l++;
			}
			else {
				ans[i] = rNum;
				r--;
			}
		} 

		return ans;
	}
}
