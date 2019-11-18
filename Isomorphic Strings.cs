/*
Given two strings s and t, determine if they are isomorphic.
Two strings are isomorphic if the characters in s can be replaced to get t.
All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character but a character may map to itself.
*/

 public bool IsIsomorphic(string s, string t) {
        
       if(s.Length != t.Length)
    return false;
    
 Hashtable ht = new Hashtable();
 int i =0;
 while (i<s.Length)
 {
     if(ht.Contains(s[i]))
     {
         if((char)ht[s[i]] != t[i])
         return false;
     }
     else if(ht.ContainsValue(t[i]))
     return false;
     
     else
     ht.Add(s[i] , t[i]);
     
     i++;
 }
 return true;
        
    }
