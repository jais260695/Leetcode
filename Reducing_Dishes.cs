public class Solution {
    public int[,] dp;
    
    public int Solve(int[] arr, int r, int time, int i)
    {
        if(i>=r) return 0;
        if(dp[i,time]!=int.MinValue)
            return dp[i,time];
        dp[i,time] = Math.Max(time*arr[i]+Solve(arr,r,time+1,i+1),Solve(arr,r,time,i+1));
        return dp[i,time];
    }
    
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);
        int n = satisfaction.Count();
        dp = new int[n,n+1];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<=n;j++)
            {
                dp[i,j] = int.MinValue;
            }
        }
        return Solve(satisfaction,satisfaction.Count(),1,0);
    }
}