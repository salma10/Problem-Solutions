public class Solution {
    public int SplitArray(int[] nums, int m) {
        int maxNum = 0, sum = 0;
        foreach(var num in nums)
        {
            maxNum = Math.Max(maxNum, num);
            sum += num;
        }
        
        while(maxNum < sum)
        {
            int mid = (sum - maxNum) / 2 + maxNum;
            if(canSplit(nums, mid, m))
                sum = mid;
            else
                maxNum = mid + 1;
        }
        
        return maxNum;
    }
    private bool canSplit(int[] nums, int maxSum, int m)
    {
        int numOfSubarrays = 1, currSum = 0;
        foreach(var num in nums)
        {
            if(currSum + num > maxSum)
            {
                numOfSubarrays++;
                currSum = 0;
            }
            
            currSum += num;
            if(numOfSubarrays > m)
                return false;
        }
        
        return true;
    }
}