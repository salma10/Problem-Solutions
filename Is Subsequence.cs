/*
Given a string s and a string t, check if s is subsequence of t.

You may assume that there is only lower case English letters in both s and t. t is potentially a very long (length ~= 500,000) string, and s is a short string (<=100).

A subsequence of a string is a new string which is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, "ace" is a subsequence of "abcde" while "aec" is not).
*/

   public bool IsSubsequence(string s, string t) {
        
        bool result = true;
        if (s==null && t==null) return true;
        if (t==null) return false; 

        int oldindex = -1;
        char[] arr = t.ToCharArray();
        
        for(int i = 0; i < s.Length; i++)
        {
            int pos = Array.IndexOf(arr,s[i],oldindex+1);          
            if(pos > -1)
              {
                  oldindex = pos;
              }
            else
              return false;
        }
        
        return result;
        
    }
