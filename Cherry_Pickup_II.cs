public class Solution {
    public int CherryPickup(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        int[,,] dp = new int[n,m,m];
        dp[0,0,m-1] = grid[0][0] + grid[0][m-1];
        int i=1;
        for(int j=0;j<m;j++)
        {
            if(j>1 && j<m-2) continue;
            for(int k=0;k<m;k++)
            {
                if(k>1 && k<m-2) continue;
                dp[i,j,k] = Math.Max(
                            Math.Max(
                                        (j==0 || k==0) ? 0 : dp[i-1,j-1,k-1],
                                         Math.Max(
                                             k==0 ? 0 : dp[i-1,j,k-1],
                                             (j==m-1 || k==0) ? 0 : dp[i-1,j+1,k-1]
                                         )
                                     ),
                            Math.Max(
                                    Math.Max(
                                                (j==0) ? 0 : dp[i-1,j-1,k],
                                                 Math.Max(
                                                     dp[i-1,j,k],
                                                     (j==m-1) ? 0 : dp[i-1,j+1,k]
                                                 )
                                             ),
                                    Math.Max(
                                                (j==0 || k==m-1) ? 0 : dp[i-1,j-1,k+1],
                                                 Math.Max(
                                                     k==m-1 ? 0 : dp[i-1,j,k+1],
                                                     (j==m-1 || k==m-1) ? 0 : dp[i-1,j+1,k+1]
                                                 )
                                             )
                             )
                        );
                    dp[i,j,k]+=grid[i][j];
                    if(j!=k)
                    {
                        dp[i,j,k]+=grid[i][k];
                    }
            }
        }
        for(i=2;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                for(int k=0;k<m;k++)
                {
                    dp[i,j,k] = Math.Max(
                            Math.Max(
                                        (j==0 || k==0) ? 0 : dp[i-1,j-1,k-1],
                                         Math.Max(
                                             k==0 ? 0 : dp[i-1,j,k-1],
                                             (j==m-1 || k==0) ? 0 : dp[i-1,j+1,k-1]
                                         )
                                     ),
                            Math.Max(
                                    Math.Max(
                                                (j==0) ? 0 : dp[i-1,j-1,k],
                                                 Math.Max(
                                                     dp[i-1,j,k],
                                                     (j==m-1) ? 0 : dp[i-1,j+1,k]
                                                 )
                                             ),
                                    Math.Max(
                                                (j==0 || k==m-1) ? 0 : dp[i-1,j-1,k+1],
                                                 Math.Max(
                                                     k==m-1 ? 0 : dp[i-1,j,k+1],
                                                     (j==m-1 || k==m-1) ? 0 : dp[i-1,j+1,k+1]
                                                 )
                                             )
                             )
                        );
                    if(dp[i,j,k]!=0)
                    {
                        dp[i,j,k]+=grid[i][j];
                        if(j!=k)
                        {
                            dp[i,j,k]+=grid[i][k];
                        }
                    }
                }
            }
            
        }
        
        int result = 0;
        for(int j=0;j<m;j++)
        {
            for(int k=0;k<m;k++)
            {
                result = Math.Max(result,dp[n-1,j,k]);
            }
        }
        return result;
    }
}