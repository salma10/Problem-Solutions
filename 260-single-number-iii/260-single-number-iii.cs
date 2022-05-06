public class Solution {
    public int[] SingleNumber(int[] nums) {
        
       int mask = 0;
       for (int i = 0; i <  nums.Length; i++) 
           mask ^= nums[i];
       int diff = mask & (-mask);

       int x = 0;
       for (int i = 0; i <  nums.Length; i++) 
       {
           if ((nums[i] & diff) != 0) 
               x ^= nums[i];
       }
       return new int[] {x, mask^x};
    }
}