public class Solution {
    public bool IsPossible(int n, IList<IList<int>> edges) {
        List<int>[] adjList = new List<int>[n];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        foreach(List<int> edge in edges)
        {
            int u = edge[0]-1;
            int v= edge[1]-1;
            
            adjList[v].Add(u);
            adjList[u].Add(v);
        }
        
        List<int> oddDegreeNodes = new List<int>();
        
        for(int i=0;i<n;i++)
        {
            if(adjList[i].Count()%2==1)
            {
                oddDegreeNodes.Add(i);
            }
        }
        
        if(oddDegreeNodes.Count()==0) return true;
        
        if(oddDegreeNodes.Count()==2)
        {
            int u = oddDegreeNodes[0];
            int v = oddDegreeNodes[1];
            if(!adjList[u].Contains(v)) return true;
            for(int i=0;i<n;i++)
            {
                if(!adjList[u].Contains(i) && !adjList[v].Contains(i)) return true;
            }
            
            return false;
        }
        
        
        if(oddDegreeNodes.Count()==4)
        {
            int u = oddDegreeNodes[0];
            int v = oddDegreeNodes[1];
            int w = oddDegreeNodes[2];
            int x = oddDegreeNodes[3];
            
  
            if( (!adjList[u].Contains(v) && !adjList[w].Contains(x)) || (!adjList[u].Contains(w) && !adjList[v].Contains(x))|| (!adjList[u].Contains(x) && !adjList[w].Contains(v))) return true;
            
            return false;
        }
        
        return false;
            
    }
}