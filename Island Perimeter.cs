 public int IslandPerimeter(int[,] grid) {    
        int result = 0;
        
        int m = grid.GetLength(0);
        int n = grid.GetLength(1);
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(grid[i,j] == 1)
                {
                    if(i-1 < 0)
                    {
                        result = result + 1;
                    }
                    else if(grid[i-1,j] == 0)
                    {
                        result = result + 1;
                    }
                    
                    if(i+1 >= m)
                    {
                        result = result + 1;
                    }
                    else if(grid[i+1,j] == 0)
                    {
                        result = result + 1;
                    }
                    
                    if(j-1 < 0)
                    {
                        result = result + 1;
                    }
                    else if(grid[i,j-1] == 0)
                    {
                        result = result + 1;
                    }
                    
                    if(j+1 >= n)
                    {
                        result = result + 1;
                    }
                    else if(grid[i,j+1] == 0)
                    {
                        result = result + 1;
                    }
                }
            }
        }
        
        return result;
    }
