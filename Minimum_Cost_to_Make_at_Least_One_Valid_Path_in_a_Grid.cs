public class Solution {
    public class Pair
    {
        public int u;
        public int v;
        public int w;
        public List<Pair> adjList;
        public Pair(int i, int j, int e )
        {
            u = i;
            v = j;
            w = e;
            adjList = new List<Pair>();
        }
    }
   
    public int MinCost(int[][] grid) {
        int res = int.MaxValue;
        int n = grid.Count();
        int m = grid[0].Count();
        int[,] dp = new int[n,m];
        Pair[,] graph = new Pair[n,m];
        
        for(int i = 0;i<n;i++)
        {
            for(int j = 0 ;j<m;j++)
            {
                dp[i,j] = int.MaxValue;
                graph[i,j] = new Pair(i,j,0);
                
                if(grid[i][j]==1)
                {
                    if(j+1<m)
                    {
                        graph[i,j].adjList.Add(new Pair(i,j+1,0));
                    }

                    if(j-1>=0)
                    {
                        graph[i,j].adjList.Add(new Pair(i,j-1,1));
                    }

                    if(i+1<n)
                    {
                        graph[i,j].adjList.Add(new Pair(i+1,j,1));
                    }

                    if(i-1>=0)
                    {
                        graph[i,j].adjList.Add(new Pair(i-1,j,1));
                    }
                }

                else if(grid[i][j]==2)
                {
                    if(j+1<m)
                    {
                        graph[i,j].adjList.Add(new Pair(i,j+1,1));
                    }

                    if(j-1>=0)
                    {
                        graph[i,j].adjList.Add(new Pair(i,j-1,0));
                    }

                    if(i+1<n)
                    {
                        graph[i,j].adjList.Add(new Pair(i+1,j,1));
                    }

                    if(i-1>=0)
                    {
                        graph[i,j].adjList.Add(new Pair(i-1,j,1));
                    }
                }

                else if(grid[i][j]==3)
                {
                    if(j+1<m)
                    {
                        graph[i,j].adjList.Add(new Pair(i,j+1,1));
                    }

                    if(j-1>=0)
                    {
                        graph[i,j].adjList.Add(new Pair(i,j-1,1));
                    }

                    if(i+1<n)
                    {
                        graph[i,j].adjList.Add(new Pair(i+1,j,0));
                    }

                    if(i-1>=0)
                    {
                        graph[i,j].adjList.Add(new Pair(i-1,j,1));
                    }
                }

                else
                {
                    if(j+1<m)
                    {
                        graph[i,j].adjList.Add(new Pair(i,j+1,1));
                    }

                    if(j-1>=0)
                    {
                        graph[i,j].adjList.Add(new Pair(i,j-1,1));
                    }

                    if(i+1<n)
                    {
                        graph[i,j].adjList.Add(new Pair(i+1,j,1));
                    }

                    if(i-1>=0)
                    {
                        graph[i,j].adjList.Add(new Pair(i-1,j,0));
                    }
                }
                
            }
        }  
        
        
        List<Pair> d = new List<Pair>();
        dp[0,0] = 0;
        d.Add(new Pair(0,0,0));
        while(d.Count()>0)
        {
            Pair p = d[0];
            d.RemoveAt(0);
            foreach(Pair adj in graph[p.u,p.v].adjList)
            {
                if(dp[adj.u,adj.v]>adj.w + dp[p.u,p.v])
                {
                    dp[adj.u,adj.v] = adj.w + dp[p.u,p.v];
                    if(adj.w==0)
                    {
                        d.Insert(0,adj);
                    }
                    else
                    {
                        d.Add(adj);
                    }
                }
                
            }
        }
        
        
            
        return dp[n-1,m-1];
    }
}