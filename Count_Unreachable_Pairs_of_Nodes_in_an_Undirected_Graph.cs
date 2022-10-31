public class Solution {
    /*int[] parent;
    int[] rank;
    public int Find(int u)
    {
        if(u==parent[u])
        {
            return u;
        }
        
        return parent[u] = Find(parent[u]);
    }
    
    public void Union(int u, int v)
    {
        int x = Find(u);
        int y = Find(v);
        
        if(rank[x]>rank[y])
        {
            parent[y] = x;
        }
        else if(rank[y]<rank[x])
        {
            parent[x] = y;
        }
        else
        {
            parent[x] = y;
            rank[y]++;
        }
    }*/
    
    bool[] visited;
    List<int>[] adjList;
    
    int DFS(int u)
    {
        visited[u] = true;
        
        int count = 1;
        
        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                count+=DFS(v);
            }
        }
        
        return count;
    }
    
    public long CountPairs(int n, int[][] edges) {
        
        int m = edges.Count();
        /*parent = new int[n];
        rank = new int[n];
        
        for(int i=0;i<n;i++)
        {
            parent[i] = i;
        }
        
        
        for(int i=0;i<m;i++)
        {
            int u = edges[i][0];
            int v = edges[i][1];
            
            int x = Find(u);
            int y = Find(v);
            
            if(x!=y)
            {
                Union(x,y);
            }
        }*/
        
        visited = new bool[n];
        adjList = new List<int>[n];
        
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        
        
        for(int i=0;i<m;i++)
        {
            int u = edges[i][0];
            int v = edges[i][1];
            
            adjList[u].Add(v);
            adjList[v].Add(u);
        }      
        
        List<int> connectedComp = new List<int>();
        
        for(int i=0;i<n;i++)
        {
            if(!visited[i])
            {
                connectedComp.Add(DFS(i));
            }
        }
        
        
        long result = 0;
        
        int sum = n;
        
        foreach(int val in connectedComp)
        {
            result += ((long)val * (long)(sum-val));
            
            sum-=val;
        }
        
        return result;
    }
}