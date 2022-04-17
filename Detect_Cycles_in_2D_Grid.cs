public class Solution {
    public int[] rank;
    public int[] parent;
    
    public void Union(int u, int v)
    {
        int x = Find(u);
        int y = Find(v);
        
        if(rank[x]>rank[y])
        {
            parent[y] = x;
        }
        else if(rank[y]>rank[x])
        {
            parent[x] = y;
        }
        else
        {
            parent[x] = y;
            rank[y]++;
        }
    }
    
    public int Find(int u)
    {
        if(parent[u]==-1)
        {
            return u;
        }
        
        return parent[u] = Find(parent[u]);
    }
    
    public bool ContainsCycle(char[][] grid) {
        int n = grid.Count();
        int m = grid[0].Count();
        int[] xDir = new int[4]{0,0,1,-1};
        
        int[] yDir = new int[4]{1,-1,0,0};
        
        List<Tuple<int,int>> edges = new List<Tuple<int,int>>();
        int N = n*m;
        
        bool[,] visited = new bool[n,m];
        
        rank = new int[N];
        parent = new int[N];
        
        for(int i=0;i<N;i++)
        {
            parent[i] = -1;
        }
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                int u = m*i+j;
                visited[i,j] = true;
                for(int d = 0;d<4;d++)
                {
                    int x = i+xDir[d];
                    int y = j+yDir[d];
                    if(x<0 || x>=n || y<0 || y>=m || grid[x][y]!=grid[i][j] || visited[x,y]) continue;
                    int v = m*x+y;
                    edges.Add(new Tuple<int,int>(u,v));
                }
            }
        }
        
        int e = edges.Count();
        for(int i=0;i<e;i++)
        {
                int u = edges[i].Item1;
                int v = edges[i].Item2;

                int a = Find(u);
                int b = Find(v);

                if(a==b) return true;

                Union(a,b);
        }
        
        return false;
    }
}