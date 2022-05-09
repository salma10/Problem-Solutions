public class Solution {
    public IList<string> LetterCombinations(string digits) {
      string[] phone = new string[]{"","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
        IList<string> result = new List<string>{""};
        
        for(int i = 0; i < digits.Length; i++)
            result = Combine(result, phone[digits[i]-'0']);
        
        return result.Count==1 ? new List<string>() : result;   
    }
     private IList<string> Combine(IList<string> current, string letters)
     {
        IList<string> result = new List<string>();
        foreach(var l in letters)
            foreach(var c in current) 
                result.Add(c+l);
        return result;
    }
}