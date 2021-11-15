public class Solution {
    int[,] dp;
    public int Solve(int[] piles, int l, int h)
    {
        if(l>h) return 0;
        if(dp[l,h]!=0) return dp[l,h];
        return dp[l,h] =  Math.Max(piles[l] - Solve(piles,l+1,h),piles[h] + Solve(piles,l,h-1));
    }
    public bool StoneGame(int[] piles) {
        int n = piles.Count();
        dp  = new int[n,n];
        int sum = 0;
        for(int i=0;i<n;i++)
        {
            sum+=piles[i];
        }
        int res = Solve(piles,0,n-1);
        return res>sum/2;
    }
}