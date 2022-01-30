public class Solution {
    public bool BFS(int[] color, int v, List<int>[] graph)
    {
        Queue<int> queue = new Queue<int>();
        int colorS = 1;
        color[v] = colorS;
        queue.Enqueue(v);
        while(queue.Count()>0)
        {
            colorS = colorS == 1 ? 2 : 1;
            int size = queue.Count();
            
            while(size>0)
            {
                int u = queue.Dequeue();
                
                foreach(int vert in graph[u])
                {
                    if(color[vert]==0)
                    {
                        color[vert] = colorS;
                        queue.Enqueue(vert);
                    }
                    else
                    {
                        if(color[vert]!=colorS) return false;
                    }
                }
                size--;
            }
        }
        return true;
    }
    public bool PossibleBipartition(int N, int[][] dislikes) {
        int[] color = new int[N];
        List<int>[] graph = new List<int>[N];
        for(int i=0;i<N;i++)
        {
            graph[i] = new List<int>();
        }
        for(int i=0;i<dislikes.Count();i++)
        {
            graph[dislikes[i][0]-1].Add(dislikes[i][1]-1);
            graph[dislikes[i][1]-1].Add(dislikes[i][0]-1);
        }
        for(int i=0;i<N;i++)
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