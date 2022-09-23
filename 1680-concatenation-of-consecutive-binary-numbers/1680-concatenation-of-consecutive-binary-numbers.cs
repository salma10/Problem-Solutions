public class Solution {
    public int ConcatenatedBinary(int n) {
        long res = 0, mul = 2, mod = 1000_000_007;

        for (int i = 1; i <= n; i++)
        {
            if (i == mul) mul *= 2; 
            res = (res * mul + i) % mod;
        }
        return (int)res;
    }
}