public class Solution {
    public int MaxSum(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        
        int[,] prefix = new int[n,m+1];
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                prefix[i,j+1] = prefix[i,j] + grid[i][j];
            }
        }
        
        int result = 0;
        
        for(int i=2;i<n;i++)
        {
            int l = 0;
            int r = 2;
            
            while(r<m)
            {
                result = Math.Max(result, (prefix[i,r+1] - prefix[i,l]) +  (prefix[i-2,r+1] - prefix[i-2,l]) + grid[i-1][r-1]);
                l++;
                r++;
            }
        }
        
        return result;
    }
}