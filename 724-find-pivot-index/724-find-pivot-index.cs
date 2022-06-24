public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        
        int currentSum = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(currentSum == sum - nums[i] - currentSum)
                return i;
            currentSum += nums[i];
        }
        return -1;
    }
}