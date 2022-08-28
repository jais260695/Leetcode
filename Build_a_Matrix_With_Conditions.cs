public class Solution {
    List<int>[] adjList;
    
    bool[] visited;
    Stack<int> st;
    
        
    public void DFS(int u)
    {
        visited[u] = true;
        
        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                DFS(v);
            }
            
        }
        
        st.Push(u);
    }
    
    public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions) {

        
        int[][] result = new int[k][];
        int n = rowConditions.Count();
        int m = colConditions.Count();
        int[] xDir = new int[k];
        int[] yDir = new int[k];
        
        adjList = new List<int>[k];
        visited = new bool[k];
        st = new Stack<int>();

        
        for(int i=0;i<k;i++)
        {
            result[i] = new int[k];
            adjList[i] = new List<int>();
        }
        
        for(int i=0;i<n;i++)
        {
            int u = rowConditions[i][0]-1;
            int v = rowConditions[i][1]-1;
            
            adjList[u].Add(v);
            
        }
        
        
        for(int i=0;i<k;i++)
        {
            if(!visited[i])
            {
                DFS(i);
            }
        } 
        
        int index = 0;
        
        List<int> topoOrder = new List<int>();
      
        while (st.Count() != 0)
        {
            xDir[st.Pop()]= index;
            index += 1;
        }
        
        for(int i=0;i<k;i++)
        {
            foreach(int v in adjList[i])
            {
                if(xDir[v]<xDir[i])
                {
                    return new int[0][];
                }
            }
        }
        
        adjList = new List<int>[k];        
        visited = new bool[k];
        st = new Stack<int>();

        
        for(int i=0;i<k;i++)
        {
            adjList[i] = new List<int>();
        }
        
        for(int i=0;i<m;i++)
        {
            int u = colConditions[i][0]-1;
            int v = colConditions[i][1]-1;
            
            adjList[u].Add(v);

        }
        
        for(int i=0;i<k;i++)
        {
            if(!visited[i])
            {
                DFS(i);
            }
        } 
        
        index = 0;
      
        while (st.Count() != 0)
        {
            yDir[st.Pop()] = index;
            index += 1;
        }
        
        for(int i=0;i<k;i++)
        {
            foreach(int v in adjList[i])
            {
                if(yDir[v]<yDir[i])
                {
                    return new int[0][];
                }
            }
        }
        
        
        for(int i=0;i<k;i++)
        {
            result[xDir[i]][yDir[i]] = i+1;
        }
        
        return result;
    }
}