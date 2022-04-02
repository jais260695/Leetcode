public class Solution {
    public int WateringPlants(int[] plants, int capacity) {
        int n = plants.Count();
        int bu = capacity;
        int result = 0;
        for(int i=0;i<n;i++)
        {
            if(plants[i]>bu)
            {
                result+=i;
                bu=capacity;
                result+=i;
                
            }
            result++;
            bu-=plants[i];
        }
        return result;
    }
}