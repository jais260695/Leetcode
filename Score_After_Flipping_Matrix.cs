public class Solution {
    public int MatrixScore(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        for(int i=0;i<n;i++)
        {
            if(grid[i][0]==0)
            {
                for(int j=0;j<m;j++)
                {
                    if(grid[i][j]==1)
                    {
                        grid[i][j] = 0;
                    }
                    else
                    {
                        grid[i][j] = 1;
                    }
                }
            }
        }
        for(int i=1;i<m;i++)
        {
            int diff = 0;
            for(int j=0;j<n;j++)
            {
                if(grid[j][i]==1) diff++;
                else diff--;
            }
            
            if(diff<0)
            {
                for(int j=0;j<n;j++)
                {
                    if(grid[j][i]==1) grid[j][i] = 0;
                    else grid[j][i] = 1;
                }
            }
        }
        int ans = 0;
        for(int i=0;i<n;i++)
        {
            int temp = 0;
            for(int j=0;j<m;j++)
            {
                if(grid[i][j]==1)
                {
                    temp+= 1<<(m-1-j);
                }
            }
            ans+=temp;
        }
        return ans;
    }
}