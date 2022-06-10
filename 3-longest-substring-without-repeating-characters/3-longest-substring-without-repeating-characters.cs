public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> data = new Dictionary<char, int>();
        int startIndex = 0;
        int maxCount = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(data.ContainsKey(s[i]) && data[s[i]] >= startIndex)
            {
                startIndex = data[s[i]] + 1;
            }
            maxCount = Math.Max(maxCount , i - startIndex + 1);
            data[s[i]] = i;
        }
        return maxCount;
    }
}