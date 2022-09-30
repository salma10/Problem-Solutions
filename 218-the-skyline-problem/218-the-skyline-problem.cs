public class Solution {
    public IList<IList<int>> GetSkyline(int[][] buildings) {
        List<int[]> height = new List<int[]>();
        List<IList<int>> result = new List<IList<int>>();
        Dictionary<int, int> dic = new Dictionary<int, int>();
        
        for(int i=0; i < buildings.GetLength(0); i++)
        {
            height.Add(new int[]{buildings[i][0], -buildings[i][2]});
            height.Add(new int[]{buildings[i][1], buildings[i][2]});
        }
        
        height.Sort((a,b)=>{
            if(a[0] != b[0])
            {
                return a[0].CompareTo(b[0]);
            }
            return a[1].CompareTo(b[1]);
        });
        
        SortedSet<int> data = new SortedSet<int>();
        data.Add(0);
        int pre = 0;
        foreach(var h in height)
        {
            if(h[1] < 0)
            {
                if(!dic.ContainsKey(-h[1]))
                {
                    dic.Add(-h[1],0);
                }
                data.Add(-h[1]);
                dic[-h[1]]++;
            }
            else
            {
                dic[h[1]]--;
                if(dic[h[1]] <= 0)
                {
                     data.Remove(h[1]);
                }
            }
            int cur = data.Max;
            if(pre != cur)
            {
                result.Add(new List<int>{h[0], cur});
                pre =cur;
            }
        }
        return result;
    }
}