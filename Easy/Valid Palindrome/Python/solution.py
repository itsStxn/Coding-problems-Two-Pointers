class Solution:
	def isPalindrome(self, s: str) -> bool:
		left, right = 0, len(s) - 1
		txt = s.lower()

		while left < right:
			if not txt[left].isalnum():
				left += 1
				continue
			if not txt[right].isalnum():
				right -= 1
				continue

			if txt[left] != txt[right]:
				return False
			
			left += 1
			right -= 1

		return True
