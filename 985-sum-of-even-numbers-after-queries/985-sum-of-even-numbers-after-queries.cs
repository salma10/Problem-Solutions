public class Solution {
    public int[] SumEvenAfterQueries(int[] A, int[][] queries) {
        
        int[] result = new int[queries.GetLength(0)];
        
        int initial = A.Where(x => x % 2 == 0).Sum();
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            int b = queries[i][1];
            
            if(A[b] % 2 == 0)
                initial = initial - A[b];    
            
            A[b] = A[b] + queries[i][0];
            
            if(A[b] % 2 == 0)
                initial = initial + A[b];    
            
            result[i] = initial;
        }
        return result;
    }
    
}