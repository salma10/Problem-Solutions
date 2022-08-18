public class Solution {
    public bool IsMatch(string s, string p) {
        bool[][] dp = new[] { new bool[s.Length + 1], new bool[s.Length + 1] };
        dp[0][0] = true;

        foreach (var c in p)
        {
            dp[1] = new bool[s.Length + 1];
            for (var i = 0; i < s.Length + 1; i++)
                if (c == '*')
                    dp[1][i] = dp[0][i] || i > 0 && dp[1][i - 1];
                else
                    dp[1][i] = i > 0 && dp[0][i - 1] && (c == '?' || c == s[i - 1]);

            dp[0] = dp[1];
        }

        return dp[0][s.Length];
    }
}