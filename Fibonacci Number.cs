    public int Fib(int N) {
        return Solution.GetNthFibonacci_Rec(N);
    }
    
    public static int GetNthFibonacci_Rec(int n)  
    {  
    if ((n == 0) || (n == 1))  
    {  
        return n;  
    }  
    else  
        return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);  
   } 
