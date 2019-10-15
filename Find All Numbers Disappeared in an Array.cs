  public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> result = new List<int>();
        for(int i = 0; i <= nums.Length - 1; i++)
        {
            int a = Math.Abs(nums[i]);
            if(nums[a-1] > 0)
              {
                 nums[a-1] = - nums[a-1];
              }
        }        
        for(int i = 0; i <= nums.Length - 1; i++)
        {
            if(nums[i] > 0)
              {
                 result.Add(i+1);
              }
        }
        return result;        
    }
