public class Solution {
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    public int DFS(int i, int j, int[][] matrix, int[,] dp, int n, int m)
    {
        if(dp[i,j]!=-1) return dp[i,j];
        dp[i,j] = 0;
        int val = matrix[i][j];
        int count =0;
        for(int d = 0; d < 4; d++)
        {
            int x = i + xDir[d];
            int y = j + yDir[d];
            if(x<0 || x>=n || y<0 || y>=m || matrix[x][y]<=val) continue;
            count = Math.Max(count,DFS(x,y,matrix,dp,n,m));
            
        }
        return dp[i,j] = 1 + count;
    }
    public int LongestIncreasingPath(int[][] matrix) {
        int n = matrix.Count();
        if(n==0) return 0;
        int m = matrix[0].Count();
        int[,] dp = new int[n,m];
        
        for(int i =0;i<n;i++)
        {
            for(int j = 0; j<m;j++)
            {
                dp[i,j]=-1;
            }
        }
        
        int max = 0;
        
        for(int i =0;i<n;i++)
        {
            for(int j = 0; j<m;j++)
            {
                if(dp[i,j]==-1)
                {
                    DFS(i,j,matrix,dp,n,m);
                }
                max = Math.Max(max,dp[i,j]);
            }
        }
        return max;
    }
}