public class Solution {
    int[] childrenCount;
    int[] pathSumToChildren;
    bool[] visited;
    void DFSUtility(int u, List<int>[] adjList)
    {
        visited[u] = true;
        
        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                childrenCount[u]++;
                pathSumToChildren[u]++;
                DFSUtility(v,adjList);
                childrenCount[u] += childrenCount[v]; 
                pathSumToChildren[u] += (childrenCount[v] + pathSumToChildren[v]);
            }
        }
    }

    void DFSResult(int u, int parent, List<int>[] adjList, int[] result)
    {
        visited[u] = true;

        result[u] = result[parent] + adjList.Count() - 2*childrenCount[u] - 2;

        foreach(int v in adjList[u])
        {
            if(!visited[v])
            {
                DFSResult(v,u,adjList,result);
            }
        }
    }

    public int[] SumOfDistancesInTree(int n, int[][] edges) {
        childrenCount = new int[n];
        pathSumToChildren = new int[n];
        visited = new bool[n];
        List<int>[] adjList = new List<int>[n];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        foreach(int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            adjList[u].Add(v);
            adjList[v].Add(u);
        }

        DFSUtility(0,adjList);
        
        visited = new bool[n];

        int[] result = new int[n];

        visited[0] = true;
        result[0] = pathSumToChildren[0];

        foreach(int v in adjList[0])
        {
            if(!visited[v])
            {
                DFSResult(v,0,adjList,result);
            }
        }

        return result;
    }
}