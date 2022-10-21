public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {        
        HashSet<int> lastKNumbers = new HashSet<int>();        
        for(int i = 0; i < nums.Length; i++)
        {
            if(lastKNumbers.Contains(nums[i]))
                return true;
            lastKNumbers.Add(nums[i]);
            if(lastKNumbers.Count > k)
                lastKNumbers.Remove(nums[i - k]);
        }
        return false;
    }
}