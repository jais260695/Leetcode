public class Solution {
    public int MinDistance(string word1, string word2) {
        int n1 = word2.Count();
        int n2 = word1.Count();
        
        int[,] dp = new int[n1+1,n2+1];
        
        dp[0,0] = 0;
        for(int i=1;i<=n1;i++)
        {
            dp[i,0] = i;
        }
        for(int i=1;i<=n2;i++)
        {
            dp[0,i] = i;
        }
        
        for(int i=1;i<=n2;i++)
        {
            for(int j=1;j<=n1;j++)
            {
                if(word1[i-1]==word2[j-1])
                {
                    dp[j,i] = dp[j-1,i-1];
                }
                else
                {
                    dp[j,i] = 1 + Math.Min(dp[j,i-1],dp[j-1,i]);
                }
            }
        }
        return dp[n1,n2];
    }
}