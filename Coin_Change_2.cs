public class Solution {
    int[,] dp; 
    public int Solve(int amount, int[] coins,int i, int n)
    {
        if(dp[i,amount]!=-1) return dp[i,amount];
        int ans = 0;
        for(int j=i;j<n;j++)
        {
            if(coins[j]<=amount)
            {
                ans+=Solve(amount-coins[j],coins,j,n);
            }
        }
        return dp[i,amount] = ans;
    }
    
    public int Change(int amount, int[] coins) {
        int n = coins.Count();
        dp = new int[n,amount+1];
        for(int i=0;i<n;i++)
        {
            dp[i,0] = 1;
        }
        for(int i=0;i<n;i++)
        {
            for(int j=1;j<=amount;j++)
            {
                dp[i,j] = -1;
            }
        }
        return Solve(amount,coins,0,n);
    }
}