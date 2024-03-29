public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        
        int len = grid.Length;
        if(grid[0][0] != 0 || grid[len - 1][len - 1] != 0)
            return -1;
        
        int[][] directions = new int[][]{
            new int[] {-1, -1}, 
            new int[] {-1, 0}, 
            new int[] {-1, 1}, 
            new int[] {0, -1}, 
            new int[] {0, 1}, 
            new int[] {1, -1}, 
            new int[] {1, 0}, 
            new int[] {1, 1}
        };
        
        Queue<int[]> queue = new Queue<int[]>();
        grid[0][0] = 1;
        queue.Enqueue(new int[]{0,0});
        
        while(queue.Count > 0)
        {
            int[] cell = queue.Dequeue();
            int r = cell[0];
            int c = cell[1];
            int dist = grid[r][c];
            if(r == len - 1 && c == len - 1)
                return dist;
            foreach(int[] item in getCurrNeighbor(grid, r, c, directions))
            {
                queue.Enqueue(item);
                grid[item[0]][item[1]] = dist + 1;
            }
        }
        return - 1;
    }
    
    private List<int[]> getCurrNeighbor(int[][] grid, int r, int c, int[][] directions)
    {
        List<int[]> adjCell = new List<int[]>();
        for(int i = 0; i < directions.Length; i++)
        {
            int currR = r + directions[i][0];
            int currC = c + directions[i][1];
            if(currR >= 0 && currC >= 0 && currR < grid.Length && currC < grid.Length && grid[currR][currC] == 0)
                adjCell.Add(new int[]{currR, currC});
        }
        return adjCell;
    }
}