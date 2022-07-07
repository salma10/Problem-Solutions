public class Solution {
    public string GetHint(string secret, string guess) {
        int bull = 0, cow = 0;  
        int[] arr = new int[10];
        
        for(int i = 0; i < secret.Length; i++)
        {
            if(secret[i] == guess[i])
                bull++;
            else
            {
                if(arr[secret[i] - '0'] < 0)
                    cow++;
                
                if(arr[guess[i] - '0'] > 0)
                    cow++;                
			
                arr[secret[i] - '0']++;
                arr[guess[i] - '0']--;
            }
        }
        
        return bull + "A" + cow + "B";
    }
}