public class Solution {
    int[,] dp;
    public int SolveGame(int[][] dungeon,int i, int j, int n, int m)
    {
        if(i<0 || j<0 || i>=n || j>=m) return int.MinValue;
        if(i==n-1 && j==m-1)
        {
            dp[i,j] = dungeon[i][j];
            if(dp[i,j]>0) dp[i,j] = 0;
            return dp[i,j];
        }
        if(dp[i,j]!=int.MinValue) return dp[i,j];
        
        dp[i,j] = dungeon[i][j] + Math.Max(SolveGame(dungeon,i+1,j,n,m),SolveGame(dungeon,i,j+1,n,m));
        if(dp[i,j]>0) dp[i,j] = 0;
        return dp[i,j];
    }
    public int CalculateMinimumHP(int[][] dungeon) {
        int n = dungeon.Count();
        int m = dungeon[0].Count();
        dp = new int[n,m];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                dp[i,j] = int.MinValue;
            }
        }
        return Math.Abs(SolveGame(dungeon,0,0,n,m))+1;
    }
}