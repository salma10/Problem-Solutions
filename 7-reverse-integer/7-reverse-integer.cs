public class Solution {
    public int Reverse(int x) {
        int result=0;
        int num = 0;
        int res = 0;
        if(x < 0)
        {
            num = -(x);
            res = 1;
        }
        else
        {
            num = x;
        }
        while (num>0) 
        {
            if (result > 0 && int.MaxValue / result < 10)
                return 0;
           result = result*10 + num%10;
           num /= 10;
        }
        if(res == 1)
        {
            return -(result);

        }
        else
        {
            return result;
        }
    }
}