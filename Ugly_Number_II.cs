public class Solution {

    public int NthUglyNumber(int n) {
        if(n==1) return 1;
        int[] dp = new int[n+1];
        int i1 = 1;
        int i2 = 1;
        int i3 = 1;
        dp[1] = 1;
        int i = 2;
        while(i<=n)
        {
            dp[i] = Math.Min(dp[i1]*2,Math.Min(dp[i2]*3,dp[i3]*5));
            if(dp[i]==dp[i1]*2) i1++;
            if(dp[i]==dp[i2]*3) i2++;
            if(dp[i]==dp[i3]*5) i3++;
            i++;
        }
        return dp[n];
    }
}