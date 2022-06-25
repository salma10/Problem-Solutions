public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        if ((s == null || s.Length == 0) || (s == null && t == null))
            return true;
        if (t == null) 
            return false; 
        
        int index = 0;
        
        for(int i = 0; i < t.Length; i++)
        {
            if(s[index] == t[i])
                index++;
            if(index == s.Length)
                return true;
        }
        
        return false;
        
    }
}