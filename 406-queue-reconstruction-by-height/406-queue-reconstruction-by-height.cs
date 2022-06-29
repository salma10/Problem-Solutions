public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        Array.Sort(people, (a,b) => a[0].CompareTo(b[0]));
        int[][] result = new int[people.Length][];
        
        for(int i = 0; i < result.Length; i++)
        {
            result[i] = new int[2] {-1,-1};
        }
        
        
        for(int i = 0; i < people.Length; i++)
        {
            int countPosition = people[i][1];
            int k = 0;
            
            while(countPosition > 0 || !(result[k][0] == -1 && result[k][1] == -1))
            {
                if(result[k][0] == people[i][0] || (result[k][0] == -1 && result[k][1] == -1))
                {
                    countPosition--;
                }
                 k++;
            }
            
            result[k] = people[i];
        }
        return result;
    }
}