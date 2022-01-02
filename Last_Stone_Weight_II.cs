public class Solution {
    public int LastStoneWeightII(int[] stones) {
        int s = 0;
        int n = stones.Count();
        for(int i=0;i<n;i++)
        {
            s+=stones[i];
        }
        
        int[,] dp = new int[n+1,s/2+1];
        
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=s/2;j++)
            {
                    dp[i,j] = dp[i-1,j];
                    if(stones[i-1]<=j)
                    {
                        dp[i,j] = Math.Max(dp[i,j],stones[i-1]+dp[i-1,j-stones[i-1]]);
                    }
            }
        }
        Console.Write(dp[n,s/2]);
        
        return s-2*dp[n,s/2];
    }
}