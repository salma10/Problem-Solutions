public class Solution {
    public int FindNthDigit(int n) {
        
        int[] liaNum = new int[] {9, 189, 2889, 38889, 488889, 5888889, 68888889, 788888889 };

        if (n < 10)
            return n;

        int i = 0;
        for (i = 0; i < liaNum.Length; ++i) 
        {
            if (liaNum[i] > n) 
                break;
        }

        n -= liaNum[i - 1];

        int liStart = (int)Math.Pow(10, i) -1 + n / ( i + 1 ); 
        int liQuot = n % (i + 1);

        if (liQuot == 0) 
            return liStart % 10;
        else 
            return ((liStart + 1 ) / (int)Math.Pow(10, i + 1 - liQuot)) % 10;
    }
}

