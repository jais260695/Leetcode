public class Solution {
    public void DFS(int i, int j, int[][] matrix, int[,] dp, int n, int m)
    {
        int count =0;
        int val = matrix[i][j];
        if(i-1>=0 && matrix[i-1][j]<val)
        {
            if(dp[i-1,j] == 0)
            {
                DFS(i-1,j,matrix,dp,n,m);
            }
            count = Math.Max(count,dp[i-1,j]);
        }
        if(i+1<n && matrix[i+1][j]<val)
        {
            if(dp[i+1,j] == 0)
            {
                DFS(i+1,j,matrix,dp,n,m);
            }
            count = Math.Max(count,dp[i+1,j]);
        }
        if(j-1>=0 && matrix[i][j-1]<val)
        {
            if(dp[i,j-1] == 0)
            {
                DFS(i,j-1,matrix,dp,n,m);
            }
            count = Math.Max(count,dp[i,j-1]);
        }
        if(j+1<m && matrix[i][j+1]<val)
        {
            if(dp[i,j+1] == 0)
            {
                DFS(i,j+1,matrix,dp,n,m);
            }
            count = Math.Max(count,dp[i,j+1]);
        }
        
        dp[i,j] = 1 + count;
    }
    public int LongestIncreasingPath(int[][] matrix) {
        int n = matrix.Count();
        if(n==0) return 0;
        int m = matrix[0].Count();
        int[,] dp = new int[n,m];
        
        int max = 0;
        
        for(int i =0;i<n;i++)
        {
            for(int j = 0; j<m;j++)
            {
                DFS(i,j,matrix,dp,n,m);
                max = Math.Max(max,dp[i,j]);
            }
        }
        return max;
    }
}