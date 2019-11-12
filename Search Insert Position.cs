/*
Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.
*/
public int SearchInsert(int[] nums, int target) {
        
        int pos = Array.IndexOf(nums, target);
        
        if(pos > -1)
          return pos;
        else
        {
           nums = nums.Where(x => x < target).ToArray();
           if(nums.Length <= 0)
             return 0;
           else
           {
               int val = nums.Max();
               int ind = Array.IndexOf(nums, val);
           
               return ind + 1;
           }
           
        }
        
    }
