public class Solution {
    public int RemoveCoveredIntervals(int[][] points) {
        int n = points.Count();
        if(n==0) return 0;
        Array.Sort(points,
                  (int[] a, int[] b) => {
                      return a[0]!=b[0] ? a[0]-b[0] : b[1] - a[1];
                  }
          );
        
        int[] refPoint = new int[2];
        refPoint[0] = points[0][0];
        refPoint[1] = points[0][1];
        int count = n;
        for(int i=1;i<n;i++)
        {           
            if(points[i][1]<= refPoint[1])
            {
                count--;
            }
            else
            {  
                refPoint[0] = Math.Min(points[i][0],refPoint[0]);
                refPoint[1] = Math.Max(points[i][1],refPoint[1]);
            }
        }
        return count;
    }
}