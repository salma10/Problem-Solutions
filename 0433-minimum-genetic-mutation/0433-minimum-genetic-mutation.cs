public class Solution {
    public int MinMutation(string start, string end, string[] bank) {
        HashSet<string> mutations = new HashSet<string>(bank);
        if(!mutations.Contains(end))
            return -1;
        
        LinkedList<string> queue = new LinkedList<string>();
        char[] charBank = new char[4]{'A', 'C', 'G', 'T'};
        mutations.Remove(start);
        queue.AddLast(start);
        int level = 0;
        
        while(queue.Count > 0)
        {
            int size = queue.Count;
            for(int i = 0; i < size; i++)
            {
                char[] currentMutation = queue.First().ToCharArray();
                queue.RemoveFirst();
                for(int j = 0; j < 8; j++)
                {
                    char temp = currentMutation[j];
                    foreach(char c in charBank)
                    {
                        currentMutation[j] = c;
                        string newMutation = new string(currentMutation);
                        if(mutations.Contains(newMutation))
                        {
                            if(newMutation.Equals(end))
                                return level + 1;
                            queue.AddLast(newMutation);
                            mutations.Remove(newMutation);
                        }
                    }
                    currentMutation[j] = temp;
                }
            }
            level++;
        }
        return -1;
    }
}