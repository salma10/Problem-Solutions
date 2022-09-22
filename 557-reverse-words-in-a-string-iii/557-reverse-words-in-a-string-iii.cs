public class Solution {
    public string ReverseWords(string s) {
        string[] splittedString = s.Split(" ");
        s = string.Empty;
        for(int i = 0; i < splittedString.Length; i++)
        { 
           s =  s + ReverseString(splittedString[i]) + " ";
        }
        return s.Trim();
    }
    
    public string ReverseString(string input) {
        int firstPos = 0;
        int lastPos = input.Length - 1;
        char[] s = input.ToCharArray();
        while(firstPos <= lastPos)
        {
            char temp = s[firstPos];
            s[firstPos] = s[lastPos];
            s[lastPos] = temp;
            firstPos++;
            lastPos--;
        }
        
        return new string(s);
    }
}