public class Solution {
    public string CountAndSay(int n) {
    string s ="1";
    for( int i = 1; i < n; i++){
     StringBuilder sb = new StringBuilder();
        int count = 1;
        for(int j = 1; j <= s.Length; j++){
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
}