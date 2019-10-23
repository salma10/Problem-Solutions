/*
Given a string date representing a Gregorian calendar date formatted as YYYY-MM-DD, return the day number of the year.
*/

public int DayOfYear(string date) {   
        
        int[] no_of_days = {31,28,31,30,31,30,31,31,30,31,30,31};
        string[] str_split = date.Split('-');
        int year = int.Parse(str_split[0]);
        int month = int.Parse(str_split[1]);
        int day = int.Parse(str_split[2]);
        int result = 0;
        
        if (((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) && month > 2)
            result = result + 1;
        if(month > 1)
        {
            for(int i = 0; i < month - 1; i++)
                result = no_of_days[i] + result;
        }
        result = day + result;
        return result;
    }
