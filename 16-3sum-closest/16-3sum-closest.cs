public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        
        int minDiff = Int32.MaxValue, res = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int left = i + 1, right = nums.Length - 1;
            while(left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if(sum == target)
                    return sum;
                else 
                {
                    int currDiff = Math.Abs(sum - target);
                    if(currDiff < minDiff)
                    {
                        res = sum;
                        minDiff = currDiff;
                    }
                    
                    if(sum > target)
                        right--;
                    else
                        left++;
                }
            }
        }
        
        return res;
    }
}