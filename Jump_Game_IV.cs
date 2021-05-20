public class Solution {
    public int MinJumps(int[] arr) {
        int n = arr.Count();
        if(n==1) return 0;
        Dictionary<int,List<int>> adjList = new Dictionary<int,List<int>>();
        bool[] visited = new bool[n];
        int i = 0;
        for(i=0;i<n;i++)
        {
            if(!(i-1>=0 && i+1<n && arr[i-1]==arr[i] && arr[i+1]==arr[i]))
            {
                if(!adjList.ContainsKey(arr[i]))
                {
                    adjList.Add(arr[i] ,new List<int>());
                }
                adjList[arr[i]].Add(i);
            }   
        }
        
        
        
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0);
        int steps = 0;
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            
            while(size>0)
            {
                int u = queue.Dequeue();
                
                if(u==n-1) return steps;
                
                if(u-1>=0 && !visited[u-1])
                {
                    queue.Enqueue(u-1);
                    visited[u-1] = true;
                }
                
                if(u+1<n && !visited[u+1])
                {
                    queue.Enqueue(u+1);
                    visited[u+1] = true;
                }
                
                foreach(var v in adjList[arr[u]])
                {
                    if(!visited[v])
                    {
                        queue.Enqueue(v);
                        visited[v] = true;
                    }
                }
                
                size--;
            }
            steps++;
        }
        return -1;
    }
}