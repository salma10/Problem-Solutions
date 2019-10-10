public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        
        int clock_sum = 0;
        int anti_clock_sum = 0;
        int len = distance.Length;
        int counter = start;
        
        while(counter != destination)
        {
            clock_sum = clock_sum + distance[counter];
            counter++;
            counter %=  len;
        }
        
        counter = destination;
        
        while(counter != start)
        {
            anti_clock_sum = anti_clock_sum + distance[counter];
            counter++;
            counter %=  len;
        }
        
        return Math.Min(clock_sum, anti_clock_sum);
    }
