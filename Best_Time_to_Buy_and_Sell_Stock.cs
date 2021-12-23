public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Count();
        int[] dp = new int[n];
        dp[0]  = prices[0];
        for(int i=1;i<n;i++)
        {
            dp[i] = Math.Min(prices[i], dp[i-1]);
        }
        int max = 0;
        int result = 0;
        for(int i = n-1;i>=0;i--)
        {
            result = Math.Max(result,prices[i]-dp[i]);
        }
        return result;
    }
}