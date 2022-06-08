public class Solution {
    public string ToLowerCase(string str) {
        Dictionary<char, char> data = new Dictionary<char, char>(){
            {'A', 'a'},
            {'B', 'b'},
            {'C', 'c'},
            {'D', 'd'},
            {'E', 'e'},
            {'F', 'f'},
            {'G', 'g'},
            {'H', 'h'},
            {'I', 'i'},
            {'J', 'j'},
            {'K', 'k'},
            {'L', 'l'},
            {'M', 'm'},
            {'N', 'n'},
            {'O', 'o'},
            {'P', 'p'},
            {'Q', 'q'},
            {'R', 'r'},
            {'S', 's'},
            {'T', 't'},
            {'U', 'u'},
            {'V', 'v'},
            {'W', 'w'},
            {'X', 'x'},
            {'Y', 'y'},
            {'Z', 'z'}
        };
        int index = 0;
        StringBuilder result = new StringBuilder();
        
        while(index < str.Length)
        {
            if(data.ContainsKey(str[index]))
                result.Append(data[str[index]]);
            else
                result.Append(str[index]);
            index++;
        }
        
        return result.ToString();
    }
}