 public bool IsMonotonic(int[] A) {
        
        int[] B = new int[A.Length];
        Array.Copy(A, B, A.Length); 
        Array.Sort(B);
        
        if(A.SequenceEqual(B))
            return true;
        else if(A.SequenceEqual(B.Reverse()))
            return true;
        else
            return false;       
        
    }
