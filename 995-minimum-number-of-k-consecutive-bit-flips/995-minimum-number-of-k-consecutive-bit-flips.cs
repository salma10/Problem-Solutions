public class Solution {
    public int MinKBitFlips(int[] nums, int k) {
        
        int n = nums.Length, flipCnt = 0;
        int[] diff = new int[n + 1];
        int totalFlip = 0;
          
        for(int i = 0; i < n; i++)
        {
            totalFlip += diff[i];
            if((nums[i] + totalFlip) % 2 == 0)
            {
                if(i + k - 1 >= n)
                    return -1;
                
                totalFlip++;
                diff[i + k] -= 1;
                flipCnt++;
            }
        }
        return flipCnt;
    }
}