public int FindComplement(int num) {
        
        string s = Convert.ToString(num, 2);
        char[] s1 = s.ToCharArray();
        for(int i = 0; i < s.Length; i++)
        {
            if(s1[i] == '0')
            {
                s1[i] = '1';
            }
            else
            {
                s1[i] = '0';
            }
        }
        
        s = new string(s1);
        
        int output = Convert.ToInt32(s, 2);
        
        return output;
    }
