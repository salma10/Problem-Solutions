public class ParkingSystem {
    private int[] capacity;
    public ParkingSystem(int big, int medium, int small) {
        capacity = new int[3] { big, medium, small };
    }
    
    public bool AddCar(int carType) {
        if(capacity[carType - 1] == 0)
            return false;
        else
        {
            capacity[carType - 1]--;
            return true;
        }
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */