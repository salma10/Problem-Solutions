public int[] Intersection(int[] nums1, int[] nums2) {
        
        nums1 = nums1.Distinct().ToArray();
        nums2 = nums2.Distinct().ToArray();
        List<int> result = new List<int>();
        
        int ind = 0;
        
        if(nums1.Length == 0|| nums2.Length == 0)
        {
            return result.ToArray();
        }
        else if(nums1.Length < nums2.Length)
        {
          int[] nums3 = new int[nums1.Length];
          nums3 = nums1;
          nums1 = nums2;
          nums2 = nums3;
        }
        
          for(int i = 0; i < nums2.Length; i++)
          {
              int pos = Array.IndexOf(nums1, nums2[i]);
                if (pos > -1)
                {
                    result.Add(nums2[i]);
                }
          }
          return result.ToArray();
        
    }
