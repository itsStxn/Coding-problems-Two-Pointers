using System;

namespace Move_Zeroes;

public class AlternativeSolution : Solution {
	public void MoveZeroes(int[] nums) {
		int insertIdx = 0;

		for (int i = 0; i < nums.Length; i++) {
			if (nums[i] != 0) {
				nums[insertIdx] = nums[i];
				insertIdx++;
			}
		}

		for (int i = insertIdx; i < nums.Length; i++) {
			nums[i] = 0;
		}
	}
}
