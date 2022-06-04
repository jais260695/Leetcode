public class Solution {
    public IList<string> WatchedVideosByFriends(IList<IList<string>> watchedVideos, int[][] friends, int id, int level) {
        int n = watchedVideos.Count();
        int m = friends.Count();
        bool[] visited = new bool[m];
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(id);
        visited[id] = true;
        
        int l = 0;
        
        while(queue.Count()>0)
        {
            if(l==level) break;
            int size = queue.Count();
            
            while(size>0)
            {
                int u = queue.Dequeue();
                
                for(int i=0;i<friends[u].Count();i++)
                {
                    int v = friends[u][i];
                    if(!visited[v])
                    {
                        queue.Enqueue(v);
                        visited[v] = true;
                    }
                }
                size--;
            }
            l++;
        }
        
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        while(queue.Count()>0)
        {
            int u = queue.Dequeue();
            foreach(string v in watchedVideos[u])
            {
                if(!dict.ContainsKey(v))
                {
                    dict.Add(v,0);
                }
                dict[v]++;
            }
        }
        
         List<string> result = new List<string>();
        
       foreach(KeyValuePair<string,int> kvp in dict.OrderBy(d=> d.Value).ThenBy(d=>d.Key))
       {
           result.Add(kvp.Key);
       }
        
       return result.ToList<String>();
        
        
    }
}