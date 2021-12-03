public class Solution {
    public int[,] dp;
    public int Solve(int i, int j, string s)
    {
        if(i>=j) return 0;
        if(dp[i,j]!=-1) return dp[i,j];
        if(s[i]==s[j])
        {
            dp[i,j] = Solve(i+1,j-1,s);
        }
        else
        {
            dp[i,j] = 1 +  Math.Min(Solve(i,j-1,s),Solve(i+1,j,s));
        }
        return dp[i,j];
    }
    public int MinInsertions(string s) {
        int n = s.Length;
        dp = new int[n,n];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                dp[i,j] = -1;
            }
        }
        return Solve(0,n-1,s);
    }
}