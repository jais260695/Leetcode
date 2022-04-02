public class Solution {
    public class Node
    {
        public int v;
        public int w;
        public Node(int V, int W)
        {
            v = V;
            w = W;
        }
    }
    
    public List<int> minHeap = new List<int>();
    public int heapSize = 0;
    public long[] dist;
    public void InsertMin(int val)
    {
        int i = -1;
        if(minHeap.Contains(val))
        {
            i = minHeap.IndexOf(val);
        }
        else
        {
            minHeap.Add(val);
            i = heapSize++;
        }
        
        
        int parent = (i-1)/2;
        
        while(i > 0 && dist[minHeap[parent]] > dist[minHeap[i]])
        {
            int temp = minHeap[i];
            minHeap[i] = minHeap[parent];
            minHeap[parent] = temp;
            
            i = parent;
            parent = (i-1)/2;
        }
    }
    public void MinHeapify(int i)
    {
        int smallest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left < heapSize && dist[minHeap[left]] < dist[minHeap[smallest]])
        {
            smallest = left;
        }
        
        if(right < heapSize && dist[minHeap[right]] < dist[minHeap[smallest]])
        {
            smallest = right;
        }
        
        if(smallest != i)
        {
            int temp = minHeap[i];
            minHeap[i] = minHeap[smallest];
            minHeap[smallest] = temp;
            MinHeapify(smallest);
        }
    }
    public int ExtractMin()
    {
        int min = minHeap[0];
        minHeap[0] = minHeap[heapSize-1];
        minHeap.RemoveAt(heapSize-1);
        heapSize--;
        
        MinHeapify(0);
        
        return min;
    }
    public int CountPaths(int n, int[][] roads) {
        List<Node>[] adj = new List<Node>[n];
        dist = new long[n];
        bool[] visited = new bool[n];
        int[] parent = new int[n];
        int mod = 1000000007;
        
        for(int i=0;i<n;i++)
        {
            adj[i] = new List<Node>();
            dist[i] = long.MaxValue;
        }
        
        foreach(var road in roads)
        {
            int u = road[0];
            int v = road[1];
            int w = road[2];
            
            adj[u].Add(new Node(v,w));
            adj[v].Add(new Node(u,w));
        }
        
        parent[0] = 1;
        dist[0] = 0;
        InsertMin(0);
        
        int index = 0;
        while(index<n-1)
        {
            int u = ExtractMin();
            visited[u] = true;
            foreach(var ngb in adj[u])
            {
                int v = ngb.v;
                int w = ngb.w;
                if(!visited[v] && dist[v]>=dist[u]+w)
                {
                    
                    if(dist[v]==dist[u]+w)
                    {
                        parent[v] = (parent[v] + parent[u])%mod;
                    }
                    else
                    {
                        dist[v] = dist[u]+w;
                        parent[v] = parent[u];
                        InsertMin(v);
                    }
                }
            }
            index++;
        }
        return parent[n-1];
        
    }
}