/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
*/

public int[] TwoSum(int[] nums, int target) {
        
        int ind1 = 0;
        int ind2 = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            var res = target - nums[i];
            ind1 = i;
            ind2 = Array.IndexOf(nums,res, i+1);
            if( ind2 > -1)
             {
                 break;
             }
        }
        return new int[] {ind1, ind2};
    }
