public class Solution {
    public int Rob(int[] nums) {
        int first = 0;
        int last = 0;
        int curr = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            last = first;
            first = curr;
            curr = Math.Max(first, last + nums[i]);
        }
        return curr;
    }
}