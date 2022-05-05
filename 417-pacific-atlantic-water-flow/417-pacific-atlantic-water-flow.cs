public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        List<IList<int>> res = new List<IList<int>>();
        if(heights == null || heights.Length == 0)
            return res;
        
        int m = heights.Length, n = heights[0].Length;
        bool[,] pacific = new bool[m,n];
        bool[,] atlantic = new bool[m,n];
        
        for(int row = 0; row < m; row++)
        {
            DFS(row, 0, heights, pacific, heights[row][0]);
            DFS(row, n - 1, heights, atlantic, heights[row][n - 1]);
        }

        for(int col = 0; col < n; col++)
        {
            DFS(0 , col,heights, pacific, heights[0][col]);
            DFS(m - 1, col, heights, atlantic, heights[m - 1][col]);        
        }
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(pacific[i,j] && atlantic[i,j])
                    res.Add(new List<int>(){i,j});
            }
        }
  
        return res;    
    }
    private void DFS(int row, int col, int[][] heights, bool[,] reach, int prev)
    {
        int m = heights.Length, n = heights[0].Length;
        
        if(row < 0 || row >= m || col < 0 || col >= n || reach[row,col] || heights[row][col] < prev)
            return;
        
        reach[row,col] = true;
        DFS(row, col + 1, heights, reach, heights[row][col]);
        DFS(row, col - 1, heights, reach, heights[row][col]);
        DFS(row + 1, col, heights, reach, heights[row][col]);
        DFS(row - 1, col, heights, reach, heights[row][col]);
    }

}