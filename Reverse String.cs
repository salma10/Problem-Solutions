 public string ReverseString(string s) {       
      char[] charArray = s.ToCharArray();
      Array.Reverse( charArray );
      return new string( charArray );

    }
//Another solution
public class Solution {
    public void ReverseString(char[] s) {
        int i = 0, j = s.Length - 1;
        Reverse_sub(s,i,j);
    }   
    public void Reverse_sub(char[] s, int i, int j) {      
        if(i > j)
            return;
        else
        {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            i++;
            j--;
            Reverse_sub(s,i,j);
        }
    }
}
//Another solution
public class Solution {
    public void ReverseString(char[] s) {
        int firstPos = 0;
        int lastPos = s.Length - 1;
        
        while(firstPos <= lastPos)
        {
            char temp = s[firstPos];
            s[firstPos] = s[lastPos];
            s[lastPos] = temp;
            firstPos++;
            lastPos--;
        }
        
    }
}
