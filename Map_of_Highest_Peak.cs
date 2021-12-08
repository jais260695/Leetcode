public class Solution {
    public int[][] HighestPeak(int[][] isWater) {
        int n = isWater.Count();
        int m = isWater[0].Count();
        
        int[][] result = new int[n][];
        
        for(int i=0;i<n;i++)
        {
            result[i] = new int[m];
        }
        
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(isWater[i][j]==1){
                    result[i][j] = 0; 
                    queue.Enqueue(new Tuple<int,int>(i,j));
                }
                else
                    result[i][j]=-1;
            }
        }
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Tuple<int,int> t = queue.Dequeue();
                int i = t.Item1;
                int j = t.Item2;
                if(i+1<n && result[i+1][j]==-1)
                {
                    result[i+1][j] = result[i][j]+1;
                    queue.Enqueue(new Tuple<int,int>(i+1,j));
                }
                if(i-1>=0 && result[i-1][j]==-1)
                {
                    result[i-1][j] = result[i][j]+1;
                    queue.Enqueue(new Tuple<int,int>(i-1,j));
                }
                if(j+1<m && result[i][j+1]==-1)
                {
                    result[i][j+1] = result[i][j]+1;
                    queue.Enqueue(new Tuple<int,int>(i,j+1));
                }
                if(j-1>=0 && result[i][j-1]==-1)
                {
                    result[i][j-1] = result[i][j]+1;
                    queue.Enqueue(new Tuple<int,int>(i,j-1));
                }
                size--;
            }
        }
        return result;
    }
}