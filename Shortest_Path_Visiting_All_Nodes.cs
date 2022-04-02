public class Solution {
    public int ShortestPathLength(int[][] graph) {
        int n = graph.Count();
        List<int>[] adjList = new List<int>[n];
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
        int target  = (int)Math.Pow(2,n)-1;//i.e; if n=3 then target = 111 (7)
        
        bool[,] visited = new bool[n,target+1];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
            foreach(int v in graph[i])
            {
                adjList[i].Add(v);
            }
            
            int mask = 1<<i;
            queue.Enqueue(new Tuple<int,int>(i,mask));
            visited[i,mask] = true;
        }
        
        
        int level = 0;
        while(queue.Count>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Tuple<int,int> t = queue.Dequeue();
                int u = t.Item1;
                int mask = t.Item2;
                if(mask==target) return level;
                foreach(int v in  adjList[u])
                {
                    int newMask = mask|(1<<v);
                    if(!visited[v,newMask])
                    {
                        queue.Enqueue(new Tuple<int,int>(v,newMask));
                        visited[v,newMask] = true;
                    }
                }
                size--;
            }
            level++;
        }
        return -1;
    }
}