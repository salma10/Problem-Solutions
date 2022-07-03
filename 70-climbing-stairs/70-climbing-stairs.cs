public class Solution {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    
    public int ClimbStairs(int n) {
        
        if(n <= 0) 
            return 0;
        if(n == 1) 
            return 1;
        if(n == 2) 
            return 2;
        
        if (dict.ContainsKey(n))
        {
            return dict[n];
        }
        else
        {
            int result1 = ClimbStairs(n - 1);
            
            if (!dict.ContainsKey(n-1))
            {
                dict.Add(n-1, result1);
            }

            int result2 = ClimbStairs(n - 2);
            
            if (!dict.ContainsKey(n-2))
            {
                dict.Add(n-2, result2);
            }

            int result = result1 + result2;
            
            if (!dict.ContainsKey(n))
            {
                dict.Add(n, result);
            }
            return result;
        }
    }
}