from typing import List


class Solution:
	def trap(self, height: List[int]) -> int:
		tot = 0
		left = [0, 0]
		right = [len(height) - 1, 0]

		while left[0] < right[0]:
			l, peak_l = left
			r, peak_r = right

			if height[l] < height[r]:
				left[1] = max(height[l], peak_l)
				tot += left[1] - height[l]
				left[0] += 1
			else:
				right[1] = max(height[r], peak_r)
				tot += right[1] - height[r]
				right[0] -= 1

		return tot
