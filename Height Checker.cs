public int HeightChecker(int[] heights) {       
        int len = heights.Length;     
        if(len == 0)
            return 0;
        else
        {
            int[] new_Height = new int[len];
            Array.Copy(heights, new_Height, len);
            Array.Sort(new_Height);       
            int count = 0;  
            for(int i = 0; i < new_Height.Length; i++)
            {
                if(new_Height[i] != heights[i])
                    count++;
            }        
            return count;
        }     
    }
