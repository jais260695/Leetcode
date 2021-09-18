public class NumMatrix {
    int[,] dp;
    int n;
    int m;
    public NumMatrix(int[][] matrix) {
        n = matrix.Count()+1;
        m = matrix[0].Count()+1;
        dp = new int[n,m];
        
        for(int i=1;i<n;i++)
        {
            for(int j=1;j<m;j++)
            {
                dp[i,j] = matrix[i-1][j-1];
                dp[i,j] += dp[i-1,j]+dp[i,j-1]-dp[i-1,j-1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return dp[row2+1,col2+1]-dp[row1,col2+1]-dp[row2+1,col1]+dp[row1,col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */