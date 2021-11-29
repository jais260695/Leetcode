public class Solution {
    public int CountSubstrings(string s) {
        int n = s.Length;
        if(n<2) return n;
        bool[,] dp = new bool[n,n];
        
        int result = n;
        for(int i=0;i<n-1;i++)
        {
            dp[i,i] = true;
            if(s[i] == s[i+1])
            {
                dp[i,i+1] = true;
                result++;
            }
        }
        dp[n-1,n-1] = true;
        
        for(int k=2;k<n;k++)
        {
            for(int i=0,j=k;j<n;i++,j++)
            {
                if(s[i] == s[j] && dp[i+1,j-1]==true)
                {
                    dp[i,j] = true;
                    result++;
                }
                    
            }
        }
        
        return result;
    }
}