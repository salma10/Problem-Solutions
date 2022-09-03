public class Solution {
    public int[] NumsSameConsecDiff(int N, int K) {
        List<int> res = new List<int>();
        
        if(N == 1)
            return new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        
        Queue<int> queue = new Queue<int>();
        for(int i = 1; i <= 9; i++)
            queue.Enqueue(i);
        
        while(queue.Count > 0)
        {
            int size = queue.Count;
            
            for(int i = 0; i < size; i++)
            {
                int curr = queue.Dequeue();
                      
                if(curr.ToString().Length == N)
                {
                    res.Add(curr);
                    continue;
                }
                
                int digit = curr % 10;
                int nextDigit1 = digit - K;
                int nextDigit2 = digit + K;
                
                if(nextDigit1 >= 0)
                    queue.Enqueue(10 * curr + digit - K);
                
                if(nextDigit1 != nextDigit2 && nextDigit2 <= 9)
                    queue.Enqueue(10 * curr + digit + K);
            }
        }
        
        return res.ToArray();
    }
}