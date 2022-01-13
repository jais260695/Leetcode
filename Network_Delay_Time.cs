public class Solution {
    public class Pair
    {
        public int V;
        public int W;
        public Pair(int v, int w)
        {
            V=v;
            W=w;
        }
        
    }
    
    public Pair ExtractMin(List<Pair> minHeap)
    {
        if(minHeap.Count()==1)
        {
            Pair result = minHeap[0];
            minHeap.RemoveAt(0);
            return result;
        }
        Pair minimum = minHeap[0];
        minHeap[0] = minHeap[minHeap.Count()-1];
        minHeap.RemoveAt(minHeap.Count()-1);
        MinHeapify(minHeap,0);
        return minimum;
    }
    
    public void MinHeapify(List<Pair> minHeap, int i)
    {
        int smallest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        
        if(left<minHeap.Count() && minHeap[left].W<minHeap[smallest].W)
        {
            smallest = left;
        }
        if(right<minHeap.Count() && minHeap[right].W<minHeap[smallest].W)
        {
            smallest = right;
        }
        if(i!=smallest)
        {
            Pair temp = minHeap[i];
            minHeap[i]=minHeap[smallest];
            minHeap[smallest]=temp;
            MinHeapify(minHeap,smallest);
        }
        
    }
    
    public void InsertKey(List<Pair> minHeap, Pair p )
    {
        minHeap.Add(p);
        int i= minHeap.Count()-1;
        int parent = Parent(i);
        while(i!=0 && minHeap[parent].W > minHeap[i].W)
        {
            Pair temp = minHeap[i];
            minHeap[i]=minHeap[parent];
            minHeap[parent]=temp;
            i=parent;
            parent = Parent(i);
        }
    }
    
    public int Parent(int i)
    {
        return (i-1)/2;
    }
    
    public int NetworkDelayTime(int[][] times, int N, int K) {
        List<Pair>[] graph = new List<Pair>[N];
        bool[] visited = new bool[N];
        List<int> dist = new List<int>();
        List<Pair> minHeap = new List<Pair>();
        for(int i=0;i<N;i++)
        {
            dist.Add(int.MaxValue);
            graph[i] = new List<Pair>();
        }
        for(int i=0;i<times.Count();i++)
        {
            graph[times[i][0]-1].Add(new Pair(times[i][1]-1,times[i][2]));     
        }
        int result = 0;
        minHeap.Add(new Pair(K-1,0));
        dist[K-1] = 0;
        
        for(int i=0;i<times.Count();i++)
        {
            if(minHeap.Count()==0) break;
            Pair pair = ExtractMin(minHeap);
            int u=pair.V;
            
            visited[u]=true;
            foreach(Pair p in graph[u])
            {
                
                if(!visited[p.V] && dist[p.V]>dist[u]+p.W)
                {    
                    dist[p.V] = dist[u]+p.W;
                    InsertKey(minHeap, new Pair(p.V,dist[p.V]));
                }
            }   
        }
        if(dist.Contains(int.MaxValue))
        {
            return -1;
        }
        return dist.Max();
    }
}