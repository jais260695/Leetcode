public class Solution {
    public int temp = 0;
    public void DFS(int[][] grid, int i, int j, int n, int m)
    {
        grid[i][j] = '0';
        temp++;
        if(i+1<n &&  grid[i+1][j]==1)
        {
            DFS(grid,i+1,j,n,m);
        }
        if(i-1>=0 &&  grid[i-1][j]==1)
        {
            DFS(grid,i-1,j,n,m);
        }
        if(j+1<m &&  grid[i][j+1]==1)
        {
            DFS(grid,i,j+1,n,m);
        }
        if(j-1>=0 &&  grid[i][j-1]==1)
        {
            DFS(grid,i,j-1,n,m);
        }
        
    }
    
    public int MaxAreaOfIsland(int[][] grid) {
        int n = grid.Count();
        if(n==0) return 0;
        int m = grid[0].Count();
        
        int count = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(grid[i][j]==1)
                {
                    
                    DFS(grid,i,j,n,m);
                    if(count<temp)
                    {
                        count = temp;
                    }
                    temp=0;
                    
                }
                
            }
        }
        return count;
    }
}