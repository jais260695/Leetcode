public class Solution {
    int[][] dp;
    public int DFS(int[][] grid,int i, int j, int n, int m)
    {
        
        if(dp[i][j]!=-2) return dp[i][j];
        
        if(grid[i][j]==1)
        {
            if(j+1==m || grid[i][j+1]==-1)
            {
                dp[i][j] = -1;
            }
            else
            {
                dp[i][j] = i==n-1 ? j+1 : DFS(grid,i+1,j+1,n,m);
            }

        }
        else
        {
            if(j-1<0 || grid[i][j-1]==1)
            {
                dp[i][j] = -1;
            }
            else
            {
                dp[i][j] = i==n-1 ? j-1 : DFS(grid,i+1,j-1,n,m);
            }
        }
        
        return dp[i][j];
    }
    public int[] FindBall(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        dp = new int[n][];
        for(int i=0;i<n;i++)
        {
            dp[i] = new int[m];
            for(int j=0;j<m;j++)
            {
                dp[i][j] = -2;
            }
        }
        
        for(int j=0;j<m;j++)
        {
            DFS(grid,0,j,n,m);
        }
        
        return dp[0];
    }
}