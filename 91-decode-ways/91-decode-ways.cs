public class Solution {
    public int NumDecodings(string s) {
        int n = s.Length;
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = s[0] != '0' ? 1 : 0;
        
        for(int i = 2; i < dp.Length; i++)
        {
            int val1 = Convert.ToInt32(s.Substring(i - 1, 1));
            if(val1 > 0)
                dp[i] = dp[i - 1];
            int val2 = Convert.ToInt32(s.Substring(i - 2, 2));
            if(val2 >= 10 && val2 <= 26)
                dp[i] += dp[i - 2];
        }
        
        return dp[n];
    }
}