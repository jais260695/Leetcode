public class Solution {
    public int count=0;
    
    public void DFS(int[][] grid, int i, int j,int n , int m, int pathLength)
    {
        if(grid[i][j]==-1)
        {
            return;
        }
        
        if(grid[i][j]==2)
        {
            if(-1==pathLength)
                count++;
            return;
        }
        
        grid[i][j] = -1;
        pathLength--;
        
        if(i+1<n)
        {
            DFS(grid,i+1,j,n,m,pathLength);
        }
        if(j+1<m)
        {
            DFS(grid,i,j+1,n,m,pathLength);
        }
        
        if(i-1>=0)
        {
            DFS(grid,i-1,j,n,m,pathLength);
        }
        if(j-1>=0)
        {
            DFS(grid,i,j-1,n,m,pathLength);
        }
        grid[i][j] = 0;
    }
    
    public int UniquePathsIII(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        int s1 = -1;
        int s2 = -1;
        int pathLength=0;
        for(int i = 0; i<n;i++)
        {
            for(int j =0;j<m;j++)
            {
                if(grid[i][j]==0)
                {
                    pathLength++;
                }
                else if(grid[i][j]==1)
                {
                    s1=i;
                    s2=j;
                }
            }
        }
        
        DFS(grid,s1,s2,n,m,pathLength);
        
        return count;
    }
}