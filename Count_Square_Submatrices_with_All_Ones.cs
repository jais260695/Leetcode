public class Solution {
    public int CountSquares(int[][] matrix) {
        int m = matrix[0].Count();
        int n = matrix.Count();
        
        int[,] dp = new int[n+1,m+1];
        int res=0;
        
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=m;j++)
            {
                if(matrix[i-1][j-1]==1)
                {
                    dp[i,j]=Math.Min(dp[i-1,j-1],Math.Min(dp[i,j-1],dp[i-1,j]))+1;
                    if(dp[i,j]>=1)
                    {
                        res+=dp[i,j];
                    }
                }
            }
        }        
        return res;       
    }
}