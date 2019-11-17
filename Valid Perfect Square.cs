/*
Given a positive integer num, write a function which returns True if num is a perfect square else False.
Note: Do not use any built-in library function such as sqrt.
*/

 public bool IsPerfectSquare(int num) {
        
        if(num <= 0)
         return false;
        
        int i = 1;
        for (; ; )
        {
            if (num < 0)
                return false;
            if (num == 0)
                return true;
            num -= i;
            i += 2;
        }
    }
