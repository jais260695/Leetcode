public class Solution {
    public int CountServers(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        int[] rows = new int[n]; 
        int[] cols = new int[m];
        int res =0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(grid[i][j]==1)
                {
                    res++;
                    rows[i]++;
                    cols[j]++;
                }
            }
        }
            
        for(int i=0;i<n;i++)
        {
                for(int j=0;j<m;j++)
                {
                    if(grid[i][j]==1 && rows[i]==1 && cols[j]==1)
                        res--;
                }
        }
        return res;
        
    }
}