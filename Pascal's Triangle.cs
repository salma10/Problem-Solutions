/*
Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
In Pascal's triangle, each number is the sum of the two numbers directly above it.
*/

public IList<IList<int>> Generate(int numRows) {        
        List<IList<int>> results1 = new List<IList<int>>();
        if(numRows<1) return results1;
         if(numRows == 1)
           {
               List<int> results = new List<int>();
               results.Add(1);
               results1.Add(results);
               return results1;
           }
           else
           {
             for(int i = 0; i < numRows; i++)
             {
                 List<int> results = new List<int>();
                 if(i == 0)
                 {
                     results.Add(1);
                 }
                 else
                 {
                    results.Add(1);
                    long pre = 1;
                    for(int k = 0; k<i; k++){
                    pre = pre * (i - k) / (k+1);
                    results.Add((int) pre);
                    }
                 }
                results1.Add(results);
            }      
           }
        return results1;
    }
