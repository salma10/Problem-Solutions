public class Solution {
    public int CharacterReplacement(string s, int k) {
        if(s == null || s.Length == 0)
            return 0;
        
        Dictionary<char,int> dic = new Dictionary<char,int>();
        int left = 0, right = 0, cnt = 0, maxCnt = 0, maxlen = 0;
               
        while(right < s.Length)
        {            
            char rightChar = s[right];
            if(dic.ContainsKey(rightChar))
                dic[rightChar]++;
            else
                dic.Add(rightChar, 1);
            right++;    
            maxCnt = Math.Max(maxCnt, dic[rightChar]);
            
            if(right - left - maxCnt > k)
            {
                char leftChar = s[left];      
                dic[leftChar]--;
                left++;
            }
            
            maxlen = Math.Max(maxlen, right - left);   
        }        
        return maxlen;
    }
}