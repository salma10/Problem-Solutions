public class Solution {
    public int Tribonacci(int n) {
        if(n == 0)
            return 0;
        if(n == 1 || n == 2)
            return 1;
        int[] result = new int[3];
        result[0] = 0;
        result[1] = result[2] = 1;
        for(int i = 3; i <= n; i++)
        {
            int temp = result[0] + result[1] + result[2];
            result[0] = result[1];
            result[1] = result[2];
            result[2] = temp;
        }
        return result[2];
    }
}
