public class Solution {
    int[,] dp;
    int[][] grid;
    int[][] moveCost;
    int n;
    int m;
    public int Solve(int row, int col)
    {
        if(row==n-1)
        {
            return dp[row,col] = grid[row][col];
        }
        
        if(dp[row,col]!=0)
        {
            return dp[row,col];
        }
        
        int result = int.MaxValue;
        
        for(int j=0;j<m;j++)
        {
            result = Math.Min(result, grid[row][col] + moveCost[grid[row][col]][j] +  Solve(row+1,j));
        }
        
        return dp[row,col] = result;
    }
    public int MinPathCost(int[][] grid, int[][] moveCost) {
        n = grid.Count();
        m = grid[0].Count();
        this.grid = grid;
        this.moveCost = moveCost;
        dp = new int[n,m];
        
        int result = int.MaxValue;
        
        for(int j=0;j<m;j++)
        {
            result = Math.Min(result, Solve(0,j));
        }
        return result;
        
        
    }
}