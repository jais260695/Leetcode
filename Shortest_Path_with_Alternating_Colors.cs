public class Solution {
    public class Node {
        public int u;
        public int c;
        public Node(int vertex, int color){
             u = vertex;
             c = color;
        }
    }
    public int[] ShortestAlternatingPaths(int n, int[][] red_edges, int[][] blue_edges) {
        List<int>[] adjBlue = new List<int>[n];
        List<int>[] adjRed = new List<int>[n];
        int[] result = new int[n];
        
        for(int i=0;i<n;i++)
        {
            adjBlue[i] = new List<int>();
            adjRed[i] = new List<int>();
            result[i] = -1;
        }
        
        for(int i=0;i<red_edges.Count();i++)
        {
            int u = red_edges[i][0];
            int v = red_edges[i][1];
            adjRed[u].Add(v);
        }
        
        for(int i=0;i<blue_edges.Count();i++)
        {
            int u = blue_edges[i][0];
            int v = blue_edges[i][1];
            adjBlue[u].Add(v);
        }
        
        int level = 0;
        bool[] visitedBlue = new bool[n];
        bool[] visitedRed = new bool[n];
        
        Queue<Node> queue = new Queue<Node>();
        visitedBlue[0] = true;
        visitedRed[0] = true;
        
        queue.Enqueue(new Node(0,-1));
        result[0] = 0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            level++;
            while(size>0)
            {
                Node temp = queue.Dequeue();
                int u = temp.u;
                int c = temp.c;
                if(c!=0)
                {
                    foreach(int v in adjRed[u])
                    {
                        if(result[v]==-1) result[v] = level;
                        if(!visitedRed[v])
                        {
                            visitedRed[v] = true;
                            queue.Enqueue(new Node(v,0));
                        }
                    }
                }
                if(c!=1)
                {
                    foreach(int v in adjBlue[u])
                    {
                        if(result[v]==-1) result[v] = level;
                        if(!visitedBlue[v])
                        {
                            visitedBlue[v] = true;
                            queue.Enqueue(new Node(v,1));
                        }
                    }
                }
                size--;
            }
        }
        
        return result;
    }
}