public class Solution {
    public bool CanReach(int[] arr, int start) {
        int n = arr.Count();
        List<int>[] adjList = new List<int>[n];
        
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        
        for(int i=0;i<n;i++)
        {
            int j = i+arr[i];
            if(j < n)
            {
                adjList[i].Add(j);
            }
            
            j = i-arr[i];
            if(j >= 0)
            {
                adjList[i].Add(j);
            }
        }
        
        bool[] visited = new bool[n];
        
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;
        
        while(queue.Count()>0)
        {
            int u = queue.Dequeue();
            
            if(arr[u]==0)
            {
                return true;
            }
            
            foreach(var v in adjList[u])
            {
                if(!visited[v])
                {
                    visited[v] = true;
                    queue.Enqueue(v);
                }
            }
        }
        
        return false;      
    }
}