public int SmallestRangeI(int[] A, int K) {
        if(A.Length < 2)
            return 0;
        else
            return Math.Max(A.Max() - A.Min() - 2*K,0);
    }
