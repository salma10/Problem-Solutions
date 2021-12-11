/*
Write a function that takes an unsigned integer and return the number of '1' bits it has (also known as the Hamming weight).
*/

 public int HammingWeight(uint n) {      
        var result = Convert.ToString(n, 2);       
        var groups = result.GroupBy(i => i);   
        foreach(var group in groups)
        {
            if(group.Key == '1')
              return group.Count();
        }
        return 0;
    }
//Another solution
public class Solution {
    public int HammingWeight(uint n) {
        
        int sum = 0;
        
        while(n != 0)
        {
            sum++;
            n &= (n - 1);
        }
        return sum;
    }
}
