public class Solution {
    public int FindLongestChain(int[][] pairs) {
        int n = pairs.Count();
        if(n==1) return 1;
        Array.Sort(pairs,(int[] a, int[] b)=>{
            return a[0]-b[0];
        });
        int res = 0;
        int[] dp =  new int[n];
        dp[0] = 1;
        
        for(int i=1;i<n;i++)
        {
            dp[i] = 1;
            for(int j=i-1;j>=0;j--)
            {
                if(pairs[i][0] > pairs[j][1] && dp[i] < (dp[j]+1))
                {
                    dp[i] = dp[j]+1;
                }
            }
            res = Math.Max(dp[i], res);
        }
        return res;
    }
}