public class Solution {
    public int SubtractProductAndSum(int n) {
        int sum = 0;
        int product = 1;
        
        while(n > 0)
        {
            int digit = n % 10;
            n /= 10;
            sum += digit;
            product *= digit;
        }
        return product - sum;
    }
}