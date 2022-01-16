public class Solution {
    
    
    public int NumRollsToTarget(int d, int f, int target) {
        int[,] dp = new int[d+1,target+1];
        int mod = 1000000007;
        for(int i=0;i<=target;i++)
        {
            dp[0,i] = 0;
        }
        
        for(int i=0;i<=d;i++)
        {
            dp[i,0] = 0;
        }
        
        dp[0,0] = 1;
        
        for(int i=1;i<=d;i++)
        {
            for(int j = 1; j<=target;j++)
            {
                for(int k=1;k<=f;k++)
                {
                    if(j-k>=0)
                        dp[i,j] =  (dp[i,j] + dp[i-1,j-k])%mod;
                }
            }
        }
        
        
        return dp[d,target];
    }
}