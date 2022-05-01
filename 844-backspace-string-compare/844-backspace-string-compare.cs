public class Solution {
    public bool BackspaceCompare(string S, string T) {
        
        Stack<char> res_str = new Stack<char>();        
        
        for(int i = 0; i < S.Length; i++)
        {
            if(res_str.Count > 0 && S[i] == '#')
                res_str.Pop();
            else if(S[i] != '#')
                res_str.Push(S[i]);
        }
        
        Stack<char> res_str1 = new Stack<char>();
        
        for(int i = 0; i < T.Length; i++)
        {
            if(res_str1.Count > 0 && T[i] == '#')
                res_str1.Pop();
            else if(T[i] != '#')
                res_str1.Push(T[i]);
        }
        
        while(res_str.Count > 0 && res_str1.Count > 0)
        {
            if(res_str.Pop() != res_str1.Pop())
                return false;
        }
       
        return res_str.Count == 0 && res_str1.Count == 0;
    }
}