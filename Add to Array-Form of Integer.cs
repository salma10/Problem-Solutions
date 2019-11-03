/*
For a non-negative integer X, the array-form of X is an array of its digits in left to right order.  For example, if X = 1231, then the array form is [1,2,3,1].
Given the array-form A of a non-negative integer X, return the array-form of the integer X+K.
*/

public class Solution {
    public IList<int> AddToArrayForm(int[] A, int K) {
        
        int K_len = GetDigitArrayLength(K);
        int A_len = A.Length;
        int len = K_len > A_len ? K_len : A_len;
        int j = A_len - 1, k = 0, carry = 0;
        List<int> result = new List<int>();
        
        for(int i = 0; i < len; i++)
        {
            int res = 0;
            if(j != -1 && k != K_len)
            {
                int temp = K % 10;
                K /= 10;
                res = A[j] + temp + carry;
                j--;
                k++;
            }
            else if(j != -1 && k == K_len)
            {
                res = A[j] + carry;
                j--;
            }
            else if(j == -1 && k != K_len)
            {
                int temp = K % 10;
                K /= 10;
                res = temp + carry;
                k++;
            }
             
                if(res > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
           
            result.Add(res % 10);
        }
        
        if(carry == 1)
            result.Add(carry);
        
        result.Reverse();
        
        return result;
      
    }
    
    private static int GetDigitArrayLength(int n)
    {
        if (n == 0)
            return 1;
        return 1 + (int)Math.Log10(n);
    }
}
