public class Solution {
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson) {
        int m = meetings.Count();
        
        List<Tuple<int,int>>[] graph = new List<Tuple<int,int>>[n];
        bool[] visited = new bool[n];
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
        
        for(int i=0;i<n;i++)
        {
            graph[i] = new List<Tuple<int,int>>();
        }
        
        for(int i=0;i<m;i++)
        {
            int u = meetings[i][0];
            int v = meetings[i][1];
            int t = meetings[i][2];
            
            graph[u].Add(new Tuple<int,int>(v,t));
            graph[v].Add(new Tuple<int,int>(u,t));
        }
        
        pq.Enqueue(0,0);
        pq.Enqueue(firstPerson,0);
        
        
        List<int> result = new List<int>();
        
        while(pq.TryDequeue(out int u, out int time))
        {
            if(visited[u]) continue;
            visited[u] = true;
            result.Add(u);

            foreach(Tuple<int,int> vTemp in graph[u])
            {
                int v = vTemp.Item1;
                int t = vTemp.Item2;
                if(t>=time && !visited[v])
                {
                    pq.Enqueue(v,t);
                }
            }
        }
        
        
        
        return result.ToList<int>();
    }
}