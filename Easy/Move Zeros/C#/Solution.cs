using System;

namespace Move_Zeroes;

public class Solution {
	public void MoveZeroes(int[] nums) {
		int swapIdx = 0;

		for (int i = 0; i < nums.Length; i++) {
			if (nums[i] != 0) {
				(nums[swapIdx], nums[i]) = (nums[i], nums[swapIdx]);
				swapIdx++;
			}
		}
	}
}
