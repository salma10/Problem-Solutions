public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int count = 0;
        int n = nums.Length;
        for (int i = 0; i < n; ++i)
        {
            if (nums[i] != val)
            {
                nums[count++] = nums[i];
            }
        }
        return count;
        
    }
}