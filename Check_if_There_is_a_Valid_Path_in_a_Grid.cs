public class Solution {
    
    public bool CheckU(int i, int j, int[][] grid)
    {
        if(grid[i][j]==2 || grid[i][j]==3 || grid[i][j]==4)
            return true;
        return false;
    }
    
    public bool CheckD(int i, int j, int[][] grid)
    {
        if(grid[i][j]==2 || grid[i][j]==5 || grid[i][j]==6)
            return true;
        return false;
    }
    
    public bool CheckL(int i, int j, int[][] grid)
    {
        if(grid[i][j]==1 || grid[i][j]==4 || grid[i][j]==6)
            return true;
        return false;
    }
    
    public bool CheckR(int i, int j, int[][] grid)
    {
        if(grid[i][j]==1 || grid[i][j]==3 || grid[i][j]==5)
            return true;
        return false;
    }
    
    public bool DFS(int[][] grid, bool[,] visited, int i, int j,int n, int m)
    {
        if(i==n-1 && j==m-1)
            return  true;
        
        visited[i,j] = true;
        
        if(grid[i][j]==1)
        {
            if(j+1<m && !visited[i,j+1] && CheckR(i,j+1,grid))
            {
                if(DFS(grid,visited,i,j+1,n,m))
                    return true;
            }
            
            if(j-1>=0 && !visited[i,j-1] && CheckL(i,j-1,grid))
            {
                if(DFS(grid,visited,i,j-1,n,m))
                    return true;
            }
        }
        
        if(grid[i][j]==2)
        {
            if(i+1<n && !visited[i+1,j] && CheckD(i+1,j,grid))
            {
                if(DFS(grid,visited,i+1,j,n,m))
                    return true;
            }
            
            if(i-1>=0 && !visited[i-1,j] && CheckU(i-1,j,grid))
            {
                if(DFS(grid,visited,i-1,j,n,m))
                    return true;
            }
        }
        
        if(grid[i][j]==3)
        {
            if(i+1<n && !visited[i+1,j] && CheckD(i+1,j,grid))
            {
                if(DFS(grid,visited,i+1,j,n,m))
                    return true;
            }
            
            if(j-1>=0 && !visited[i,j-1] && CheckL(i,j-1,grid))
            {
                if(DFS(grid,visited,i,j-1,n,m))
                    return true;
            }
        }
        
        if(grid[i][j]==4)
        {
            if(i+1<n && !visited[i+1,j] && CheckD(i+1,j,grid))
            {
                if(DFS(grid,visited,i+1,j,n,m))
                    return true;
            }
            
            if(j+1<m && !visited[i,j+1] && CheckR(i,j+1,grid))
            {
                if(DFS(grid,visited,i,j+1,n,m))
                    return true;
            }
        }
        
        if(grid[i][j]==5)
        {
            if(i-1>=0 && !visited[i-1,j] && CheckU(i-1,j,grid))
            {
                if(DFS(grid,visited,i-1,j,n,m))
                    return true;
            }
            
            if(j-1>=0 && !visited[i,j-1] && CheckL(i,j-1,grid))
            {
                if(DFS(grid,visited,i,j-1,n,m))
                    return true;
            }
        }
        
        if(grid[i][j]==6)
        {
            if(i-1>=0 && !visited[i-1,j] && CheckU(i-1,j,grid))
            {
                if(DFS(grid,visited,i-1,j,n,m))
                    return true;
            }
            
            if(j+1<m && !visited[i,j+1] && CheckR(i,j+1,grid))
            {
                if(DFS(grid,visited,i,j+1,n,m))
                    return true;
            }
        }
        
        return false;
    }
    public bool HasValidPath(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        bool[,] visited = new bool[n,m];
        
       return DFS(grid,visited,0,0,n,m);
    }
}