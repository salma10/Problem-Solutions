 public int CountPrimeSetBits(int L, int R) {
        int result = 0;
        HashSet<int> prime = new HashSet<int>{2, 3, 5, 7, 11, 13, 17, 19};
        for(int i = L; i <= R; i++)
        {
            int no_of_bits = HammingWeight(i);
            if(prime.Contains(no_of_bits))
                result++;
        }
        
        return result;
    }
    
    public static int HammingWeight(int n) {
        
        var result = Convert.ToString(n, 2);
        int count = 0;
        for(int i = 0; i < result.Length; i++)
        {
            if(result[i] == '1')
                count++;
        }
        
        return count;
    }
