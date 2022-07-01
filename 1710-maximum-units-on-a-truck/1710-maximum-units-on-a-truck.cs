public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Array.Sort(boxTypes, (a, b) => {
            return a[1] - b[1];
        });
        int max = 0;
        int index = boxTypes.Length - 1;
        while(truckSize > 0 && index >= 0)
        {
            int[] currentBox = boxTypes[index];
            if(truckSize <= currentBox[0])
            {
                max += truckSize * currentBox[1];
                truckSize = 0;
            }
            else
            {
                max += currentBox[0] * currentBox[1];
                truckSize -= currentBox[0];
            }
            index--;
        }
        return max;
    }
}