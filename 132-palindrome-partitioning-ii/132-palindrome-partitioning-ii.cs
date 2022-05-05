public class Solution {
    public int MinCut(string s) {
        if (s.Length <= 1)
            return 0;
        
        bool[,] palindrome = new bool[s.Length, s.Length];
        int[] dp = new int[s.Length + 1];
        
        dp[0] = 0;
        for (int i = 1; i <= s.Length; ++i)
        {
            dp[i] = i;
            for (int j = 1; j <= i; ++j)
            {
                if (s[i - 1] == s[j - 1] && (i - j <= 1 || palindrome[j, i - 2]))
                {
                    palindrome[j - 1, i - 1] = true;
                    dp[i] = Math.Min(dp[i], dp[j - 1] + 1);
                }
            }
        }
        
        return dp[s.Length] - 1;
    }
}