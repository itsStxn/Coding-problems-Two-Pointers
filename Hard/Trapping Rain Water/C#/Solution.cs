using System;

namespace Trapping_Rain_Water;

public class Solution {
	public int Trap(int[] height) {
		int n = height.Length - 1;
		if (n <= 1) return 0;

		var (l, lMax) = (0, 0); 
		var (r, rMax) = (n, 0); 
		int trapped = 0;

		while (l < r) {
			if (height[l] < height[r]) {
				lMax = Math.Max(lMax, height[l]);
				trapped += lMax - height[l];
				l++;
			}
			else {
				rMax = Math.Max(rMax, height[r]);
				trapped += rMax - height[r];
				r--;
			}
		}

		return trapped;
	}
}
