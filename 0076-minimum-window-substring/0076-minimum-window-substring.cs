public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> dic = new Dictionary<char,int>();
        foreach(char c in t)
        {
            if(dic.ContainsKey(c))
                dic[c]++;
            else
                dic.Add(c, 1);
        }
        
        int left = 0, right = 0, minlen = s.Length + 1, counter = dic.Count;
        string res = "";
        
        while(right < s.Length)
        {
            char rightChar = s[right];
            if(dic.ContainsKey(rightChar))
            {
                dic[rightChar]--;
                if(dic[rightChar] == 0)
                    counter--;
            }
            right++;
            
            while(counter == 0)
            {
                if(right - left < minlen)
                {
                    minlen = right - left;
                    res = s.Substring(left, minlen);
                }
                char leftChar = s[left];
                if(dic.ContainsKey(leftChar))
                {
                    dic[leftChar]++;
                    if(dic[leftChar] > 0)
                        counter++;
                }       
                left++;
            }
        }       
        return res;
    }
}