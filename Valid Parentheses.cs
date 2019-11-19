/*
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.
*/

public bool IsValid(string s) {
        Stack st = new Stack();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
                st.Push(s[i]);
            else if(s[i] == ')' && (st.Count == 0 || (char)st.Pop() != '('))
                return false;
            else if(s[i] == '}' && (st.Count == 0 || (char)st.Pop() != '{'))
                return false;
            else if(s[i] == ']' && (st.Count == 0 || (char)st.Pop() != '['))
                return false;             
        }
        
        if(st.Count == 0)
            return true;
        else
            return false;
        
    }
