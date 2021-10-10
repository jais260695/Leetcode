public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        
        int n = text1.Count();
        int m = text2.Count();
        //if(n==0 || m==0) return 0;
        int[,] dp = new int[n,m];
        
        int var1 = text1.IndexOf(text2[0]);
        int var2 = text2.IndexOf(text1[0]);
        
        if(var2!=-1)
            for(int i=var2;i<m;i++)
            {
                dp[0,i] = 1;
            }
        if(var1!=-1)
            for(int j=var1;j<n;j++)
            {
                dp[j,0] = 1;
            }
        
        for(int i =1;i<n;i++)
        {
            for(int j=1;j<m;j++)
            {
                if(text1[i]==text2[j])
                {
                    dp[i,j] = 1+ dp[i-1,j-1];
                }
                else
                {
                    dp[i,j] = Math.Max(dp[i-1,j],dp[i,j-1]);
                }
            }
        }
        
        return dp[n-1,m-1];
    }
}