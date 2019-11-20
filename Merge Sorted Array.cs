/*
Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
Note:
The number of elements initialized in nums1 and nums2 are m and n respectively.
You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
*/

 public void Merge(int[] nums1, int m, int[] nums2, int n) {
          for(int i = m+n-1, i1 = m-1, i2 = n-1; i > -1; i--){
            if(i1 < 0)
                nums1[i] = nums2[i2--];
            else if(i2 < 0 || nums1[i1] > nums2[i2])
                nums1[i] = nums1[i1--];
            else
                nums1[i] = nums2[i2--];
        }
    }
