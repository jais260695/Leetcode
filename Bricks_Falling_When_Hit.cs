public class Solution {
    public int DFS(int[][] grid, int u, int v, int n, int m)
    {
        if(u<0 || u>=n || v<0 || v>=m) return 0;
        if(grid[u][v]!=1) return 0;
        grid[u][v] = 2;        
        int numOfBricksVisited = 1;
        numOfBricksVisited+=DFS(grid,u-1,v,n,m);
        numOfBricksVisited+=DFS(grid,u+1,v,n,m);
        numOfBricksVisited+=DFS(grid,u,v-1,n,m);
        numOfBricksVisited+=DFS(grid,u,v+1,n,m);
        return numOfBricksVisited;
    }
    
    public int[] HitBricks(int[][] grid, int[][] hits) {
        int n = grid.Count();//number of rows
        int m = grid[0].Count();// number of columns
        
        int nH = hits.Count();//number of hits
        //remove all bricks which need hit
        for(int i=0;i<nH;i++)
        {
            int x = hits[i][0];
            int y = hits[i][1];
            if(grid[x][y]==1)
                grid[x][y] = 0;// break the brick at x and y
            else
                grid[x][y] = -1;
        }
        
        for(int i=0;i<m;i++)
        {
            DFS(grid,0,i,n,m);
        }
        
        int[] result = new int[nH];
        
        //Add back the bricks in reverse order
        for(int i=nH-1;i>=0;i--)
        {
            int x = hits[i][0];
            int y = hits[i][1];
            if(grid[x][y]==-1)
            {
                grid[x][y] = 0;
            }
            else
            {        
                    grid[x][y] = 1;
                    if(
                        x==0 ||
                        x-1>=0 && grid[x-1][y]==2 ||
                        x+1<n && grid[x+1][y]==2 ||
                        y-1>=0 && grid[x][y-1]==2 ||
                        y+1<m && grid[x][y+1]==2
                    )
                    {
                        int bricksFallen = DFS(grid,x,y,n,m)-1;
                        result[i] = bricksFallen;
                    }
            }
            
        }
        return result;
    }
}