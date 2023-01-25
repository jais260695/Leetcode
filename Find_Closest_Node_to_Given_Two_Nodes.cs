public class Solution {
    int[] adjList;
    bool[] visited;
    int[] dist;
    bool flag;
    int minDist = int.MaxValue;
    int result = int.MaxValue;
    public void DFS(int u, int count)
    {
        visited[u] = true;
        if(!flag) 
        {
            dist[u] = count;
        }
        else if(dist[u]!=-1)
        {
            int temp = Math.Max(dist[u],count);
            if(minDist>=temp)
            {
                if(minDist==temp)
                {
                    result = Math.Min(result,u);
                }
                else
                {
                    minDist = temp;
                    result = u;
                }
            }
        }

        if(adjList[u]!=-1 && !visited[adjList[u]])
        {
            DFS(adjList[u],count+1);
        }
    }
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        int n = edges.Count();
        adjList = new int[n];
        dist = new int[n];
        for(int i=0;i<n;i++)
        {
            dist[i] = -1;
            adjList[i] = edges[i];
        }

        visited = new bool[n];
 
        flag = false;
        DFS(node1,0);

        visited = new bool[n];
        flag = true;
        DFS(node2,0);

        return result==int.MaxValue ? -1 : result;
    }
}