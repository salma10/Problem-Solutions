public int HammingDistance(int x, int y) {
        
        string sx = Convert.ToString(x, 2);
        string sy = Convert.ToString(y, 2);
        int count = 0;
        if(sx.Length < sy.Length)
        {
            sx = sx.PadLeft(sy.Length, '0');
        }
        else
        {
            sy = sy.PadLeft(sx.Length, '0');
        }
      
        char[] sx1 = sx.ToCharArray();
        char[] sy1 = sy.ToCharArray();
        
        for(int i = 0; i < sx.Length; i++)
        {
            if(sx1[i] != sy1[i])
            {
                count++;
            }
        }
        return count;
    }
//Another solution
public class Solution {
    public int HammingDistance(int x, int y) {
        string xBin = GetBinary(x);
        string yBin = GetBinary(y);
        
        int count = 0;
        
        if(xBin.Length > yBin.Length)
           yBin = yBin.PadLeft(xBin.Length, '0');
        else
           xBin = xBin.PadLeft(yBin.Length, '0');
        
        for(int i = 0; i < xBin.Length; i++)
        {
            if(xBin[i] != yBin[i])
                count++;
        }
        return count;
        
    }
    private string GetBinary(int input)
    {
        string result = string.Empty;
        while(input > 1)
        {
            result = (input % 2) + result;
            input /= 2;
        }
        if(input == 1)
            return "1" + result;
        else
            return result;
    }
}
