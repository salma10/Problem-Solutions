/*
Given two binary strings, return their sum (also a binary string).
The input strings are both non-empty and contains only characters 1 or 0.
*/

public class Solution {
    
     string sum = string.Empty;
     string rems = "0";
     int rem1 = 0;
    
    public string AddBinary(string a, string b) {

         char[] a1 = a.ToCharArray();
         char[] b1 = b.ToCharArray();
         
         int aL = a1.Length;
         int bL = b1.Length;
         
         if(a1.Length < b1.Length)
         {
             char[] c1 = a1;
             a1 = b1;
             b1 = c1;
            
             aL = a1.Length;
             bL = b1.Length;
         }
         
         for(int i = aL-1; i >= 0; i--)
         {
             int l,m,n;
             if(aL > 0 && bL > 0)
             {
                 
                 l = Convert.ToInt32(a1[aL-1]-48);
                 m = Convert.ToInt32(b1[bL-1] - 48);
                 n = Convert.ToInt32(rems);
                 AddBinary(l,m,n);
             }
             else if(aL > 0 && bL <= 0)
             {
                 l = Convert.ToInt32(a1[aL-1]-48);
                
                 m = 0;
                 n = Convert.ToInt32(rems);
                 AddBinary(l,m,n);
             }
             else if(bL > 0 && aL <= 0)
             {
                 l = 0;
                 m = Convert.ToInt32(b1[bL-1] - 48);
                 n = Convert.ToInt32(rems);
                 AddBinary(l,m,n);
             }
            
            aL--;
            bL--;
         }
         
         if(rems != "0")
           sum = rems + sum;
         
         return sum;
    }
    
    private void AddBinary(int a, int b, int rem) {
        
        if(a != 0 || b != 0 || rem != 0)
        {
           sum = Convert.ToString((a % 10 + b % 10 + rem) % 2) + sum;
           rem1 = (a % 10 + b % 10 + rem) / 2;
           rems = Convert.ToString(rem1);
        }
        else
        {
            sum = "0" + sum;
            rems = "0";
        }
    }
    
}
