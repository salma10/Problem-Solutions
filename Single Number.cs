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
