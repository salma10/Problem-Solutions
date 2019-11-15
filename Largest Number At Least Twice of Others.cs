/*
In a given integer array nums, there is always exactly one largest element.
Find whether the largest element in the array is at least twice as much as every other number in the array.
If it is, return the index of the largest element, otherwise return -1.
*/

 public int DominantIndex(int[] nums) {    
        int maxnum = 0;
        int maxpos = -1;
        for(int i = 0; i < nums.Length; i++)
        {
            if(maxnum < nums[i])
            {
                maxnum = nums[i];
                maxpos = i;
            }
        }     
        for(int i = 0; i < nums.Length; i++)
        {
            if(maxnum != nums[i] && maxpos != i && maxnum < nums[i] * 2)
            {
                return -1;
            }
        }
        return maxpos;
    }
