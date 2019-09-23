public int PeakIndexInMountainArray(int[] A) {
        
        int result = -1;
        
        if( A.Length == 1)
          return 0;
        
        for(int i = 0; i < A.Length; i++)
        {
            if(i == A.Length - 1 &&  A[i-1] < A[i])
              result = i;
            else if(i != 0 && A[i-1] < A[i] && A[i] > A[i+1])
              result = i;
            else if(i == 0 && A[i] > A[i+1])
                result = i;
        }
        return result;
        
    }
