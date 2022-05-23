public class Solution {
    public long MaxPoints(int[][] points) {
        int n = points.Count();
        int m = points[0].Count();
        long[,] dp = new long[n,m];
        for(int j=0;j<m;j++)
        {
            dp[0,j] = points[0][j];
        }
        for(int i=1;i<n;i++)
        {
            long[] left = new long[m];
            long[] right = new long[m];
            
            left[0] = dp[i-1,0];
            right[m-1] = dp[i-1,m-1]-(m-1); 
            for(int j=1;j<m;j++)
            {
                left[j] = Math.Max(left[j-1],dp[i-1,j]+j);
                right[(m-1)-j] = Math.Max(right[m-j],dp[i-1,(m-1)-j]-((m-1)-j));
                
            }
            
            for(int j=0;j<m;j++)
            {
                
                    dp[i,j] = points[i][j] + Math.Max(left[j]-j,right[j]+j);
                    
            }
        }
        
        long result = 0;
        for(int j=0;j<m;j++)
        {
            result = Math.Max(result,dp[n-1,j]);
        }
        
        return result;
    }
}