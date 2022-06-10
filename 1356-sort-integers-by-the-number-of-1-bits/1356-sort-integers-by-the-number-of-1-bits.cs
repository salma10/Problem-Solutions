public class Solution {
    public int[] SortByBits(int[] arr) {
        if(arr == null || arr.Length == 0)
            return arr;        
        Array.Sort(arr, (a,b)=>
           {
               int bitCnt1 = countBits(a);
               int bitCnt2 = countBits(b);

               if(bitCnt1 == bitCnt2)
                   return a.CompareTo(b);
               else
                   return bitCnt1.CompareTo(bitCnt2);
           });        
        return arr;
    }
    private int countBits(int num)
    {
        int cnt = 0;
        
        while(num > 0)
        {
            cnt += (1 & num);
            num >>= 1;
        }
        
        return cnt;
    }
}