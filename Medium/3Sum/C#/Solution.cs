namespace _3Sum;

public class Solution {
	public IList<IList<int>> ThreeSum(int[] nums) {
		Array.Sort(nums);
		int n = nums.Length;
		var ans = new List<IList<int>>();
		
		if (nums[^1] < 0) return ans;
		
		for (int l = 0; l < n - 2; l++) {
			if (nums[l] > 0) 
				break;
			if (l > 0 && nums[l] == nums[l - 1])
				continue;

			int m = l + 1;
			int r = n - 1;

			while (l < r) {
				int tot = nums[l] + nums[m] + nums[r];
				if (tot < 0) {
					l++;
				}
				else if (tot > 0) {
					r--;
				}
				else {
					ans.Add([nums[l], nums[m], nums[r]]);
					while (l < r && nums[l] == nums[++l]);
					while (l < r && nums[r] == nums[--r]);
				}
			}
		}

		return ans;
	}
}
