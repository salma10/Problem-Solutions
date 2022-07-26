public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> taskCount = new Dictionary<char, int>();
        int maxFrequency = 0;
        for(int i = 0; i < tasks.Length; i++)
        {
            char currentTask = tasks[i];
            if(taskCount.ContainsKey(currentTask))
               taskCount[currentTask]++;
            else
                taskCount[currentTask] = 1;
            maxFrequency = Math.Max(maxFrequency, taskCount[currentTask]);
        }
        int maxIdle = (maxFrequency - 1) * n;
        bool isMaxFound = false;
        foreach(var item in taskCount)
        {
            if(!isMaxFound && maxFrequency == item.Value)
            {
                isMaxFound = true;
            }
            else if(maxFrequency == item.Value)
                maxIdle -= (item.Value - 1);
            else
               maxIdle -= item.Value; 
        }
        if(maxIdle > 0)
            return tasks.Length + maxIdle;
        else
           return tasks.Length; 
    }
}