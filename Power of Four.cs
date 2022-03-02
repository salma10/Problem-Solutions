/*
Given an integer (signed 32 bits), write a function to check whether it is a power of 4.
*/

  public bool IsPowerOfFour(int num) {
        if(num <= 0)
          return false;
        while(num != 1)
        {    
          if(num%4 != 0)
            return false;
          num = num/4;      
        }
        return true;
    }
//Another solution
public class Solution {
    public bool IsPowerOfFour(int num) {
        if(num <= 0)
          return false;
        
        while(num % 4 == 0)
        {
          num = num / 4;      
        }
        
        return num == 1;
    }
}
