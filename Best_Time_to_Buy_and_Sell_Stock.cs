public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Count();
        if(n==0)  return 0;
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
            max = Math.Max(prices[i], max);
            dp[i] = max - dp[i];
            result = Math.Max(result,dp[i]);
        }
        return result;
    }
}