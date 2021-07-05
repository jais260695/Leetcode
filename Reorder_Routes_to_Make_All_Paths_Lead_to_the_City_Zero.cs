public class Solution {
    List<int>[] adjListForward,adjListBackWard;
    bool[] visited;
    int reverseCount = 0;
    public void DFS(int u)
    {
        visited[u] = true;
        foreach(int v in adjListForward[u])
        {
            if(!visited[v])
            {
                reverseCount++;
                DFS(v);
            }
        }
        
        foreach(int v in adjListBackWard[u])
        {
            if(!visited[v])
                DFS(v);
        }
        
    }
    public int MinReorder(int n, int[][] connections) {
        adjListForward = new List<int>[n];
        adjListBackWard = new List<int>[n];
        visited = new bool[n];
        for(int i=0;i<n;i++)
        {
            adjListForward[i] = new List<int>();
            adjListBackWard[i] = new List<int>();
        }
        
        for(int i=0;i<n-1;i++)
        {
            adjListForward[connections[i][0]].Add(connections[i][1]);
            adjListBackWard[connections[i][1]].Add(connections[i][0]);
        }
        
        DFS(0);
        return reverseCount;
    }
}