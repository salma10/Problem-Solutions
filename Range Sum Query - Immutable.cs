/*
Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.
*/
public class NumArray {

   int[] arr;
    
    public NumArray(int[] nums) {
        arr = new int[nums.Count()];
        int currSum = 0;
        for(int i = 0; i < nums.Count(); ++i){
            currSum += nums[i];
            arr[i] = currSum;
        }
    }

    public int SumRange(int i, int j) 
    {
        int a = arr[j];
        int b = 0;
        if (i != 0){
            b = arr[i - 1];
        }
        return a - b;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */
