public class Solution {
    public void DFS(int[,] graph, int u, int v, int n)
    {
        if(u>=0 && u<n && v>=0 && v<n && graph[u,v] == 0) 
        {
            graph[u,v] = 1;
            DFS(graph,u,v+1,n);
            DFS(graph,u,v-1,n);
            DFS(graph,u+1,v,n);
            DFS(graph,u-1,v,n);
        }
    }
    public int RegionsBySlashes(string[] grid) {
        int n = grid.Count();
        int m = 3*n;
        int[,] graph = new int[m,m];
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]=='/')
                {
                    graph[3*i,3*j+2] = 1;
                    graph[3*i+1,3*j+1] = 1;
                    graph[3*i+2,3*j] = 1;
                }
                else if(grid[i][j]=='\\')
                {
                    graph[3*i,3*j] = 1;
                    graph[3*i+1,3*j+1] = 1;
                    graph[3*i+2,3*j+2] = 1;
                }
            }
        }
        int result = 0;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(graph[i,j]==0)
                {
                    result++;
                    DFS(graph,i,j,m);
                }
            }
        }
        return result;
    }
}