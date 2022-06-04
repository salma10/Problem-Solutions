public class Solution {
    public void MoveZeroes(int[] nums) {     
        int nonZeroPos = -1;
        int ZeroPos = -1;
        int pos = 0;
        
        while(pos < nums.Length)
        {
            while(ZeroPos == -1 && pos < nums.Length)
            {
                if(nums[pos] != 0)
                    pos++;
                else{
                    ZeroPos = pos;
                    pos++;
                }
            }
            while(ZeroPos != -1  && pos < nums.Length)
            {
                if(nums[pos] != 0)
                {
                   nums[ZeroPos] = nums[pos];
                   nums[pos] = 0;
                   ZeroPos++; 
                   pos++;
                }
                else
                {
                    pos++;
                }
            }
        }
    }
}