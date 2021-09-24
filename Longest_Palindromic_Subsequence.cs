
public class Solution {
    public int LongestPalindromeSubseq(string s) {
        int n = s.Length;
        
        if(n<2) return n;
        
        int[,] dp = new int[n,n];
        
        for(int i=0;i<n-1;i++)
        {
            dp[i,i] = 1;
            dp[i,i+1] = 1;
            if(s[i] == s[i+1])
            {
                dp[i,i+1] = 2;
            }
        }
        
        dp[n-1,n-1] = 1;
        
        for(int k=2;k<n;k++)
        {
            for(int i=0,j=k;j<n;i++,j++)
            {
                if(s[i] == s[j])
                {
                    dp[i,j] = 2+ dp[i+1,j-1];
                }
                else
                {
                    dp[i,j] = Math.Max(dp[i,j-1],dp[i+1,j]);
                }
                    
            }
        }
        
        return dp[0,n-1];
    }
}