public class Solution {
    public int Candy(int[] ratings) {
        int[] candy = new int[ratings.Length];
        
        for(int i = 0; i < candy.Length; i++) 
            candy[i] = 1;

        for(int i = 0; i < ratings.Length - 1; i++)
            if(ratings[i] < ratings[i + 1]) 
                candy[i + 1] = candy[i] + 1;

        for(int i = ratings.Length - 1; i > 0; i--)
            if(ratings[i - 1] > ratings[i])
                candy[i - 1] = Math.Max(candy[i] + 1, candy[i - 1]);

        int result = 0;

        foreach(int i in candy) 
            result += i;

        return result;
    }
}