public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
       if (source == target)
       {
            return 0;
       }
       
       var busToStops = new Dictionary<int, HashSet<int>>();
       var stopToBuses = new Dictionary<int, HashSet<int>>();
       
       for (int i = 0; i < routes.Length; i++)
       {
           busToStops[i] = new HashSet<int>();
           
           for (int j = 0; j < routes[i].Length; j++)
           {
               busToStops[i].Add(routes[i][j]);
               
               if (!stopToBuses.ContainsKey(routes[i][j]))
               {
                   stopToBuses[routes[i][j]] = new HashSet<int>();
               }
               
               stopToBuses[routes[i][j]].Add(i);
           }
       }
        
        if (!stopToBuses.ContainsKey(source) ||
           !stopToBuses.ContainsKey(target))
        {
            return -1;
        }
        
        return BFS(source, target, busToStops, stopToBuses);
    }
    
    public class Node
    {
        public int stop, distance;
    }
    
    public int BFS(int src, int destination, Dictionary<int, HashSet<int>> busToStops, Dictionary<int, HashSet<int>> stopToBuses)
    {
        var queue = new Queue<Node>();
        var visited = new HashSet<int>();
        queue.Enqueue(new Node() { stop = src, distance = 0});
        visited.Add(src);
        
        while (queue.Any())
        {
            var current = queue.Dequeue();
            
            if (current.stop == destination)
            {
                return current.distance;
            }
            
            foreach (var bus in stopToBuses[current.stop])
            {
                foreach (var stop in busToStops[bus])
                {
                    if (!visited.Contains(stop))
                    {
                        if (stop == destination)
                        {
                            return current.distance + 1;
                        }
                        
                        visited.Add(stop);
                        queue.Enqueue(new Node {stop  = stop, distance = current.distance + 1});
                    }
                }
            }
        }
        
        return -1;
    }
}