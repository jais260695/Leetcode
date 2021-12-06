public class Solution {
    int[,] dp;
    public int Solve(int i, int[] prices, int fee,int flag)
    {
        if(i>=prices.Count()) return 0;
        
        if(dp[i,flag]!=-1) return dp[i,flag];
        
        if(flag==1)
        {
            dp[i,flag] = Math.Max(Solve(i+1,prices,fee,1),Solve(i+1,prices,fee,0)+prices[i]-fee);
        }
        else
        {
            dp[i,flag] = Math.Max(Solve(i+1,prices,fee,1)-prices[i],Solve(i+1,prices,fee,0));
        }
        return dp[i,flag];
    }
    public int MaxProfit(int[] prices, int fee) {
        int n =  prices.Count();
        dp = new int[n,2];
        for(int i=0;i<n;i++)
        {
            dp[i,0] = -1;
            dp[i,1] = -1;
        }
        return Math.Max(Solve(1,prices,fee,1)-prices[0],Solve(1,prices,fee,0));
    }
}