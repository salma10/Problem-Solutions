public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        if(prerequisites.Length == 0)
            return Enumerable.Range(0, numCourses).ToArray();
        
        int[] result = new int[numCourses];
        int[] inDegree = new int[numCourses];
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();   
        
        for(int i = 0; i < prerequisites.Length; i++)
        {
            if(!graph.ContainsKey(prerequisites[i][1]))
                graph[prerequisites[i][1]] = new List<int>();
            graph[prerequisites[i][1]].Add(prerequisites[i][0]);
            inDegree[prerequisites[i][0]]++;
        }
        
        Queue<int> queue = new Queue<int>();
        
        for(int course = 0; course < numCourses; course++)
        {
            if(inDegree[course] == 0)
            {
                queue.Enqueue(course);
            }   
        }
        
       int index = 0;
       while(queue.Count > 0)
       {
           int course = queue.Dequeue();
          
           result[index] = course;
           index++;
           if(graph.ContainsKey(course))
           {
               List<int> current = graph[course];
               foreach(int child in current)
               {
                   inDegree[child]--;
                   if(inDegree[child] == 0)
                      queue.Enqueue(child); 
               }
           }
           
       }
       return index == numCourses ? result : new int[0]; 
    }
}