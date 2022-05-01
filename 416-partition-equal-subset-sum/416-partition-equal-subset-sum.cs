public class Solution {
    public bool CanPartition(int[] nums) {
        if(nums.Length < 2)
            return false;
        
        int sum = nums.Sum();
        
        if(sum % 2 == 1)
            return false;
        
        int target = sum / 2;
        bool[] cache = new bool[target + 1];
        cache[0] = true;
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = target; j >= nums[i]; j--)
            {
                cache[j] = cache[j] | cache[j - nums[i]];
            }
        }
        return cache[target];
    }
}