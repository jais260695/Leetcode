public class Solution {
    public int MinSideJumps(int[] obstacles) {
        int n = obstacles.Count();
        int[,] dp = new int[n,3];
        
        dp[0,0] = 1;
        dp[0,1] = 0;
        dp[0,2] = 1;
        
        for(int i=1;i<n;i++)
        {
            int x = int.MaxValue;
            int y = int.MaxValue;
            int z = int.MaxValue;
            
            if(obstacles[i]!=1 && dp[i-1,0]!=int.MaxValue)
            {
                x = dp[i-1,0];
            }
            if(obstacles[i]!=2 && dp[i-1,1]!=int.MaxValue)
            {
                y = dp[i-1,1];
            }
            if(obstacles[i]!=3 && dp[i-1,2]!=int.MaxValue)
            {
                z = dp[i-1,2];
            }
            
            dp[i,0] = x;
            dp[i,1] = y;
            dp[i,2] = z;
            
            if(x!=int.MaxValue)
            {
                dp[i,1] = obstacles[i]==2 ? dp[i,1] :  Math.Min(dp[i,1],1+x);
                dp[i,2] = obstacles[i]==3 ? dp[i,2] :  Math.Min(dp[i,2],1+x);
            }
            if(y!=int.MaxValue)
            {
                dp[i,0] = obstacles[i]==1 ? dp[i,0] :  Math.Min(dp[i,0],1+y);
                dp[i,2] = obstacles[i]==3 ? dp[i,2] :  Math.Min(dp[i,2],1+y);
            }
            if(z!=int.MaxValue)
            {
                dp[i,0] = obstacles[i]==1 ? dp[i,0] :  Math.Min(dp[i,0],1+z);
                dp[i,1] = obstacles[i]==2 ? dp[i,1] :  Math.Min(dp[i,1],1+z);
            }
            
        }
        
        return Math.Min(Math.Min(dp[n-1,0],dp[n-1,1]),dp[n-1,2]);
    }
}