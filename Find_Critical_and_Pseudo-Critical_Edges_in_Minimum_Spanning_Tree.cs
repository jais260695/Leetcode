public class Solution {
    
    public class Comp:IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return a[2]-b[2];
        }
    }
    
    public int Find(int[] parent, int i)
    {
        while(parent[i]!=-1)
        {
            i = parent[i];
        }
        return i;
    }
    
    public void Union(int[] parent, int[] rank, int x, int y)
    {
        int u = Find(parent,x);
        int v = Find(parent,y);
        if(rank[u]==rank[v])
        {
            parent[v] = u;
            rank[u]++;
        }
        else if(rank[u]<rank[v])
        {
            parent[u] = v;
        }
        else
        {
            parent[v] = u;
        }
    }
    
    public int KruskalsMST(int n,int[][] edges,int[] include,int[] exclude)
    {
        
        int[] parent = new int[n];
        int[] rank = new int[n];
        for(int k=0;k<n;k++)
        {
            parent[k] = -1;
        }
        int E = edges.Count();
        int i = 0;
        int min = 0;
        if(include!=null)
        {
            int x = Find(parent,include[0]);
            int y = Find(parent,include[1]);
            if(x!=y)
            {
                Union(parent,rank,include[0],include[1]);
                min+=include[2];
                i++;
            }
        }
        for(int e=0;e<E && i<n-1;e++)
        {
            if(exclude!=null && (edges[e][0]==exclude[0] && edges[e][1]==exclude[1])) continue;
            
            int x = Find(parent,edges[e][0]);
            int y = Find(parent,edges[e][1]);
            if(x!=y)
            {
                Union(parent,rank,edges[e][0],edges[e][1]);
                min+=edges[e][2];
                i++;
            }
            
        }
        return i==n-1?min:int.MaxValue;
    }
    
    public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges) {
        int m = edges.Count();
        
        List<List<int>> result = new List<List<int>>();
        List<int> critical = new List<int>();
        List<int> pseudoCritical = new List<int>();
        int[][] newEdges = new int[m][];
        Array.Copy(edges,newEdges,m);
        Array.Sort(newEdges,new Comp());
        int min = KruskalsMST(n,newEdges,null,null);
        for(int i=0;i<m;i++)
        {
            
            int v = KruskalsMST(n,newEdges,null,edges[i]);
            if(v>min)
            {
                critical.Add(i);
            }
            else
            {
                v = KruskalsMST(n,newEdges,edges[i],null);
                if(v==min)
                {
                    pseudoCritical.Add(i);
                }
            }
               
        }
        result.Add(critical);
        result.Add(pseudoCritical);
        return result.ToList<IList<int>>();
    }
}