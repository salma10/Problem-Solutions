public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int idx1 = 0;
        int idx2 = 0;
        StringBuilder result = new StringBuilder();
        int count = 0;
        
        while(idx1 < word1.Length && idx2 < word2.Length)
        {
            if(count % 2 == 0)
            {
                result.Append(word1[idx1]);
                idx1++;
            }
            else
            {
                result.Append(word2[idx2]);
                idx2++;
            } 
            count++;
        }
        
        while(idx1 < word1.Length)
        {
           result.Append(word1[idx1]);
           idx1++; 
        }
        
        while(idx2 < word2.Length)
        {
            result.Append(word2[idx2]);
            idx2++;
        }
        return result.ToString();
    }
}