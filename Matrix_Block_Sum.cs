public class Solution {
    public int[][] MatrixBlockSum(int[][] mat, int K) {
        int n=mat.Count();
        int m=mat[0].Count();
        int[][] dp = new int[n][];
        
        for(int i=0;i<n;i++)
        {
            dp[i] = new int[m];
            for(int j=0;j<m;j++)
            {
                for(int r = i-K;r<=i+K && r<n;r++)
                {
                    if(r>=0)
                    {
                        for(int c = j-K;c<=j+K && c<m; c++)
                        {
                            if(c>=0)
                            {
                                dp[i][j]+=mat[r][c];
                            }
                        }
                        
                    }
                }
            }
        }
        return dp;
        
    }
}