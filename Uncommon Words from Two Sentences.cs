 public string[] UncommonFromSentences(string A, string B) {
        
        string str = String.Concat(A," ", B).Trim(); 
        string[] result = str.Split(" ").ToArray();
         result = result
    .GroupBy(c => c)
    .Where(grp => grp.Count() < 2)
    .Select(grp => grp.Key).ToArray();
        
        return result ;
    }
