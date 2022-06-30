public class Solution {
    public int MinMoves2(int[] nums) {        
        Array.Sort(nums); 
        int result = 0;
        int mid = nums.Length/2;
        
        for(int i = mid; i < nums.Length; i++)
        {
            result = result + nums[i] - nums[mid];
        }
        for(int i = 0; i < mid; i++)
        {
            result = result + nums[mid] - nums[i];
        }
        
        return result;
        
    }
}