public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int pairCount = 0;
        for(int index = 0; index < nums.Length; index++)
        {
            if(!counts.ContainsKey(nums[index]))
                counts[nums[index]] = 0;
            counts[nums[index]]++;
        }
        
        foreach(KeyValuePair<int, int> item in counts)
        {
            int rest = k - item.Key;
            if(rest == item.Key)
            {
                pairCount += item.Value / 2;
                counts[item.Key] = 0;
            }
            else if(counts.ContainsKey(rest))
            {
                pairCount += Math.Min(item.Value, counts[rest]);
                counts[item.Key] = 0;
                counts[rest] = 0;
            }
        }
        return pairCount;
    }
}