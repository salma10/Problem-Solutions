public int[,] MatrixReshape(int[,] nums, int r, int c) {
        
        int rows = nums.GetLength(0);
        int columns = nums.GetLength(1);
        
        int res_row = 0;
        int res_col = -1;
        
        if(rows * columns != r * c)
            return nums;
        
        int[,] result = new int[r,c];    
        
        for(int k=0;k < rows;k++)
        {
            for(int l=0;l < columns;l++)
            {      
                res_col++;
                 if(res_col >= c)
                 {
                     res_col = 0;
                     res_row++;          
                 }                         
                
                result[res_row,res_col] = nums[k,l];                 
            }               
        }
         return result;   
        
    }
