public class Solution {
    public int NumRollsToTarget(int n, int k, int target) {
        int[] dp = new int[target + 1];
        dp[0] = 1;
        for (int i = 1; i <= n; i++) 
        {
            int[] temp = new int[target + 1];
            for (int j = 1; j <= k; j++)
                for (int l = j; l <= target; l++)
                    temp[l] = (temp[l] + dp[l - j]) % 1_000_000_007;
            dp = temp;
        }
        return dp[target];
    }
}