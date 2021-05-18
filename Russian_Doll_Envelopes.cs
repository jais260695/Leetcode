public class Solution {
    
    public class ArrayComparer : IComparer<int[]>
    {
       public int Compare(int[] x, int[] y)
       {
           return x[0]!= y[0] ? x[0]-y[0] : y[1]-x[1];
       }
    }
    public int MaxEnvelopes(int[][] envelopes) {
        int result = 1;
        int n = envelopes.Count();
        Array.Sort(envelopes,new ArrayComparer());
        int[] dp = new int[n];
        dp[0] = 1;
        for(int i=1;i<n;i++)
        {
            dp[i] = 1;
            for(int j=i-1;j>=0;j--)
            {
                
                if(envelopes[i][1] > envelopes[j][1] && dp[i]<1+dp[j])
                {
                    dp[i]=1+dp[j];
                    result = Math.Max(dp[i],result);
                }
            }
        }
        
        return result;
    }
}