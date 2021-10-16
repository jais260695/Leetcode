public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        
        int[] row = new int[n];
        int[] col = new int[m];
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                row[i] = Math.Max(row[i],grid[i][j]);
                col[j] = Math.Max(col[j],grid[i][j]);
            }
        }
        
        int res = 0;
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                res += ( Math.Min(row[i],col[j]) - grid[i][j]);
            }
        }
        
        return res;
    }
}