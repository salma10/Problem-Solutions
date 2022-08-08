public class Solution {
    public int LengthOfLIS(int[] nums) {
        List<int> data = new List<int>();
        data.Add(nums[0]);
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > data[data.Count - 1])
                data.Add(nums[i]);
            else
            {
                int pos = SearchPosition(data, nums[i]);
                data[pos] = nums[i];
            }
        }
        return data.Count();
    }
    
    private int SearchPosition(List<int> data, int target)
    {
        int left = 0;
        int right = data.Count - 1;
        while(left < right)
        {
            int mid = (left + right) / 2;
            if(data[mid] == target)
                return mid;
            if(data[mid] < target)
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }
}