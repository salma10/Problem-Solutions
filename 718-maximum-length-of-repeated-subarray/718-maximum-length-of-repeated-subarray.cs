public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        int len1 = nums1.Length;
        int len2 = nums2.Length;
        int maxLen = 0;
        int[][] dp = new int[len1 + 1][];
        dp[len1] = new int[len2 + 1];
        
        for(int i = len1 - 1; i >= 0; i--)
        {
            dp[i] = new int[len2 + 1];
            for(int j = len2 - 1; j >= 0; j--)
            {
                if(nums1[i] == nums2[j])
                {
                    dp[i][j] = dp[i + 1][j + 1] + 1;
                    if(dp[i][j] > maxLen)
                        maxLen = dp[i][j];
                }  
            }
        }
        return maxLen;
    }
}