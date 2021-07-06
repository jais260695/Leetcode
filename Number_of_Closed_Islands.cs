public class Solution {
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    public void DFS(int x, int y,int n, int m,int[][] grid)
    {
        grid[x][y] = 1;        
        for(int i=0;i<4;i++)
        {
            int u = x + xDir[i];
            int v = y + yDir[i];
            if(u<0 || u>=n || v<0 || v>=m || grid[u][v]!=0) continue;
            DFS(u,v,n,m,grid);           
        }
    }
    public int ClosedIsland(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        
        for(int i=0;i<n;i++)
        {
            if(grid[i][0]==0)
                DFS(i,0,n,m,grid);
        }
        
        for(int i=0;i<n;i++)
        {
            if(grid[i][m-1]==0)
                DFS(i,m-1,n,m,grid);
        }
        
        for(int j=1;j<m-1;j++)
        {
            if(grid[0][j]==0)
                DFS(0,j,n,m,grid);
        }
        
        for(int j=1;j<m-1;j++)
        {
            if(grid[n-1][j]==0)
                DFS(n-1,j,n,m,grid);
        }
        
        int res = 0;
        
        for(int i=1;i<n-1;i++)
        {
            for(int j=1;j<m-1;j++)
            {
                if(grid[i][j]==0)
                {
                    res++;
                    DFS(i,j,n,m,grid);
                }
            }
        }
        
        return res;
    }
}