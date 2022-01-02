public class Solution {
    List<int>[] graph;
    int[] parent;
    bool[] visited;
    int[] desc;
    int[] low;
    bool apExists;
    int time = 0;
    
    public void APDFS(int u)
    {
        visited[u] = true;
        time++;
        desc[u] = time;
        low[u] = time;
        int children = 0;
        foreach(int v in graph[u])
        {
            if(!visited[v])
            {
                children++;
                parent[v] = u;
                APDFS(v);
                low[u] = Math.Min(low[u],low[v]);
                if(children>1 && parent[u]==-1) 
                {
                    apExists = true;
                }
                
                if(parent[u]!=-1 && low[v]>=desc[u])
                {
                    apExists = true;
                }
            }
            else
            {
                if(v!=parent[u])
                {
                    low[u] = Math.Min(low[u],desc[v]);
                }
            }
        }
    }
    
    public int MinDays(int[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        
        int[] xDir = new int[4]{0,0,1,-1};
        int[] yDir = new int[4]{1,-1,0,0};
        
        int V = n*m;
        graph = new List<int>[V];
        parent = new int[V];
        visited = new bool[V];
        desc = new int[V];
        low = new int[V];
        
        int landCount = 0;
               
        for(int i=0;i<V;i++)
        {
            parent[i] = -1;
            graph[i] = new List<int>();
        }
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(grid[i][j]==0) continue;
                landCount++;
                int u = i*m+j;
                for(int d = 0;d<4;d++)
                {
                    int x = i+xDir[d];
                    int y = j+yDir[d];
                    if(x<0 || x>=n || y<0 || y>=m || grid[x][y]==0) continue;
                    
                    int v = x*m + y;
                    graph[u].Add(v);
                }
            }
        }
        
        if(landCount<=1) return landCount;
        
        int components = 0;
        for(int u=0;u<V;u++)
        {
            int j = u%m;
            int i = (u-j)/m;
            if(!visited[u] && grid[i][j]==1)
            {
                components++;
                if(components==2) return 0;                
                APDFS(u);                
            }
        }
        
        return apExists ? 1 : 2;
    }
}