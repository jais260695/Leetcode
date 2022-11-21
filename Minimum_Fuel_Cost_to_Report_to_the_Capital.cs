public class Solution {
    public long MinimumFuelCost(int[][] roads, int seats) {
        int n = roads.Count();
        List<int>[] adjList = new List<int>[100001];
        int[] degree = new int[100001];
        long[] cap = new long[100001];
        
        for(int i=0;i<100001;i++)
        {
            adjList[i] = new List<int>();
            cap[i] = 1;
        }
        
        for(int i=0;i<roads.Count();i++)
        {
            int u = roads[i][0];
            int v = roads[i][1];
            adjList[u].Add(v);
            adjList[v].Add(u);
            degree[u]++;
            degree[v]++;
        }
       
        long result = 0;
        Queue<int> queue = new Queue<int>();
        
        
        for(int i=1;i<100001;i++)
        {
            if(degree[i]==0) break;
            if(degree[i]==1)
            {
                
                queue.Enqueue(i);
                degree[i]--;
            }
            
        }
        
        
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            
            while(size>0)
            {
                int u = queue.Dequeue();
                long r = (long)(Math.Ceiling((double)cap[u]/(double)seats));
                result+=r;
                foreach(int v in adjList[u])
                {
                    if(v!=0 && degree[v]>1)
                    {
                        cap[v]+=cap[u];
                        degree[v]--;
                        if(degree[v]==1)
                        {
                            queue.Enqueue(v);                        
                        }
                        
                    }   
                        
                }

                size--;
            }
        }
        
        return result;
    }
}