public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        int n = status.Count();
        List<int>[] adjList = new List<int>[n];
        bool[] visited = new bool[n];
        for(int i=0;i<n;i++)
        {
            adjList[i] = new List<int>();
        }
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<containedBoxes[i].Count();j++)
            {
                adjList[i].Add(containedBoxes[i][j]);
            }
        }
        
        int result = 0;
        
        Queue<int> queue = new Queue<int>();
        
        for(int i=0;i<initialBoxes.Count();i++)
        {
                queue.Enqueue(initialBoxes[i]);
                visited[initialBoxes[i]] = true;
        }
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            bool areAllClosed = true;
            while(size>0)
            {
                int currBox = queue.Dequeue();
                if(status[currBox]==0)
                {
                    queue.Enqueue(currBox);
                }
                else
                {
                    areAllClosed = false;
                    result+=candies[currBox];
                    foreach(int unlockBox in keys[currBox])
                    {
                        status[unlockBox] = 1;
                    }
                    foreach(int nextBox in adjList[currBox])
                    {
                        if(!visited[nextBox])
                        {
                            queue.Enqueue(nextBox);
                            visited[nextBox] = true;
                        }
                    }
                }
                size--;
            }
            if(areAllClosed) break;
        }
        
        return result;
    }
}