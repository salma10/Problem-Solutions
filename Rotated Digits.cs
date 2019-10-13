public int RotatedDigits(int N) {
        
        int result = 0;
        char[] bad_char = new char[] { '3', '4', '7' };
        
        for(int i = 1; i <= N; i++)
        {
            string num = i.ToString();
            
          if(num.IndexOfAny(bad_char) == -1)            
            {
              string res_temp = num;
                 if(res_temp.Contains("2"))
                    res_temp = res_temp.Replace("2", "t");
                if(res_temp.Contains("5"))
                    res_temp = res_temp.Replace("5", "f");
                if(res_temp.Contains("6"))
                    res_temp = res_temp.Replace("6", "s");
                if(res_temp.Contains("9"))
                    res_temp = res_temp.Replace("9", "n");
            
                res_temp = res_temp.Replace("n", "6");
                res_temp = res_temp.Replace("s", "9");
                res_temp = res_temp.Replace("f", "2");
                res_temp = res_temp.Replace("t", "5");

                if(num != res_temp)
                    result++;
            }
        }
        
        return result;
    }
