public class Solution {
    
    public void DFS(int u,bool[] visited,List<int>[] adjList)
    {
        visited[u] = true;
        
        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                DFS(v,visited,adjList);
            }
        }
    }
    
    public int MakeConnected(int n, int[][] connections) {
        int m = connections.Count();
        if(m<n-1) return -1;
        List<int>[] adjList = new List<int>[n];        
        for(int i=0;i<n;i++)
        {
            adjList[i] =  new List<int>();
        }        
        for(int i=0;i<m;i++)
        {
            adjList[connections[i][0]].Add(connections[i][1]);
            adjList[connections[i][1]].Add(connections[i][0]);
        }        
        bool[] visited = new bool[n];        
        int count = 0;
        for(int i=0;i<n;i++)
        {
            if(!visited[i])
            {
                DFS(i,visited,adjList);
                count++;
            }
        }
        return count-1;
    }
}