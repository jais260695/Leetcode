public class Solution {
    public int HardestWorker(int n, int[][] logs) {
        
        int m = logs.Count();
        int expectedID = logs[0][0];
        int maxHours = logs[0][1];
        
        for(int i =1;i<m;i++)
        {
            if(maxHours <= logs[i][1]-logs[i-1][1])
            {
                if(maxHours == logs[i][1]-logs[i-1][1])
                {
                    expectedID = Math.Min(logs[i][0], expectedID);
                    
                }
                else
                {
                    expectedID = logs[i][0];
                    maxHours = logs[i][1]-logs[i-1][1];
                }
                
            }
        }
        
        return expectedID;
    }
}