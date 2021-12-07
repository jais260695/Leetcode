public class Solution {
    
    public class Edges
    {
        public int u;
        public int v;
        public int w;
        
        public Edges(int i,int j, int k)
        {
            u = i;
            v = j;
            w = k;
        }
    }
    
    public int Find(int i, int[] parent)
    {
        if(parent[i]==-1)
        {
            return i;
        }
        return parent[i] = Find(parent[i],parent);
    }
    
    public void Union(int i, int j, int[] parent,int[] rank)
    {
        if(rank[i]<=rank[j])
        {
            parent[i] = j;
        }
        else if (rank[i]>rank[j])
        {
            parent[j] = i;
        }
        if(rank[i]==rank[j])
        {
            rank[j]++;
        }
    }
    
    public int MinCostConnectPoints(int[][] points) {
        
        int V = points.Count();
        List<Edges> graph = new List<Edges>();
        int[] parent = new int[V];
        int[] rank = new int[V];
        int i;        
        for(i = 0;i<V-1;i++)
        {
            parent[i] = -1;
            for(int j=i+1;j<V;j++)
            {
                int dist = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                graph.Add(new Edges(i,j,dist));
                graph.Add(new Edges(j,i,dist));
            }
        }
        
        parent[V-1] = -1;
        
        graph.Sort(delegate(Edges x, Edges y)
        {
            return x.w.CompareTo(y.w);
        });
   
        int E = graph.Count();
        
        int e = 0;
        i = 0;
        
        int result = 0;
        
        while(e<V-1 && i<E)
        {
            int x = Find(graph[i].u, parent);
            int y = Find(graph[i].v, parent);
            
            if(x!=y)
            {
                Union(x,y,parent,rank);
                result+=graph[i].w;
                e++;
            }
            i++;
        }
        
        return result;
    }
}