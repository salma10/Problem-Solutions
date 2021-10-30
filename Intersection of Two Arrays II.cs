public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> hash = new Dictionary<int, int>();
        List<int> result = new List<int>();
        for(int i = 0; i < nums2.Length; i++)
        {
            if(hash.ContainsKey(nums2[i]))
                hash[nums2[i]]++;
            else
                hash[nums2[i]] = 1;
        }
        
        for(int i = 0; i < nums1.Length && hash.Count > 0; i++)
        {
            if(hash.ContainsKey(nums1[i]))
            {
               result.Add(nums1[i]);
               if(hash[nums1[i]] > 1)
                   hash[nums1[i]]--;
               else
                   hash.Remove(nums1[i]);
            }
        }
        return result.ToArray();
    }
