public class Solution {
    public bool CheckPartitioning(string s) {
        int n = s.Length;
        bool[,] dp = new bool[n,n];        
        for(int i=0;i<n-1;i++)
        {
            dp[i,i] = true;
            if(s[i]==s[i+1])
            {
                dp[i,i+1] = true;
            }
        }
        dp[n-1,n-1] = true;
        for(int k=2;k<n;k++)
        {
            for(int i=0,j=k;j<n;i++,j++)
            {
                if(s[i]==s[j] && dp[i+1,j-1])
                {
                    dp[i,j] = true;
                }
            }
        }
        
        for(int i=0;i<n-2;i++)
        {
            if(dp[0,i])
            {
                for(int j=i+1;j<n-1;j++)
                {
                    if(dp[i+1,j] && dp[j+1,n-1])
                    {
                        return true;
                    }
                }
            }
        }
        
        return false;
    }
}