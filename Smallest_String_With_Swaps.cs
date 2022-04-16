public class Solution {
    List<int> list = new List<int>();
    List<char> cList = new List<char>();
    public void DFS(int u ,string s, bool[] visited, List<int>[] adjList)
    {
        list.Add(u);
        cList.Add(s[u]);
        visited[u] = true;
        
        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                DFS(v, s,visited, adjList);
            }
        }
    }
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs) {
        int n = s.Length;
        int m = pairs.Count();
        List<int>[] adjList=new List<int>[n];
        for(int i=0;i<n;i++){
            adjList[i]=new List<int>();
        }
        for(int i=0;i<m;i++){
            int u=pairs[i][0];
            int v=pairs[i][1];
            adjList[u].Add(v);
            adjList[v].Add(u);
        }
        
        bool[] visited =  new bool[n];
        
                StringBuilder sb = new StringBuilder(s);
        for(int i=0;i<n;i++)
        {
            if(!visited[i])
            {
                DFS(i, s,visited, adjList);                
                list.Sort();        
                cList.Sort();        
                for(int j=0;j<list.Count();j++)
                {
                    sb[list[j]] = cList[j];
                }
                
                list.Clear();
                cList.Clear();
            }
        }
        
        return sb.ToString();
        
            
    }
}