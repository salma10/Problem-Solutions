/*
Write an algorithm to determine if a number is "happy".

A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.
*/

  public bool IsHappy(int n) {
        
        int newNum = n;
        int count = 0;
        while (newNum != 1) {
            if (count > 10) {
                return false;
            }
            string s = newNum.ToString();
            int total = 0;
            for (int i = 0; i < s.Length; i++) {
                int n2 = int.Parse(s[i].ToString());
                total += n2*n2;
            }
            newNum = total;
            count++;
        }
        return true;
       
    }
