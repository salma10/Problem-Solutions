public class Solution {
    public int MinimumSemesters(int n, int[][] relations) {
        int res = 0, courseTaken = 0;
        int[] indegree = new int[n + 1];
        List<int>[] graph = new List<int>[n + 1];
        for(int i = 0; i <= n; i++)
            graph[i] = new List<int>();
        
        foreach(int[] relation in relations)
        {
            indegree[relation[1]]++;
            graph[relation[0]].Add(relation[1]);
        }
        
        Queue<int> queue = new Queue<int>(); 
        for(int i = 1; i <= n; i++)
        {
            if(indegree[i] == 0)
                queue.Enqueue(i);
        }
        
        while(queue.Count > 0)
        {
            int size = queue.Count;
            for(int i = 0; i < size; i++)
            {
                int currCourse = queue.Dequeue();
                courseTaken++;
                
                foreach(int course in graph[currCourse])
                {
                    indegree[course]--;
                    if(indegree[course] == 0)
                        queue.Enqueue(course);                
                }
            }
            res++;
        }

        return courseTaken == n? res : -1;
    }
}