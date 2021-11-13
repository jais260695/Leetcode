public class Solution {
    public int MaxSumAfterPartitioning(int[] arr, int k) {
        int n = arr.Count();
        int[] dp = new int[n+1];
        dp[1] = arr[0];
        for(int i=2;i<=n;i++)
        {
            for(int j=1;j<=k;j++)
            {
                if(i-j>=0)
                {
                    int max = int.MinValue;
                    for(int z = i-1;z>=(i-j) && z>=0;z--)
                    {
                        max = Math.Max(max,arr[z]);
                    }
                    dp[i] = Math.Max(dp[i], max*j+dp[i-j]);
                }
            }   
        }
        return dp[n];
    }
}