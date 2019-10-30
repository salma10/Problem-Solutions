/*
A binary watch has 4 LEDs on the top which represent the hours (0-11), and the 6 LEDs on the bottom represent the minutes (0-59).
Each LED represents a zero or one, with the least significant bit on the right.
For example, the above binary watch reads "3:25".
Given a non-negative integer n which represents the number of LEDs that are currently on, return all possible times the watch could represent.
*/

 public IList<string> ReadBinaryWatch(int num) {
          List<string> llist = new List<string>();
    int[] liaMin = new int[60];
    
    for( int i = 1; i < 60; ++i ) {
        liaMin[i] = liaMin[i & i -1] + 1;
    }
    
    for( int i = 0; i < 12; ++i ) {
        if ( num >= liaMin[i] ) {
            for( int j = 0; j < 60; ++j ) {
                if ( liaMin[j] == num - liaMin[i])
                    llist.Add( i.ToString() + ":" + ( j < 10 ? "0" : "" ) + j.ToString());
            }
        }
    }
    return llist;
    }
