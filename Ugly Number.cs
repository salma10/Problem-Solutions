/*
Write a program to check whether a given number is an ugly number.
Ugly numbers are positive numbers whose prime factors only include 2, 3, 5.
*/

 public bool IsUgly(int num) {
        
        if(num==1)
            return true;
        if(num < 2)
            return false;
        if(num==2||num==3||num==5)
            return true;
        if(num%2==0)
            return IsUgly(num/2);
        if(num%3==0)
            return IsUgly(num/3);
        if(num%5==0)
            return IsUgly(num/5);
            
        return false;
    }
