public class Solution {
    public string Interpret(string command) {
        int index = 0;
        char last = command[index];
        StringBuilder result = new StringBuilder();
        
        while(index < command.Length)
        {
            if(command[index] == ')' && last == '(')
                result.Append("o");
            else if(command[index] == ')' && last == 'l')
                result.Append("al");
            else if(command[index] == 'G')
                result.Append("G");
            last = command[index];
            index++;
        }
        
        return result.ToString();
    }
}