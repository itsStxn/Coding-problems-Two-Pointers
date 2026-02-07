using System;

namespace Container_With_Most_Water;

public class Solution {
	public int MaxArea(int[] height) {
		int l = 0, r = height.Length - 1;
		int max = 0;

		while (l < r) {
			int w = r - l;
			if (height[l] < height[r]) {
				max = Math.Max(max, w * height[l]);
				l++;
			}
			else {
				max = Math.Max(max, w * height[r]);
				r--;
			}
		}

		return max;
	}
}
