public int[] SortedSquares(int[] A) {
        for(int i = 0; i < A.Length; i++)
            A[i] = A[i] * A[i];
        Array.Sort(A);
        return A;
    }
//Another solution
public class Solution {
    public int[] SortedSquares(int[] A) {
           int min = -1;
           for (int i = 0; i < A.Length; i++)
           {
               min = i;
               for (int j =  i + 1; j < A.Length; j++)
               {
                    if (Math.Abs(A[j]) < Math.Abs(A[min]))
                        min = j;
               }
               if (min != i)
               {
                   int iElm = Math.Abs(A[i]);
                   A[i] = Math.Abs(A[min]);
                   A[min] = iElm;
                   A[i] =  A[i] *  A[i];
               }
               else
                   A[i] =  Math.Abs(A[i]) *  Math.Abs(A[i]);
           }
        return A;
    }
}
