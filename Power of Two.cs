/*
Given an integer, write a function to determine if it is a power of two.
*/

public bool IsPowerOfTwo(int n) {
        if(n < 0)
          return false;
        else
          return (n != 0) && ((n & (n - 1)) == 0);
        
    }
