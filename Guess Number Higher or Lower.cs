/*
We are playing the Guess Game. The game is as follows:
I pick a number from 1 to n. You have to guess which number I picked.
Every time you guess wrong, I'll tell you whether the number is higher or lower.
You call a pre-defined API guess(int num) which returns 3 possible results (-1, 1, or 0):
-1 : My number is lower
 1 : My number is higher
 0 : Congrats! You got it!
*/

 int guessNumber(int n) {

             int left = 1;
        int right = n;
        
        while (left < right)
        {
            int mid = left +  (right - left) / 2;
            int val = guess(mid);
            if (val == 0) return mid;
            if (val == -1) right = mid - 1;
            if (val == 1) left = mid + 1;
        }
        return left;
        
       
    }
