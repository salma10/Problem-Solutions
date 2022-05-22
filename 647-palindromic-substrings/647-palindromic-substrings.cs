public class Solution {
    public int CountSubstrings(string s) {
        if(string.IsNullOrEmpty(s))
            return 0;
        
        int res = 0;
        for(int i = 0; i < s.Length; i++)
        {
            res += ExtendPanlindrom(s, i, i);
            res += ExtendPanlindrom(s, i, i+1);
        }
        
        return res;
    }
    private int ExtendPanlindrom(string s, int left, int right)
    {
        int cnt = 0;
        
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {
            cnt++;
            left--;
            right++;
        }
        
        return cnt;
    }
}