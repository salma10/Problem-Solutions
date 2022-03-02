/*
Given an integer, write a function to determine if it is a power of three.
*/

 public bool IsPowerOfThree(int n) {
       return n>0 && 1162261467%n == 0;
    }
//Another solution
public bool IsPowerOfThree(int n) {
       return (Math.Log10(n) / Math.Log10(3)) % 1 == 0;
    }
