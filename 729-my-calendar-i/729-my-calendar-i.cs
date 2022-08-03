public class MyCalendar {
    List<int[]> calenderSlots;
    public MyCalendar() {
        calenderSlots = new List<int[]>();
        calenderSlots.Add(new int[]{int.MinValue, int.MinValue});
        calenderSlots.Add(new int[]{int.MaxValue, int.MaxValue});
    }
    
    public bool Book(int start, int end) {
        
        int insertPosition = SearchInsertPosition(start);
        if(insertPosition == -1)
            return false;
        int[] nextStart = calenderSlots[insertPosition];
        int[] prevEnd = calenderSlots[insertPosition - 1];
        if(end > nextStart[0] || prevEnd[1] > start)
            return false;
        
        calenderSlots.Insert(insertPosition, new int[]{start, end}); 
        return true;
    }
    public int SearchInsertPosition(int start)
    {
        int first = 0;
        int last = calenderSlots.Count - 1;
        
        while(first < last)
        {
            var mid = first + (last - first)/2;
            int next = (calenderSlots[mid])[0];
            if(start == next)
                return -1;
            
            if(start < next)
                last = mid;
            else
                first = mid + 1;
        }
        return last;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */