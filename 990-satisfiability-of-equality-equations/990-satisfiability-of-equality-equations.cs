public class Solution {
    char[] root;
    private char getRoot(char c)
    {
        return root[c] == c ? c : root[c] = getRoot(root[c]);
    }
    public bool EquationsPossible(string[] equations) {
        root = new char[256];
        
        for(char c = 'a'; c <= 'z'; c++)
        {
           root[c] = c; 
        }
        
        int i = 0, j = 0;
        
        while(j < equations.Length)
        {
            if(equations[j][1] == '=')
            {
                string temp = equations[j];
                equations[j] = equations[i];
                equations[i] = temp;
                i++;
            }
            j++;
        }
        
        for(int k = 0; k < equations.Length; k++)
        {
            char a = equations[k][0];
            char b = equations[k][3];
            
            a = getRoot(a);
            b = getRoot(b);
            
            if(equations[k][1] == '=')
                root[b] = a;
            else if(a == b)
                return false;
        }
        
        return true;
    }
}