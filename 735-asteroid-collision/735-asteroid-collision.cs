public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        
        if(asteroids == null || asteroids.Length == 0)
            return new int[0];
        
        Stack<int> stack = new Stack<int>();
        
        foreach(var item in asteroids)
        {
            bool add = true;
            while(stack.Count > 0 && stack.Peek() > 0 && item < 0)
            {
                if(stack.Peek() < -item)
                    stack.Pop();
                else 
                {
                    if(stack.Peek() == -item)
                        stack.Pop();
                    add = false;
                    break;
                }    
            }
            
            if(add)
                stack.Push(item);
        }
        
        int n = stack.Count;
        int[] res = new int[n];
        
        for(int j = n - 1; j >= 0; j--)
            res[j] = stack.Pop();
        
        return res;
    }
}