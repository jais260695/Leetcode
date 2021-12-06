public class Solution {
    
    public int Find(int[] parent, int u)
    {
        while(parent[u]!=0)
        {
            u = parent[u];
        }
        return u;
    }
    
   
    
    public int[] FindRedundantConnection(int[][] edges) {
        int[] mst = new int[2];
        int[] parent = new int[3000];
        
        for(int i=0;i<edges.Count();i++)
        {
            
            int u = Find(parent,edges[i][0]);
            int v = Find(parent,edges[i][1]);
            
            if(u!=v)
            {
                parent[u] = v;
            }
            else
            {
                mst[0] = edges[i][0];
                mst[1] = edges[i][1];
            }
        }
        
        return mst;
    }
}