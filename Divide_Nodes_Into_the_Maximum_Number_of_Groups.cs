public class Solution {
    List<int> connected;
    bool[] visited;

    public void DFS(int u,List<int>[] adjList)
    {
        visited[u] = true;
        connected.Add(u);
        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                DFS(v,adjList);
            }
        }
    }
    public int MagnificentSets(int n, int[][] edges) {
        List<int>[] adjList = new List<int>[n];
        visited = new bool[n];

        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
            
        foreach(int[] edge in edges)
        {
            int u = edge[0]-1;
            int v = edge[1]-1;
            adjList[u].Add(v);
            adjList[v].Add(u);
        }
        
        int  maxGroupCount = 0;
        for(int i=0;i<n;i++)
        {
            if(!visited[i])
            {
                connected = new List<int>();
                DFS(i,adjList);
                int tempResult = 0;
                foreach(int vert in connected)
                {
                    int[] coloring = new int[n];
                    Queue<int> queue = new Queue<int>();                     
                    queue.Enqueue(vert);   
                    int level = 0;  
                    coloring[vert]=1;
                    
                    while(queue.Count()>0)
                    {
                        int size = queue.Count();
                        while(size>0)
                        {
                            int u = queue.Dequeue();
                            foreach(int v in adjList[u])
                            {
                                if(coloring[v]==0)
                                {
                                    queue.Enqueue(v);
                                    coloring[v]=coloring[u]+1;
                                    foreach(int z in adjList[v])
                                    {
                                        if(coloring[z]!=0 && Math.Abs(coloring[v]-coloring[z])!=1)
                                        {
                                            return -1;
                                        }
                                            
                                    }
                                    
                                }
                                else
                                {
                                        if(Math.Abs(coloring[v]-coloring[u])!=1)
                                        {
                                            return -1;
                                        }
                                }
                                
                            }
                            size--;
                        }
                        level++;
                    }

                    tempResult = Math.Max(tempResult,level);
                }
                maxGroupCount+=tempResult;
               
            }
        }
        
        return maxGroupCount<1 ? -1 : maxGroupCount;
    }
}