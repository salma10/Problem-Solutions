 public int MajorityElement(int[] nums) {
        var groups = nums.GroupBy(v => v);
        int n = nums.Length/2;
        
        foreach(var group in groups)
        {
            if(group.Count() > n)
              return group.Key;
        }
        
        return 0;
    }
//Another solution
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        int majorityCount = nums.Length % 2 == 0 ? nums.Length / 2 : (nums.Length / 2) + 1;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(count.ContainsKey(nums[i]))
                count[nums[i]]++;
            else
                count[nums[i]] = 1;
            if(count[nums[i]] == majorityCount)
                return nums[i];
        }
        
        return -1;
    }
}
