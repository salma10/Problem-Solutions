public class Solution {
    public int LongestStrChain(string[] words) {
        if(words == null || words.Length == 0)
            return 0;
        
        Array.Sort(words, (w1, w2) => w1.Length - w2.Length);
        Dictionary<string,int> dic = new Dictionary<string,int>();
        int maxLen = 0;
        foreach(var word in words)
        {     
            if(!dic.ContainsKey(word))
            {
                int currLen = 1;
                for(int i = 0; i < word.Length; i++)
                {
                    StringBuilder sb = new StringBuilder(word); 
                    sb.Remove(i,1);
                    string modifiedWord = sb.ToString();
                    int modifiedLen = dic.ContainsKey(modifiedWord)? dic[modifiedWord] + 1 : 1;
                    currLen = Math.Max(currLen, modifiedLen);
                }

                dic.Add(word,currLen);
                maxLen = Math.Max(maxLen, currLen);
            }     
        }
        
        return maxLen;
    }
}