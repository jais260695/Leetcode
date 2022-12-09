public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        int[] rows = new int[n];
        int[] cols = new int[m];

        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(grid[i][j]==0)
                {
                    rows[i]--;
                    cols[j]--;
                }
                else
                {
                    rows[i]++;
                    cols[j]++;
                }
            }
        }

        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                grid[i][j] = rows[i] + cols[j];
            }
        }
        return grid;
    }
}