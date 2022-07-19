public class Solution {
    
    int[,,] dp;   
    int n;
    int K;
    public int FindResult(int[] prices, int i, int flag, int limit)
    {
        //if all the days are covered or transaction limit is exhausted then return 0
        if(i==n || limit==K) return 0;
        
        //If current state is already solved then return result
        if(dp[flag,limit,i]!=int.MinValue) return dp[flag,limit,i];
        
        //Chose to skip this day i.e.; don;t buy/sell and go to next day
        int val = FindResult(prices,i+1,flag,limit);
        
        if(flag==0)
        {            
            //take maximum after skipping cuurent day OR chose to buy on current day 
            val = Math.Max(val, -prices[i] + FindResult(prices,i+1,1,limit));   
        }
        else
        {  
            //take maximum after skipping cuurent day OR chose to sell on current day and increase transaction limit
            val =  Math.Max(val, prices[i] + FindResult(prices,i+1,0,limit+1));
        }
        
        dp[flag,limit,i] = val;
        return val;
    }
    
    public int MaxProfit(int k, int[] prices) {
        K=k;
        n = prices.Count();
        int transactionType = 2;// 0  when user can buy/skip and 1 when user can sell/skip
        int transactionLimit = K+1;// upto K transactions allowed
        dp = new int[transactionType,transactionLimit,n];
        
        //Initialize all result to minus infinity
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<K;j++)
            {
                for(int l=0;l<n;l++)
                {
                    dp[i,j,l] = int.MinValue;
                }
            }
        }
        return FindResult(prices,0,0,0);
    }
}