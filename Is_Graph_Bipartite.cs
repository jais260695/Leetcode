public class Solution {
    public bool BFS(int[] color, int v, int[][] graph)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(v);
        color[v] = 2;
        while(queue.Count()>0)
        {
            int u = queue.Dequeue();
            int col = 2;
            if(color[u]==2)
                col = 1;
            
            for(int i=0;i<graph[u].Count();i++)
            {
                if(color[graph[u][i]]==0)
                {
                    color[graph[u][i]] = col;
                    queue.Enqueue(graph[u][i]);
                }
                else if(color[graph[u][i]]==color[u])
                {
                    return false;
                }
            }
        }
        return true;
    }
    
    public bool IsBipartite(int[][] graph) {
        int n = graph.Count();
        int[] color = new int[n];
        for(int i=0;i<n;i++)
        {
            if(color[i] == 0)
            {
                if(!BFS(color,i,graph))
                {
                    return false;
                }
            }
        }
        return true;
    }
}