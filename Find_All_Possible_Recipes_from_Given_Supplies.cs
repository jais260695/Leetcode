public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        Dictionary<string,List<string>> adjList = new Dictionary<string,List<string>>();
        Dictionary<string,int> inDegree = new Dictionary<string,int>();
        
        int n = recipes.Count();
        HashSet<string> suppliesMap = new HashSet<string>(supplies);        
        
        for(int i=0;i<n;i++)
        {
            string u = recipes[i];
            inDegree.Add(u,0);
            
            foreach(string v in ingredients[i])
            {
                if(!suppliesMap.Contains(v))
                {
                    if(!adjList.ContainsKey(v))
                    {
                        adjList.Add(v,new List<string>());
                    }
                    adjList[v].Add(u);
                    inDegree[u]++;
                }
            }
        }
        
        
        
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();
        
        for(int i=0;i<n;i++)
        {
            string u = recipes[i];
            if(inDegree[u]==0)
            {
                queue.Enqueue(u);
            }
        }
        
        
        while(queue.Count()>0)
        {
            string u = queue.Dequeue();
            
            result.Add(u);
            
            if(!adjList.ContainsKey(u)) continue;
            
            foreach(string v in adjList[u])
            {
                inDegree[v]--;
                if(inDegree[v]<=0)
                {
                    queue.Enqueue(v);
                }
            }
        }
        
        return result.ToList<string>();
    }
}