public class Solution {
    public int MinOperations(int[] nums, int x) {
        int sum = nums.Sum() - x;
        if(sum < 0) return -1;
        if(sum == 0) return nums.Length;
        int start = 0, cur = 0, len = -1;
        for(int end = 0; end < nums.Length; end++)
        {
            if (cur < sum)
                cur += nums[end];
            while (cur >= sum)
            {
                if (cur == sum)
                    len = Math.Max(len, end - start + 1);
                cur -= nums[start++];
            }
        }

        return len == -1 ? -1 : nums.Length - len;
    }
}