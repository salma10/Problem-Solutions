/*
Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.
*/

public int FirstUniqChar(string s) {
        
        char[] chars = s.ToCharArray();
        
        var groups = s.GroupBy(v => v);
        
        foreach(var group in groups)
        {
            if(group.Count() == 1)
              return Array.IndexOf(chars, group.Key);
        }
        
        return -1;
        
    }

//Another solution
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
