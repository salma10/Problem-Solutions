public class Solution {
    public int MaxProduct(int[] nums) {
        int sum = nums[0],currentSum = nums[0], actualSum = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            int tempcurrentSum = Math.Max(nums[i], Math.Max(currentSum * nums[i], actualSum * nums[i]));
            actualSum = Math.Min(nums[i], Math.Min(currentSum * nums[i], actualSum * nums[i]));
            currentSum = tempcurrentSum;
            sum = sum > currentSum ? sum : currentSum;
        }
        return sum;
    }
}