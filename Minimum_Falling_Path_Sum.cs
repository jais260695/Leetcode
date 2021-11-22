public class Solution {
    public int MinFallingPathSum(int[][] A) {
        int n = A.Count();
        int m = A[0].Count();        
        for(int i=1;i<n;i++)
        {
            A[i][0] = A[i][0] + Math.Min(A[i-1][1],A[i-1][0]);
            for(int j =1;j<m-1;j++)
            {
                 A[i][j] = A[i][j] + Math.Min(Math.Min(A[i-1][j-1],A[i-1][j]),A[i-1][j+1]);
            }
            A[i][m-1] = A[i][m-1] + Math.Min(A[i-1][m-2],A[i-1][m-1]);
        }        
        int result = int.MaxValue;
        for(int i=0;i<m;i++)
        {
            result = Math.Min(result,A[n-1][i]);
        }
        return result;        
    }
}