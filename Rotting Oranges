public class Solution {
    public int OrangesRotting(int[][] grid) {
     if(grid == null || grid[0].Length == 0)
            return 0;
        
        int m = grid.Length, n = grid[0].Length;
        int fresh = 0;
        
        Queue<(int,int)> queue = new Queue<(int,int)>();
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(grid[i][j] == 1)
                    fresh++;
                else if(grid[i][j] == 2)
                    queue.Enqueue((i,j));
            }
        }
        
        if(fresh == 0)
            return 0;
        
        int time = 0;
        int[,] dir = new int[,]{{-1,0}, {1,0}, {0,-1}, {0,1}};
        while(queue.Count > 0)
        {
            time++;
            int size = queue.Count;
            for(int i = 0; i < size; i++)
            {
                var curr = queue.Dequeue();
                for(int j = 0; j < 4; j++)
                {
                    int newRow = curr.Item1 + dir[j,0];
                    int newCol = curr.Item2 + dir[j,1];
                    
                    if(newRow >= 0 && newRow < m && newCol >=0 && newCol < n && grid[newRow][newCol] == 1)
                    {
                        grid[newRow][newCol] = 2;
                        queue.Enqueue((newRow,newCol));
                        fresh--;
                    }
                }
            }
        }
        
        return fresh == 0? time - 1: -1;
    }
}

