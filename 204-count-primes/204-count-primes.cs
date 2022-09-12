public class Solution {
    public int CountPrimes(int n) {
      bool[] sieve = new bool[n];
        for(int i=2; i<n; i++)
            sieve[i] = true;
        
        for(int i=2; i < Math.Sqrt(n); i++)
        {
            if(!sieve[i])
                continue;
            for(int j=i+i; j < n; j += i)
                sieve[j] = false;
        }
        
        int res = 0;
        for(int i=1; i<n; i++)
            if(sieve[i])
                res++;
        
        return res;           
   }
}