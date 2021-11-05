/*
You have a total of n coins that you want to form in a staircase shape, where every k-th row must have exactly k coins.
Given n, find the total number of full staircase rows that can be formed.
n is a non-negative integer and fits within the range of a 32-bit signed integer.
*/

 public int ArrangeCoins(int n) {
        if(n <= Int32.MaxValue)
        {
             int i = 0;
        int rest = n;
        
        while(i != n)
        {
            rest = rest - i;
            if(rest <= i)
              return i;
            i++;
        }
        return i;
        }
        else 
        {
            return -1;
        }
       
    }
//Another solution
public class Solution {
    public int ArrangeCoins(int n) {
        
        int left = 1;
        int right = n;
        
        while(left <= right)
        {
           int mid = left + (right - left) / 2;
           long sum = (long)mid * (mid + 1) / 2;
           bool isClosest = (sum <= n && (sum + mid + 1) > n);
            
           if(isClosest)
               return mid;
            else if(sum < n && (sum + mid + 1) <= n)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
