public class Solution {
    public int RomanToInt(string s) {
        int number = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && RomanMap[s[i]] < RomanMap[s[i + 1]])
            {
                number -= RomanMap[s[i]];
            }
            else
            {
                number += RomanMap[s[i]];
            }
        }
        return number;
    }
    
    private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
}