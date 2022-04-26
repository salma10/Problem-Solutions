public class Solution {
    private int[] set = null;
    
    public int MinCostConnectPoints(int[][] points) {
         if (points == null || points.Length == 0)
            return 0;
        
        int res = 0;
        List<int[]> list = new List<int[]>();
        
        set = new int[points.Length];
        
        for (int i = 0; i < set.Length; i++)
            set[i] = i;
        
        for (int i = 0; i < points.Length - 1; i++)
            for (int j = i + 1; j < points.Length; j++)
                list.Add(new int[] { i, j, Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]) });
        
        list = list.OrderBy(x => x[2]).ToList();
        
        foreach (var item in list)
            if (Find(item[0]) != Find(item[1]))
            {
                res += item[2];
                Union(item[0], item[1]);
            }
        
        return res;
    }
    private void Union(int x, int y)
    {
        int px = Find(x),
            py = Find(y);
        
        if (px != py)
            set[px] = py;
    }
    
    private int Find(int x)
    {
        if (x != set[x])
            set[x] = Find(set[x]);
        
        return set[x];
    }
}