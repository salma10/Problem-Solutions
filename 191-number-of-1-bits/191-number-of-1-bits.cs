public class Solution {
    public int HammingWeight(uint n) {
        
        int sum = 0;
        
        while(n != 0)
        {
            sum++;
            n &= (n - 1);
        }
        return sum;
    }
}