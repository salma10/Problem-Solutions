public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
          
        List<string> result = new List<string>();
        
         for(int k = 0; k < words.Length; k++)
         {
            if(words[k].Length != pattern.Length)
              continue;

            string s = words[k];
            Hashtable ht = new Hashtable();
            int i =0;
            bool complete = false; 

            while (i<s.Length)
            {
                if(ht.Contains(s[i]))
                {
                    if((char)ht[s[i]] != pattern[i])
                    {
                       complete = true;
                       break; 
                    } 
                }
                else if(ht.ContainsValue(pattern[i]))
                {
                    complete = true;
                    break;
                } 
                else
                    ht.Add(s[i] , pattern[i]);
                i++;
            }
            if(!complete)
              result.Add(words[k]);
        }
        return result;        
    }
}