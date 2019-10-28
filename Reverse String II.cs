/*
Given a string and an integer k, you need to reverse the first k characters for every 2k characters counting from the start of the string. If there are less than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, then reverse the first k characters and left the other as original.
*/

 public string ReverseStr(string s, int k) {
        char[] ch = s.ToCharArray();
        for (int i = 0; i < ch.Length; i += 2 * k) {
            rev(ch, i, i + k);
        }
        return new string(ch);
        
    }
    
     private void rev(char[] ch, int i, int j) {
        j = Math.Min(ch.Length, j) - 1;
        for (; i < j; i++, j--) {
            char tmp = ch[i];
            ch[i] = ch[j];
            ch[j] = tmp;
        }
    }
