public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum = nums[0],currentSum = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            currentSum = currentSum + nums[i] > nums[i] ? currentSum + nums[i] : nums[i];
            sum = sum > currentSum ? sum : currentSum;
        }
        return sum;
    }
}