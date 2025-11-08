using System;

namespace Trapping_Rain_Water;

public class Solution {
	public int Trap(int[] height) {
		int n = height.Length;
		if (n-- < 3) return 0;

		int left = 0, leftPeak = 0, 
		right = n, rightPeak = n,

		trappedWater = 0,
		rightWater = 0,
		leftWater = 0;

		while (++left <= --right) {
			if (height[left] < height[leftPeak]) {
				leftWater += height[leftPeak] - height[left];
			}
			else {
				trappedWater += leftWater;
				leftPeak = left;
				leftWater = 0;
			}

			if (left == right) continue;

			if (height[right] < height[rightPeak]) {
				rightWater += height[rightPeak] - height[right];
			}
			else {
				trappedWater += rightWater;
				rightPeak = right;
				rightWater = 0;
			}
		}

		int w = rightPeak - leftPeak - 1,
		h = Math.Min(height[rightPeak], height[leftPeak]);
		
		while (++leftPeak < rightPeak) {
			trappedWater -= Math.Min(height[leftPeak], h);
		}

		return trappedWater + w * h;
	}
}
