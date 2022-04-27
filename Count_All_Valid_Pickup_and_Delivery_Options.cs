public class Solution {
    long[,] dp;
    long mod = 1000000007;
    public long Solve(int P, int D)
    {
        if(P>D || P<0 || D<0) return 0;        
        if(dp[P,D]!=0) return dp[P,D];
        
        long result = ((P*Solve(P-1,D))%mod + ((D-P)*Solve(P,D-1))%mod)%mod;        
        return dp[P,D] = result;        
    }
    public int CountOrders(int n) {
        dp = new long[n+1,n+1];       
        dp[0,0] = 1;
        return (int)Solve(n,n);
    }
}