public int[] SortedSquares(int[] A) {
        for(int i = 0; i < A.Length; i++)
            A[i] = A[i] * A[i];
        Array.Sort(A);
        return A;
    }
