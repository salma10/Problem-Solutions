    public int[] DiStringMatch(string S) {
        var st = 0;
        var en = S.Length;
        var result = new int[S.Length + 1];     
        for(var i = 0; i < S.Length; i++){
            result[i] = S[i] == 'I' ? st++: en--;
        }        
        result[S.Length] = st;       
        return result;
    }
