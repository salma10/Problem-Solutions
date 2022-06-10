public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        char s1First = '0';
        char s1Sec = '0';
        char s2First = '0';
        char s2Sec = '0';
        
        for(int index = 0; index < s1.Length; index++)
        {
            if(s1[index] != s2[index])
            {
                if(s1First == '0')
                {
                    s1First = s1[index];
                    s2First = s2[index];
                }
                else if(s1Sec == '0')
                {
                    s1Sec = s1[index];
                    s2Sec = s2[index];
                }
                else
                    return false;
            }
        }
        
        return s1Sec == s2First && s1First == s2Sec;
    }
}