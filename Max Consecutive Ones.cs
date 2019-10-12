 public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int tmp_max = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                tmp_max++;
                if(max < tmp_max)
                  max = tmp_max;
            }
            else
            {
                tmp_max = 0;
            }
        }
        
        return max;
    }
