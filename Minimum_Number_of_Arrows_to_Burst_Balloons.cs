public class Solution {

    public int FindMinArrowShots(int[][] points) {
        int n = points.Count();
        if(n==0) return 0;
        Array.Sort(points, (int[] a, int[] b)=> {
            return  a[0]<b[0] ? -1 
                    :a[0]>b[0] ? 1
                    :a[1]<b[1] ? -1
                    :a[1]>b[1] ? 1
                    :0;
        });
        int i = 0;
        int count = 0;
        while(i<n)  
        {
            int start = points[i][0];
            int end = points[i][1];
            while(i<n-1 &&  points[i+1][0]<=end)
            {
                i++;
                start = Math.Max(start,points[i][0]);
                end = Math.Min(end,points[i][1]);
            }
            count++;            
            i++;
        }
        
        return count;
    }
}