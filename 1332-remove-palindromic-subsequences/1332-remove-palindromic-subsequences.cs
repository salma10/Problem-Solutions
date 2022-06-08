public class Solution {
    public int RemovePalindromeSub(string s) {
        if(s == null || s.Length < 2)
            return 0;
        return IsPalindromeSub(s)? 1 : 2;
    }
    private bool IsPalindromeSub(string s)
    {
        int left = 0, right = s.Length - 1;
        while(left < right)
        {
            if(s[left] != s[right])
                return false;
            
            left++;
            right--;
        }
        return true;
    }
}