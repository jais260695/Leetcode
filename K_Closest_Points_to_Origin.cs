public class Solution {
    
    int[] Extract(int[][] points, int[] dist, int n)
    {
        
        int[] res = new int[2];
        res[0] = points[0][0];
        res[1] = points[0][1];
        
        points[0][0] = points[n][0];
        points[0][1] = points[n][1];
        
        dist[0] = dist[n];
        
        Heapify(points, dist, 0, n);
        return res;
    }
    
    void Swap(int[][] points, int i, int j, int[] dist)
    {
        int t0 = points[i][0];
        int t1 = points[i][1];
        
        points[i][0] = points[j][0];
        points[i][1] = points[j][1];
        
        points[j][0] = t0;
        points[j][1] = t1;
        
        int temp = dist[i];
        dist[i] = dist[j];
        dist[j] = temp;
    }
    
    void Heapify(int[][] points, int[] dist, int i, int n)
    {
        int smallest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left<n && dist[left]<=dist[smallest])
        {
            smallest = left;
        }
        if(right<n && dist[right]<=dist[smallest])
        {
            smallest = right;
        }
        if(smallest!=i)
        {
            Swap(points, i, smallest,dist);
            Heapify(points, dist, smallest, n);
        }
    }
    
    int Eucledian(int x, int y)
    {
        int a = (x)*(x);
        int b = (y)*(y);
        return a+b;
    }
    
    public int[][] KClosest(int[][] points, int K) {
        int n = points.Count();
        int[] dist = new int[n];
        int[][] result = new int[K][];
        
        for(int i=0;i<n;i++)
        {
            dist[i] = Eucledian(points[i][0],points[i][1]);
        }
        
        for(int i =(n/2)-1;i>=0;i--)
        {
            Heapify(points,dist,i,n);
        } 
        
        for(int i=0;i<K;i++)
        {
            result[i] = Extract(points,dist,n-i-1);   
        }
        
        return result;
    }
}