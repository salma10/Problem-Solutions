public class Solution {
    public int ArraySign(int[] nums) {
        int product = 1;
        for(int index = 0; index < nums.Length; index++)
        {
            if(nums[index] < 0)
                product *= -1;
            else if(nums[index] > 0)
                product *= 1;
            else
                return 0;
        }
        if(product < 0)
            return -1;
        else if(product > 0)
            return 1;
        else
            return 0;
    }
}