public class Solution {
    
    public bool BFS(int[,] graph, int s, int t, int V, int[] parent)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[V];
        queue.Enqueue(s);
        visited[s] = true;
        parent[s] = -1;
        while(queue.Count()>0)
        {
            int u = queue.Dequeue();
            for(int i=0;i<V;i++)
            {
                if(!visited[i] && graph[u,i]==1)
                {
                    visited[i] = true;
                    parent[i] = u;
                    queue.Enqueue(i);
                }
            }
        }
        
        return visited[t];
    }
    public int MaxStudents(char[][] seats) {
        int m = seats.Count();
        int n = seats[0].Count();
        
        int V = m*n+2;
        
        int s = m*n;
        int t = m*n+1;
        
    
        
        int totalSeats=0;
        
        int[,] graph = new int[m*n+2,m*n+2];
        
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                
                if(seats[i][j]=='.')
                {
                    totalSeats++;
                    int v = n*i+j;
                    if(j%2==0)
                    {
                        graph[s,v] = 1;
                        if(j+1<n)
                        {
                            int u = v+1;
                            if(seats[i][j+1]=='.')
                                graph[v,u] = 1;
                            if(i+1<m && seats[i+1][j+1]=='.')
                            {
                                graph[v,u+n]=1;
                            }
                            if(i-1>=0 && seats[i-1][j+1]=='.')
                            {
                                graph[v,u-n]=1;
                            }
                        }
                        if(j-1>=0)
                        {
                            int u = v-1;
                            if(seats[i][j-1]=='.')
                                graph[v,u]=1;
                            if(i+1<m && seats[i+1][j-1]=='.')
                            {
                                graph[v,u+n]=1;
                            }
                            if(i-1>=0 && seats[i-1][j-1]=='.')
                            {
                                graph[v,u-n]=1;
                            }
                        }
                    }
                    else
                    {
                        graph[v,t]=1;
                    }
                }
            }
        }
        
        int[] parent = new int[V];
        for(int i=0;i<V;i++)
        {
            parent[i] = -1;
        }
        while(BFS(graph,s,t,V,parent))
        {
            int i=t;
            while(i!=s)
            {
                graph[parent[i],i]--;
                graph[i,parent[i]]++;
                i=parent[i];
            }
            totalSeats--;
            for(int j=0;j<V;j++)
            {
                parent[j] = -1;
            }
        }
        return totalSeats;
    }
}