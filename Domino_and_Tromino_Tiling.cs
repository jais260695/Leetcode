public class Solution {
    public int NumTilings(int N) {
        int[] dp = new int[N+1];
        int[] temp = new int[N+1];
        int mod = 1000000007;
        if(N==0) return 1;
        if(N<=2) return N;
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 5;
        
        temp[2] = 2;//2nd row top or bottom empty
        temp[3] = 4;//3rd row top or bottom empty
        
        for(int i=4;i<=N;i++)
        {
            //Ways to complete i rows is sum no. of ways of i-1 rows complete, i-2 rows complete and number of ways (i-1) th row is incomplete
            // We can use tromino only if (i-1)th row is incomplete
            dp[i] = ((dp[i-1] + dp[i-2])%mod +  temp[i-1])%mod;//ith row complete
            
            // Ways of reaching the state at ith row incomplete is sum of ways of incomplete (i-1)th rows and twice the ways of (i-2)th row complete
            temp[i] = (temp[i-1] +  (2*dp[i-2])%mod)%mod;//ith row top or bottom empty
        }
        return dp[N];
    }
}