public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        Dictionary<string, List<int>> dp = new Dictionary<string, List<int>>();
        return helper(expression, dp, 0, expression.Length -1);
    }
    private List<int> helper(string input, Dictionary<string, List<int>> dp, int l, int r)
    {
        string curInput = input.Substring(l, r - l + 1);
        if(dp.ContainsKey(curInput)) 
            return dp[curInput];
        
        List<int> result = new List<int>();
        
        for(int i = l; i <= r; i++)
        {
            if(input[i] == '+' || input[i] == '*' || input[i] == '-')
            {                
                List<int> leftResult = helper(input, dp, l, i-1);
                List<int> rightResult = helper(input, dp, i + 1, r);
                
                foreach(int left in leftResult)
                {
                    foreach(int right in rightResult)
                    {
                        if(input[i] == '+')
                            result.Add(left + right);
                        else if(input[i] == '*')
                            result.Add(left * right);
                        else
                            result.Add(left - right);
                    }
                }
            }
        }
        
        if(result.Count <= 0)
            result.Add(Convert.ToInt32(curInput)); 
        
        dp.Add(curInput, new List<int>(result)); 
        return result;
    }
}