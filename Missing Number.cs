/*
Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
*/

   public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int expectedSum = n *(n+1)/2;
    
      int sum = 0;
      for(int i = 0; i < nums.Length; i++){
        sum += nums[i];
      }
    
       return expectedSum-sum;
    }
