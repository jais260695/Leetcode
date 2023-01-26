public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        int[,] graph = new int[n,n];
        int[,] dist = new int[n,K+2];    

        for(int i=0;i<n;i++)
        {
            for(int j=0;j<=(K+1);j++)
            {
                dist[i,j] = int.MaxValue;
            }
        }
         
        foreach(int[] flight in flights)
        {
            graph[flight[0],flight[1]] = flight[2];
        }
        dist[src,0] = 0;
        
        PriorityQueue<Tuple<int,int>,int> pq = new PriorityQueue<Tuple<int,int>,int>();
        
        pq.Enqueue(new Tuple<int,int>(src,0),dist[src,0]);
        int result = int.MaxValue;
        int index = 0;
        while(pq.Count>0)
        {
            Tuple<int,int> temp = pq.Dequeue();

            int u = temp.Item1;
            int k = temp.Item2;

            if(u==dst)
            {
                result = Math.Min(result,dist[u,k]);
            }

            for(int v = 0; v<n; v++)
            {
                if(graph[u,v]!=0)
                { 
                    if(k<(K+1) && dist[v,k+1]>dist[u,k]+graph[u,v])
                    {
                        dist[v,k+1] = dist[u,k]+graph[u,v];
                        pq.Enqueue(new Tuple<int,int>(v,k+1),dist[v,k+1]);
                    }
                }
            }
            index++;
        }        
        
        return result==int.MaxValue ? -1 : result;
    }
}