public class Solution {
    public int MissingElement(int[] nums, int k) {
        int left = 0, right = nums.Length - 1, pivot;

        while (left < right) 
        {
          pivot = left + (right - left + 1) / 2;
          int distance  =  nums[pivot] - nums[left] + left - pivot;
          if (distance >= k) 
              right = pivot - 1;
          else
          {
              k -= distance;
              left = pivot;
          }
              
        }
        return nums[left] + k;
    }
}