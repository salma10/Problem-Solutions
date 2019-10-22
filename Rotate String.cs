/*
We are given two strings, A and B.

A shift on A consists of taking string A and moving the leftmost character to the rightmost position. For example, if A = 'abcde', then it will be 'bcdea' after one shift on A. Return True if and only if A can become B after some number of shifts on A.
*/

public bool RotateString(string A, string B) {       
        if(A == B)
            return true;
        else
        {
            for(int i = 0; i < A.Length; i++)
            {
              char temp = A[0];
              A = A.Substring(1,A.Length - 1);
              A = A + temp;
            if(A == B)
                return true;
            }
        }       
        return false;
    }
