public class Solution {
    public int[] FindErrorNums(int[] nums) {
        
        int len = nums.Length;
        
        int[] original = new int[len];        
        
        foreach(int item in nums)
        {
            original[item-1]++;
        }
        int[] result = new int[2];
        for(int i = 0; i < original.Length; i++)
        {
            if(original[i] == 0)
                result[1] = i+1; 
            
            if(original[i] > 1)
                result[0] = i+1; 
        }
        return result;
    }
}