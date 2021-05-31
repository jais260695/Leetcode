public class Solution 
{
    public bool DFS(int[][] grid, int i, int j, int t, bool[,] visited, int n)
    {
        if(i<0 || j<0 || i>=n || j>=n || grid[i][j]>t || visited[i,j]) return false;
        if(i==n-1 && j==n-1) return true;
        visited[i,j] = true;
        return DFS(grid,i-1,j,t,visited,n) || DFS(grid,i+1,j,t,visited,n) || DFS(grid,i,j-1,t,visited,n) || DFS(grid,i,j+1,t,visited,n);
    }
    public int SwimInWater(int[][] grid) 
    {
        int n = grid.Count();
        int l = 0;
        int h = grid.Count()*grid.Count()-1;
        while(l<=h)
        {
            int mid = l+ (h-l)/2;
            bool[,] visited = new bool[n,n];
            bool res = DFS(grid,0,0,mid,visited,n);
            if(res)
            {
                h = mid-1;
            }
            else
            {
                l = mid+1;
            }
        }
        return l;
    }
}