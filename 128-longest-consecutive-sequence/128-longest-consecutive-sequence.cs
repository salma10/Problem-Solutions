public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> dict = new HashSet<int>(nums);
        int maxSeqLen = 0;
        foreach(int num in dict)
        {
           if(!dict.Contains(num - 1))
           {
               int currNum = num;
               int currLen = 1;
               while(dict.Contains(currNum + 1))
               {
                   currNum++;
                   currLen++;
               }
               maxSeqLen = Math.Max(maxSeqLen, currLen);
           }
        }
        return maxSeqLen;
    }
}