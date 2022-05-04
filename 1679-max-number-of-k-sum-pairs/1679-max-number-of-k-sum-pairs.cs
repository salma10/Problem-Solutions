public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int pairCount = 0;
        for(int index = 0; index < nums.Length; index++)
        {
            int rest = k - nums[index];
            if(counts.ContainsKey(rest) && counts[rest] > 0)
            {
                counts[rest]--;
                pairCount++;
            }
            else
            {
                if(!counts.ContainsKey(nums[index]))
                    counts[nums[index]] = 0;
                counts[nums[index]]++;               
            }
        }
        return pairCount;
    }
}