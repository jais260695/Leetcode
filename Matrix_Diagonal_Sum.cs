public class Solution {
    public int DiagonalSum(int[][] mat) {
        int n = mat.Count();
        int sum = 0;
        for(int i =0;i<n;i++)
        {
            sum+= (mat[i][i]+mat[i][n-1-i]);
        }
        return n%2!=0 ? sum-=mat[n/2][n/2] : sum;
    }
}