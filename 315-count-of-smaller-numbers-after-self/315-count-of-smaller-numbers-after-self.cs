public class Solution {
    public IList<int> CountSmaller(int[] nums) {    
        int[] lintResult = new int[nums.Length];
        List<int> llistSorted = new List<int>();

        for (int i = nums.Length - 1; i >= 0; --i) {
            int lintPos = llistSorted.BinarySearch(nums[i]);
            if (lintPos >= 0) {
                while (lintPos > 0 && llistSorted[lintPos] == llistSorted[lintPos - 1])                 {
                    lintPos--;
                }
                lintResult[i] = lintPos ;
            } else {
                lintPos = ~lintPos;
                lintResult[i] = lintPos;
            }
            llistSorted.Insert(lintPos, nums[i]);
        }
        return lintResult.ToList<int>();
    }
}