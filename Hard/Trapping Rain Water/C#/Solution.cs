using System;

namespace Trapping_Rain_Water;

public class Solution {
	public int Trap(int[] height) {
		int n = height.Length;
		if (n-- < 3) return 0;

		var (l, lMax) = (0, 0); 
		var (r, rMax) = (n, 0); 
		int trappedWater = 0;

		while (l < r) {
			if (height[l] < height[r]) {
				lMax = Math.Max(lMax, height[l]);
				trappedWater += lMax - height[l++];
			}
			else {
				rMax = Math.Max(rMax, height[r]);
				trappedWater += rMax - height[r--];
			}
		}

		return trappedWater;
	}
}
