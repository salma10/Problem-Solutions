 public string RemoveDuplicates(string S) {     
        Stack<char> res_str = new Stack<char>();
        string result = string.Empty;
        
        for(int i = 0; i < S.Length; i++)
        {
            
            if(res_str.Count() > 0 && res_str.Peek() == S[i])
                res_str.Pop();
            else
                res_str.Push(S[i]);
        }    
        foreach(var item in res_str)
        {
            result = item + result;
        }
        return result;
    }
