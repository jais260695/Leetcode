public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);
        int n = satisfaction.Count();
        int[,] dp = new int[n+1,n+1];
        for(int i=1;i<=n;i++)
        {
            dp[i,i] = dp[i-1,i-1]+satisfaction[i-1]*i;
        }
        int result = 0;
        for(int k=1;k<=n;k++)
        {
            for(int i=k+1,j=1;i<=n;i++,j++)
            {
                dp[i,j] = Math.Max(dp[i-1,j-1]+satisfaction[i-1]*j,dp[i-1,j]);
            }
            result = Math.Max(dp[n,k],result);
        }
        return result;
    }
}