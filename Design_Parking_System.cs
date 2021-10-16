public class ParkingSystem {
    int[] types = new int[3];
    public ParkingSystem(int big, int medium, int small) {
        types[0] = big;
        types[1] = medium;
        types[2] = small;
    }
    
    public bool AddCar(int carType) {
        if(types[carType-1] >0)
        {
            types[carType-1]-=1;
            return true;
        }
        
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */