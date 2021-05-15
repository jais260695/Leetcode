public class Solution {
    public int[,,] dp;
    
    public int FindResult(int[] prices, int i, int n, int flag, int limit)
    {
        if(i==n || limit==0) return 0;
        
        if(dp[flag,limit,i]!=0) return dp[flag,limit,i];
        int val =FindResult(prices,i+1,n,flag,limit);
        if(flag==0)
        {            
            val = Math.Max(val ,FindResult(prices,i+1,n,1,limit)-prices[i]);   
        }
        else
        {  
            val =  Math.Max(val,prices[i] + FindResult(prices,i+1,n,0,limit-1));
        }
        dp[flag,limit,i] = val;
        return val;
    }
    
    public int MaxProfit(int k,int[] prices) {
        int n = prices.Count();
        dp = new int[2,k+1,n];
        return FindResult(prices,0,n,0,k);
    }
}