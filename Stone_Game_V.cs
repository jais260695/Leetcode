public class Solution {
    int[,] dp;
    int[] prefix;
    public int Solve(int[] arr, int i, int j)
    {
        if(i>=j) return 0;
        if(dp[i,j]!=0) return dp[i,j];
        int res = 0;
        for(int k=i;k<=j;k++)
        {
            int left = prefix[k+1] - prefix[i];
            int right = prefix[j+1] - prefix[k+1];
            if(left>right)
            {
                res = Math.Max(res, right + Solve(arr,k+1,j));
            }
            else if(left<right)
            {
                res = Math.Max(res, left + Solve(arr,i,k));
            }
            else
            {
                res = Math.Max(res, right + Math.Max(Solve(arr,i,k),Solve(arr,k+1,j)));
            }
            
        }
        
        dp[i,j] = res;
        return res;
        
    }
    public int StoneGameV(int[] stoneValue) {
        int n = stoneValue.Count();
        dp = new int[n,n];
        prefix = new int[n+1];
        prefix[0] = 0;
        for(int i=0;i<n;i++)
        {
            prefix[i+1] = prefix[i] + stoneValue[i];
        }
        return Solve(stoneValue,0,n-1);
    }
}