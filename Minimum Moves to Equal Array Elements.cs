/*
Given a non-empty integer array of size n, find the minimum number of moves required to make all array elements equal, where a move is incrementing n - 1 elements by 1.
*/

 public int MinMoves(int[] nums) {        
        Array.Sort(nums);       
        int result = 0;      
        for(int i = 1; i < nums.Length; i++)
        {
            result = result + nums[i] - nums[0];
        }       
        return result;
    }
