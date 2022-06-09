public class Solution {
    public bool IsAnagram(string s, string t) {        
        if(s.Length != t.Length)
        {
            return false;
        }
        else
        {
            Dictionary<char,int> dict = new Dictionary<char,int>();

            for(int i = 0; i < s.Length; i++)
            {
                if(!dict.ContainsKey(s[i]))
                {
                    dict[s[i]] = 0;
                }
                dict[s[i]]++;
            }

            for(int i = 0; i < t.Length; i++)
            {
                if(!dict.ContainsKey(t[i]))
                {
                    return false;
                }
                dict[t[i]]--;
                if(dict[t[i]]  == 0)
                    dict.Remove(t[i]);
            }
        }
        return true;
    }
}