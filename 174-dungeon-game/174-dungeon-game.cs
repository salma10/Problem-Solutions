public class Solution {
    
    int infinite = int.MaxValue;
    int[][] dp;
    int rows, cols;
   
    public int CalculateMinimumHP(int[][] dungeon) {
        
        rows = dungeon.Length;
        cols = dungeon[0].Length;
        dp = new int[rows][];
        
        for (int i = 0; i < rows; i++)
        {
          dp[i] = new int[cols];
        }
        
        int currCell, rightHealth, downHealth, nextHealth, minHealth;
        for (int row = rows - 1; row >= 0; --row) 
        {
          for (int col = cols - 1; col >= 0; --col) 
          {
            currCell = dungeon[row][col];

            rightHealth = getMinHealth(currCell, row, col + 1);
            downHealth = getMinHealth(currCell, row + 1, col);
            nextHealth = Math.Min(rightHealth, downHealth);

            if (nextHealth != infinite) 
            {
              minHealth = nextHealth;
            } 
            else 
            {
              minHealth = currCell >= 0 ? 1 : 1 - currCell;
            }
              
            dp[row][col] = minHealth;
          }
        }
        return dp[0][0];
    }
    
    public int getMinHealth(int currCell, int nextRow, int nextCol) 
    {
        if (nextRow >= rows || nextCol >= cols)
          return infinite;
        int nextCell = dp[nextRow][nextCol];
        return Math.Max(1, nextCell - currCell);
    }
}