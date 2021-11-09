public int SingleNumber(int[] nums) {
        int k = 0;
          var groups = nums.GroupBy(v => v);
        foreach(var group in groups)
        {
          var i = group.Key;
          var j = group.Count();
          
          if(Convert.ToInt32(j) == 1)
            k = i;;
        }
        return k;
    }
//Another solution
public int SingleNumber(int[] nums) {
        int result = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            result = result ^ nums[i];
        }
        return result;
}
//Another solution
 public int SingleNumber(int[] nums) {
        if(nums.Length == 0)
            return 0;
        for(int i = 1; i < nums.Length; i++)
        {
            nums[0] = nums[0] ^ nums[i];
        }
        return nums[0];
    }
