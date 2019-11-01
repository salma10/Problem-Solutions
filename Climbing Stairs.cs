/*
You are climbing a stair case. It takes n steps to reach to the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
Note: Given n will be a positive integer.
*/

 public int ClimbStairs(int n) {
        if(n<=0) return 0;
        if(n==1) return 1;
    if(n==2) return 2;
    int a=1;
    int b=2;
    if(n>=3){
        for(int i = 3; i <= n; i++){
            b=a+b;
            a=b-a;
        }
    }
    return b;
    }
