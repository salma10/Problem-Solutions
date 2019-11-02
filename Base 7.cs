/*
Given an integer, return its base 7 string representation.
*/
 public string ConvertToBase7(int num) {
         string result = string.Empty;      
         bool isNeg = false;        
         if(num < 0)
         {
             isNeg = true;
             
             num = -(num);
         }
    do
    {
        result = "0123456"[num % 7] + result;
        num /= 7;
    }
    while (num > 0);    
     if(isNeg)
       return "-" + result;
     else
      return result;
    }
