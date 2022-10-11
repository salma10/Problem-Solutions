public class Solution {
    public bool IncreasingTriplet(int[] nums) {        
        int fast = int.MaxValue;
        int sec = int.MaxValue;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] <= fast)
                fast = nums[i];
            else if(nums[i] <= sec)
                sec = nums[i];
            else
                return true;
        }
        return false;
    }
}