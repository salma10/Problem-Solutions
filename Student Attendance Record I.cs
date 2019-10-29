/*
You are given a string representing an attendance record for a student. The record only contains the following three characters:
'A' : Absent.
'L' : Late.
'P' : Present.
A student could be rewarded if his attendance record doesn't contain more than one 'A' (absent) or more than two continuous 'L' (late).

You need to return whether the student could be rewarded according to his attendance record.
*/

public bool CheckRecord(string s) {       
        bool result = true;  
        int i = s.Count(x => x == 'A');        
        if(i > 1)
         return false;
        else if(s.Contains("LLL"))
          return false;          
        return true;        
    }
