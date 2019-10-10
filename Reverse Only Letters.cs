 public string ReverseOnlyLetters(string S) {     
         string my_String =  Regex.Replace(S, @"[^a-zA-Z]+", "");      
         char[] charArray = my_String.ToCharArray();
         Array.Reverse( charArray );
         string result =  new string( charArray );
        
         for(int i =0; i < S.Length; i++)
         {
            if(!char.IsLetter(S[i]))
                result = result.Insert(i,S[i].ToString());                
         }       
        return result;
    }
