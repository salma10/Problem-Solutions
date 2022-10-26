public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        if(nums == null || nums.Length < 2)
            return false;

        int prefixSum = 0; 
        Dictionary<int,int> dic = new Dictionary<int,int>();
        dic.Add(0,-1);
        for(int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            int remainder = prefixSum % k;
            if(dic.ContainsKey(remainder) && i - dic[remainder] > 1)
                return true;
            else if(!dic.ContainsKey(remainder))
                dic.Add(remainder,i);
        }
           
        return false;
    }
}