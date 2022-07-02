public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        
        int prevColor = image[sr][sc];
        image[sr][sc] = newColor;
        
        if(prevColor == newColor)
            return image;
        
        if(sr - 1 >= 0)
        {
           if(image[sr - 1][sc] == prevColor) 
               FloodFill(image, sr - 1, sc, newColor);
        }
        
        if(sr + 1 < image.Length)
        {
           if(image[sr + 1][sc] == prevColor) 
               FloodFill(image, sr + 1, sc, newColor);
        }
        
        if(sc - 1 >= 0)
        {
           if(image[sr][sc - 1] == prevColor) 
               FloodFill(image, sr, sc - 1, newColor);
        }
        
        if(sc + 1 < image[0].Length)
        {
           if(image[sr][sc + 1] == prevColor) 
               FloodFill(image, sr, sc + 1, newColor);
        }
        
        return image;
        
    }
}