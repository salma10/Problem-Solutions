/*
Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.
*/

public bool BackspaceCompare(string S, string T) {        
        Stack<char> res_str = new Stack<char>();
        string result_S = string.Empty;
        string result_T = string.Empty;
        
        for(int i = 0; i < S.Length; i++)
        {
            if(res_str.Count() > 0 && S[i] == '#')
                res_str.Pop();
            else if(S[i] != '#')
                res_str.Push(S[i]);
        }
        
        foreach(var item in res_str)
        {
            result_S = item + result_S;
        }
        res_str = new Stack<char>();
        
        for(int i = 0; i < T.Length; i++)
        {
            if(res_str.Count() > 0 && T[i] == '#')
                res_str.Pop();
            else if(T[i] != '#')
                res_str.Push(T[i]);
        }
        
        foreach(var item in res_str)
        {
            result_T = item + result_T;
        }
        return result_S == result_T;
   

    }
