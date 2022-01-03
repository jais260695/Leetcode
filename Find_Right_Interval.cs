public class Solution {
    
    public int[] FindRightInterval(int[][] intervals) {
        int n = intervals.Count();
        int[][] newInterval = new int[n][];
         for(int i =0;i<n;i++)
         {
             newInterval[i] = new int[2];
             newInterval[i][0] = intervals[i][0];
             newInterval[i][1] = i;
         }
        
        Array.Sort(newInterval,delegate(int[] a, int[] b){ return a[0] - b[0]; });
        
        int[] result = new int[n];
        
        for(int i=0;i<n;i++)
        {
            result[i] = BinarySearch(newInterval, intervals[i][1],n);
        }
        return result;
    }
    public int BinarySearch(int[][] newInterval, int target , int n)
    {
        int l = 0;
        int h = n-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            
            if(newInterval[mid][0]<target) 
            {
                l = mid+1;
            }
            else
            {
                h = mid -1;
            }
        }
        return l==n ? -1 : newInterval[l][1];
    }
}