public class Solution {
    public int Solve(int[] slices, int l, int r) {
        int n = r-l+1;
        int[,] dp = new int[n,(n+1)/3+1];
        for(int i=0;i<n;i++)
        {
            dp[i,1] = slices[l+i];
        }
        for(int j=1;j<=(n+1)/3;j++)
        {
            dp[0,j] = slices[l];
            dp[1,j] = Math.Max(dp[0,j],slices[l+1]);
        }
        for(int i=2;i<n;i++)
        {
            for(int j=1;j<=(n+1)/3;j++)
                dp[i,j] = Math.Max(slices[l+i]+dp[i-2,j-1],dp[i-1,j]);         
        }
        return dp[n-1,(n+1)/3];
    }
    public int MaxSizeSlices(int[] slices) {
        int n = slices.Count();
        return Math.Max(Solve(slices,0,n-2),Solve(slices,1,n-1));
    }
}