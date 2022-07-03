public class Solution {
    Dictionary<int, int> hash = new Dictionary<int, int>();
    
    public int Fib(int N) {
        
        if(hash.ContainsKey(N))
            return hash[N];
        int result;
        
        if(N < 2)
            result = N;
        else
            result = Fib(N - 1) + Fib(N - 2);
        
        hash[N] = result;
        
        return result;
    }
}