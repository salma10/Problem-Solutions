public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[2];
        for(int i = 0; i < numbers.Length; i++)
        {
            if(target - numbers[i] < numbers[i])
                continue;
            else
            {
                
                int secPos = Search(numbers, target - numbers[i], i + 1, numbers.Length - 1);
                if(secPos != -1)
                {
                    result[0] = i + 1;
                    result[1] = secPos + 1;
                    return result;
                }
            }
        }
        return result;
    }    
    private int Search(int[] nums, int target, int start, int end)
    {
        while(start <= end)
        {
            int mid = start + (end - start) / 2;
            if(nums[mid] == target)
                return mid;
            else if(nums[mid] < target)
                start = mid + 1;
            else
                end = mid - 1;
        }
        return -1;
    }
}