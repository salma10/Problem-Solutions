public class Solution {
    public string LongestPalindrome(string s)     {
       string T = string.Empty;
        
        for(int i=0;i<s.Length;i++)
            T = T + "#" + s.Substring(i,1);
        
        T = T + "#";

        int[] P = new int[T.Length];
        
        int center = 0, boundary = 0, maxLen = 0, resCenter = 0;
        
        for(int i=1; i < T.Length - 1; i++) {
            
            int iMirror = 2 * center - i; 
                P[i] = (boundary > i) ? Math.Min(boundary - i , P[iMirror]) : 0; // shortcut
            
            while(i-1-P[i] >= 0 && i + 1 + P[i] <= T.Length - 1 && T[i+1+P[i]] == T[i-1-P[i]])
                P[i]++;
            
            if(i+P[i]>boundary) { 
                center = i;
                boundary = i+P[i];
            }
            
            if(P[i]>maxLen) { 
                maxLen = P[i];
                resCenter = i;
            }    
        }
        Console.WriteLine("resCenter " + resCenter);
        Console.WriteLine("maxLen " + maxLen);
        return s.Substring((resCenter - maxLen)/2, maxLen);
    }
}