public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        
        int n=obstacleGrid.Count();
        int m = obstacleGrid[0].Count();
        int[,] dp = new int[n,m];
        int ways=1;
        for(int i=0;i<m;i++)
        {
            if(obstacleGrid[0][i]==1)
            {
                ways=0;
            }
            dp[0,i]=ways;
        }
        ways=1;
        for(int i=0;i<n;i++)
        {
            if(obstacleGrid[i][0]==1)
            {
                ways=0;
            }
            dp[i,0]=ways;
        }
        
        for(int i=1;i<n;i++)
        {
            for(int j=1;j<m;j++)
            {
                if(obstacleGrid[i][j]==1)
                {
                    dp[i,j]=0;
                    continue;
                }
                if(obstacleGrid[i-1][j]==1)
                {
                    dp[i,j]=dp[i,j-1];
                }
                else if(obstacleGrid[i][j-1]==1)
                {
                    dp[i,j]=dp[i-1,j];
                }
                else
                {
                    dp[i,j]=dp[i-1,j]+dp[i,j-1];
                }
            }
        }
        return dp[n-1,m-1];
        
    }
}