public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
         if(s.Length != t.Length)
            return false;
    
         Hashtable ht = new Hashtable();
         int i =0;
        
         while (i < s.Length)
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
}