/*
Given an array A of 0s and 1s, consider N_i: the i-th subarray from A[0] to A[i] interpreted as a binary number (from most-significant-bit to least-significant-bit.)
Return a list of booleans answer, where answer[i] is true if and only if N_i is divisible by 5.
*/

public IList<bool> PrefixesDivBy5(int[] A) {
        
        List<bool> result = new List<bool>();
        
        int res = 0;
        
        for(int i = 0; i < A.Length; i++)
        {
            res = ((res * 2)+ A[i]) % 10;
            result.Add(res % 5 == 0);
        }
        return result;
    }
