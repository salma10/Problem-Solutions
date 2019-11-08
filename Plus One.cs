/*
Given a non-empty array of digits representing a non-negative integer, plus one to the integer.

The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.

You may assume the integer does not contain any leading zero, except the number 0 itself.
*/

    public int[] PlusOne(int[] digits) {
        
        string result = string.Empty;
        int carry = 1;
        int i = digits.Length - 1;
        
        while(carry == 1 && i != -1)
        {
            int temp = digits[i] + carry;
            digits[i] = temp % 10;
            if(temp >= 10)
                carry = 1;
            else
               carry = 0; 
            i--;
        }
        
        if(carry == 1)
        {
            int[] res = {1};
            return res.Concat(digits).ToArray();
        }
        else
            return digits;
    }
