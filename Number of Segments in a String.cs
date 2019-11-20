/*
Count the number of segments in a string, where a segment is defined to be a contiguous sequence of non-space characters.
Please note that the string does not contain any non-printable characters.
*/

 public int CountSegments(string s) {
        
        if(s.Length == 0)
           return 0;
        var s1 = s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x));
        return s1.Count();
        
    }
