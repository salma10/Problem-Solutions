public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> Map = new Dictionary<int,int>();      
        for(int i = 0; i < nums.Length; i++)
        {
            Map[nums[i]] = i;
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(Map.ContainsKey(target - nums[i]) && i != Map[target - nums[i]])
            {
               return new int[] {i, Map[target - nums[i]]} ;
            }
        }
        return new int[] {} ;
    }
}