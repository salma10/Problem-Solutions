public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
          if(triangle == null || triangle.Count == 0)
            return 0;
        
        int[] minPath = triangle[triangle.Count-1].ToArray();
        
        for(int i = triangle.Count - 2; i >= 0; i--)
            for(int j = 0; j <= i; j++)
                minPath[j] = Math.Min(minPath[j], minPath[j+1]) + triangle[i][j];
        
        return minPath[0];
    }
}