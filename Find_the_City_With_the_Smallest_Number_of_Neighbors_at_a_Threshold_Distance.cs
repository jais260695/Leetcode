public class Solution {
    public int FindTheCity(int n, int[][] edges, int distanceThreshold) {
        int[,] dp = new int[n,n];
        for(int i =0;i<n;i++)
        {
            for(int j = 0;j<n;j++)
            {
                dp[i,j] = 10001;
            }
        }
        
        int m = edges.Count();
        for(int i =0;i<m;i++)
        {
            dp[edges[i][0],edges[i][1]] = edges[i][2];
            dp[edges[i][1],edges[i][0]] = edges[i][2];
        }

        for(int k = 0 ;k<n;k++)
        {
            for(int i =0;i<n;i++)
            {
                for(int j = 0;j<n;j++)
                {
                    if(dp[i,j]>dp[i,k]+dp[k,j])
                        dp[i,j] = dp[i,k]+dp[k,j]; 
                }
            }
        }
        
        int result = int.MaxValue;
        int ans = -1;
        for(int i =0;i<n;i++)
        {
            int count = 0;
            
            for(int j = 0;j<n;j++)
            {
                if(i!=j && dp[i,j]<=distanceThreshold)
                {
                    count++;
                }
            }
            
            if(result>=count)
            {
                result = count;
                ans = i;
            }
        }
        return ans;
    }
}