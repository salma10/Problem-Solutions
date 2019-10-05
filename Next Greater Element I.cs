public int[] NextGreaterElement(int[] findNums, int[] nums) {
        
        int[] result = new int[findNums.Length];
        
        for(int i = 0; i < findNums.Length; i++)
        {
            int pos = Array.IndexOf(nums,findNums[i]);
            result[i] = GetGreaterNo(pos,nums);
        }
        
        return result;
    }
    
    public static int GetGreaterNo(int pos, int[] nums)
    {
        if(pos >= nums.Length - 1)
          return -1;
          
        int count = pos + 1;
        
        while(count < nums.Length)
        {
            if(nums[pos] < nums[count])
              return nums[count];
            count++;
        }
        
        return -1;
    }
