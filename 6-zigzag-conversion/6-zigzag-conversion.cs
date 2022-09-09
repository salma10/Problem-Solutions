public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1)
            return s;
        StringBuilder[] result = new StringBuilder[numRows];
        int currentRow = 0;
        int position = 0;
        bool isUp = false;
        
        while(position < s.Length)
        {
            if(result[currentRow] == null)
                result[currentRow] = new StringBuilder();
            result[currentRow].Append(s[position]);
            position++;
            if(isUp)
               currentRow--;
            else
                currentRow++;
            if(currentRow == numRows - 1)
               isUp = true;
            else if(currentRow == 0)
                isUp = false;
        }
        
        StringBuilder zigzagedString = new StringBuilder();
        
        for(int i = 0; i < result.Length; i++)
        {
            zigzagedString.Append(result[i]);
        }
        return zigzagedString.ToString();
    }
}