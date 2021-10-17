public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int sum = 0 ;
        int n = points.Count();
        for(int i=0;i<n-1;i++)
        {
            int a = Math.Abs(points[i][0] - points[i+1][0]);
            int b = Math.Abs(points[i][1] - points[i+1][1]);
            if(a>b)
            {
                sum+=a;
            }
            else
            {
                sum+=b;
            }
        }
        return sum;
    }
}