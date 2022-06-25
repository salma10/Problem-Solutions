public class Solution {
    public bool CheckPossibility(int[] nums) {
        int count = 0;
        for (int i = 1; i < nums.Length; i++) 
        {
            
            if (nums[i - 1] > nums[i]) {
                
                if (count == 1) {
                    return false;
                }
                
                count++;
                
                if (i < 2 || nums[i - 2] <= nums[i]) {
                    nums[i - 1] = nums[i];
                } else {
                    nums[i] = nums[i - 1];
                }
            }
        }
        return true;
    }
}