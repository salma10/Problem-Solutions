public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        if(nums == null || nums.Length == 0)
            return 0;
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int left = 0, right = 0, sum = 0, max = 0, counter = 0;
        while(right < nums.Length)
        {
            int rightNum = nums[right];
            sum += rightNum;
            if(dic.ContainsKey(rightNum))
            {
                dic[nums[right]]++;
                if(dic[rightNum] > 1)
                    counter++;
            }
            else
                dic.Add(rightNum,1);
            right++;
            
            while(counter > 0)
            {
                int leftNum = nums[left];
                dic[leftNum]--;
                if(dic[leftNum] == 1)
                    counter--;
                sum -= leftNum;
                left++;
            }
            
            max = Math.Max(max,sum);
        }
        
        return max;
    }
}