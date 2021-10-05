public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        int[] xDir = new int[4]{0,0,1,-1};
        int[] yDir = new int[4]{1,-1,0,0};
        int result = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(grid[i][j]==1)
                {
                    for(int k=0;k<4;k++)
                    {
                        int x = i+xDir[k];
                        int y = j+yDir[k];
                        if(x<0 || y<0 || x>=n || y>=m || grid[x][y]==0)
                        {
                            result++;
                        }
                    }
                }
            }
        }
        return result; 
    }
}