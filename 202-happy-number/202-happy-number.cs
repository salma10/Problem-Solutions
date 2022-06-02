
public class Solution {
    
    Hashtable series = new Hashtable();
    
    public bool IsHappy(int n) {
        if(n == 1)
            return true;
        else if(series.Count > 0 && series.Contains(n))
            return false;
        else
        {
            series.Add(n,true);
            int result = 0;
            while(n != 0)
            {
                int lastDigit = n % 10;
                n /= 10;
                result = result + lastDigit * lastDigit;
            }
            return IsHappy(result);
        }
    }
}