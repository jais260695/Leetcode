public class Solution {
    Dictionary<int,Queue<int>> adjList;
    Dictionary<int,int> outDegree;
    Dictionary<int,int> inDegree;
    List<int> tempResult = new List<int>();

    int n;
    
    public void DFS(int u)
    {
        
        while(outDegree[u]>0)
        {
            int v = adjList[u].Dequeue();

            outDegree[u]--;

            DFS(v);
        }
        tempResult.Add(u);
         
    }
    
    public int[][] ValidArrangement(int[][] pairs) {
        n = pairs.Count();
        if(n==1) return pairs;
        adjList = new Dictionary<int,Queue<int>>();
        outDegree = new Dictionary<int,int>();
        inDegree = new Dictionary<int,int>();
        int[][] result = new int[n][];
        
        int i = 0;
        for(;i<n;i++)
        {
            int u = pairs[i][0];
            int v = pairs[i][1];
            
            if(!adjList.ContainsKey(u)) 
            {
                adjList.Add(u, new Queue<int>());
            }
            
            if(!outDegree.ContainsKey(u)) 
            {
                outDegree.Add(u,0);
                inDegree.Add(u,0);
            }
            
            if(!inDegree.ContainsKey(v)) 
            {
                outDegree.Add(v,0);
                inDegree.Add(v,0);
            }
            
            adjList[u].Enqueue(v);
            
            outDegree[u]++;
            inDegree[v]++;
            
            
        }

        i = 0;
        for(;i<n;i++)
        {
            int u = pairs[i][0];
            if(outDegree[u]-inDegree[u] == 1)
            {
                DFS(u);
                break;
            }
        }
        
        if(i==n) DFS(pairs[0][0]);
            int index = 0;
        for(i=tempResult.Count()-1;i>0;i--)
        {
            result[index] = new int[2]{tempResult[i],tempResult[i-1]};
            index++;
            
        }
        
        return result;
        
    }
}