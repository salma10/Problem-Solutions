public bool IsToeplitzMatrix(int[,] matrix) {
        
      for (int r = 0; r < matrix.GetLength(0); ++r)
            for (int c = 0; c < matrix.GetLength(1); ++c)
                if (r > 0 && c > 0 && matrix[r-1,c-1] != matrix[r,c])
                    return false;
        return true;
    }
