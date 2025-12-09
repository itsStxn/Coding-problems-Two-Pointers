from typing import List


class Solution:
	def maxArea(self, height: List[int]) -> int:
		max_area = 0
		l, r = 0, len(height) - 1

		while (l < r):
			area, w = 0, r - l
			if height[l] < height[r]:
				area = w * height[l]
				l += 1
			else:
				area = w * height[r]
				r -= 1
			max_area = max(area, max_area)

		return max_area
