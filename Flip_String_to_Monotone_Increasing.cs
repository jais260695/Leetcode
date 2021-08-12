public class Solution {    
    public int[] prefixOnesCount;
    
    public int[] dp;
    
    public int Solve(int r,string s)
    {
        if(r==0)
        {
            return 0;
        }
        if(dp[r]!=-1) return dp[r];
        if(s[r]=='1')
        {
            return dp[r]=Solve(r-1,s);
        }
        else
        {
            return dp[r]=Math.Min(1+Solve(r-1,s),prefixOnesCount[r-1]);
        }
    }
    
    public int MinFlipsMonoIncr(string s) {
        int n = s.Length;
        if(s.Length==1) return 0;
        
        dp = new int[n];
        prefixOnesCount = new int[n];
        
        if(s[0]=='1')
        {
            prefixOnesCount[0] = 1;
        }
        dp[0] = -1;
        for(int i = 1;i<n;i++)
        {
            prefixOnesCount[i] = prefixOnesCount[i-1];
            if(s[i]=='1')
            {
                prefixOnesCount[i]+=1;
            }
            dp[i] = -1;
        }
        return Solve(n-1,s);
    }
}