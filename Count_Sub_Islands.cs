public class Solution {
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    bool isSubIsland = false;
    public void Union(int u, int v, int[] parent, int[] rank)
    {
        int x = Find(u,parent);
        int y = Find(v,parent);
        if(x != y)
        {
            if(rank[x] == rank[y])
            {
                rank[y]++;
            }
            else if(rank[x] > rank[y])
            {
                int temp = x;
                x = y;
                y = temp;
            }
            parent[x] = y;
            return ;
        }
        return ;
    }
    public int Find(int u, int[] parent)
    {
        if(u == parent[u])
        {
            return u;
        }
        
        return parent[u] = Find(parent[u],parent);
    }
    
    public void DFS(int u, int v, bool[,] visited, int[][] grid,int[][] refGrid, int[] parent, int[] rank, int n, int m, int N, bool isTest)
    {
        visited[u,v] = true;
        
         if(isTest && refGrid[u][v]==0)
        {
            isSubIsland =  false;
        }
        
        int U = m*u+v;
        
        for(int d=0;d<4;d++)
        {
            int x = u+xDir[d];
            int y = v+yDir[d];
            if(x<0 || x>=n || y<0 || y>=m || grid[x][y]==0 || visited[x,y]) continue;
            int V = m*x+y;
            int X = Find(U,parent);
            int Y = Find(V,parent);
            if(X!=Y)
            {
                if(isTest)
                {
                    isSubIsland =  false;
                }
                else
                {  
                    Union(X,Y,parent,rank);
                }
            }
            DFS(x,y,visited,grid,refGrid,parent,rank,n,m,N,isTest);
        }
    }
    public int CountSubIslands(int[][] grid1, int[][] grid2) {
        int n = grid1.Count();
        int m = grid1[0].Count();
        bool[,] visited = new bool[n,m];
        int N = m*n;
        int[] parent = new int[N];
        int[] rank = new int[N];
        int result = 0;
        
        for(int i=0;i<N;i++)
        {
            parent[i] = i;
        }
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(grid1[i][j]==1 && !visited[i,j])
                {
                    DFS(i,j,visited,grid1,grid2,parent,rank,n,m,N,false);
                }
            }
        }
        

        result = 0;
        visited = new bool[n,m];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                isSubIsland = true;
                if(grid2[i][j]==1 && !visited[i,j])
                {
                    DFS(i,j,visited,grid2,grid1,parent,rank,n,m,N,true);
                    if(isSubIsland)
                    {
                        result++;
                    }
                }
            }
        }
        
        return result;
    }
}