public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        List<int> res = new List<int>();
        if(n < 2)
        {
            for(int i = 0; i < n; i++)
                res.Add(i);
        }
        
        HashSet<int>[] graph = new HashSet<int>[n];
        for(int i = 0; i < n; i++)
            graph[i] = new HashSet<int>();
        
        foreach(int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        
        Queue<int> queue = new Queue<int>();
        for(int i = 0; i < n; i++)
        {
            if(graph[i].Count == 1)
                queue.Enqueue(i);
        }
            
        while(n > 2)
        {
            int size = queue.Count;
            n -= size;
            for(int i = 0; i < size; i++)
            {
                int curr = queue.Dequeue();
                foreach(int next in graph[curr])
                {
                    graph[next].Remove(curr);
                    if(graph[next].Count == 1)
                        queue.Enqueue(next);
                }
            }
        }
        
        while(queue.Count > 0)
            res.Add(queue.Dequeue());
        
        return res;

    }
}