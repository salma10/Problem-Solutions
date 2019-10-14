 public int MajorityElement(int[] nums) {
        var groups = nums.GroupBy(v => v);
        int n = nums.Length/2;
        
        foreach(var group in groups)
        {
            if(group.Count() > n)
              return group.Key;
        }
        
        return 0;
    }
