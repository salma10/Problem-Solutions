/*
The set S originally contains numbers from 1 to n. But unfortunately, due to the data error, one of the numbers in the set got duplicated to another number in the set, which results in repetition of one number and loss of another number.

Given an array nums representing the data status of this set after the error. Your task is to firstly find the number occurs twice and then find the number that is missing. Return them in the form of an array.
*/

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
