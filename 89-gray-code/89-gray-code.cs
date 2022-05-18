public class Solution {
    public IList<int> GrayCode(int n) {
        
        if (n == 0) 
            return new List<int> { 0 };
        
        IList<int> ans = new List<int> { 0, 1 };
        if (n == 1) return ans;
        
        for (int i = 2; i <= n; ++i)
        {
            for (int j = (int)Math.Pow(2, (i - 1)) - 1; j >= 0; --j)
            {
                int k = 1 << (i - 1);
                ans.Add(ans[j] | k);
            }
        }
        
        return ans;
    }
}