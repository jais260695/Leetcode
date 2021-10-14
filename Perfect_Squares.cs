public class Solution {
    public int NumSquares(int n) {
        if(n<=3) return n;
        int[] dp = new int[n+1];
        
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 3;
        
        for(int i=4;i<=n;i++)
        {
            dp[i] = i;
            for(int j=1;j*j<=i;j++)
            {
                dp[i] = Math.Min(dp[i],dp[i-(j*j)] +1);
            }
        }
        return dp[n];
    }
}