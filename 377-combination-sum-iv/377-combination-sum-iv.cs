public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        int[] dp = new int[target + 1];
        dp[0] = 1;

        for (int sum = 1; sum < target + 1; ++sum) {
            foreach (int num in nums) {
                if (sum - num >= 0)
                    dp[sum] += dp[sum - num];
            }
        }
        return dp[target];
    }
}