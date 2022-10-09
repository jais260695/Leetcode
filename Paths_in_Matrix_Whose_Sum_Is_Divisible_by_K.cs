public class Solution {
    int[][] grid;
    int k;
    int n;
    int m;
    int mod = 1000000007;
    int[,,] dp;
    public int DFS(int i,int j, int sum)
    {
        
        if(i==(n-1) && j== (m-1))
        {
            if(sum%k==0)
            {
                return 1;
            }
            return 0;
        }
        
        if(dp[i,j,sum]!=-1)
        {
            return dp[i,j,sum];
        }
        
        
        
        int result = 0;
        
        if((i+1)<n)
        {
            result = (result + DFS(i+1,j,(sum+grid[i+1][j])%k))%mod;
        }
        
        if((j+1)<m)
        {
            result = (result + DFS(i,j+1,(sum+grid[i][j+1])%k))%mod;
        }
        
        dp[i,j,sum] = result;
        
        return result;
        
    }
    public int NumberOfPaths(int[][] grid, int k) {
        this.grid = grid;
        this.k = k;
        this.n = grid.Count();
        this.m = grid[0].Count();
        dp = new int[n,m,k];
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                for(int t=0;t<k;t++)
                {
                    dp[i,j,t] = -1;
                }
            }
        }
        
        return DFS(0,0,grid[0][0]%k);
    }
}