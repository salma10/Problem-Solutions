public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {   
        
        if(prerequisites.Length == 0)
            return true;
        
        Dictionary<int, Node> graph = new Dictionary<int, Node>();      
        for(int i = 0; i < prerequisites.Length; i++)
        {
            if(!graph.ContainsKey(prerequisites[i][0]))
                graph[prerequisites[i][0]] = new Node();
            if(!graph.ContainsKey(prerequisites[i][1]))
                graph[prerequisites[i][1]] = new Node();
            graph[prerequisites[i][1]].childs.Add(prerequisites[i][0]);
            graph[prerequisites[i][0]].count++;
        }
        
        Queue<int> queue = new Queue<int>();
        int processedCourse = 0;
        
        foreach(KeyValuePair<int, Node> course in graph)
        {
            if(course.Value.count == 0)
            {
                queue.Enqueue(course.Key);
            }
                
        }
        
       while(queue.Count > 0)
       {
           processedCourse++;
           int course = queue.Dequeue();
           Node current = graph[course];
           
           foreach(int child in current.childs)
           {
               graph[child].count--;
               if(graph[child].count == 0)
                  queue.Enqueue(child); 
           }
       }
       return processedCourse == graph.Count; 
    }
}
public class Node
{
    public List<int> childs { get; set; }
    public int count { get; set; }
    
    public Node()
    {
        childs = new List<int>();
        count = 0;
    }
}

