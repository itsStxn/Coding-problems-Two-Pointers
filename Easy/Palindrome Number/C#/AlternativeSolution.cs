using System;

namespace Palindrome_Number;

public class AlternativeSolution : Solution {
	public bool IsPalindromeStr(int x) {
		if (x < 0 || (x % 10 == 0 && x != 0)) return false;

		string str = x.ToString();
		int R = str.Length - 1;
		int L = 0; 

		while (str[L] == str[R]) {
				if (L++ >= R--) return true;
		}

		return false;
	}
}
