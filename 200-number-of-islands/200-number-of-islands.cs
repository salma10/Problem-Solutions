public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length == 0)
            return 0;
        
        int totalRow =  grid.Length;
        int totalCol = grid[0].Length;
        int numberofIsland = 0;
        
        for(int i = 0; i < totalRow; i++)
        {
            for(int j = 0; j < totalCol; j++)
            {
                if(grid[i][j] == '1')
                {
                    numberofIsland++;
                    DFS(grid, i, j, totalRow, totalCol);
                }
            }
        }
        
        return numberofIsland;
        
    }
    
    public void DFS(char[][] grid, int r, int c, int totalRow, int totalCol)
    {
        if(r < 0 || c < 0 || r >= totalRow || c >= totalCol || grid[r][c] == '0')
            return;
        
        grid[r][c] = '0';
        DFS(grid, r - 1, c, totalRow, totalCol);
        DFS(grid, r + 1, c, totalRow, totalCol);
        DFS(grid, r, c - 1, totalRow, totalCol);
        DFS(grid, r, c + 1, totalRow, totalCol);     
    }
}