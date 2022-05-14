public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
            Dictionary<int, List<int[]>> graph = new Dictionary<int, List<int[]>>();
            
            foreach (int[] edge in times)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph.Add(edge[0], new List<int[]>());
                graph[edge[0]].Add(new int[] { edge[1], edge[2] });
            }
        
            List<int> Q = new List<int>();
            for (int i = 1; i <= n; i++)
                Q.Add(i);

            int[] distmap = new int[n + 1];
        
            for (int i = 1; i <= n; i++)
                distmap[i] = Int32.MaxValue;
        
            distmap[0] = -1; 
            distmap[k] = 0;

            while (Q.Count > 0)
            {

                Q.Sort(Comparer<int>.Create((a, b) => distmap[a] - distmap[b]));
                int q = Q[0];
                if (q == 0)
                    break;
                if (graph.ContainsKey(q))
                {
                    List<int[]> adj = graph[q];
                    for (int i = 0; i < adj.Count; i++)
                    {
                        int v = adj[i][0];
                        int dist = adj[i][1];
                        distmap[v] = Math.Min(distmap[v], distmap[q] + dist);
                    }
                }
                Q.Remove(q);
            }

            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                max = Math.Max(distmap[i], max);
            }
            return (max == Int32.MaxValue) ? -1 : max;
    }
}