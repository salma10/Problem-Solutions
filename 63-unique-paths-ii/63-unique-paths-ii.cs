public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        
        if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0][0] == 1)
            return 0;            
        
        int[,] grid = new int[obstacleGrid.Length, obstacleGrid[0].Length];
        
        grid[0, 0] = 1;
        
        for (int i = 1; i < obstacleGrid[0].Length; i++)
            if (obstacleGrid[0][i] != 1)
                grid[0, i] = 1;
            else
                break;
        
        for (int i = 1; i < obstacleGrid.Length; i++)
            if (obstacleGrid[i][0] != 1)
                grid[i, 0] = 1;
            else
                break;
        
        for (int i = 1; i < obstacleGrid.Length; i++)
            for (int j = 1; j < obstacleGrid[0].Length; j++)
                if (obstacleGrid[i][j] == 1)
                    continue;
                else
                    grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
        
        return grid[obstacleGrid.Length - 1, obstacleGrid[0].Length - 1];
    }
}