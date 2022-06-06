public class Solution {
    public char FindTheDifference(string s, string t) {
        char result = (char)0;
        
        for(int i = 0; i < s.Length; i++)
        {
            result ^= s[i];
            result ^= t[i];
        }
        result ^= t[t.Length - 1];
        return result;
    }
}