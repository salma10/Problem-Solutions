public class UndergroundSystem {
    Dictionary<int, Tuple<string, int>> arrival;
    Dictionary<string, int[]> average;
    public UndergroundSystem() {
        arrival = new Dictionary<int, Tuple<string, int>>();
        average = new Dictionary<string, int[]>();
    }
    
    public void CheckIn(int id, string stationName, int t) {
        Tuple<string, int> customer = new Tuple <string, int>(stationName, t);
        arrival[id] = customer;
    }
    
    public void CheckOut(int id, string stationName, int t) {
        Tuple<string, int> customer = arrival[id];
        string key = customer.Item1 + "-" + stationName;
        if(!average.ContainsKey(key))
            average[key] = new int[2];
        int[] avg = average[key];
        avg[0] += t - customer.Item2;
        avg[1]++;
        average[key] = avg;
        arrival.Remove(id);
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        string key = startStation + "-" + endStation;
        int[] avg = average[key];
        return (double)avg[0] / avg[1];
    }
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */