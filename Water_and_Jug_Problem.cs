public class Solution {
    public int GCD(int a, int b)
    {
        if(a==0)
        {
            return b;
        }
        
        if(a>=b)
        {
            return GCD(a-b,b);
        }
        return GCD(a,b-a);
    }
    public bool CanMeasureWater(int jug1Capacity, int jug2Capacity, int targetCapacity) {
        if(jug1Capacity+jug2Capacity<targetCapacity) return false;
        return targetCapacity%GCD(jug1Capacity,jug2Capacity)==0;
    }
}