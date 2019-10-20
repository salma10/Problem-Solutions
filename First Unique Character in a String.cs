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
