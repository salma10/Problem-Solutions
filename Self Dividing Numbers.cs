public IList<int> SelfDividingNumbers(int left, int right) {
        
        List<int> result = new List<int>();
        
        for(int i = left; i <= right; i++)
        {
            string temp = i.ToString();
            
            if(!temp.Contains('0'))
            {
                
                bool s = true;
                for(int j = 1; j <= temp.Length; j++)
                {
                    int temp1 = temp[j-1] - '0';
                    if(i%temp1 == 0 && s == true)
                    {

                    }
                    else
                       s = false; 
                }                
                if(s)
                {
                    result.Add(i);
                }                        
            }
        }
        
        return result;
    }
