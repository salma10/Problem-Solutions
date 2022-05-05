public class Solution {
    public IList<IList<int>> GetFactors(int n) {     
        List<IList<int>> res = new List<IList<int>>();
        backtracking(n, 2, new List<int>(), res);
        return res;
    }
    
    private void backtracking(int n, int start, List<int> list, List<IList<int>> res)
    {
        if(list.Count > 0)
        {
            list.Add(n);
            res.Add(new List<int>(list));
            list.RemoveAt(list.Count - 1);
        }
        
        for(int i = start; i * i <= n; i++)
        {
            if(n % i == 0)
            {
                list.Add(i);
                backtracking(n / i, i, list, res);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}