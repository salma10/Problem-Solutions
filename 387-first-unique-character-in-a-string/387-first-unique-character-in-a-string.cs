public class Solution {
    public int FirstUniqChar(string s) {
        
        Dictionary<char,int> dict = new Dictionary<char,int>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i]))
                dict[s[i]] = -1;
            else
                dict[s[i]] = i;
        }
        
        foreach(var item in dict)
        {
            if(item.Value != -1)
                return item.Value;
        }
        return -1;
    }
}