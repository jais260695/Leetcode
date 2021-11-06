public class Solution {
    int[,] dp; 
    public int FindSolution(int[] rating,int curr, int n, int val, int K,bool isDec )
    {
        if(K==0) return 1;
        if(dp[curr,K]!=-1) return dp[curr,K];
        int result = 0;
        for(int i = curr;i<n;i++)
        {
            if((isDec && rating[i]<val) || (!isDec && rating[i]>val))
            {
                result+=FindSolution(rating,i+1,n,rating[i],K-1, isDec);
            }
        }
        return dp[curr,K] = result;
    }
    public int NumTeams(int[] rating) {
        int n = rating.Count();
        dp = new int[n+1,4];
        for(int i=0;i<=n;i++)
        {
            for(int j=0;j<=3;j++)
            {
                dp[i,j] = -1;
            }
        }
        int ans = FindSolution(rating,0,n,int.MinValue,3,false);
        for(int i=0;i<=n;i++)
        {
            for(int j=0;j<=3;j++)
            {
                dp[i,j] = -1;
            }
        }
        ans+=FindSolution(rating,0,n,int.MaxValue,3,true);
        return  ans;
    }
}