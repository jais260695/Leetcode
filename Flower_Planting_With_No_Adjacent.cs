public class Solution {
    public int[] GardenNoAdj(int N, int[][] paths) {
        List<int>[] adjList = new List<int>[N];
        bool[] visited =  new bool[N];
        int n = paths.Count();
        int[] result = new int[N];
        for(int i=0;i<N;i++)
        {
            adjList[i]=new List<int>();
        }
        for(int i=0;i<n;i++)
        {
            adjList[paths[i][0]-1].Add(paths[i][1]-1);
            adjList[paths[i][1]-1].Add(paths[i][0]-1);
        }
        
        for(int vertex=0;vertex<N;vertex++)
        {
            if(!visited[vertex])
            {
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(vertex);
                visited[vertex] = true;
                while(queue.Count()>0)
                {
                    int u = queue.Dequeue();
                    List<int> color = new List<int>();
                    foreach(int v in adjList[u])
                    {
                        color.Add(result[v]);
                        if(!visited[v])
                        {
                            visited[v] = true;
                            queue.Enqueue(v);
                        }
                    }
                    for(int i=1;i<=4;i++)
                    {
                        if(!color.Contains(i))
                        {
                            result[u] = i;
                            break;
                        }
                    }
                }
            }
        }
        return result;
    }
}