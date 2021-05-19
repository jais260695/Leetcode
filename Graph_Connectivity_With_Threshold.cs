public class Solution {
    public int[] parent;
    public int[] rank;
    public int Find(int u)
    {
        if(parent[u]==-1) return u;
        return parent[u] = Find(parent[u]);
    }
    public void Union(int u, int v)
    {
        int x = Find(u);
        int y = Find(v);
        if(x!=y)
        {
            if(rank[x]<rank[y])
            {
                int temp = x;
                x = y;
                y = temp;
            }
            if(rank[x]==rank[y])
            {
                rank[x]++;
            }
            
            parent[y] = x;
        }
        
    }
    public IList<bool> AreConnected(int n, int threshold, int[][] queries) {
        parent = new int[n+1];
        rank = new int[n+1];
        for(int i=1;i<=n;i++)
        {
            parent[i] = -1;
        }
        
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=Math.Sqrt(n);j++)
            {
                if(i!=j && i%j==0)
                {
                    if(j>threshold)
                        if(!dict.ContainsKey(j))
                        {
                            dict.Add(j,i);
                        }
                        else
                        {
                            Union(i,dict[j]);
                        }
                    if(i/j>threshold)
                        if(!dict.ContainsKey(i/j))
                        {
                            dict.Add(i/j,i);
                        }
                        else
                        {
                            Union(i,dict[i/j]);
                        }
                    
                }
            }
            if(i>threshold)
            if(!dict.ContainsKey(i))
            {
                dict.Add(i,i);
            }
            else
            {
                Union(i,dict[i]);
            }
        }
        
        int m = queries.Count();
        List<bool> result = new List<bool>();
        for(int i=0;i<m;i++)
        {
            if(Find(queries[i][0])==Find(queries[i][1]))
            {
                result.Add(true);
            }
            else{
                result.Add(false);
            }
        }
        return result.ToList<bool>();
    }
}