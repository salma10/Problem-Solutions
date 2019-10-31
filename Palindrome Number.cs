/*
Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
*/

public bool IsPalindrome(int x) {      
        if(x < 0)
          return false;
         int i, remainder = 0, newnum = 0;
        int uinput = x;
        for (i = uinput; i > 0; i = (i / 10))
        {
            remainder = i % 10;
            newnum = (newnum*10) + remainder;
        }
        if (newnum == uinput)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
