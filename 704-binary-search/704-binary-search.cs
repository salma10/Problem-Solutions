public class Solution {
    public int Search(int[] nums, int target) {        
        int min = 0;
        int max = nums.Length - 1;
        
        while(min <= max)
        {
            int mid = (min + max) / 2;
            
            if(target == nums[mid])
                return mid;
            else if(target < nums[mid])
                max = mid - 1;
            else
                min = mid + 1;
        }        
        return -1;
    }
}