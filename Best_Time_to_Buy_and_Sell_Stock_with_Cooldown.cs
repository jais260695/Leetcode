public class Solution {
    public int[,] dp = new int[5000,2];
    
    public int FindResult(int[] prices, int i, int n, int flag)
    {
        if(i>=n) return 0;
        
        if(dp[i,flag]!=0) return dp[i,flag];
        
        if(flag==0)
        {            
            int val = Math.Max(FindResult(prices,i+1,n,0) ,FindResult(prices,i+1,n,1)-prices[i]);   
            dp[i,flag] = val;
            return val;
        }
        else
        {  
            int val =  Math.Max(FindResult(prices,i+1,n,1) ,prices[i]  + FindResult(prices,i+2,n,0));
            dp[i,flag] = val;
            return val;
        }
    }
    
    public int MaxProfit(int[] prices) {
        int n = prices.Count();
        return FindResult(prices,0,n,0);
    }
}