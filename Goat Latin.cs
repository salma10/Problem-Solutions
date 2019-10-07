public string ToGoatLatin(string S) {
        
        string vowels = "AEIOUaeiou";
        var words = S.Split(' ');
        var result = string.Empty;
        if(S.Length > 0)
        {
            for(int i = 0; i < words.Length; i++)
        {
            var temp = words[i];
            var res = string.Empty;
               if(!vowels.Contains(temp[0]))
               {
                   if(temp.Length > 1)
                     res = temp.Substring(1) + temp[0];
                   else
                     res = temp;  
               }
            else
                res = temp;
            
            string AppendString = new string('a', i + 1);
            res = res + "ma" + AppendString + " ";
                  
           result = result + res;
        }
            return result.Trim();
        }
        else
            return string.Empty; 
    }
