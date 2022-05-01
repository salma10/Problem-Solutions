public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int[] dp = new int[nums.Length];
        for (int s = nums.Length; s >= 0; s--) 
        {
            for (int e = s; e < nums.Length; e++) 
            {
                if (s == e) 
                {
                    dp[s] = nums[s];
                } 
                else 
                {
                    int a = nums[s] - dp[e];
                    int b = nums[e] - dp[e - 1];
                    dp[e] = Math.Max(a, b);
                }
            }
        }
        return dp[nums.Length - 1] >= 0;
    }
}