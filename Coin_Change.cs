public class Solution {
    
    public int CoinChange(int[] coins, int amount) {
        int n = coins.Count();
        int[] dp = new int[amount+1];
        dp[0] =0;
        for(int i=1;i<=amount;i++)
        {
            dp[i] = int.MaxValue;
        }
        for(int i=0;i<n;i++)
        {
            for(int j=1;j<=amount;j++)
            {
                if(j>=coins[i] && dp[j-coins[i]]!=int.MaxValue)
                {
                        dp[j] = Math.Min(1+dp[j-coins[i]],dp[j]);
                }
            }
        }
        return dp[amount]==int.MaxValue?-1:dp[amount];
    }
}