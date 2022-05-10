public class Solution {
    public int Divide(int dividend, int divisor) {
        if(dividend == Int32.MinValue && divisor == -1)
            return Int32.MaxValue;
        int negative = 2;
        if(dividend > 0)
        {
            negative--;
            dividend = -dividend;
        }
        
        if(divisor > 0)
        {
            negative--;
            divisor = -divisor;
        }
        
        int quotient = 0;
        int minHalfInt = -1073741824;
        int power = 1;
        List<int> values = new List<int>();
        List<int> powers = new List<int>();
        
        while(divisor >= dividend)
        {
            values.Add(divisor);
            powers.Add(power);
            
            if(divisor < minHalfInt)
                break;
            
            divisor += divisor;
            power += power;
        }
        
        for(int i = values.Count - 1; i >= 0; i--)
        {
            if(values[i] >= dividend)
            {
                quotient += powers[i];
                dividend -= values[i];
            }
        }
        
        if(negative == 1)
            return -quotient;
        return quotient;
    }
} 