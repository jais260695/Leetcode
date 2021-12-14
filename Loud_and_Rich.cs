public class Solution {
    public int[] result;
    
    public void DFS(int u, List<int>[] adjList, int[] quiet,bool[] visited)
    {
        visited[u] = true;
        result[u] = u;
        foreach(var v in adjList[u])
        {
            if(!visited[v])
            {
                DFS(v,adjList,quiet,visited);
            }
            if(quiet[result[u]]>=quiet[result[v]])
                    result[u] = result[v];
        }
    }
    
    public int[] LoudAndRich(int[][] richer, int[] quiet) {
        int n = quiet.Count();
        int m = richer.Count();
        List<int>[] adjList = new List<int>[n];      
        bool[] visited =  new bool[n];
        
        for(int i = 0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        
        for(int i = 0;i<m;i++)
        {
            adjList[richer[i][1]].Add(richer[i][0]);
        }
        
        result = new int[n];
        for(int i = 0;i<n;i++)
        {
            if(!visited[i])
            {
                DFS(i,adjList,quiet,visited);
            }
        }        
        
        return result;
    }
}