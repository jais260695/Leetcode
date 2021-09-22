public class Solution {
    public class Pair
    {
        public int v;
        public int w;
        public Pair(int ver,int wgt)
        {
            v = ver;
            w = wgt;
        }
    }
    public int[] dist;
    public List<int> heap;
    public int heapSize;
    public List<Pair>[] adjList;
    public int[] dp;
    public bool[] visited;
    public int mod = 1000000007;
    public void Swap(int x, int y)
    {
        int temp = heap[x];
        heap[x] = heap[y];
        heap[y] = temp;
    }
    public void MinHeapify(int i)
    {
        int smallest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left<heapSize && dist[heap[smallest]]>dist[heap[left]])
        {
            smallest = left;
        }
        if(right<heapSize && dist[heap[smallest]]>dist[heap[right]])
        {
            smallest = right;
        }
        if(i!=smallest)
        {
            Swap(i,smallest);
            MinHeapify(smallest);
        }
    }
    public void InsertKey(int val)
    {
        int i = heapSize;
        if(!heap.Contains(val))
        {
            heap.Add(val);
            heapSize++;
        }
        else
        {
            i = heap.IndexOf(val);
        }
        int parent = (i-1)/2;
        while(i!=0 && dist[heap[parent]]>dist[heap[i]])
        {
            Swap(i,parent);
            i = parent;
            parent = (i-1)/2;
        }
    }
    public int ExtractMin()
    {
        heapSize--;
        int val = heap[0];
        Swap(0,heapSize);
        heap.RemoveAt(heapSize);
        MinHeapify(0);
        return val;
    }
    public int CountPath(int u, int n)
    {
        if(u==n-1) return 1;
        if(dp[u]!=-1) return dp[u];
        int ans = 0;
        foreach(Pair p in adjList[u])
        {
            int v = p.v;
            if(!visited[v] && dist[v]<dist[u])
            {
                visited[v] = true;
                ans= (ans + CountPath(v,n))%mod;
                visited[v] = false;
            }
        }
        return dp[u]=ans;
    }
    public int CountRestrictedPaths(int n, int[][] edges) {
        dist = new int[n];
        heap = new List<int>();
        heapSize = 0;
        adjList = new List<Pair>[n];
        visited = new bool[n];
        dp = new int[n];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<Pair>();
            dist[i] = int.MaxValue;
            dp[i] = -1;
        }
        int m = edges.Count();
        for(int i=0;i<m;i++)
        {
            int u = edges[i][0]-1;
            int v = edges[i][1]-1;
            int w = edges[i][2];
            adjList[u].Add(new Pair(v,w));
            adjList[v].Add(new Pair(u,w));
        }
        dist[n-1] = 0;
        InsertKey(n-1);
        int j =0;
        while(j<n-1)
        {
            int u = ExtractMin();
            visited[u] = true;
            foreach(Pair p in adjList[u])
            {
                int v = p.v;
                int w = p.w;
                if(!visited[v])
                {
                    if(dist[v]>dist[u]+w)
                    {
                        dist[v] = dist[u]+w;
                        InsertKey(v);
                    }
                }
            }
            j++;
        }
        visited = new bool[n];
        visited[0] = true;
        return CountPath(0,n);
    }
}