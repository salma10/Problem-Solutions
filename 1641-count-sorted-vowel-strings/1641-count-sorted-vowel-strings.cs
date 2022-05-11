public class Solution {
    public int CountVowelStrings(int n) {
        if(n == 0)
            return 0;      
        
        int a = 1, e = 1, i = 1, o = 1, u = 1;
        for(int len = 1; len < n; len++)
        {
            a = a + e + i + o + u; 
            e = e + i + o + u;     
            i = i + o + u;         
            o = o + u;             
            u = u;                 
        }
        
        return a + e + i + o + u;
    }
}