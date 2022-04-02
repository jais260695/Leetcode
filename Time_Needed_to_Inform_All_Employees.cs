public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        
        List<int>[] adjList = new List<int>[n];
        int[] timeList = new int[n];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        
        for(int i=0;i<n;i++)
        {
            if(manager[i]!=-1)
                adjList[manager[i]].Add(i);
        }
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(headID);
        timeList[headID] = informTime[headID];
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            
            while(size>0)
            {
                int u = queue.Dequeue();
                
                foreach(int v in adjList[u])
                {
                    timeList[v] = informTime[v]+timeList[u];
                    queue.Enqueue(v);
                }
                size--;
            }
        }
        
        int result = 0;
        
        for(int i=0;i<n;i++)
        {
             result = Math.Max(result, timeList[i]);
        }
        
        return result;
    }
}