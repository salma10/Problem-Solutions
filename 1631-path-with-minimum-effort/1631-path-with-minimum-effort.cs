public class Solution {
    public int MinimumEffortPath(int[][] heights) {
        int r = heights.Length;
        int c = heights[0].Length;
        int[][] diffMatrix = new int [r][];
        bool[][] visited = new bool[r][];
        
        for(int index = 0; index < r; index++)
        {
            diffMatrix[index] = Enumerable.Repeat(Int32.MaxValue, c).ToArray();
            visited[index] = new bool[c];
        }
        
        diffMatrix[0][0] = 0;
        PriorityQueue<Cell, int> queue = new PriorityQueue<Cell, int>();
        
        queue.Enqueue(new Cell(0, 0, diffMatrix[0][0]), diffMatrix[0][0]);
        
        int[][] directions = new int[][]{
            new int[]{0, 1}, 
            new int[]{1, 0}, 
            new int[]{0, -1}, 
            new int[]{-1, 0}};
        
        while(queue.Count > 0)
        {
            Cell current = queue.Dequeue();
            visited[current.row][current.col] = true;
            if(current.row == r - 1 && current.col == c - 1)
                return current.diff;
            
            foreach(int[] dir in directions)
            {
                int adjX = current.row + dir[0];
                int adjY = current.col + dir[1];
                if(IsValidCell(adjX, adjY, r, c) && !visited[adjX][adjY])
                {
                    int currDiff = Math.Abs(heights[adjX][adjY] - heights[current.row][current.col]);
                    int max = Math.Max(currDiff, diffMatrix[current.row][current.col]);
                    if(diffMatrix[adjX][adjY] > max)
                    {
                        diffMatrix[adjX][adjY] = max;
                        queue.Enqueue(new Cell(adjX, adjY, max), max);
                    }
                }
            }
        }
        return diffMatrix[r - 1][c - 1];
    }
    
    private bool IsValidCell(int x, int y, int row, int col)
    {
        return x >= 0 && x < row && y >= 0 && y < col;
    }
    
    public class Cell{
        public int row;
        public int col;
        public int diff;
        public Cell(int x, int y, int difference)
        {
            row = x;
            col = y;
            diff = difference;
        }
    }
}