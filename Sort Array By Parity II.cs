 public int[] SortArrayByParityII(int[] A) {      
        int j = 1;
        int k = 0;
        int[] result = new int[A.Length];        
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] % 2 == 0)
            {
                result[k] = A[i];
                k = k +2;
            }
            else
            {
                result[j] = A[i];
                j = j +2;
            }                           
        }
        return result;       
    }
