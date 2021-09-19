public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int n = matrix.Count();
        int m = matrix[0].Count();
        int[,] dp = new int[n,m];
        
        int result = 0;
        if(matrix[0][0]=='0')
        {
            dp[0,0] = 0;
        }
        else
        {
            dp[0,0] = 1;
            result = 1;
        }
        for(int i=1;i<n;i++)
        {
            if(matrix[i][0]=='0')
            {
                dp[i,0] = 0;
            }
            else
            {
                dp[i,0] = 1;
                result = 1;
            }
        }
        for(int j=1;j<m;j++)
        {
            if(matrix[0][j]=='0')
            {
                dp[0,j] = 0;
            }
            else
            {
                dp[0,j] = 1;
                result = 1;
            }
        }
        
        for(int i=1;i<n;i++)
        {
            for(int j=1;j<m;j++)
            {
                if(matrix[i][j]=='0')
                {
                    dp[i,j] = 0;
                }
                else
                {
                    dp[i,j] = Math.Min(dp[i-1,j-1],Math.Min(dp[i,j-1],dp[i-1,j]))+1;
                    int area = (int)Math.Pow(dp[i,j],2);
                    result = Math.Max(result,area);
                }
            }
        }
        return result;
    }
}