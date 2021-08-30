public class Solution {
    public class Node
    {
        public int cost;
        public int time;
        public int vertex;
        public Node(int v,int c, int t)
        {
            cost = c;
            time = t;
            vertex = v;
        }
    }
    
    public class Edge
    {
        public int time;
        public int vertex;
        public Edge( int v, int t)
        {
            time = t;
            vertex = v;
        }
    }
    
    List<Node> minHeap = new List<Node>();
    List<Edge>[] adjList;
    List<int> cost;
    List<int> time;
    int heapSize = 0;
    int noOfVertices;
    int noOfEdges;
    
    public bool IsSmaller(int i, int j)
    {
        return minHeap[i].cost<minHeap[j].cost || 
               (
                   minHeap[i].cost==minHeap[j].cost &&
                   minHeap[i].time<minHeap[j].time
               );
    }
    
    public void Swap(int i, int j)
    {
        Node temp = minHeap[i];
        minHeap[i] = minHeap[j];
        minHeap[j] = temp;
    }   
    
    public void MinHeapify(int i)
    {
        int smallest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        
        if(left<heapSize && IsSmaller(left,smallest))
        {
            smallest = left;
        }
        
        if(right<heapSize && IsSmaller(right,smallest))
        {
            smallest = right;
        }
        
        if(smallest!=i)
        {
            Swap(i,smallest);
            MinHeapify(smallest);
        }
    }
    
    public Node ExtractMin()
    {
        heapSize--;
        Node min = minHeap[0];
        Swap(0,heapSize);
        minHeap.RemoveAt(heapSize);
        MinHeapify(0);
        return min;
    }
    
    public void InsertKey(int t, int c,int key)
    {
        time[key] = t;
        cost[key] = c;
        minHeap.Add(new Node(key,c,t));
        int i = heapSize;
        heapSize++;
        int parent = (i-1)/2;
        while(i!=0 && IsSmaller(i,parent))
        {
            Swap(i,parent);
            i = parent;
            parent = (i-1)/2;
        }
    }
    
    public int  DijikstraAlgo(int maxTime,int[] passingFees)
    {
        while(heapSize>0)
        {
            Node minNode = ExtractMin();
            int u = minNode.vertex;
            int t = minNode.time;
            int c = minNode.cost;
            if(u==passingFees.Count()-1) return c;

            foreach(Edge e in adjList[u])
            {
                int v = e.vertex;
                if(t+e.time<=maxTime && ( cost[v] > c + passingFees[v]  || time[v] > t+e.time) )
                {
                       InsertKey(t+e.time,passingFees[v]+c,v);
                }
            }
        }
        return -1;
    }
    
    public int MinCost(int maxTime, int[][] edges, int[] passingFees) {
        noOfVertices = passingFees.Count();
        adjList = new List<Edge>[noOfVertices];
        cost = new List<int>();
        time = new List<int>();
        for(int v=0;v<noOfVertices;v++)
        {
            adjList[v] = new List<Edge>();
            cost.Add(int.MaxValue);
            time.Add(int.MaxValue);
        }
        
        noOfEdges = edges.Count();
        for(int e=0;e<noOfEdges;e++)
        {
            int u=edges[e][0];
            int v=edges[e][1];
            int t=edges[e][2];
            adjList[u].Add(new Edge(v,t));
            adjList[v].Add(new Edge(u,t));
        }
        InsertKey(0,passingFees[0],0);
        return DijikstraAlgo(maxTime,passingFees);
    }
}