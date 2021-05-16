public class Solution {
    public int[,,] dp;
    public int n;
    public int DFS(int[][] grid,  int r1, int c1, int c2)
    {
        int r2 = r1+c1-c2;
        if(r2==n || c1==n || c2==n || r1==n || grid[r1][c1] ==-1 ||  grid[r2][c2]==-1) return int.MinValue;
        
        if(r1 == n-1 && c1 == n-1) return grid[r1][c1];
        if(dp[r1,c1,c2]!=int.MinValue) return dp[r1,c1,c2];
        
        int val = grid[r1][c1];
        if(c1!=c2) val += grid[r2][c2];
        val+=Math.Max
                        (
                                Math.Max(DFS(grid,r1,c1+1,c2), DFS(grid,r1+1,c1,c2)),
                                Math.Max(DFS(grid,r1,c1+1,c2+1), DFS(grid,r1+1,c1,c2+1))
                        );  
        dp[r1,c1,c2] = val;
        return val;
    }

    public int CherryPickup(int[][] grid) {
        n = grid.Count();
        dp = new int[n,n,n];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                for(int k=0;k<n;k++)
                {
                    dp[i,j,k] = int.MinValue;
                }
            }
        }
        return Math.Max(0,DFS(grid,0,0,0));
    }
}