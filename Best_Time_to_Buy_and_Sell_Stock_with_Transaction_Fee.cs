public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        int n =  prices.Count();
        int[] dp = new int[n+1];
        int dp1 = -prices[0];
        for(int i=1;i<n;i++)
        {
            
            dp1 = Math.Max(dp1,dp[i-1]-prices[i-1]);
            dp[i+1] = Math.Max(dp[i],dp1 - fee + prices[i] );
        }
        return dp[n];
    }
}