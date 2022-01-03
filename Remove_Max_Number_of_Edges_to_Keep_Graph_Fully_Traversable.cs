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
    
    public int MST(int[][] edges, int[] parent,int[] rank, int edgeType, int personType)
    {
        //No need to check for E=V-1, as MST will always have V-1 Edges 
        //Adding condition when mstLens length = V-1 will make us avoid some redundant edges
        int redundantEdges = 0;  
        for(int i=0;i<edges.Count();i++)
        {
            if(edges[i][0]==edgeType)
            {
                int u = Find(parent, edges[i][1]-1);
                int v = Find(parent, edges[i][2]-1);
                if(u!=v)
                {
                    Union(u,v,parent,rank);
                    mstLens[personType]++;
                }
                else
                {
                    redundantEdges++;
                }
            }
        }
        return redundantEdges;
    }
    
    public int MaxNumEdgesToRemove(int n, int[][] edges) {
        //Create Two separate MSTs for Alice and Bob
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
        res += MST(edges, parentA, rankA, 3, 0);//Create Alice's MST with common edges and add redundant edges in result
        MST(edges, parentB, rankB, 3, 1);// Create Bob's MST with common edges and avoid adding duplicate redundant edges
        res += MST(edges, parentA, rankA, 1, 0);// Update Alices's MST with Alice Specific Edges and add redundant edges
        res += MST(edges, parentB, rankB, 2, 1);// Update Bob's MST with Bob Specific Edges and add redundant edges
        
        //If MST is not possible for either Alice or Bob, then return -1;
        if(mstLens[0]!=(n-1) || mstLens[1]!=(n-1))
        {
            return -1;
        }
        
        return res;
    }
}