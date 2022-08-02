public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        
        int h = matrix.GetLength(0);
        
        List<int> list = new List<int>();
        
        for (int i=0;i<h;i++){
            for (int j = 0;j<h;j++)
                list.Add(matrix[i][j]);
        }
        
        list.Sort();
        
        return list[k-1];
    }
}