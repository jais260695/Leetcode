public class Solution {
    int mod = 1000000007;
    int[,] dp = new int[4002,1001];
    
    public int NumberOfWaysUtil(int startPos, int endPos, int k) {
        if(k==0)
        {
            if(startPos==endPos) return 1;
            return 0;
        }
        
        if(dp[startPos+2002,k]!=-1) return dp[startPos+2002,k];
        
        int result = 0;
        
        result = (result + NumberOfWaysUtil(startPos+1,endPos,k-1))%mod;
        result = (result + NumberOfWaysUtil(startPos-1,endPos,k-1))%mod;

        dp[startPos+2002,k] = result;
        return result;
    }
    
    public int NumberOfWays(int startPos, int endPos, int k) {
        
        for(int i=0;i<4002;i++)
        {
            for(int j=0;j<1001;j++)
            {
                dp[i,j] = -1;
            }
        }
        return NumberOfWaysUtil(startPos, endPos, k);
    }
    
}