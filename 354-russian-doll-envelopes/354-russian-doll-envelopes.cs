public class Solution {
    public int MaxEnvelopes(int[][] envelopes) {
        if(envelopes == null || envelopes.Length == 0)
            return 0;
        
        Array.Sort(envelopes, (e1, e2) =>
           {
              if(e1[0] == e2[0])
                  return e2[1] - e1[1];
               else
                   return e1[0] - e2[0];
           });
        
        int len = 0;
        int[] dp = new int[envelopes.Length];
        for(int i = 0; i < envelopes.Length; i++)
        {
            int idx = Array.BinarySearch(dp, 0, len, envelopes[i][1]);
            if(idx < 0)
                idx = ~idx;
            
            dp[idx] = envelopes[i][1];
            if(idx == len)
                len++;
        }
        
        return len;
    }
    
   
}