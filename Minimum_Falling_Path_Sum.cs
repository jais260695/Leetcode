public class Solution {
    public int MinFallingPathSum(int[][] A) {
        int n = A.Count();
        int m = A[0].Count();
        
        int[,] dp = new int[n,m];
        
        for(int i=0;i<m;i++)
        {
            dp[0,i] = A[0][i];
        }
        
        for(int i=1;i<n;i++)
        {
            for(int j =0;j<m;j++)
            {
                 int min = int.MaxValue;
                 if(j-1>=0)
                 {
                     min =Math.Min(min,dp[i-1,j-1]);
                 }
                 min =Math.Min(min,dp[i-1,j]);
                 if(j+1<m)
                 {
                     min =Math.Min(min,dp[i-1,j+1]);
                 }
                 dp[i,j] = A[i][j] + min;
            }
        }
        
        int result = int.MaxValue;
        for(int i=0;i<m;i++)
        {
            result = Math.Min(result,dp[n-1,i]);
        }
        return result;
        
    }
}