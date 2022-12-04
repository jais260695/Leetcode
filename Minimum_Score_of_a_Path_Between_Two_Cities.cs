public class Solution {
    public int DFS(int u, bool[] visited, List<Tuple<int,int>>[] adjList)
    {
        visited[u] = true;
        
        int result = int.MaxValue;
        
        foreach(Tuple<int,int> ngb in adjList[u])
        {
            int v = ngb.Item1;
            int w = ngb.Item2;
            if(!visited[v])
            { 
                result = Math.Min(result,w);
                result = Math.Min(result,DFS(v,visited,adjList));
            }
            else
            {
                result = Math.Min(result,w);
            }
        }
        return result;
    }
    public int MinScore(int n, int[][] roads) {
        
        List<Tuple<int,int>>[] adjList = new List<Tuple<int,int>>[n];
        
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<Tuple<int,int>>();
        }
        
        foreach(int[] road in roads)
        {
            int u = road[0]-1;
            int v = road[1]-1;
            int w = road[2];
            adjList[u].Add(new Tuple<int,int>(v,w));
            adjList[v].Add(new Tuple<int,int>(u,w));
        }
        
        bool[] visited = new bool[n];
        
        int result = DFS(0,visited,adjList);
        
        return result;
        
    }
}