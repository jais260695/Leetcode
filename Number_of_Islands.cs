public class Solution {
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    
    public void DFS(char[][] grid, int i, int j, int n, int m)
    {
        grid[i][j] = '0';        
        for(int d=0;d<4;d++)
        {
            int x = i + xDir[d];
            int y = j + yDir[d];
            if(x<0 || y<0 || x>=n || y>=m || grid[x][y]=='0') continue;
            DFS(grid,x,y,n,m);
        }       
    }
    public int NumIslands(char[][] grid) {
        
        int n = grid.Count();
        if(n==0) return 0;
        int m = grid[0].Count();
        
        int count = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(grid[i][j]=='1')
                {
                    count++;
                    DFS(grid,i,j,n,m);
                }
            }
        }
        return count;
    }
}