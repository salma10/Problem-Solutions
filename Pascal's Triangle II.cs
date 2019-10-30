/*
Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.
Note that the row index starts from 0.
In Pascal's triangle, each number is the sum of the two numbers directly above it.
*/

 public IList<int> GetRow(int rowIndex) {     
         List<int> results = new List<int>();       
        if(rowIndex<0) return results;    
        results.Add(1);      
        if(rowIndex == 0) return results;
        long pre = 1;
        for(int k = 0; k<rowIndex; k++){
            
            pre = pre * (rowIndex - k) / (k+1);
            
            results.Add((int) pre);
            
        }
        return results;
    }
