/*
Given two arrays, write a function to compute their intersection.
*/

 public int[] Intersect(int[] nums1, int[] nums2) {
        
        List<int> result = new List<int>();
        
        if(nums1.Length == 0 || nums2.Length == 0)
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
                List<int> fa = new List<int>();
                fa = nums1.ToList();
                fa.RemoveAt(pos);
                nums1 = fa.ToArray();
                
            }
        }
        return result.ToArray();
    }
