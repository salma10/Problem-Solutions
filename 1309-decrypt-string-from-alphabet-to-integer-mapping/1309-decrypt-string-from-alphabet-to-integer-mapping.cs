public class Solution {
    public string FreqAlphabets(string s) {
        Dictionary<char, char> firstDict = new Dictionary<char, char>()
        {
            {'1', 'a'},
            {'2', 'b'},
            {'3', 'c'},
            {'4', 'd'},
            {'5', 'e'},           
            {'6', 'f'},
            {'7', 'g'},
            {'8', 'h'},
            {'9', 'i'}
        };
        Dictionary<string, char> secondDict = new Dictionary<string, char>()
        {
            {"10", 'j'},
            {"11", 'k'},
            {"12", 'l'},
            {"13", 'm'},
            {"14", 'n'},           
            {"15", 'o'},
            {"16", 'p'},
            {"17", 'q'},
            {"18", 'r'},
            {"19", 's'},
            {"20", 't'},
            {"21", 'u'},
            {"22", 'v'},
            {"23", 'w'},
            {"24", 'x'},
            {"25", 'y'},
            {"26", 'z'}
        };
        string first = "-1";
        bool isHashFound = false;
        StringBuilder result = new StringBuilder();
        
        for(int index = s.Length - 1; index >= 0; index--)
        {
            if(s[index] == '#')
                isHashFound = true;
            else if(isHashFound && first == "-1")
                first = s[index].ToString();
            else if(isHashFound && first != "-1")
            {
                first = s[index].ToString() + first;
                result.Insert(0, secondDict[first]);
                first = "-1";
                isHashFound = false;
            }
            else
            {
                result.Insert(0, firstDict[s[index]]);
            }
                
        }
        
        return result.ToString();
    }
}