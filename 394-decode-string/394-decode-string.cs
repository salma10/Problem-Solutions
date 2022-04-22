public class Solution {
    public string DecodeString(string s) {
        Stack<char> data = new Stack<char>();
        Stack<string> queue = new Stack<string>();
        string result = string.Empty;
        
        for(int i = 0; i < s.Length; i++)
            data.Push(s[i]);
        
        while(data.Count > 0)
        {
            char currChar = data.Pop();
            if(currChar == '[')
            {
                string curr = string.Empty;
                string currRes = string.Empty;
                while(queue.Peek() != "]")
                    curr += queue.Pop();
                queue.Pop();
                
                string currNo = string.Empty;
                int currDigit = 0;
                while(data.Count > 0 && Int32.TryParse(data.Peek().ToString(), out currDigit))
                {
                    currNo = data.Pop().ToString() + currNo;
                }
                int noToRep = Int32.Parse(currNo);
                for(int j = 0; j < noToRep; j++)
                    currRes += curr;
                queue.Push(currRes);
            }
            else
            {
                queue.Push(currChar.ToString());
            }
        }
        
        while(queue.Count > 0)
            result += queue.Pop();
        return result;
    }
}