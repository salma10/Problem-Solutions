/*
The count-and-say sequence is the sequence of integers with the first five terms as following:

1.     1
2.     11
3.     21
4.     1211
5.     111221
1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.

Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence.

Note: Each term of the sequence of integers will be represented as a string.
*/

  public string CountAndSay(int n) {
        string s ="1";

    // Doing this n-1 times to get the nth sequence
    for( int i = 1; i < n; i++){
     // Need a new working StringBuilder each time
     StringBuilder sb = new StringBuilder();
        int count = 1;
        for(int j = 1; j <= s.Length; j++){
            // If the last character of the previous sequence or when next char is not the current char 
            if( j == s.Length || s[j] != s[j-1]){
                sb.Append(count);
                sb.Append(s[j-1]);
                count = 1;
            }
            else{
                count++;
            }
        }
        s = sb.ToString();
    }
    return s;
    }
