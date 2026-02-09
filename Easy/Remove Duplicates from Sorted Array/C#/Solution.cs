using System;

namespace Remove_Duplicates_from_Sorted_Array;

public class Solution {
	public int RemoveDuplicates(int[] nums) {
		int swapIdx = 1;

		for (int i = 1; i < nums.Length; i++) {
			if (nums[i] != nums[i - 1]) {
				nums[swapIdx] = nums[i];
				swapIdx++;
			}
		}

		return swapIdx;
	}
}
