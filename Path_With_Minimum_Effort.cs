public class Solution {
    
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    bool[,] visited;
    int n;
    int m;
    
    public bool DFS(int[][] heights, int i, int j, int th)
    {
        if(i==n-1 && j==m-1) return true;
        
        visited[i,j] = true;
        
        for(int d = 0; d<4;d++)
        {
            int x = i + xDir[d];
            int y = j + yDir[d];
            
            if(x<0 || x>=n || y<0 || y>=m || visited[x,y] || Math.Abs(heights[i][j]-heights[x][y])>th) continue;
            
            if(DFS(heights,x,y,th)) return true;
        }
        
        return false;
    }
    
    public int MinimumEffortPath(int[][] heights) {
        n = heights.Count();
        m = heights[0].Count();
        visited = new bool[n,m];
        int start = 0, end = 1000000;        
        int res = 1000000;
        
        while(start<=end)
        {
            int mid = start + (end-start)/2;
            visited = new bool[n,m];
            if(DFS(heights,0,0,mid))
            {
                res = Math.Min(res,mid);
                end = mid -1;
            }
            else
            {
                start = mid + 1;
            }
        }
        
        return res;
    }
}