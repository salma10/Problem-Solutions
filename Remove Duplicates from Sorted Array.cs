/*
Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
*/
 public int RemoveDuplicates(int[] nums) {
        
        if (nums == null || nums.Length == 0) return 0;
        int len = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1])
            {
                nums[len] = nums[i];
                len++;
            }
        }
        return len;
 
    }
