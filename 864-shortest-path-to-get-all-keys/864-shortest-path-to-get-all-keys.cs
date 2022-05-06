public class Solution {
    public int ShortestPathAllKeys(string[] grid) {
        int r = grid.Length, c = grid[0].Length, x = 0, y = 0;
        var hashset = new HashSet<char>();
        for(int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                var ch = grid[i][j];
                if(ch == '@')
                {
                    x = i; y = j;
                }
                
                if(Char.IsLower(ch))
                    hashset.Add(ch);
            }
        }
        int[] dx = new int[] {0, 1, 0, -1};
        int[] dy = new int[] {1, 0, -1, 0};
        int k = hashset.Count();
        var start = new int[k + 2];
        start[k] = x; start[k + 1] = y;
        var queue = new Queue<int[]>();
        var visited = new Dictionary<string, int>();
        queue.Enqueue(start);
        visited[string.Join(":", start)] = 0;
        while(queue.Count() != 0)
        {
            var curr = queue.Dequeue();
            var currKey = string.Join(":", curr);
            x = curr[k]; y = curr[k + 1];
            int sum = 0;
            for(int i = 0; i < k; i++)
                sum += curr[i];
            if(sum == k) return visited[currKey];
            for(int i = 0; i < 4; i++)
            {
                int nx = x + dx[i], ny = y + dy[i];
                if(nx >= 0 && nx < r && ny >= 0 && ny < c && grid[nx][ny] != '#')
                {
                    var next = (int[]) curr.Clone();
                    next[k] = nx; next[k + 1] = ny;
                    
                    if(char.IsUpper(grid[nx][ny]) && next[grid[nx][ny] - 'A'] == 0)
                        continue;
                    if(char.IsLower(grid[nx][ny]))
                        next[grid[nx][ny] - 'a'] = 1;
                    
                    var nextKey = string.Join(":", next);
                    if(!visited.ContainsKey(nextKey))
                    {
                        visited[nextKey] = visited[currKey] + 1;
                        queue.Enqueue(next);
                    }
                }
            }
        }
        
        return -1;
    }
}