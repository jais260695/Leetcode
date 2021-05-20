public class Solution {
    public int[] mstLens;
    public int Find(int[] parent, int i)
    {
        while(i!=parent[i])
        {
            i = parent[i];
        }
        return i;
    }
    
    public void Union(int u, int v, int[] parent, int[] rank)
    {
        int x = Find(parent,u);
        int y = Find(parent,v);
        if(rank[x]>rank[y])
        {
            parent[y] = x;
        }
        else if(rank[x]<rank[y])
        {
            parent[x] = y;
        }       
        else
        {
            parent[x] = y;
            rank[y]++;
        }
    }
    
    public int MST(int[][] edges, int[] parent,int[] rank, int type, int index)
    {
        int temp = 0;  
        for(int i=0;i<edges.Count();i++)
        {
            if(edges[i][0]==type)
            {
                int u = Find(parent, edges[i][1]-1);
                int v = Find(parent, edges[i][2]-1);
                if(u==v)
                {
                    temp++;
                }
                else
                {
                    Union(u,v,parent,rank);
                    mstLens[index]++;
                }
            }
        }
        return temp;
    }
    
    public int MaxNumEdgesToRemove(int n, int[][] edges) {
        int[] parentA = new int[n];
        int[] parentB = new int[n];
        int[] rankA = new int[n];
        int[] rankB = new int[n];
        
        mstLens = new int[2];
        
        for(int i=0;i<n;i++)
        {
            parentA[i] = i;
            parentB[i] = i;
        }
        int res = 0;
        res += MST(edges, parentA, rankA, 3, 0);
        MST(edges, parentB, rankB, 3, 1);
        res += MST(edges, parentA, rankA, 1, 0);
        res += MST(edges, parentB, rankB, 2, 1);
        
        if(mstLens[0]!=(n-1) || mstLens[1]!=(n-1))
        {
            return -1;
        }
        return res;
    }
}