public class Solution {
    public void Union(int u, int v, int[] parent)
    {
        parent[u] = v;
    }
    public int Find(int u, int[] parent)
    {
        while(parent[u]!=u)
        {
            u = parent[u];
        }
        return u;
    }
    public int MinSwapsCouples(int[] row) {
        int n = row.Count();
        int[] parent = new int[n];
        
        for(int i=0;i<n;i++)
        {
            parent[i] = i;
        }
        
        for(int i=0;i<n;i+=2)
        {
            int x = Find(row[i],parent);
            int y = Find(row[i+1],parent);
            if(x!=y)
                Union(x,y,parent);
        }
        int result = 0;
        for(int i=0;i<n;i+=2)
        {
            int x = Find(i,parent);
            int y = Find(i+1,parent);
            if(x!=y)
            {
                result++;
                Union(x,y,parent);
            }
        }
        return result;
    }
} 