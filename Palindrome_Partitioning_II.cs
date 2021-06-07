public class Solution {
    public int MinCut(string s) {
        int n = s.Length;
        bool[,] dp = new bool[n,n];        
        for(int i=0;i<n-1;i++)
        {
            dp[i,i] = true;
            if(s[i]==s[i+1])
            {
                dp[i,i+1] = true;
            }
            else
            {
                dp[i,i+1] = false;
            }
        }
        dp[n-1,n-1] = true;
        for(int k=2;k<n;k++)
        {
            for(int i=0,j=k;j<n;i++,j++)
            {
                dp[i,j] = false;
                if(s[i]==s[j] && dp[i+1,j-1])
                {
                    dp[i,j] = true;
                }
            }
        }
        int[] ans = new int[n];
        for(int i=0;i<n;i++)
            ans[i] = i;
        for(int i = 1;i<n;i++)
        {
            if(dp[0,i]==true)
            {
                ans[i] = 0;
                continue;
            }
            for(int j=i;j>0;j--)
            {
                if(dp[j,i]==true)
                {
                    ans[i] = Math.Min(ans[i],1+ans[j-1]);
                }
            }
        }
        
        return ans[n-1];
    }
}