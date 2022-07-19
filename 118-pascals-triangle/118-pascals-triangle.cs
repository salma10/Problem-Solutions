public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>{1});
        for(int i = 1; i < numRows; i++)
        {
            List<int> row = new List<int>();
            IList<int> temp = result[i - 1];
            for(int j = 0; j <= i; j++)
            {
                if(j == 0 || j == i)
                {
                   row.Add(1); 
                }
                else
                {
                    row.Add(temp[j] + temp[j - 1]);
                }
            }
            result.Add(row);
        }
        return result;
    }
}